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
    public partial class Mant_conceptoCXC : Form
    {
        public Mant_conceptoCXC()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4003";
            TextBox[] Grupotextbox = { txt_id, txt_descripcion, txt_concepto, txt_estado };
            TextBox[] Idtextbox = { txt_id, txt_descripcion, txt_concepto, txt_estado };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_Concepto;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_Concepto, Grupotextbox, "colchoneria");
        }
    }
}
