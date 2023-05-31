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
    public partial class TipoPago : Form
    {
        public TipoPago()
        {
            InitializeComponent();
        }

        private void TipoPago_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "5003";
            TextBox[] Grupotextbox = { txtId, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { txtId, txtDescripcion };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "sig");
        }
    }
}
