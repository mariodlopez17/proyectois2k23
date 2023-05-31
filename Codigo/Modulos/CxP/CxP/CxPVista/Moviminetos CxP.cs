using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class Moviminetos_CxP : Form
    {
        GControlador cn = new GControlador();
        string table2;
        public Moviminetos_CxP()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }

        private void Moviminetos_CxP_Load(object sender, EventArgs e)
        {
            this.dtpEmision.Visible = false;
            porDefecto.Text = "00/00/0000";
            porDefecto.Visible = true;
            TextBox[] Grupo = { txtMovimiento, txtNombreTipo, txtMovimiento, txtMoneda, txtIdCuenta, txtIdAlmacen, txtIdProveedor, txtIdFatura, txtIdTipo, txtIdMoneda, txtIdConcepto, txtCambio, txtEmision, txtMovimiento, txtSaldo, txtMonto, txtEstado };
            cn.Inicio(txtIdCuenta, txtMovimiento,Grupo, cmbEstado);
        }

        private void btnTipoPago_Click(object sender, EventArgs e)
        {
            AyudaTipoPago ayudaPago = new AyudaTipoPago("tbl_tipopago", txtIdTipo,txtNombreTipo);
            ayudaPago.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AyudaMoneda ayudaMoneda = new AyudaMoneda("tbl_moneda", txtIdMoneda, txtMoneda,txtCambio);
            ayudaMoneda.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AyudaConcepto ayudaConcepto = new AyudaConcepto("tbl_conceptocuentaporpagar", txtIdConcepto, txtConcepto, txtTipoConcepto);
            ayudaConcepto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AyudaFactura2 ayudaFactura = new AyudaFactura2("tbl_factura", txtIdFatura, txtIdAlmacen, txtSaldo,txtIdProveedor,txtEmision,txtIdCuenta,txtMonto,dtpEmision,porDefecto);
            ayudaFactura.Show();
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            string valorSeleccionado = cmbEstado.SelectedItem.ToString();
            char primerCaracter = valorSeleccionado[0];
            txtEstado.Text = primerCaracter.ToString();

            TextBox[] Grupo = { txtIdCuenta, txtIdAlmacen, txtIdProveedor, txtIdFatura, txtIdTipo, txtIdMoneda, txtIdConcepto, txtCambio, txtEmision, txtMovimiento, txtSaldo, txtMonto, txtEstado};
            Double Monto = Convert.ToDouble(txtMonto.Text) ;
            cn.operacionCxP(Grupo, "tbl_cuentaporpagar",Monto,txtIdProveedor.Text,txtIdConcepto.Text );

            TextBox[] Grupo2 = { txtMovimiento,txtMoneda,txtNombreTipo,txtMovimiento,txtConcepto,txtTipoConcepto,txtNombreTipo,txtMovimiento,txtMoneda, txtIdCuenta, txtIdAlmacen, txtIdProveedor, txtIdFatura, txtIdTipo, txtIdMoneda, txtIdConcepto, txtCambio, txtEmision, txtMovimiento, txtSaldo, txtMonto, txtEstado };
            cn.Inicio(txtIdCuenta,txtMovimiento,Grupo2, cmbEstado);
            dtpEmision.Visible = false;
            porDefecto.Visible = true;

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            TextBox[] Grupo = {txtMovimiento,txtMoneda,txtNombreTipo,txtMovimiento,txtConcepto,txtTipoConcepto,txtNombreTipo,txtMovimiento,txtMoneda, txtIdCuenta, txtIdAlmacen, txtIdProveedor, txtIdFatura, txtIdTipo, txtIdMoneda, txtIdConcepto, txtCambio, txtEmision, txtMovimiento, txtSaldo, txtMonto, txtEstado };
            cn.Inicio(txtIdCuenta, txtMovimiento,Grupo,cmbEstado);
            porDefecto.Visible = true;
            dtpEmision.Visible = false;
            
        }

        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayuda/Modulos/CxP/MovimientosCxP/AyudaCxP.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "CuentasPorPagar.html");
        }
    }
}
