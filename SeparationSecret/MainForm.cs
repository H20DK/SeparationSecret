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

                ����ToolStripMenuItem.Text = file[Nlanguage];
                ����ToolStripMenuItem1.Text = output[Nlanguage];
                �������ToolStripMenuItem.Text = help[Nlanguage];
                ����������ToolStripMenuItem.Text = aboutTheProgram[Nlanguage];
                �����������������������ToolStripMenuItem.Text = userManual[Nlanguage];
                ����ToolStripMenuItem.Text = language[Nlanguage];
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

            // ��������� HelpProvider
            helpProvider = new HelpProvider();
            // ���������� ������������� ���� � CHM-�����
            string helpFilePath = Path.Combine(Application.StartupPath, "SeparationSecretHelp.chm");
            helpProvider.HelpNamespace = helpFilePath;
            helpProvider.SetHelpNavigator(this, HelpNavigator.TableOfContents);

            // ��������� ��������� ������ �� ������ �����
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // �������� ������� ������� F1
            if (e.KeyCode == Keys.F1)
            {
                string helpFilePath = Path.Combine(Application.StartupPath, "SeparationSecretHelp.chm");
                if (File.Exists(helpFilePath))
                {
                    Help.ShowHelp(this, helpFilePath);
                }
                else
                {
                    MessageBox.Show($"���� ������� �� ������ �� ����: {helpFilePath}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true; // �������� ������� ��� ������������
            }
        }

        static List<string> file = new List<string>() { "����", "File" };
        static List<string> output = new List<string>() { "�����", "Exit" };
        static List<string> help = new List<string>() { "�������", "Help" };
        static List<string> aboutTheProgram = new List<string>() { "� ���������", "About the program" };
        static List<string> userManual = new List<string>() { "����������� ������������", "User manual" };
        static List<string> language = new List<string>() { "����", "Language" };
        static List<string> shareSecret = new List<string>() { "��������� ������", "Share a secret:" };
        static List<string> enterSecret = new List<string>() { "������� ������ :", "Enter the secret :" };
        static List<string> enterNumberPartsSecret = new List<string>() { "������� ���������� ������ ������� :", "Enter the number of parts of the secret :" };
        static List<string> enterMinimumRequiredNumberPartsSecretRecover = new List<string>() { "������� ���������� ����������� ���-�� ������ ������� ��� �������������� :", "Enter the minimum required number of parts of secret to recover :" };
        static List<string> result = new List<string>() { "��������� :", "Result :" };
        static List<string> recoverSecret = new List<string>() { "������������ ������", "Recover secret" };
        static List<string> enterNthSecret = new List<string>() { "������� n-�� ������:", "Enter the nth secret :" };

        public static List<string> errorNonNumber = new List<string>() { "�� �����", "Not a number" };
        public static List<string> errorFormat = new List<string>() { "������������ ������ �����", "Incorrect input format" };
        public static List<string> errors = new List<string>() { "���� ������, �������� �� ��� ���������", "There were mistakes, the wrong result is possible" };
        public static List<string> errorCalculate = new List<string>() { "����� ��������� ��������� �� �����", "The program cannot calculate this" };
        public static List<string> errorLoadLanguage = new List<string>() { "������ � ���������� ����� � �������� �����", "Error in the number of lines in the language file" };

        public static List<string> version = new List<string>() { "������:", "Version:" };
        public static List<string> developers = new List<string>() { "������������:", "Developers:" };

        public static List<string> supportService = new List<string>() { "������ ���������", "Support service" };

        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nlanguage = 0;
        }

        private void ����������ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Nlanguage = 1;
        }
    }
}
