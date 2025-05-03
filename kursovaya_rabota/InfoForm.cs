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
    public partial class InfoForm : Form
    {
        private Form mainForm; // Переменная для хранения объекта MainForm

        public InfoForm(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm; // callingForm покажет ту самую MainForm, с которой мы пришли
            this.FormBorderStyle = FormBorderStyle.None; // Убираем границы формы
            this.StartPosition = FormStartPosition.CenterScreen; // При запуске  формы она появляется в середине экрана
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            // Цвета элементов
            o_programme.ForeColor = ColorTranslator.FromHtml("#3A3A3A"); // Текст "О программе"
            topPanel.BackColor = ColorTranslator.FromHtml("#FFD6A5"); // Верхняя панель
            labelInfa.BackColor = ColorTranslator.FromHtml("#FFF5E4"); // Фон текстбокса для заполнения информации
            labelInfa.ForeColor = ColorTranslator.FromHtml("#111111"); // Цвет текста
            labelInfa.Font = new Font("Microsoft Tai Le", 11); // Шрифт и размер


            labelInfa.Text =
                    "  Название: ZAGSoft\r\n" +
                    "  Версия: 1.0\r\n" +
                    "  Разработчик: Хачатурян Андрей\r\n" +
                    "  Год выпуска: 2025\r\n\r\n" +
                    "  Описание:\r\n" +
                    "  Данное приложение позволяет сотрудникам ЗАГСа быстро и удобно оформлять\r\n" +
                    "  записи о рождении и смерти граждан.\r\n" +
                    "  Программа упрощает заполнение данных, ведение учёта записей, выдачу свиде-\r\n" +
                    "  тельств и формирование отчётности.\r\n\r\n" +
                    "  Системные требования:\r\n" +
                    "   - Windows 10/11\r\n" +
                    "   - .NET Framework 4.7.2 и выше\r\n" +
                    "   - База данных PostgreSQL\r\n\r\n" +
                    "  Контакты для связи: anrusha@email.com";
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide(); // Скрытие формы
            mainForm.Show(); // Показ формы MainForm (ссылаемся на нее)
            this.Close(); // Закрытие формы
        }

        private void btnLogout_Click(object sender, EventArgs e) // Выход из системы
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

        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit(); // При закрытии крестиком — завершить все приложение
        }
    }
}
