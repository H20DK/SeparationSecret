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
        public History(string v, string d)
        {
            InitializeComponent();
            Program.RegisterForm(this); // Регистрируем форму

            label4.Text = v;
            label3.Text = d;
        }

        private void History_Load(object sender, EventArgs e)
        {

        }
    }
}
