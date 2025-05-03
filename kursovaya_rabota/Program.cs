using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovaya_rabota
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Включает современный внешний вид (темы) элементов управления Windows (кнопок, текстбоксов, и т.д.) — без этого всё выглядело бы как в Windows 98
            //Application.EnableVisualStyles();

            // Устанавливает режим отрисовки текста. false - означает использование нового движка GDI + (он лучше отображает шрифты и поддерживает Unicode).
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.RememberMe) // Если галочка в чекбоксе "Запомнить" нажата
            {
                string savedRole = Properties.Settings.Default.SavedRole; // Запускаем программу с определенной ролью
                // Запускаем главную форму
                Application.Run(new MainForm(savedRole));
            }
            else
            {
                // Иначе — нас перекидывает на форму входа
                Application.Run(new Login());
            }
        }
    }
}
