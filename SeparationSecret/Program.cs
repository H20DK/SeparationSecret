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

            // ��������� ������ �����, �� �� ����������� � ��� ��������� ���� ����������
            AutForm AutForm = new AutForm();
            AutForm.Show();

            // ��������� ���� ���������� ��� �������� � ���������� �����
            Application.Run();
        }
    }
}