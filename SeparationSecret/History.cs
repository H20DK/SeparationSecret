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
    public partial class History : Form
    {
        private DataTable historyTable;

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
                справкаToolStripMenuItem.Text = help[Nlanguage];
                оПрограммеToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                руководствоПользователяToolStripMenuItem.Text = userManual[Nlanguage];
                языкToolStripMenuItem.Text = language[Nlanguage];

                выходИзАккаунтаToolStripMenuItem.Text = output2[Nlanguage];
                выходToolStripMenuItem.Text = output[Nlanguage];
                назадToolStripMenuItem.Text = back[Nlanguage];


            }
        }
        public History(string v, string d)
        {
            InitializeComponent();
            Program.RegisterForm(this); // Регистрируем форму

            InitializeHistoryTable();
            LoadHistoryForUser(Program.CurrentUsername);


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

        private void InitializeHistoryTable()
        {
            historyTable = new DataTable();
            historyTable.Columns.Add("Дата");
            historyTable.Columns.Add("Описание");
            historyTable.Columns.Add("Число");

            dgvHistory.DataSource = historyTable;
        }

        private void LoadHistoryForUser(string username)
        {
            string filePath = Path.Combine(Application.StartupPath, "shares.txt");

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл с историей (shares.txt) не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length <= 1)
                return;

            foreach (var line in lines.Skip(1)) // Пропустить заголовок
            {
                string[] parts = line.Split('|');
                if (parts.Length < 5)
                    continue;

                string владелец = parts[4].Trim();
                if (string.Equals(владелец, username, StringComparison.OrdinalIgnoreCase))
                {
                    historyTable.Rows.Add(
                        parts[0].Trim(),
                        parts[1].Trim(),
                        parts[2].Trim()
                    );
                }
            }
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

        static List<string> file = new List<string>() { "Аккаунт", "Account" };
        static List<string> output = new List<string>() { "Выход из приложения", "Exiting the app" };
        static List<string> output2 = new List<string>() { "Выход из аккаунта", "Exit from account" };
        static List<string> back = new List<string>() { "Назад", "Back" };

        static List<string> help = new List<string>() { "Справка", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "О программе", "About the program" };
        static List<string> userManual = new List<string>() { "Руководство пользователя", "User manual" };
        static List<string> language = new List<string>() { "Язык", "Language" };

        public static List<string> errorNonNumber = new List<string>() { "не число", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "Неправильный формат ввода", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "Были ошибки, возможен не тот результат", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "Такое программа посчитать не может", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "Ошибка в количестве строк в языковом файле", "Error in the number of lines in the language file" };

        public static List<string> version = new List<string>() { "Версия:", "Version:" };
        public static List<string> developers = new List<string>() { "Разработчики:", "Developers:" };

        public static List<string> supportService = new List<string>() { "Служба поддержки", "Support service" };

        private void History_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
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
            Close();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void выходИзАккаунтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutForm AutForm = new AutForm();
            AutForm.Show();
            this.Close();
        }
    }
}
