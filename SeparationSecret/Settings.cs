using SecretSharing;
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

namespace SeparationSecret
{
    public partial class Settings : Form
    {
        public static int NumberLanguage = 0;
        int Nlanguage
        {
            get
            {
                return NumberLanguage;
            }

            set
            {
                NumberLanguage = value;

                фToolStripMenuItem.Text = file[Nlanguage];
                вToolStripMenuItem.Text = output2[Nlanguage];
                выходИзПриложенияToolStripMenuItem.Text = output[Nlanguage];
                выToolStripMenuItem.Text = back[Nlanguage];

                справкаToolStripMenuItem.Text = help[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];

                button1.Text = changePassword[Nlanguage];

                label.Text = passwordChangeForm[Nlanguage];
                label3.Text = enterCurrentPassword[Nlanguage];
                label4.Text = enterNewPassword[Nlanguage];
                label1.Text = confirmPassword[Nlanguage];

            }
        }
        public Settings(string v, string d)
        {
            InitializeComponent();
            Program.RegisterForm(this); // Регистрируем форму


            // Настройка HelpProvider
            helpProvider = new HelpProvider();
            // Используем относительный путь к CHM-файлу
            string helpFilePath = Path.Combine(Application.StartupPath, "Properties", "SeparationSecretHelp.chm");
            helpProvider.HelpNamespace = helpFilePath;
            helpProvider.SetHelpNavigator(this, HelpNavigator.TableOfContents);

            // Включение обработки клавиш на уровне формы
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Проверка нажатия клавиши F1
            if (e.KeyCode == Keys.F1)
            {
                string helpFilePath = Path.Combine(Application.StartupPath, "Properties", "SeparationSecretHelp.chm");
                if (File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, helpFilePath, "osnovnoj_interfejs.htm");
                }
                else
                {
                    MessageBox.Show($"Файл справки не найден по пути: {helpFilePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // Отмечаем событие как обработанное
            }
        }

        static List<string> file = new List<string>() { "Файл", "File" };
        static List<string> output = new List<string>() { "Выход из приложения", "Exiting the app" };
        static List<string> output2 = new List<string>() { "Выход из аккаунта", "Exit from account" };
        static List<string> back = new List<string>() { "Назад", "Back" };

        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };

        static List<string> changePassword = new List<string>() { "Сменить пароль", "Change password" };

        static List<string> passwordChangeForm = new List<string>() { "Форма смены пароля", "Password change form" };

        static List<string> enterNewPassword = new List<string>() { "Введите новый пароль", "Enter a new password" };
        static List<string> enterCurrentPassword = new List<string>() { "Введите старый пароль", "Enter your current password" };
        static List<string> confirmPassword = new List<string>() { "Подтвердите пароль", "Confirm the password" };
        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

        public static List<string> version = new List<string>() { "Версия:", "Version:" };
        public static List<string> developers = new List<string>() { "Разработчики:", "Developers:" };

        public static List<string> supportService = new List<string>() { "Служба поддержки", "Support service" };

        private void button1_Click(object sender, EventArgs e)
        {
            string login = Program.CurrentUsername;
            string oldPassword = txtOldPassword.Text.Trim();
            string newPassword = txtNewPassword.Text.Trim();
            string confirmPassword = txtConfirmPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(oldPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Новый пароль и подтверждение не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filePath = Path.Combine(Application.StartupPath, "Log.txt");
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл пользователей не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith($"Login: {login}", StringComparison.OrdinalIgnoreCase))
                {
                    // Проверим пароль
                    string[] parts = lines[i].Split(',');
                    string passwordPart = parts.FirstOrDefault(p => p.Trim().StartsWith("Password:"));
                    if (passwordPart == null)
                        continue;

                    string existingPassword = passwordPart.Split(':')[1].Trim();
                    if (existingPassword != oldPassword)
                    {
                        MessageBox.Show("Неверный старый пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Заменим пароль
                    string newLine = lines[i].Replace($"Password: {existingPassword}", $"Password: {newPassword}");
                    lines[i] = newLine;
                    updated = true;
                    break;
                }
            }

            if (updated)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_the_program about_the_program = new about_the_program(version[Nlanguage], developers[Nlanguage]);
            about_the_program.ShowDialog();
        }

        private void руководствоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            users_guide users_guide = new users_guide(userManual[Nlanguage], supportService[Nlanguage]);
            users_guide.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }

        private void вToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutForm AutForm = new AutForm();
            AutForm.Show();
            this.Close();
        }

        private void выходИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
