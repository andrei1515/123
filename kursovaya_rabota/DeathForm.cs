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
    public partial class DeathForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Строка подключения к бд
        private Form mainForm; // Переменная для хранения объекта MainForm

        public DeathForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm; // callingForm покажет ту самую MainForm, с которой мы пришли
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана

            // Варианты выбора для комбобокса "пол"
            cbGender.Items.Add("Мужской");
            cbGender.Items.Add("Женский");

            // Прописываем, что в поле элемента Combobox мы не сможем вводить данные вручную, а только выбирать из списка
            cbGender.DropDownStyle = ComboBoxStyle.DropDownList;

            // Прописывем, в элементе DataTime мы не сможем вводить дату, которая уходит более 100 лет назад и дату, котоаря превышает сегодняшнй день
            // AddYears - метод, который возвращает новый объект DateTime, который добавляет заданное число лет к значению текущего экземпляра
            // Рождение дата 
            dtpChildBirth.MinDate = DateTime.Now.AddYears(-100); // 100 лет назад
            dtpChildBirth.MaxDate = DateTime.Now; // Сегодня

            // Смерть дата
            dtpChildDeath.MinDate = DateTime.Now.AddYears(-100); // 100 лет назад
            dtpChildDeath.MaxDate = DateTime.Now; // Сегодня

            // Паспорт
            dtpExtradition.MinDate = DateTime.Now.AddYears(-100); // 14 лет назад
            dtpExtradition.MaxDate = DateTime.Now; // Сегодня

            dtpChildBirth.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для ребенка, как "пользовательский"
            dtpChildBirth.CustomFormat = "Дата рождения";   // Устанавливаем текст, который будет отображаться как плейсхолдер

            dtpChildDeath.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для матери, как "пользовательский"
            dtpChildDeath.CustomFormat = "Дата смерти";   // Устанавливаем текст, который будет отображаться как плейсхолдер

            dtpExtradition.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для отца, как "пользовательский"
            dtpExtradition.CustomFormat = "Дата получения";   // Устанавливаем текст, который будет отображаться как плейсхолдер
        }

        private void DeathForm_Load(object sender, EventArgs e)
        {
            ///<summary>
            /// Тут у нас расписываются цвета элементов
            ///</summary>
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Регистрация смерти"
            Svedeniya.ForeColor = ColorTranslator.FromHtml("#A73302"); // Текст "Сведения об умершем"
            Pasport.ForeColor = ColorTranslator.FromHtml("#A73302"); // Текст "Паспорт"
            panelSvedeniya.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Панель "Сведения"
            panelpodSvedeniya.BackColor = ColorTranslator.FromHtml("#646C84"); // Панель под "Сведения"
            panelPasport.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Панель "Паспорт"
            panelpodPasport.BackColor = ColorTranslator.FromHtml("#646C84"); // Панель под "Паспорт"
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
            btnSave.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Сохранить"
            btnSave.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Текст кнопки "Сохранить"
        }

        ///<summary>
        /// Тут у нас проводится проверка над элементами textbox на то, чтобы пользователь:
        /// 1.Не смог оставить поле пустым
        /// 3.Не смог вводить значения, превышающие 60 символов
        /// 4.Не смог вводить какие-либо иные символы, которые не вхоядт в категорию "буквы", "пробел", "тире"
        /// 5.Также, так как в данном коде имеются плейсхолдеры - на них тоже присутствует проверка
        ///</summary>
        private bool ValidateTextBox(TextBox textBox, string fieldName, string placeholder)
        {
            string text = textBox.Text.Trim(); // В переменную вносится определенное название тексбокса

            if (string.IsNullOrWhiteSpace(text) || text == placeholder) // Если строка пустая, либо в ней стоит определенный плейсхолдер
            {
                // Выводится сообщение с подставлением fieldName
                MessageBox.Show($"Поле \"{fieldName}\" не должно быть пустым.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (text.Length > 60) // Если длина превышает 60 символов
            {
                // Выводится сообщение с подставлением fieldName
                MessageBox.Show($"Поле \"{fieldName}\" не должно содержать более 60 символов.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

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

            return true;
        }

        /// <summary>
        /// Тут у нас проводится проверка над элементами textbox(серия и номер документа) на то, чтобы пользователь:
        /// 1.Не смог оставить поле пустым
        /// 2.Не смог вводить значения, превышающие 4, либо 6 символов символов
        /// 3.Не смог вводить какие-либо иные символы, которые не вхоядт в категорию "цифры"
        /// 4.Также, так как в данном коде имеются плейсхолдеры - на них тоже присутствует проверка
        /// </summary>
        private bool ValidatePassportSeries(TextBox textBox, string fieldName, string placeholder)
        {
            string input = textBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(input) || input == placeholder) // Если строка пустая, либо в ней стоит определенный плейсхолдер
            {
                // Выводится сообщение с подставлением fieldName
                MessageBox.Show($"Поле \"{fieldName}\" не должно быть пустым.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (rbPassport.Checked) // Если стоит радиобатон "Паспорт"
            {
                // Если в строке input есть хотя бы один символ, который не является цифрой
                // .All — метод, который проверяет, что все символы строки соответствуют условию
                // char.IsDigit — стандартный метод, который возвращает true, если символ — это цифра (0–9)
                if (!input.All(char.IsDigit))
                {
                    MessageBox.Show($"Поле \"{fieldName}\" должно содержать только цифры.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return false;
                }
            }
            if (rbCertificate.Checked) // Если стоит радиобатон "Свидетельство"
            {
                if (fieldName == "Серия документа")
                {
                    /// .Any - метод, который проверяет: есть ли хотя бы один символ, удовлетворяющий условию
                    /// ch => - для каждого символа ch из строки text проверяеи условие
                    /// char.IsLetter(ch) - метод, который проверяет, относится ли указанный символ Юникода к категории букв
                    if (input.Any(ch => !(char.IsLetter(ch) || ch == '-'))) // Разрешаем только русские и английские буквы, дефисы
                    {
                        // Выводится сообщение с подставлением fieldName
                        MessageBox.Show($"Поле \"{fieldName}\" может содержать только буквы русского и английского алфавита и дефисы.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                if (fieldName == "Номер документа")
                {
                    // Если в строке input есть хотя бы один символ, который не является цифрой
                    // .All — метод, который проверяет, что все символы строки соответствуют условию
                    // char.IsDigit — стандартный метод, который возвращает true, если символ — это цифра (0–9)
                    if (!input.All(char.IsDigit))
                    {
                        MessageBox.Show($"Поле \"{fieldName}\" должно содержать только цифры.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBox.Focus();
                        return false;
                    }
                }
            }

            if (rbPassport.Checked) // Если стоит радиобатон "Паспорт"
            {
                // Проверка длины в зависимости от поля
                if ((fieldName == "Серия документа" && input.Length != 4) || (fieldName == "Номер документа" && input.Length != 6))
                {
                    MessageBox.Show($"Поле \"{fieldName}\" должно содержать {(fieldName == "Серия документа" ? "4" : "6")} цифры.",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (rbCertificate.Checked) // Если стоит радиобатон "Свидетельство"
            {
                // Проверка длины в зависимости от поля
                if ((fieldName == "Серия документа" && input.Length < 4 || input.Length > 6) ||
                    (fieldName == "Номер документа" && input.Length != 6))
                {
                    MessageBox.Show($"Поле \"{fieldName}\" должно содержать {(fieldName == "Серия документа" ? "4-6 символов" : "6 цифр")}",
                    "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true; // Всё прошло успешно
        }


        private void btnSave_Click(object sender, EventArgs e) // Кнопка "Сохранить"
        {
            // Проверка на то, что выбран хотя бы 1 радиобатон
            if (!rbPassport.Checked && !rbCertificate.Checked)
            {
                MessageBox.Show("Выберите тип документа: паспорт или свидетельство о рождении.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на то, что пользователь ввел дату рождения
            if (dtpChildBirth.CustomFormat == "Дата рождения")
            {
                MessageBox.Show("Введите дату рождения.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка на то, что пользователь ввел дату смерти
            if (dtpChildDeath.CustomFormat == "Дата смерти")
            {
                MessageBox.Show("Введите дату смерти.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка на то, что пользователь ввел дату получения документа
            if (dtpExtradition.CustomFormat == "Дата получения")
            {
                MessageBox.Show("Введите дату получения документа.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ///<summary>
            ///Тут происходит небольшшая проверка на даты (это делается для того, чтобы человек умер до своего рождения):
            ///Дата рождения умершего человека должна быть больше даты получения его паспорта
            ///Дата получения паспорта умершего должна быть больше даты его смерти
            ///</summary>
            DateTime BirthDate = dtpChildBirth.Value; // В переменую записывается дата рождения
            DateTime dateExtradition = dtpExtradition.Value; // В переменую записывается дата выдачи паспорта
            DateTime DeathDate = dtpChildDeath.Value; // В переменую записывается дата смерти

            if (rbPassport.Checked) // Если выбран радиобатон "Паспорт"
            {
                if (BirthDate >= dateExtradition)
                {
                    MessageBox.Show("Дата получения паспорта должна быть позже даты рождения.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dateExtradition >= DeathDate)
                {
                    MessageBox.Show("Дата смерти должна быть позже даты получения паспорта.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (rbCertificate.Checked) // Если выбран радиобатон "Свидетельство"
            {
                if (BirthDate >= dateExtradition)
                {
                    MessageBox.Show("Дата получения свидетельства о рождении должна быть позже даты рождения.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dateExtradition >= DeathDate)
                {
                    MessageBox.Show("Дата смерти должна быть позже даты получения свидетельства о рождении.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Тут у нас производится отдельная проверка на то, чтобы дата получения паспорта была минимум на 14 лет больше, чем рождение данного человека
            // Вычисляем минимально допустимую дату выдачи паспорта
            DateTime minPassportDate = BirthDate.AddYears(14);

            if (rbPassport.Checked) // Если стоит радиобатон "Паспорт"
            {
                if (dateExtradition < minPassportDate) // Если дата выдачи меньше 14 лет, то условие выполянется
                {
                    MessageBox.Show("Паспорт не может быть выдан ранее, чем через 14 лет после рождения.", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (rbCertificate.Checked) // Если стоит радиобатон "Свидетельство о рождении"
            {
                if (dateExtradition >= minPassportDate) // Если дата выдачи больше, либо равно 14 лет, то условие выполянется
                {
                    MessageBox.Show("Свидетельство о рождении не может быть выдано позже, чем через 14 лет после рождения.", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Проверяем выбран ли пол ребенка в комбобоксе "Пол"
            if (cbGender.SelectedItem == null) // Если в поле "пол" ниичего не выбрано, то выдается меседжбокс
            {
                MessageBox.Show("В поле 'Пол' выберите пол: мужской или женский.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем поиск
            }

            // Проверка текстбоксов. В метод ValidateTextBox подставляются эти данные и при false происходит возвращение return
            // "Сведения об умершем"
            if (!ValidateTextBox(txtChildLastName, "Фамилия", "Фамилия")) return;
            if (!ValidateTextBox(txtChildFirstName, "Имя", "Имя")) return;
            if (!ValidateTextBox(txtChildPatronymic, "Отчество", "Отчество")) return;
            if (!ValidateTextBox(txtBirthPlace, "Место рождения", "Место рождения")) return;
            if (!ValidateTextBox(txtDeathPlace, "Место смерти", "Место смерти")) return;

            // Паспорт
            if (!ValidateTextBox(txtExtradition, "Кем выдан", "Кем выдан")) return;
            if (!ValidatePassportSeries(txtSeriesPasport, "Серия документа", "Серия документа")) return;
            if (!ValidatePassportSeries(txtNumberPasport, "Номер документа", "Номер документа")) return;



            // Тут мы записываем значения текстбоксов в переменные
            // Данные "Сведения об умершем"
            string LastName = txtChildLastName.Text.Trim(); // В переменую записывается фамилия
            string FirstName = txtChildFirstName.Text.Trim(); // В переменую записывается имя
            string Patronymic = txtChildPatronymic.Text.Trim(); // В переменую записывается отчество
            string BirthPlace = txtBirthPlace.Text.Trim(); // В переменую записывается место рождения
            string DeathPlace = txtDeathPlace.Text.Trim(); // В переменую записывается место смерти
            string gender = cbGender.SelectedItem?.ToString(); /* В переменую записывается пол,
            SelectedItem возвращает объект, который выбран в списке, ToString - преобразует элемент в строку */

            // Данные паспорта
            string SeriesPasport = txtSeriesPasport.Text.Trim(); // В переменую записывается серия паспорта
            string NumberPasport = txtNumberPasport.Text.Trim(); // В переменую записывается номер паспорта
            string Extradition = txtExtradition.Text.Trim(); // В переменую записывается кем был выдан паспорт

            // Подключение к базе данных
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Получаем новые номера записи и свидетельства
                // Обе переменные изначально ставятся в 1, на случай, если в базе данных нет записей - у нас всё равно был номер 1
                int RecordNumber = 1;
                int CertificateNumber = 1;

                // Находим самый большой номер записи и свидетельства
                using (var cmdLast = new NpgsqlCommand("SELECT MAX(record_number), MAX(certificate_number) FROM death_records", conn))
                using (var reader = cmdLast.ExecuteReader()) // Переменная для хранения прочитанного запроса
                {
                    if (reader.Read()) // Читаем первую строку результата запроса
                    {
                        // Проверяем, пустое ли значение в первой колонке, если да - ставим 1, если нет - берем самое большое значение + 1
                        RecordNumber = reader.IsDBNull(0) ? 1 : reader.GetInt32(0) + 1;
                        CertificateNumber = reader.IsDBNull(1) ? 1 : reader.GetInt32(1) + 1;
                    }
                }

                // Создаем запрос для бд
                string insertQuery = @"
                INSERT INTO death_records (record_number, certificate_number,
                document,
                last_name, first_name, patronymic, birth_date, death_date, place_of_birth, place_of_death, gender,
                passport_series, passport_number, passport_issue_date, passport_issued_by)

                VALUES (
                @record, @cert,
                @doctype,
                @lname, @fname, @pname, @birth, @death, @bplace, @dplace, @gender,
                @seriesp, @numberp, @dateEx, @extradition)";

                // Выполнение SQL-запроса. В этом запросе мы прописываем передачу значения переменных параметрам @, для вставки новых записей в таблицу
                using (var cmd = new NpgsqlCommand(insertQuery, conn))
                {
                    // Передача параметров
                    // AddWithValue - метод для безопасного и эффективного добавления параметров к SQL-командам
                    // Номер записи акта и номер свидетельства
                    cmd.Parameters.AddWithValue("@record", RecordNumber);
                    cmd.Parameters.AddWithValue("@cert", CertificateNumber);

                    // "Сведения об умершем"
                    cmd.Parameters.AddWithValue("@lname", LastName);
                    cmd.Parameters.AddWithValue("@fname", FirstName);
                    cmd.Parameters.AddWithValue("@pname", Patronymic);
                    cmd.Parameters.AddWithValue("@birth", BirthDate);
                    cmd.Parameters.AddWithValue("@death", DeathDate);
                    cmd.Parameters.AddWithValue("@bplace", BirthPlace);
                    cmd.Parameters.AddWithValue("@dplace", DeathPlace);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    // Документ
                    cmd.Parameters.AddWithValue("@seriesp", SeriesPasport);
                    cmd.Parameters.AddWithValue("@numberp", NumberPasport);
                    cmd.Parameters.AddWithValue("@extradition", Extradition);
                    cmd.Parameters.AddWithValue("@dateEx", dateExtradition);

                    // Просмотр типа документа
                    string docType = rbPassport.Checked ? "Паспорт" : "Свидетельство о рождении";
                    cmd.Parameters.AddWithValue("@doctype", docType);

                    cmd.ExecuteNonQuery(); // Выполнение запроса
                }

                // Уведомление
                MessageBox.Show("Запись успешно добавлена!", "Успех", MessageBoxButtons.OK);
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

            if (result == DialogResult.Yes) // Если да - выходим
            {
                Properties.Settings.Default.RememberMe = false; // Делаем галочку в чекбоксе "Запомнить" не нажатой
                Properties.Settings.Default.Save(); // Сохранениие

                Application.Restart(); // Перезапуск приложения // Если нажали Да — выходим
            }
            // Иначе (Нет) — ничего не делаем
        }

        private void CloseApplication_Click(object sender, EventArgs e) // Крестик
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

        // Фамилия
        private void txtChildLastName_Enter(object sender, EventArgs e)
        {
            if (txtChildLastName.Text == "Фамилия")
            {
                txtChildLastName.Text = ""; // Очищаем текст
                txtChildLastName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildLastName.Text))
            {
                txtChildLastName.Text = "Фамилия"; // Возвращаем placeholder
                txtChildLastName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Имя 
        private void txtChildFirstName_Enter(object sender, EventArgs e)
        {
            if (txtChildFirstName.Text == "Имя")
            {
                txtChildFirstName.Text = ""; // Очищаем текст
                txtChildFirstName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildFirstName.Text))
            {
                txtChildFirstName.Text = "Имя"; // Возвращаем placeholder
                txtChildFirstName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Отчество 
        private void txtChildPatronymic_Enter(object sender, EventArgs e)
        {
            if (txtChildPatronymic.Text == "Отчество")
            {
                txtChildPatronymic.Text = ""; // Очищаем текст
                txtChildPatronymic.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildPatronymic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildPatronymic.Text))
            {
                txtChildPatronymic.Text = "Отчество"; // Возвращаем placeholder
                txtChildPatronymic.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Место рождения
        private void txtBirthPlace_Enter(object sender, EventArgs e)
        {
            if (txtBirthPlace.Text == "Место рождения")
            {
                txtBirthPlace.Text = ""; // Очищаем текст
                txtBirthPlace.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtBirthPlace_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthPlace.Text))
            {
                txtBirthPlace.Text = "Место рождения"; // Возвращаем placeholder
                txtBirthPlace.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Мксто смерти
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtDeathPlace.Text == "Место смерти")
            {
                txtDeathPlace.Text = ""; // Очищаем текст
                txtDeathPlace.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDeathPlace.Text))
            {
                txtDeathPlace.Text = "Место смерти"; // Возвращаем placeholder
                txtDeathPlace.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Серия паспорта
        private void txtSeriesPasport_Enter(object sender, EventArgs e)
        {
            if (txtSeriesPasport.Text == "Серия документа")
            {
                txtSeriesPasport.Text = ""; // Очищаем текст
                txtSeriesPasport.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtSeriesPasport_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSeriesPasport.Text))
            {
                txtSeriesPasport.Text = "Серия документа"; // Возвращаем placeholder
                txtSeriesPasport.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Номер паспорта
        private void txtNumberPasport_Enter(object sender, EventArgs e)
        {
            if (txtNumberPasport.Text == "Номер документа")
            {
                txtNumberPasport.Text = ""; // Очищаем текст
                txtNumberPasport.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtNumberPasport_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumberPasport.Text))
            {
                txtNumberPasport.Text = "Номер документа"; // Возвращаем placeholder
                txtNumberPasport.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Кем выдан
        private void txtExtradition_Enter(object sender, EventArgs e)
        {
            if (txtExtradition.Text == "Кем выдан")
            {
                txtExtradition.Text = ""; // Очищаем текст
                txtExtradition.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtExtradition_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExtradition.Text))
            {
                txtExtradition.Text = "Кем выдан"; // Возвращаем placeholder
                txtExtradition.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Событие DropDown у ComboBox срабатывает в момент, когда пользователь нажимает на стрелку перед открытием выпадающего списка
        private void cbGender_DropDown(object sender, EventArgs e)
        {
           tbPlaceholderGender.Visible = false; // Текстбокс "Пол" становится невидимым

        }
        // Если пользователь не выбрал ничего и ушёл — показываем плейсхолдер
        private void cbGender_DropDownClosed(object sender, EventArgs e)
        {
            // Получаем выбранное значение
            string selectedValue = cbGender.SelectedItem?.ToString();

            // Если выбрано "Мужской" или "Женский"
            if (selectedValue == "Мужской" || selectedValue == "Женский")
            {
                tbPlaceholderGender.Visible = false; // Скрываем TextBox-плейсхолдер
            }
            else
            {
                tbPlaceholderGender.Visible = true; // Показываем плейсхолдер
            }
        }

        // Событие, которое срабатывает, когда пользователь выбирает дату
        private void dtpChildBirth_ValueChanged(object sender, EventArgs e)
        {
            // Меняем формат на обычную дату
            dtpChildBirth.Format = DateTimePickerFormat.Long;
            dtpChildBirth.CustomFormat = "";
        }

        // Событие, которое срабатывает, когда пользователь выбирает дату
        private void dtpChildDeath_ValueChanged(object sender, EventArgs e)
        {
            // Меняем формат на обычную дату
            dtpChildDeath.Format = DateTimePickerFormat.Long;
            dtpChildDeath.CustomFormat = "";
        }

        // Событие, которое срабатывает, когда пользователь выбирает дату
        private void dtpExtradition_ValueChanged(object sender, EventArgs e)
        {
            // Меняем формат на обычную дату
            dtpExtradition.Format = DateTimePickerFormat.Long;
            dtpExtradition.CustomFormat = "";
        }
    }
}
