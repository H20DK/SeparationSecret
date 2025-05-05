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
    public partial class about_the_program : Form
    {
        public about_the_program(string v, string d)
        {
            InitializeComponent();
            Program.RegisterForm(this); // Регистрируем форму

            label4.Text = v;
            label3.Text = d;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void О_программе_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(400, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
