using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPVista
{
    public partial class Moneda : Form
    {
        public Moneda()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      
        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5002";
            TextBox[] Grupotextbox = { txtid,txtnombre,txtabreviatura,txtcambio,txtestado};
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }
    }
}
