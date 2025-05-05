using SeparationSecret;
using System;
using System.Windows.Forms;

namespace SecretSharing
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Запускаем первую форму, но не привязываем к ней жизненный цикл приложения
            AutForm AutForm = new AutForm();
            AutForm.Show();

            // Запускаем цикл приложения без привязки к конкретной форме
            Application.Run();
        }
    }
}