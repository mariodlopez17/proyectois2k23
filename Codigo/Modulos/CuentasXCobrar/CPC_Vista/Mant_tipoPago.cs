using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Vista
{
    public partial class Mant_tipoPago : Form
    {
        public Mant_tipoPago()
        {
            InitializeComponent();
        }
        
        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4002";
            TextBox[] Grupotextbox = { txt_id, txt_nombre, txt_estado };
            TextBox[] Idtextbox = { txt_id, txt_nombre, txt_estado };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_tipopago;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_tipopago, Grupotextbox, "colchoneria");
        }
    }
}
