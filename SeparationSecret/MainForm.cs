using Microsoft.VisualBasic.ApplicationServices;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.IO;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Text;

namespace SeparationSecret
{
    public partial class MainForm : Form
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
                файлToolStripMenuItem1.Text = output[Nlanguage];
                справкаToolStripMenuItem.Text = help[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];
                button1.Text = shareSecret[Nlanguage];
                label2.Text = enterSecret[Nlanguage];
                label3.Text = enterNumberPartsSecret[Nlanguage];
                label4.Text = enterMinimumRequiredNumberPartsSecretRecover[Nlanguage];
                label5.Text = result[Nlanguage];
                button2.Text = recoverSecret[Nlanguage];
                label10.Text = enterNumberPartsSecret[Nlanguage];
                label7.Text = enterNthSecret[Nlanguage];
                label11.Text = result[Nlanguage];
            }
        }
        public MainForm()
        {
            InitializeComponent();

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
                    Help.ShowHelp(this, helpFilePath);
                }
                else
                {
                    MessageBox.Show($"Файл справки не найден по пути: {helpFilePath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // Отмечаем событие как обработанное
            }
        }

        static List<string> file = new List<string>() { "Файл", "File" };
        static List<string> output = new List<string>() { "Выход", "Exit" };
        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };
        static List<string> shareSecret = new List<string>() { "Разделить секрет", "Share a secret:" };
        static List<string> enterSecret = new List<string>() { "Введите секрет :", "Enter the secret :" };
        static List<string> enterNumberPartsSecret = new List<string>() { "Введите количество частей секрета :", "Enter the number of parts of the secret :" };
        static List<string> enterMinimumRequiredNumberPartsSecretRecover = new List<string>() { "Введите минимально необходимое кол-во частей секрета для восстановления :", "Enter the minimum required number of parts of secret to recover :" };
        static List<string> result = new List<string>() { "Результат :", "Result :" };
        static List<string> recoverSecret = new List<string>() { "Восстановить секрет", "Recover secret" };
        static List<string> enterNthSecret = new List<string>() { "Введите n-ый секрет:", "Enter the nth secret :" };

        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

        public static List<string> version = new List<string>() { "Версия:", "Version:" };
        public static List<string> developers = new List<string>() { "Разработчики:", "Developers:" };

        public static List<string> supportService = new List<string>() { "Служба поддержки", "Support service" };

        private void файлToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void языкToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void английскийToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void английскийToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about_the_program about_the_program = new about_the_program(version[Nlanguage], developers[Nlanguage]);
            about_the_program.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void английскийToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }
    }
}
