using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class Balance : Form
    {
        TControlador controlador = new TControlador();
        public Balance()
        {
            InitializeComponent();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            controlador.llenardatosproveedor("tbl_proveedor", DgvProveedor);
        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            controlador.llenardatosproveedorfiltro("tbl_proveedor", DgvProveedor, "pk_id_proveedor", txtProveedor.Text);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            controlador.llenardatosproveedorfiltro("tbl_proveedor", DgvProveedor, "pk_id_proveedor", txtProveedor.Text);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            controlador.balance(DgvProveedor);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            string rutaAyuda = "../../../../../../../Ayuda/Modulos/CxP/Balance/ayudaBalance.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "Balance.html");
        }
    }
}
