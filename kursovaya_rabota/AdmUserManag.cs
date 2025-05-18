using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya_rabota
{
    public partial class AdmUserManag : Form
    {
        private Form mainForm; // Переменная для хранения объекта MainForm
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Строка подключения к бд

        public AdmUserManag(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm; // callingForm покажет ту самую AdminForm, с которой мы пришли
            LoadUsers();

            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана
            dgvUsers.AllowUserToAddRows = false; // Для того, чтобы убрать автоматически создавающуюся пустую строку в элементе датагриз

            // Варианты выбора для комбобокса "пол"
            cmbRole.Items.Add("User");
            // Прописываем, что в поле элемента Combobox мы не сможем вводить данные вручную, а только выбирать из списка
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AdmUserManag_Load(object sender, EventArgs e)
        {
            ///<summary>
            /// Тут у нас расписываются цвета элементов
            ///</summary>
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Управление пользователями"
            btnAddUser.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Добавить"
            btnAddUser.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Текст кнопки "Добавить"
            btnDeleteUser.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Удалить"
            btnDeleteUser.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Текст кнопки "Удалить"
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
        }

        private void LoadUsers()
        {
            using (var conn = new NpgsqlConnection(connectionString)) // Создаём подключение к базе данных
            {
                conn.Open(); // Открываем соединение с базой данных
                string query = "SELECT id, login, fio, password, role FROM users ORDER BY id"; // SQL-запрос: выбираем id, логин, ФИО и роль всех пользователей, отсортированных по id
                using (var cmd = new NpgsqlCommand(query, conn)) // Создаём команду для выполнения SQL-запроса, привязываем её к открытому соединению
                using (var adapter = new NpgsqlDataAdapter(cmd)) // Создаём адаптер, который позволяет выполнить команду и заполнить таблицу данными
                {
                    DataTable table = new DataTable(); // Создаём объект DataTable — это таблица в памяти, куда будут помещены результаты запроса
                    adapter.Fill(table); // Выполняем запрос и заполняем таблицу данными из базы
                    dgvUsers.DataSource = table; // Привязываем полученную таблицу к элементу DataGridView на форме, чтобы показать пользователям
                }
            }
        }

        // Проверка текстбоксов на ввод
        private bool ValidateTextBox(TextBox textBox, string fieldName, string placeholder)
        {
            string text = textBox.Text.Trim(); // В переменную вносится определенное название тексбокса

            if (string.IsNullOrWhiteSpace(text) || text == placeholder) // Если строка пустая, либо в ней стоит определенный плейсхолдер
            {
                // Выводится сообщение с подставлением fieldName
                MessageBox.Show($"Поле \"{fieldName}\" не должно быть пустым.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fieldName == "Логин" || fieldName == "Пароль") //  Условия для логина и пароля
            {
                if (text.Length > 15) // Если длина превышает 15 символов
                {
                    // Выводится сообщение с подставлением fieldName
                    MessageBox.Show($"Поле \"{fieldName}\" не должно содержать более 15 символов.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Проверка на английские буквы и цифры
                if (!System.Text.RegularExpressions.Regex.IsMatch(text, @"^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show($"Поле \"{fieldName}\" должно содержать только английские буквы и цифры.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            if (fieldName == "ФИО") //  Условия для ФИО
            {
                ///<summary>
                /// .Any - метод, который проверяет: есть ли хотя бы один символ, удовлетворяющий условию
                /// ch => - для каждого символа ch из строки text проверяеи условие
                /// char.IsLetter(ch) - метод, который проверяет, относится ли указанный символ Юникода к категории букв
                ///</summary>
                if (text.Any(ch => !(char.IsLetter(ch) || ch == '-' || ch == ' '))) // Разрешаем только русские и английские буквы, пробелы и дефисы
                {
                    // Выводится сообщение с подставлением fieldName
                    MessageBox.Show($"Поле \"{fieldName}\" может содержать только буквы русского и английского алфавита, пробелы и дефисы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (text.Length > 60) // Если длина превышает 60 символов
                {
                    // Выводится сообщение с подставлением fieldName
                    MessageBox.Show($"Поле \"{fieldName}\" не должно содержать более 60 символов.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e) // Кнопка "Добавить"
        {
            // Проверка текстбоксов. В метод ValidateTextBox подставляются эти данные и при false происходит возвращение return
            if (!ValidateTextBox(txtLogin, "Логин", "Логин")) return;
            if (!ValidateTextBox(txtPassword, "Пароль", "Пароль")) return;
            if (!ValidateTextBox(txtFIO, "ФИО", "ФИО")) return;

            // Забираем введённые значения из текстовых полей и ComboBox
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text.Trim();
            string fio = txtFIO.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString();

            if (login == "" || password == "" || fio == "" || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Заполните все поля.");
                return;
            }

            using (var conn = new NpgsqlConnection(connectionString)) // Открываем подключение к базе данных
            {
                conn.Open();
                string query = "INSERT INTO users(login, fio, password, role) VALUES (@login, @fio, @password, @role)"; // Запрос
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // Передаём значения в параметры запроса
                    cmd.Parameters.AddWithValue("login", login);
                    cmd.Parameters.AddWithValue("fio", fio);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.Parameters.AddWithValue("role", role);

                    cmd.ExecuteNonQuery(); // Выполнение запроса
                    LoadUsers();
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)  // Кнопка "Удалить"
        {
            if (dgvUsers.SelectedRows.Count == 0) // Проверяем, выбрал ли пользователь строку в таблице DataGridView
            {
                MessageBox.Show("Выберите пользователя для удаления.");
                return;
            }

            int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["id"].Value); // Получаем id выбранного пользователя из таблицы. Cells — доступ ко всем ячейкам выбранной строки
            string selectedLogin = dgvUsers.SelectedRows[0].Cells["role"].Value.ToString();

            // Проверяем, не пытается ли админ удалить сам себя
            if (selectedLogin == "admin")
            {
                MessageBox.Show("Вы не можете удалить свой собственный аккаунт.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Показываем окно подтверждения. Если пользователь нажал "Нет" — выход из метода
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM users WHERE id = @id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", userId); // Передаём значения в параметры запроса
                    cmd.ExecuteNonQuery(); // Выполнение запроса
                    MessageBox.Show("Пользователь удалён.");
                    LoadUsers();
                }
            }
        }

        private void nazad_Click(object sender, EventArgs e) // Кнопка "назад" (стрелочка)
        {
            this.Hide(); // Скрытие данной формы
            mainForm.Show(); // Показ формы MainForm (ссылаемся на нее)
            this.Close(); // Закрытие данной формы
        }

        private void btnLogout_Click(object sender, EventArgs e) // Кнопка выхода из системы (справа сверху)
        {
            DialogResult result = MessageBox.Show(
                    "Вы действительно хотите выйти из системы?", // Сообщение
                    "Выход из системы", // Заголовок окна
                    MessageBoxButtons.YesNo, // кнопки Да/Нет
                    MessageBoxIcon.Question // Значок вопроса
                    );

            if (result == DialogResult.Yes) // Если да - выходим из системы
            {
                Properties.Settings.Default.RememberMe = false; // Делаем галочку в чекбоксе "Запомнить" не нажатой и тем самым в Programs.cs
                Properties.Settings.Default.Save(); // Сохранениие

                Application.Restart(); // Перезапуск приложения
            }
            // Иначе (Нет) — ничего не делаем
        }

        private void CloseApplication_Click(object sender, EventArgs e) // Кнопка - закрытие формы (крестик)
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложение
        }


        /// <summary>
        /// Тут мы прописываем все плейсхолдеры (потухшие буквы в текстбоксах)
        /// Это делается для того, чтобы пользователю было понятно, что вводить в определенный текстбокс
        /// Для каждого текстбокса создается два обработчиика событий - Enter и Leave.
        /// Enter - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// Leave - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// </summary>

        // Логин
        private void txtLogin_Enter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "Логин")
            {
                txtLogin.Text = ""; // Очищаем текст
                txtLogin.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtLogin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text = "Логин"; // Возвращаем placeholder
                txtLogin.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // ФИО
        private void txtFIO_Enter(object sender, EventArgs e)
        {
            if (txtFIO.Text == "ФИО")
            {
                txtFIO.Text = ""; // Очищаем текст
                txtFIO.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFIO_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFIO.Text))
            {
                txtFIO.Text = "ФИО"; // Возвращаем placeholder
                txtFIO.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Пароль
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Пароль")
            {
                txtPassword.Text = ""; // Очищаем текст
                txtPassword.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Пароль"; // Возвращаем placeholder
                txtPassword.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Событие DropDown у ComboBox срабатывает в момент, когда пользователь нажимает на стрелку перед открытием выпадающего списка
        private void cmbRole_DropDown(object sender, EventArgs e)
        {
            txtRole.Visible = false; // Лейбл "Роль" становится невидимым
        }

        // Если пользователь не выбрал ничего и ушёл — показываем плейсхолдер
        private void cmbRole_DropDownClosed(object sender, EventArgs e)
        {
            // Получаем выбранное значение
            string selectedValue = cmbRole.SelectedItem?.ToString();

            // Если выбрано "Мужской" или "Женский"
            if (selectedValue == "User")
            {
                txtRole.Visible = false; // Скрываем TextBox-плейсхолдер
            }
            else
            {
                txtRole.Visible = true; // Показываем плейсхолдер
            }
        }
    }
}
