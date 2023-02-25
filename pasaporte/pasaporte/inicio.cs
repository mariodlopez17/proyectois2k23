using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasaporte
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu rep = new menu();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminlogin rep = new adminlogin();
            rep.Show();
        }
    }
}
