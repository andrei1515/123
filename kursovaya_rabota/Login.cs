using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; // Библиотека для работы с PostgreSQL

namespace kursovaya_rabota
{
    public partial class Login : Form
    {
        // Строка подключения к PostgreSQL
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Строка подключения к бд
        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана
        }

        private void btnLogin_Click_1(object sender, EventArgs e) // Кнопка "Вход"
        {
            string login = txtLogin.Text.Trim(); // Получение логина, Trim() удаляет пробелы с начала и конца строки
            string password = txtPassword.Text.Trim(); // Получение пароля

            // Если метод IsNullOrEmpty выдает true (поля не заполнены), то выводится сообщение
            if (string.IsNullOrWhiteSpace(login) && string.IsNullOrWhiteSpace(password))
            {
                lblLoginError.Text = "Заполните поле";
                lblPasswordError.Text = "Заполните поле";
                return;
            }
            else
            {
                lblPasswordError.Text = "";
                lblLoginError.Text = "";
            }

            if (string.IsNullOrWhiteSpace(login))
            {
                lblLoginError.Text = "Заполните поле";
                return;
            }
            else
            {
                lblLoginError.Text = "";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                lblPasswordError.Text = "Заполните поле";
                return;
            }
            else
            {
                lblPasswordError.Text = "";
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open(); // Открываем соединение с бд

                    string sql = "SELECT id, password, role FROM users WHERE login = @login"; // Подготавливаем SQL-запрос для получения пользователя по логину

                    using (var cmd = new NpgsqlCommand(sql, connection)) // Выполнение запроса
                    {
                        // Передача параметров
                        // AddWithValue - метод для безопасного и эффективного добавления параметров к SQL-командам
                        cmd.Parameters.AddWithValue("@login", login); // Передается логин

                        using (var reader = cmd.ExecuteReader()) // Метод ExecuteReader используется для выпполнения запроса
                        {
                            if (reader.Read()) // Читаем первую строку из результата. Если строка найдена — пользователь существует.
                            {
                                string dbPassword = reader["password"].ToString(); // Читаем пароль

                                // Сравниваем введённый пароль с тем, что в БД
                                if (password == dbPassword)
                                {
                                    // Получаем id и role пользователя и сохраняем в настройках программы
                                    int userId = Convert.ToInt32(reader["id"]);
                                    string role = reader["role"].ToString(); // Получаем роль из базы

                                    // Сохраняем данные пользователя
                                    Properties.Settings.Default.UserId = userId;
                                    Properties.Settings.Default.UserRole = role;

                                    // Если пользователь отметил галочку "Запомнить", сохраняем логин
                                    if (chkRemember.Checked) // Если чекбокс стоит
                                    {
                                        Properties.Settings.Default.RememberMe = true; // Записываем в параметры
                                        Properties.Settings.Default.SavedRole = role; // Записываем в параметры роль
                                    }
                                    else
                                    {
                                        Properties.Settings.Default.RememberMe = false; // Записываем в параметры
                                    }
                                    Properties.Settings.Default.Save(); // Сохранение настроек

                                    // Происходит открытие главной формы
                                    this.Hide(); // Скрывает текущую форму, в данном случае Form1 (Скрываем, а не закрываем,
                                                    // потому что Form1 - главная форма и если мы ее закроем, то закроются все окна)
                                    MainForm mainForm = new MainForm(role); // Создаём главную форму, передавая роль
                                    mainForm.ShowDialog(); // Показывает форму mainForm
                                    this.Close(); // Закрывает Form1, если MainForm закроется
                                }
                                else
                                {
                                    MessageBox.Show("Неверный пароль");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден");
                            }
                        }
                    }
                }
            }
            catch (Exception ex) // Если произойдёт ошибка — выводится сообщение.
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}");
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Элементы Label, текст которых появляется под текстбоксами при незаполнении текстбоксов
            lblLoginError.Text = ""; // Текст "Заполните поле";
            lblPasswordError.Text = ""; // Текст "Заполните поле"

            // Цвета элементов
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            btnLogin_Click.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка
            btnLogin_Click.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Текст на кнопке
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Вход в систему(цвет)
            label2.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Логин
            label3.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Пароль
            chkRemember.ForeColor = ColorTranslator.FromHtml("#4A2714"); // Чекбокс
            lblLoginError.ForeColor = ColorTranslator.FromHtml("#A73302"); // Заполните поле
            lblPasswordError.ForeColor = ColorTranslator.FromHtml("#A73302"); // Заполните поле
            topPanel.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
            pictureBox1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Фон для изображения "Человечек"
            pictureBox2.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Фон для изображения "Замочек"
        }

        private void CloseApplication_Click(object sender, EventArgs e) // Кнопка выхода из приложения
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложение
        }
    }
}
