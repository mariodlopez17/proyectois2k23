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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crear_cita rep = new crear_cita();
            rep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ver_cita rep = new ver_cita();
            rep.Show();
        }
    }
}
