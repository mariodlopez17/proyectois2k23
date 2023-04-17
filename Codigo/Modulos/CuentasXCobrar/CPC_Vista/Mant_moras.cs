using System;
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
    public partial class Mant_moras : Form
    {
        public Mant_moras()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "6005";
            TextBox[] Grupotextbox = { txt_id, txt_nombre, txtMonto };
            TextBox[] Idtextbox = { txt_id, txt_nombre, txtMonto };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_moras;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_moras, Grupotextbox, "colchoneria");
        }
    }
}
