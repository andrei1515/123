using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;

namespace kursovaya_rabota
{
    public partial class BirthForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Подключение к бд
        private Form mainForm; // Переменная для хранения объекта MainForm


        public BirthForm(Form callingForm)
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
            // Мама 
            dtpMotherBirth.MinDate = DateTime.Now.AddYears(-100); // 100 лет назад
            dtpMotherBirth.MaxDate = DateTime.Now; // Сегодня
            // Папа
            dtpFatherBirth.MinDate = DateTime.Now.AddYears(-100); // 100 лет назад
            dtpFatherBirth.MaxDate = DateTime.Now; // Сегодня

            // Для ребенка ставим другие ограничения (в течении месяца)
            // Ребенок
            dtpChildBirth.MinDate = DateTime.Now.AddMonths(-1); // 100 лет назад
            dtpChildBirth.MaxDate = DateTime.Now; // Сегодня

            dtpChildBirth.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для ребенка, как "пользовательский"
            dtpChildBirth.CustomFormat = "Дата рождения";   // Устанавливаем текст, который будет отображаться как плейсхолдер

            dtpMotherBirth.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для матери, как "пользовательский"
            dtpMotherBirth.CustomFormat = "ДР";   // Устанавливаем текст, который будет отображаться как плейсхолдер

            dtpFatherBirth.Format = DateTimePickerFormat.Custom; // Устанавливаем формат отображения даты для отца, как "пользовательский"
            dtpFatherBirth.CustomFormat = "ДР";   // Устанавливаем текст, который будет отображаться как плейсхолдер
        }

        private void BirthForm_Load(object sender, EventArgs e)
        {
            ///<summary>
            /// Тут у нас расписываются цвета элементов
            ///</summary>
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Регистрация рождения"
            btnSave.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Сохранить"
            btnSave.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Текст кнопки "Сохранить"
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
            Rebenok.ForeColor = ColorTranslator.FromHtml("#A73302"); // Текст "Ребенок"
            Otec.ForeColor = ColorTranslator.FromHtml("#A73302"); // Текст "Мать"
            Mat.ForeColor = ColorTranslator.FromHtml("#A73302"); // Текст "Отец"
            panelRebenok.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Панель "Ребенок"
            panelpodRebenok.BackColor = ColorTranslator.FromHtml("#646C84"); // Панель под "Ребенок"
            panelMama.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Панель "Мама"
            panelpodMama.BackColor = ColorTranslator.FromHtml("#646C84"); // Панель под "Мама"
            panelPapa.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Панель "Папа"
            panelpodPapa.BackColor = ColorTranslator.FromHtml("#646C84"); // Панель под "Папа"

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

        private void btnSave_Click(object sender, EventArgs e) // Кнопка "Сохранить"
        {
            // Проверка на то, что пользователь ввел дату рождения ребенка
            if (dtpChildBirth.CustomFormat == "Дата рождения")
            {
                MessageBox.Show("Введите дату рождения ребенка.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка на то, что пользователь ввел дату рождения матери
            if (dtpMotherBirth.CustomFormat == "ДР")
            {
                MessageBox.Show("Введите дату рождения матери.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Проверка на то, что пользователь ввел дату рождения отца
            if (dtpFatherBirth.CustomFormat == "ДР")
            {
                MessageBox.Show("Введите дату рождения отца.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            ///<summary>
            ///Тут происходит небольшшая проверка на даты (это делается для того, чтобы ребенок не был старше своих родителей):
            ///Дата рождения ребенка должна быть больше даты рождения метери и отца
            ///Также родителям нельзя рожать детей до 16 лет
            ///</summary>
            DateTime childBirthDate = dtpChildBirth.Value; // В переменую записывается дата рождения ребенка
            DateTime motherBirthDate = dtpMotherBirth.Value; // В переменую записывается дата рождения мамы
            DateTime fatherBirthDate = dtpFatherBirth.Value; // В переменую записывается дата рождения отца

            if (childBirthDate <= motherBirthDate)
            {
                MessageBox.Show("Дата рождения ребенка должна быть позднее даты рождения матери.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (childBirthDate <= fatherBirthDate)
            {
                MessageBox.Show("Дата рождения ребенка должна быть позднее даты рождения отца.", "Ошибка дат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Тут мы прописываем, что родители не могут завести ребенка, если им нет 16 лет
            // Вычисляем минимально допустимую дату рождения ребенка
            DateTime minMama = motherBirthDate.AddYears(16);
            DateTime minPapa = fatherBirthDate.AddYears(16);

            if (childBirthDate < minMama || childBirthDate < minPapa) // Если ребенок родился, когда родителям было меньше 16 лет, то условие выполянется
            {
                MessageBox.Show("Ребенка нельзя рожать до 16 лет, вы арестованы.", "Ошибка даты", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем выбран ли пол ребенка в комбобоксе "Пол"
            if (cbGender.SelectedItem == null) // Если в поле "пол" ниичего не выбрано, то выдается меседжбокс
            {
                MessageBox.Show("В поле 'Пол' выберите пол: мужской или женский.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Останавливаем поиск
            }

            // Проверка текстбоксов. В метод ValidateTextBox подставляются эти данные и при false происходит возвращение return
            // Ребенок
            if (!ValidateTextBox(txtChildLastName, "Фамилия ребёнка", "Фамилия")) return;
            if (!ValidateTextBox(txtChildFirstName, "Имя ребёнка", "Имя")) return;
            if (!ValidateTextBox(txtChildPatronymic, "Отчество ребёнка", "Отчество")) return;
            if (!ValidateTextBox(txtBirthPlace, "Место рождения ребенка", "Место рождения")) return;

            // Мама
            if (!ValidateTextBox(txtMotherLastName, "Фамилия матери", "Фамилия")) return;
            if (!ValidateTextBox(txtMotherFirstName, "Имя матери", "Имя")) return;
            if (!ValidateTextBox(txtMotherPatronymic, "Отчество матери", "Отчество")) return;
            if (!ValidateTextBox(txtMotherPlace, "Место рождения матери", "Место рождения")) return;
            if (!ValidateTextBox(txtMotherCitizenship, "Гражданство матери", "Гражданство")) return;

            // Папа
            if (!ValidateTextBox(txtFatherLastName, "Фамилия отца", "Фамилия")) return;
            if (!ValidateTextBox(txtFatherFirstName, "Имя отца", "Имя")) return;
            if (!ValidateTextBox(txtFatherPatronymic, "Отчество отца", "Отчество")) return;
            if (!ValidateTextBox(txtFatherPlace, "Место рождения отца", "Место рождения")) return;
            if (!ValidateTextBox(txtFatherCitizenship, "Гражданство отца", "Гражданство")) return;

            // Тут мы записываем значения текстбоксов в переменные
            // Данные ребёнка
            string childLastName = txtChildLastName.Text.Trim(); // В переменую записывается фамилия
            string childFirstName = txtChildFirstName.Text.Trim(); // В переменую записывается имя
            string childPatronymic = txtChildPatronymic.Text.Trim(); // В переменую записывается отчество
            string childBirthPlace = txtBirthPlace.Text.Trim(); // В переменую записывается место рождения
            string gender = cbGender.SelectedItem?.ToString(); /* В переменую записывается пол,
            SelectedItem возвращает объект, который выбран в списке, ToString - преобразует элемент в строку */

            // Данные матери
            string motherLastName = txtMotherLastName.Text.Trim(); // В переменую записывается фамилия
            string motherFirstName = txtMotherFirstName.Text.Trim(); // В переменую записывается имя
            string motherPatronymic = txtMotherPatronymic.Text.Trim(); // В переменую записывается отчество
            string motherBirthPlace = txtMotherPlace.Text.Trim(); // В переменую записывается место рождения
            string motherCitizenship = txtMotherCitizenship.Text.Trim(); // В переменую записывается гражданство

            // Данные отца
            string fatherLastName = txtFatherLastName.Text.Trim(); // В переменую записывается фамилия
            string fatherFirstName = txtFatherFirstName.Text.Trim(); // В переменую записывается имя
            string fatherPatronymic = txtFatherPatronymic.Text.Trim(); // В переменую записывается отчество
            string fatherBirthPlace = txtFatherPlace.Text.Trim(); // В переменую записывается место рождения
            string fatherCitizenship = txtFatherCitizenship.Text.Trim(); // В переменую записывается гражданство

            // Подключение к базе данных
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Получаем новые номера записи и свидетельства
                // Обе переменные изначально ставятся в 1, на случай, если в базе данных нет записей - у нас всё равно был номер 1
                int newRecordNumber = 1;
                int newCertificateNumber = 100000; // Если записей нет, то стартовое значение

                // Находим самый большой номер записи и свидетельства
                using (var cmdLast = new NpgsqlCommand("SELECT MAX(record_number), MAX(certificate_number) FROM birth_records", conn))
                using (var reader = cmdLast.ExecuteReader()) // Переменная для хранения прочитанного запроса
                {
                    if (reader.Read()) // Читаем первую строку результата запроса
                    {
                        // Проверяем, пустое ли значение в первой колонке, если да - ставим 1, если нет - берем самое большое значение + 1
                        newRecordNumber = reader.IsDBNull(0) ? 1 : reader.GetInt32(0) + 1;

                        // Если в базе данных нет записей, начинается с 100000, иначе +1 от последнего
                        newCertificateNumber = reader.IsDBNull(1) ? 100000 : reader.GetInt32(1) + 1;
                    }
                }

                // Создаем запрос для бд
                string insertQuery = @"
                INSERT INTO birth_records (record_number, certificate_number,
                child_last_name, child_first_name, child_patronymic, child_birth_date, child_birth_place, child_gender,
                mother_last_name, mother_first_name, mother_patronymic, mother_birth_date, mother_birth_place, mother_citizenship,
                father_last_name, father_first_name, father_patronymic, father_birth_date, father_birth_place, father_citizenship)

                VALUES (
                @record, @cert,
                @clname, @cfname, @cpname, @cbirth, @cplace, @gender,
                @mlname, @mfname, @mpname, @mbirth, @mplace, @mcit,
                @flname, @ffname, @fpname, @fbirth, @fplace, @fcit)";

                // Выполнение SQL-запроса. В этом запросе мы прописываем передачу значения переменных параметрам @, для вставки новых записей в таблицу
                using (var cmd = new NpgsqlCommand(insertQuery, conn))
                {
                    // Передача параметров
                    // AddWithValue - метод для безопасного и эффективного добавления параметров к SQL-командам.
                    // Номер записи акта и номер свидетельства
                    cmd.Parameters.AddWithValue("@record", newRecordNumber);
                    cmd.Parameters.AddWithValue("@cert", newCertificateNumber);

                    // Ребенок
                    cmd.Parameters.AddWithValue("@clname", childLastName);
                    cmd.Parameters.AddWithValue("@cfname", childFirstName);
                    cmd.Parameters.AddWithValue("@cpname", childPatronymic);
                    cmd.Parameters.AddWithValue("@cbirth", childBirthDate);
                    cmd.Parameters.AddWithValue("@cplace", childBirthPlace);
                    cmd.Parameters.AddWithValue("@gender", gender);

                    // Мама
                    cmd.Parameters.AddWithValue("@mlname", motherLastName);
                    cmd.Parameters.AddWithValue("@mfname", motherFirstName);
                    cmd.Parameters.AddWithValue("@mpname", motherPatronymic);
                    cmd.Parameters.AddWithValue("@mbirth", motherBirthDate);
                    cmd.Parameters.AddWithValue("@mplace", motherBirthPlace);
                    cmd.Parameters.AddWithValue("@mcit", motherCitizenship);

                    // Папа
                    cmd.Parameters.AddWithValue("@flname", fatherLastName);
                    cmd.Parameters.AddWithValue("@ffname", fatherFirstName);
                    cmd.Parameters.AddWithValue("@fpname", fatherPatronymic);
                    cmd.Parameters.AddWithValue("@fbirth", fatherBirthDate);
                    cmd.Parameters.AddWithValue("@fplace", fatherBirthPlace);
                    cmd.Parameters.AddWithValue("@fcit", fatherCitizenship);

                    cmd.ExecuteNonQuery(); // Выполнение запроса на сервере
                }

                CreateBirthCertificate();

                // Уведомление
                MessageBox.Show("Запись успешно добавлена и свидетельство создано!", "Успех", MessageBoxButtons.OK);
            }
        }

        private void CreateBirthCertificate() // Метод, который создает пдф файл и вносит туда сохраненные данные
        {
            // Подключаемся к бд
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                // Получаем новые номера записи и свидетельства
                // Обе переменные изначально ставятся в 1, на случай, если в базе данных нет записей - у нас всё равно был номер 1
                int newRecordNumber = 1;
                int newCertificateNumber = 100000; // Если записей нет, то стартовое значение


                // Находим самый большой номер записи и свидетельства
                using (var cmdLast = new NpgsqlCommand("SELECT MAX(record_number), MAX(certificate_number) FROM birth_records", conn))
                using (var reader = cmdLast.ExecuteReader()) // Переменная для хранения прочитанного запроса
                {
                    if (reader.Read()) // Читаем первую строку результата запроса
                    {
                        // Проверяем, пустое ли значение в первой колонке, если да - ставим 1, если нет - берем самое большое значение + 1
                        newRecordNumber = reader.IsDBNull(0) ? 1 : reader.GetInt32(0) + 1;

                        // Если в базе данных нет записей, начинается с 100000, иначе +1 от последнего
                        newCertificateNumber = reader.IsDBNull(1) ? 100000 : reader.GetInt32(1) + 1;
                    }
                }

                // Данные ребёнка
                string childLastName = txtChildLastName.Text.Trim();
                string childFirstName = txtChildFirstName.Text.Trim();
                string childPatronymic = txtChildPatronymic.Text.Trim();
                string childBirthDate = dtpChildBirth.Value.ToString("dd.MM.yyyy");
                string childBirthPlace = txtBirthPlace.Text.Trim();
                string gender = cbGender.SelectedItem?.ToString();

                // Данные матери
                string motherFullName = $"{txtMotherLastName.Text.Trim()} {txtMotherFirstName.Text.Trim()} {txtMotherPatronymic.Text.Trim()}";
                string motherBirthDate = dtpMotherBirth.Value.ToString("dd.MM.yyyy");
                string motherBirthPlace = txtMotherPlace.Text.Trim();

                // Данные отца
                string fatherFullName = $"{txtFatherLastName.Text.Trim()} {txtFatherFirstName.Text.Trim()} {txtFatherPatronymic.Text.Trim()}";
                string fatherBirthDate = dtpFatherBirth.Value.ToString("dd.MM.yyyy");
                string fatherBirthPlace = txtFatherPlace.Text.Trim();

                // Создание PDF документа
                PdfDocument document = new PdfDocument(); // Создаётся новый экземпляр PDF-документа
                PdfPage page = document.AddPage(); // Добавление страницы в документ
                XGraphics gfx = XGraphics.FromPdfPage(page); // Создаётся объект XGraphics, который используется для рисования текста, линий, изображений и других элементов на странице
                XFont fontTitle = new XFont("Arial", 20); // Шрифт для заголовка
                XFont fontText = new XFont("Arial", 12); //  Шрифт для основного текста

                /// <summary>
                /// Тут прописываем элементы и текст, которые будут располагаться в документе
                /// </summary>
                // fontTitle или fontText — шрифт 
                // XBrushes.Black — цвет текста(например, чёрный)
                // XRect - определение области для элемента; координаты по горизонтали и вертикали; page.Width - задает ширину области для текста; page.Height - задает высоту области для текста 
                // XStringFormats.TopCenter — выравнивание текста по центру

                gfx.DrawString("Свидетельство о рождении", fontTitle, XBrushes.Black, new XRect(0, 40, page.Width, page.Height), XStringFormats.TopCenter);
                gfx.DrawString($"ФИО ребенка: {childLastName} {childFirstName} {childPatronymic}", fontText, XBrushes.Black, new XRect(40, 100, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Дата рождения: {childBirthDate}", fontText, XBrushes.Black, new XRect(40, 140, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Место рождения: {childBirthPlace}", fontText, XBrushes.Black, new XRect(40, 180, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Пол: {gender}", fontText, XBrushes.Black, new XRect(40, 220, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Мать: {motherFullName}, Дата рождения: {motherBirthDate}, Место рождения: {motherBirthPlace}", fontText, XBrushes.Black, new XRect(40, 260, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Отец: {fatherFullName}, Дата рождения: {fatherBirthDate}, Место рождения: {fatherBirthPlace}", fontText, XBrushes.Black, new XRect(40, 300, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Номер записи акта: {newRecordNumber}", fontText, XBrushes.Black, new XRect(40, 340, page.Width, page.Height), XStringFormats.TopLeft);
                gfx.DrawString($"Номер свидетельства: {newCertificateNumber}", fontText, XBrushes.Black, new XRect(40, 380, page.Width, page.Height), XStringFormats.TopLeft);

                // Сохранение PDF в папку Загрузки
                string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"); // путь к папке "Загрузки"
                string filename = Path.Combine(downloadsPath, $"Свидетельство_о_рождении_{childLastName}_{childFirstName}.pdf"); // Полное имя файла
                document.Save(filename); // Сохранение документа по указанному пути
            }
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

        private void nazad_Click(object sender, EventArgs e) // Кнопка "назад" (стрелочка)
        {
            this.Hide(); // Скрытие данной формы
            mainForm.Show(); // Показ формы MainForm (ссылаемся на нее)
            this.Close(); // Закрытие данной формы
        }


        /// <summary>
        /// Тут мы прописываем все плейсхолдеры (потухшие буквы в текстбоксах)
        /// Это делается для того, чтобы пользователю было понятно, что вводить в определенный текстбокс.
        /// Для каждого текстбокса создается два обработчиика событий - Enter и Leave.
        /// Enter - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// Leave - если мы встаем на определенный текстбокс, то происходят какие-то действия
        /// </summary>

        // Фамилия матери
        private void txtMotherLastName_Enter(object sender, EventArgs e)
        {
            if (txtMotherLastName.Text == "Фамилия")
            {
                txtMotherLastName.Text = ""; // Очищаем текст
                txtMotherLastName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtMotherLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotherLastName.Text))
            {
                txtMotherLastName.Text = "Фамилия"; // Возвращаем placeholder
                txtMotherLastName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Имя матери
        private void txtMotherFirstName_Enter(object sender, EventArgs e)
        {
            if (txtMotherFirstName.Text == "Имя")
            {
                txtMotherFirstName.Text = ""; // Очищаем текст
                txtMotherFirstName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtMotherFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotherFirstName.Text))
            {
                txtMotherFirstName.Text = "Имя"; // Возвращаем placeholder
                txtMotherFirstName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Отчество матери
        private void txtMotherPatronymic_Enter(object sender, EventArgs e)
        {
            if (txtMotherPatronymic.Text == "Отчество")
            {
                txtMotherPatronymic.Text = ""; // Очищаем текст
                txtMotherPatronymic.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtMotherPatronymic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotherPatronymic.Text))
            {
                txtMotherPatronymic.Text = "Отчество"; // Возвращаем placeholder
                txtMotherPatronymic.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Гражданство матери
        private void txtMotherCitizenship_Enter(object sender, EventArgs e)
        {
            if (txtMotherCitizenship.Text == "Гражданство")
            {
                txtMotherCitizenship.Text = ""; // Очищаем текст
                txtMotherCitizenship.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtMotherCitizenship_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotherCitizenship.Text))
            {
                txtMotherCitizenship.Text = "Гражданство"; // Возвращаем placeholder
                txtMotherCitizenship.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Место рождения матери
        private void txtMotherPlace_Enter(object sender, EventArgs e)
        {
            if (txtMotherPlace.Text == "Место рождения")
            {
                txtMotherPlace.Text = ""; // Очищаем текст
                txtMotherPlace.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtMotherPlace_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotherPlace.Text))
            {
                txtMotherPlace.Text = "Место рождения"; // Возвращаем placeholder
                txtMotherPlace.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Фамилия отца
        private void txtFatherLastName_Enter(object sender, EventArgs e)
        {
            if (txtFatherLastName.Text == "Фамилия")
            {
                txtFatherLastName.Text = ""; // Очищаем текст
                txtFatherLastName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFatherLastName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherLastName.Text))
            {
                txtFatherLastName.Text = "Фамилия"; // Возвращаем placeholder
                txtFatherLastName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Имя отца
        private void txtFatherFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFatherFirstName.Text == "Имя")
            {
                txtFatherFirstName.Text = ""; // Очищаем текст
                txtFatherFirstName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFatherFirstName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherFirstName.Text))
            {
                txtFatherFirstName.Text = "Имя"; // Возвращаем placeholder
                txtFatherFirstName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Отчество отца
        private void txtFatherPatronymic_Enter(object sender, EventArgs e)
        {
            if (txtFatherPatronymic.Text == "Отчество")
            {
                txtFatherPatronymic.Text = ""; // Очищаем текст
                txtFatherPatronymic.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFatherPatronymic_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherPatronymic.Text))
            {
                txtFatherPatronymic.Text = "Отчество"; // Возвращаем placeholder
                txtFatherPatronymic.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Гражданство отца
        private void txtFatherCitizenship_Enter(object sender, EventArgs e)
        {
            if (txtFatherCitizenship.Text == "Гражданство")
            {
                txtFatherCitizenship.Text = ""; // Очищаем текст
                txtFatherCitizenship.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFatherCitizenship_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherCitizenship.Text))
            {
                txtFatherCitizenship.Text = "Гражданство"; // Возвращаем placeholder
                txtFatherCitizenship.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Место рождения отца
        private void txtFatherPlace_Enter(object sender, EventArgs e)
        {
            if (txtFatherPlace.Text == "Место рождения")
            {
                txtFatherPlace.Text = ""; // Очищаем текст
                txtFatherPlace.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtFatherPlace_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFatherPlace.Text))
            {
                txtFatherPlace.Text = "Место рождения"; // Возвращаем placeholder
                txtFatherPlace.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Фамилия ребенка
        private void txtChildLastName_Enter_1(object sender, EventArgs e)
        {
            if (txtChildLastName.Text == "Фамилия")
            {
                txtChildLastName.Text = ""; // Очищаем текст
                txtChildLastName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildLastName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildLastName.Text))
            {
                txtChildLastName.Text = "Фамилия"; // Возвращаем placeholder
                txtChildLastName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Имя ребенка
        private void txtChildFirstName_Enter_1(object sender, EventArgs e)
        {
            if (txtChildFirstName.Text == "Имя")
            {
                txtChildFirstName.Text = ""; // Очищаем текст
                txtChildFirstName.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildFirstName_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildFirstName.Text))
            {
                txtChildFirstName.Text = "Имя"; // Возвращаем placeholder
                txtChildFirstName.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Отчество ребенка
        private void txtChildPatronymic_Enter_1(object sender, EventArgs e)
        {
            if (txtChildPatronymic.Text == "Отчество")
            {
                txtChildPatronymic.Text = ""; // Очищаем текст
                txtChildPatronymic.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtChildPatronymic_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtChildPatronymic.Text))
            {
                txtChildPatronymic.Text = "Отчество"; // Возвращаем placeholder
                txtChildPatronymic.ForeColor = Color.Gray; // Снова делаем текст серым
            }
        }

        // Место рождения
        private void txtBirthPlace_Enter_1(object sender, EventArgs e)
        {
            if (txtBirthPlace.Text == "Место рождения")
            {
                txtBirthPlace.Text = ""; // Очищаем текст
                txtBirthPlace.ForeColor = Color.Black; // Меняем цвет на обычный
            }
        }
        private void txtBirthPlace_Leave_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBirthPlace.Text))
            {
                txtBirthPlace.Text = "Место рождения"; // Возвращаем placeholder
                txtBirthPlace.ForeColor = Color.Gray; // Снова делаем текст серым
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
        private void dtpMotherBirth_ValueChanged(object sender, EventArgs e)
        {
            // Меняем формат на обычную дату
            dtpMotherBirth.Format = DateTimePickerFormat.Long;
            dtpMotherBirth.CustomFormat = "";
        }

        // Событие, которое срабатывает, когда пользователь выбирает дату
        private void dtpFatherBirth_ValueChanged(object sender, EventArgs e)
        {
            // Меняем формат на обычную дату
            dtpFatherBirth.Format = DateTimePickerFormat.Long;
            dtpFatherBirth.CustomFormat = "";
        }
    }
}
