using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaInventario
{
    public partial class mantenimiento_producto : Form
    {
        public mantenimiento_producto()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6001";
            TextBox[] Grupotextbox = { textBox1, textBox2, textBox3, textBox6, textBox5, textBox4,textBox9
            , textBox8, textBox7, textBox10, textBox11, textBox12 };
            TextBox[] Idtextbox = { textBox1, textBox2 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");


        }
    }
}
