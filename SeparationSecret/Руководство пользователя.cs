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
        public users_guide()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Руководство_пользователя_Load(object sender, EventArgs e)
        {
            ClientSize = new System.Drawing.Size(700, 200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
