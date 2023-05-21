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
    public partial class AyudaFactura2 : Form
    {
        GControlador cn = new GControlador();
        string table;
        public TextBox txtIdFactura, txtIdAlmacen, txtSaldo, txtIdProveedor,txtIdCuenta,txtMonto,txtEmision;
      
        public AyudaFactura2(string tabla, TextBox txtIdFactura, TextBox txtIdAlmacen, TextBox txtSaldo, TextBox txtIdProveedor, TextBox txtEmision, TextBox txtIdCuenta, TextBox txtMonto)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdFactura = txtIdFactura;
            this.txtIdAlmacen = txtIdAlmacen;
            this.txtSaldo = txtSaldo;
            this.txtIdProveedor = txtIdProveedor;
            this.txtIdCuenta = txtIdCuenta;
            this.txtMonto = txtMonto;
            this.txtEmision = txtEmision;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudaFactura.CurrentCell != null)
            {
                
                
                string[] datos = cn.llenartabla3(Dgv_ayudaFactura.CurrentRow.Cells[0].Value.ToString(), Dgv_ayudaFactura.CurrentRow.Cells[2].Value.ToString(), Dgv_ayudaFactura.CurrentRow.Cells[1].Value.ToString());
                double[] montos = { Convert.ToDouble(datos[5]),Convert.ToDouble(datos[6])};
                double nuevoSaldo = cn.operacionConcepto(montos, Dgv_ayudaFactura.CurrentRow.Cells[0].Value.ToString(), Dgv_ayudaFactura.CurrentRow.Cells[1].Value.ToString(), Dgv_ayudaFactura.CurrentRow.Cells[2].Value.ToString());
                txtIdAlmacen.Text = datos[1];
                txtIdProveedor.Text = datos[2];
                txtIdFactura.Text = datos[3];
                txtEmision.Text = datos[4];
                txtSaldo.Text = nuevoSaldo.ToString(); //(Convert.ToDouble(datos[5])- Convert.ToDouble(datos[6])).ToString();
                //txtMonto.Text = datos[6];
                cn.IDS = Convert.ToDouble(datos[6]);
                this.Close();
            }
        }

        private void AyudaFactura_Load(object sender, EventArgs e)
        {
            cn.llenartablaa2(table, Dgv_ayudaFactura);
        }
    }
}
