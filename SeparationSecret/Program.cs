using SeparationSecret;
using System;
using System.Windows.Forms;

namespace SecretSharing
{
    static class Program
    {
        private static List<Form> openForms = new List<Form>();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AutForm AutForm = new AutForm();
            openForms.Add(AutForm);
            AutForm.FormClosed += (s, e) => CheckForOpenForms();
            AutForm.Show();

            Application.Run();
        }

        private static void CheckForOpenForms()
        {
            openForms.RemoveAll(form => form.IsDisposed);
            if (openForms.Count == 0)
            {
                Application.Exit();
            }
        }

        public static void RegisterForm(Form form)
        {
            openForms.Add(form);
            form.FormClosed += (s, e) => CheckForOpenForms();
        }
    }
    
}