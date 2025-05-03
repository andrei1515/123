using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya_rabota
{
    public partial class SearchForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Строка подключения к бд
        private Form mainForm; // Переменная для хранения объекта MainForm

        public SearchForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm; // callingForm покажет ту самую MainForm, с которой мы пришли
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана
            dgvResults.AllowUserToAddRows = false; // Для того, чтобы убрать автоматически создавающуюся пустую строку в элементе датагриз

            // AddRange - метод, который позволяет добавить несколько элементов в коллекцию за одну операцию
            cbRecordType.Items.AddRange(new string[] { "Рождение", "Смерть" });
            // Прописываем, что в поле элемента Combobox мы не сможем вводить данные вручную, а только выбирать из списка
            cbRecordType.DropDownStyle = ComboBoxStyle.DropDownList;
            lblNoResults.Visible = false; // Прячем надпись "Записи не найдено"
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // Цвета элементов
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Поиск записей"
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
        }

        private void btnSearch_Click_1(object sender, EventArgs e) // Кнопка поиска "лупа" 
        {
            // Проверяем выбран ли тип записи
            if (cbRecordType.SelectedItem == null)
            {
                MessageBox.Show("В поле 'Выбор акта' выберите тип записи: Рождение или Смерть.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем поиск
            }

            // Проверка на заполненность хотя бы одного поля ФИО
            // Эти переменные принимают значение true, если текстбоксы ФИО не будут пустыми и в них не будет плейсхолдеров ФИО
            bool isLastNameFilled = !string.IsNullOrWhiteSpace(txtLastName.Text) && txtLastName.Text != "Фамилия";
            bool isFirstNameFilled = !string.IsNullOrWhiteSpace(txtFirstName.Text) && txtFirstName.Text != "Имя";
            bool isPatronymicFilled = !string.IsNullOrWhiteSpace(txtPatronymic.Text) && txtPatronymic.Text != "Отчество";

            // Проверяем заполненность полей ФИО
            if (!isLastNameFilled && !isFirstNameFilled && !isPatronymicFilled)
            {
                MessageBox.Show("Введите хотя бы одну часть ФИО для поиска.", "Ошибка поиска", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем выполнение поиска
            }
            else
            {
                SearchRecords(); // Иначе выполняем поиск 
            }
        }

        private void btnClear_Click(object sender, EventArgs e) // Кнопка очистки "крестик"
        {
            txtLastName.Text = "";
            txtPatronymic.Text = "";
            txtFirstName.Text = "";
            dgvResults.DataSource = null;
            lblNoResults.Visible = false; // Label "Записи не найдено"  становится видимой
        }

        private void SearchRecords()
        {
            //Выбираем таблицу для работы. Если в комбобоксе стоит "Рождение", то выбиарем таблицу birth_records, в противном случае - death_records
            string table = cbRecordType.SelectedItem.ToString() == "Рождение" ? "birth_records" : "death_records";
            bool isBirth = cbRecordType.SelectedItem.ToString() == "Рождение"; // Переменная, которая будет тру, если в комбобоксе выбрать рождение

            using (var conn = new NpgsqlConnection(connectionString)) // Создаем соединение с бд
            {
                conn.Open(); // Открываем соединение

                // Создание запроса для выбранной таблицы
                string query = $"SELECT * FROM {table} WHERE 1=1";

                // Условия поиска
                // ILIKE означает регистронезависимое(не зависит от больших или маленьких букв) сравнение поля child_last_name с параметром @last_name
                if (!string.IsNullOrEmpty(txtLastName.Text.Trim()) && txtLastName.Text != "Фамилия") // Если текстбокс не пустой и нет плейсхолдера
                    query += isBirth ? " AND child_last_name ILIKE @last_name" : " AND last_name ILIKE @last_name"; // Добавляем к запросу. Говорим, что ищем такие записи, у которых столбец совпадает с тем, что ввел пользователь
                if (!string.IsNullOrEmpty(txtFirstName.Text.Trim()) && txtFirstName.Text != "Имя") // Если текстбокс не пустой и нет плейсхолдера
                    query += isBirth ? " AND child_first_name ILIKE @first_name" : " AND first_name ILIKE @first_name"; // Добавляем к запросу. Говорим, что ищем такие записи, у которых столбец совпадает с тем, что ввел пользователь
                if (!string.IsNullOrEmpty(txtPatronymic.Text.Trim()) && txtPatronymic.Text != "Отчество") // Если текстбокс не пустой и нет плейсхолдера
                    query += isBirth ? " AND child_patronymic ILIKE @patronymic" : " AND patronymic ILIKE @patronymic"; // Добавляем к запросу. Говорим, что ищем такие записи, у которых столбец совпадает с тем, что ввел пользователь

                // Выполнение запроса
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    // Передаём значения параметров
                    if (!string.IsNullOrEmpty(txtLastName.Text.Trim()) && txtLastName.Text != "Фамилия") // Если текстбокс не пустой
                        cmd.Parameters.AddWithValue("@last_name", txtLastName.Text.Trim());

                    if (!string.IsNullOrEmpty(txtFirstName.Text.Trim()) && txtFirstName.Text != "Имя") // Если текстбокс не пустой
                        cmd.Parameters.AddWithValue("@first_name", txtFirstName.Text.Trim());

                    if (!string.IsNullOrEmpty(txtPatronymic.Text.Trim()) && txtPatronymic.Text != "Отчество") // Если текстбокс не пустой
                        cmd.Parameters.AddWithValue("@patronymic", txtPatronymic.Text.Trim());

                    DataTable resultTable = new DataTable(); // Создаем пустую таблицу в памяти
                    using (var adapter = new NpgsqlDataAdapter(cmd)) // Создаём адаптер данных для выполнения команды
                    {
                        adapter.Fill(resultTable); // Заполняем таблицу данными, полученными от запроса

                        if (resultTable.Rows.Count > 0) // Если строки нашлись
                        {
                            dgvResults.DataSource = resultTable; // Выводим строки в элемент DataGridView 
                            lblNoResults.Visible = false; // Скрываем надпись "Записи не найдено"
                        }
                        else
                        {
                            dgvResults.DataSource = null; // Очищаем элемент DataGridView 
                            lblNoResults.Visible = true; // Показываем Label с текстом "Записи не найдено"
                        }
                    }
                }
            }
        }


        private void nazad_Click(object sender, EventArgs e) // Кнопка "назад"
        {
            this.Hide(); // Скрытие формы
            mainForm.Show(); // Показ формы MainForm (ссылаемся на нее)
            this.Close(); // Закрытие формы
        }

        private void btnLogout_Click(object sender, EventArgs e) // Кнопка "выход из системы"
        {
            DialogResult result = MessageBox.Show(
                    "Вы действительно хотите выйти из системы?", // Сообщение
                    "Выход из системы", // Заголовок окна
                    MessageBoxButtons.YesNo, // Кнопки Да/Нет
                    MessageBoxIcon.Question // Значок вопроса
                    );

            if (result == DialogResult.Yes) // Если да - выходим
            {
                Properties.Settings.Default.RememberMe = false; // Делаем галочку в чекбоксе "Запомнить" не нажатой
                Properties.Settings.Default.Save(); // Сохранениие

                Application.Restart(); // Перезапуск приложения // Если нажали Да — выходим
            }
            // Иначе (Нет) — ничего не делаем
        }

        private void CloseApplication_Click(object sender, EventArgs e) // Кнопка "крестик"
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложения
        }


        /// <summary>
        /// Тут мы прописываем все плейсхолдеры (потухшие буквы в текстбоксах)
        /// Это делается для того, чтобы пользователю было понятно, что вводить в определенный текстбокс
        /// Для каждого текстбокса создается два обработчиика событий - Enter и Leave.
        /// Enter - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// Leave - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// </summary>
        
        // Фамилия
        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Фамилия")
            {
                txtLastName.Text = ""; // Очищаем текст
                txtLastName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                txtLastName.Text = "Фамилия"; // Возвращаем placeholder
                txtLastName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Имя
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "Имя")
            {
                txtFirstName.Text = ""; // Очищаем текст
                txtFirstName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                txtFirstName.Text = "Имя"; // Возвращаем placeholder
                txtFirstName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Отчество
        private void txtPatronymic_Enter(object sender, EventArgs e)
        {
            if (txtPatronymic.Text == "Отчество")
            {
                txtPatronymic.Text = ""; // Очищаем текст
                txtPatronymic.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtPatronymic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatronymic.Text))
            {
                txtPatronymic.Text = "Отчество"; // Возвращаем placeholder
                txtPatronymic.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }


        // Событие DropDown у ComboBox срабатывает в момент, когда пользователь нажимает на стрелку перед открытием выпадающего списка
        private void cbRecordType_DropDown(object sender, EventArgs e)
        {
            txtVibor.Visible = false; // Текстбокс "Запись акта" становится невидимым
        }
        private void cbRecordType_DropDownClosed(object sender, EventArgs e)
        {
            // Получаем выбранное значение
            string selectedValue = cbRecordType.SelectedItem?.ToString();

            // Если выбрано "Рождение" или "Смерть"
            if (selectedValue == "Рождение" || selectedValue == "Смерть")
            {
                txtVibor.Visible = false; // Скрываем TextBox-плейсхолдер
            }
            else
            {
                txtVibor.Visible = true; // Показываем плейсхолдер
            }
        }
    }
}
