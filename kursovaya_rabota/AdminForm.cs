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
    public partial class AdminForm : Form
    {
        private Form mainForm; // Переменная для хранения объекта MainForm

        public AdminForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm; // callingForm покажет ту самую MainForm, с которой мы пришли
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана

            // Цвета элементов
            this.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон формы 
            label1.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "Страница для администратора"
            btnUserManag.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Управление пользователями"
            btnUserManag.ForeColor = ColorTranslator.FromHtml("#4A2714");
            btnAssigRol.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Назначение ролей"
            btnAssigRol.ForeColor = ColorTranslator.FromHtml("#4A2714");
            btnActionLog.BackColor = ColorTranslator.FromHtml("#FFB085"); // Кнопка "Журнал действий"
            btnActionLog.ForeColor = ColorTranslator.FromHtml("#4A2714");
            topPanel1.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель 
        }

        private void btnUserManag_Click(object sender, EventArgs e) // Кнопка "Управление пользователями"
        {
            AdmUserManag admuser = new AdmUserManag(this);
            this.Hide(); // Скрывает текущую форму (мы ее не закрываем, а скрываем для того, чтобы потом вернуться на нее)
            admuser.ShowDialog();
        }

        private void btnAssigRol_Click(object sender, EventArgs e) // Кнопка "Назначение ролей"
        {

        }

        private void btnActionLog_Click(object sender, EventArgs e) // Кнопка "Журнал действий"
        {

        }

        private void btnLogout_Click_Click(object sender, EventArgs e) // Кнопка "выход из системы"
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

        private void CloseApplication_Click_1(object sender, EventArgs e) // Кнопка крестик
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложение
        }

        private void nazad_Click_1(object sender, EventArgs e) // Кнопка "Назад"
        {
            this.Hide(); // Скрытие данной формы
            mainForm.Show(); // Показ формы MainForm (ссылаемся на нее)
            this.Close(); // Закрытие данной формы
        }
    }
}
