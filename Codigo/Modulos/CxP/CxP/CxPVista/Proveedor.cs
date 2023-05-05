using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class Proveedor : Form
    {

        public Proveedor()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5002";
            TextBox[] Grupotextbox = { txtid,txtnombre,txtdireccion,txttelefono,txtcorreo,
            txtrubro,txtsaldoanterior, txtsaldoactual, txtcargo, txtabono, txtcargoacum, txtabonoacum, txtestado};
            TextBox[] Idtextbox = { txtid, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "CxP");
        }

        private void Proveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
