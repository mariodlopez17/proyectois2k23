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
    public partial class Mant_moneda : Form
    {
        public Mant_moneda()
        {
            InitializeComponent();
        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4002";
            TextBox[] Grupotextbox = { txt_id, txt_nombre, txt_simbolo, txt_cambio,txt_estado };
            TextBox[] Idtextbox = { txt_id, txt_nombre, txt_simbolo, txt_cambio, txt_estado };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_Moneda;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_Moneda, Grupotextbox, "colchoneria");
        }
    }
}
