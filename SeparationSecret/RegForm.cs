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
using System.Xml.Linq;

namespace SeparationSecret
{
    public partial class RegForm : Form
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

                файлToolStripMenuItem.Text = file[Nlanguage];
                выходToolStripMenuItem.Text = output[Nlanguage];
                справкаToolStripMenuItem.Text = help[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];

                
                button2.Text = Signup[Nlanguage];

                label2.Text = Password[Nlanguage];
                label.Text = Pleaselogin[Nlanguage];
                label1.Text = Login[Nlanguage];

            }
        }
        public RegForm()
        {
            InitializeComponent();

            Program.RegisterForm(this); // Регистрируем форму

            // Настройка HelpProvider
            helpProvider = new HelpProvider();
            // Используем относительный путь к CHM-файлу
            string helpFilePath = Path.Combine(Application.StartupPath, "SeparationSecretHelp.chm");
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
                string helpFilePath = Path.Combine(Application.StartupPath, "SeparationSecretHelp.chm");
                if (File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, helpFilePath, "registratsiya.htm");
                }
                else
                {
                    MessageBox.Show($"Файл справки не найден по пути: {helpFilePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // Отмечаем событие как обработанное
            }
        }

        static List<string> file = new List<string>() { "Файл", "File" };
        static List<string> output = new List<string>() { "Выход из приложения", "Exit" };
        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };
        public static List<string> version = new List<string>() { "Версия:", "Version:" };
        public static List<string> developers = new List<string>() { "Разработчики:", "Developers:" };
        public static List<string> supportService = new List<string>() { "Служба поддержки", "Support service" };

        static List<string> Signin = new List<string>() { "Войти", "Sign in" };
        static List<string> Signup = new List<string>() { "Зарегистрироваться", "Sign up" };

        static List<string> Password = new List<string>() { "Пароль", "Password" };
        static List<string> Login = new List<string>() { "Логин", "Login" };
        static List<string> Pleaselogin = new List<string>() { "Пожалуйста, войдите в систему", "Please login" };

        static List<string> enterMinimumRequiredNumberPartsSecretRecover = new List<string>() { "Введите минимально необходимое кол-во частей секрета для восстановления :", "Enter the minimum required number of parts of secret to recover :" };
        static List<string> result = new List<string>() { "Результат :", "Result :" };

        static List<string> enterNthSecret = new List<string>() { "Введите n-ый секрет:", "Enter the nth secret :" };

        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

        private void RegForm_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем данные из полей ввода
                string login = txtLogin.Text;
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string password = txtPassword.Text;
                string patronymic = txtPatronymic.Text;

                // Проверяем, что обязательные поля заполнены
                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Пожалуйста, заполните все обязательные поля (*).", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Формируем строку для записи
                string userData = $"Login: {login}, Password: {password}, Surname: {surname} Name: {name}, Patronymic: {patronymic}\n";

                // Сохраняем данные в файл Log.txt
                string filePath = Path.Combine(Application.StartupPath, "Log.txt");
                File.AppendAllText(filePath, userData); // Используем AppendAllText для добавления новых записей

                MessageBox.Show("Пользователь успешно зарегистрирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очищаем поля после успешной регистрации (опционально)
                txtLogin.Clear();
                txtName.Clear();
                txtSurname.Clear();
                txtPassword.Clear();
                txtPatronymic.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }
    }
}
