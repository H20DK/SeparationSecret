using SecretSharing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeparationSecret
{
    public partial class users_guide : Form
    {
        public users_guide(string user_manual, string feedback)
        {
            InitializeComponent();
            Program.RegisterForm(this); // Регистрируем форму

            label1.Text = user_manual;
            label2.Text = feedback;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Руководство_пользователя_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(700, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Открываем URL в браузере по умолчанию
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkLabel1.Text,
                    UseShellExecute = true
                });
                // Устанавливаем ссылку как "посещенную" (меняет цвет, если настроено)
                linkLabel1.LinkVisited = true;
            }
            catch
            {

            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // Открываем URL в браузере по умолчанию
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = linkLabel2.Text,
                    UseShellExecute = true
                });
                // Устанавливаем ссылку как "посещенную" (меняет цвет, если настроено)
                linkLabel1.LinkVisited = true;
            }
            catch
            {

            }
        }
    }
}
