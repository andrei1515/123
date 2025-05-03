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
    public partial class MainForm : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=kurs;Username=postgres;Password=qwerty"; // Строка подключения к бд
        private string userRole; // Храним роль пользователя

        public MainForm(string role)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана

            userRole = role; // Переменная для хранения роли

            // Проверяем роль и отображаем кнопку админа
            if (userRole == "admin")
            {
                btnAdminPanel.Visible = true;
            }
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            ///<summary>
            /// В данном методе мы прописываем приветствие пользователя, а точнее - его отображение ФИО при приветствии
            /// </summary>
            int userId = Properties.Settings.Default.UserId; // Сохраняем ID авторизованного пользователя в переменную userId

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open(); // Открываем соединение с бд
                string query = "SELECT fio FROM users WHERE id = @id"; /* Готовим SQL-запрос: найти ФИО пользователя в таблице
                                                                          users, у которого id равен нашему userId */

                using (var cmd = new NpgsqlCommand(query, connection)) // Создаем команду для выполнения запроса
                {
                    cmd.Parameters.AddWithValue("@id", userId); // Передаём значение переменной userId в параметр @id
                    var fio = cmd.ExecuteScalar(); //ExecuteScalar() возвращает первое значение первой строки результата

                    lblGreeting.Text = $"Добро пожаловать, {fio}"; // label выводит текст и имя сотрудника согласно запросу
                }
            }

            // Цвета элементов
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Домашняя страница"
            lblGreeting.ForeColor = ColorTranslator.FromHtml("#A73302"); // Приветствие
            btnRegisterBirth.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Регистрация рождения"
            btnRegisterBirth.ForeColor = ColorTranslator.FromHtml("#4A2714");
            btnRegisterDeath.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Регистрация смерти"
            btnRegisterDeath.ForeColor = ColorTranslator.FromHtml("#4A2714"); 
            btnSearchRecords.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Поиск записей"
            btnSearchRecords.ForeColor = ColorTranslator.FromHtml("#4A2714");
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель 
            btnAdminPanel.BackColor = ColorTranslator.FromHtml("#C5C4C1"); // Кнопка "Для админа"
            btnAdminPanel.ForeColor = ColorTranslator.FromHtml("#A73302");
        }

        private void btnRegisterBirth_Click_1(object sender, EventArgs e) // Кнопка "Регситрация рождения"
        {
            BirthForm birthForm = new BirthForm(this); // Создание объекта для формы BirthForm
            this.Hide(); // Скрывает текущую форму MainForm (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            birthForm.ShowDialog(); // Показывает форму BirthForm
        }

        private void btnRegisterDeath_Click(object sender, EventArgs e) // Кнопка "Регситрация смерти"
        {
            DeathForm deathForm = new DeathForm(this);
            this.Hide(); // Скрывает текущую форму MainForm (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            deathForm.ShowDialog();
        }

        private void btnSearchRecords_Click(object sender, EventArgs e) // Кнопка "Поиск записей"
        {
            SearchForm searchForm = new SearchForm(this);
            this.Hide(); // Скрывает текущую форму MainForm (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            searchForm.ShowDialog();
        }

        private void btnAdminPanel_Click(object sender, EventArgs e) // Кнопка "Для админа"
        {
            AdminForm admform = new AdminForm(this);
            this.Hide(); // Скрывает текущую форму MainForm (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            admform.ShowDialog();
        }

        private void btnLogout_Click_Click(object sender, EventArgs e) // // Кнопка "Выход"
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

        private void btnAbout_Click(object sender, EventArgs e) // Кнопка "О программе"
        {
            InfoForm infoForm = new InfoForm(this); // Создание объекта для формы BirthForm
            this.Hide(); // Скрывает текущую форму MainForm (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            infoForm.ShowDialog(); // Показывает форму InfoForm
        }

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложение
        }
    }
}
