using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCompras
{
    public partial class mantenimiento_factura : Form
    {
        public mantenimiento_factura()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "3003";
            TextBox[] Grupotextbox = { textBox8, textBox7, textBox1, textBox6 };
            TextBox[] Idtextbox = { textBox8, textBox7 };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "colchoneria");
        }
    }
}
