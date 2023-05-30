using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CxPControlador;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPVista
{
    public partial class AyudaFactura : Form
    {
        JControlador cn = new JControlador();

        string table;
        public TextBox txtIdProveedor, txtIdAlmacen;
       // public AyudaFactura( string tabla, TextBox txtIdAlmacen, TextBox txtIdProveedor)
        public AyudaFactura(string tabla, TextBox txtIdAlmacen, TextBox txtIdProveedor)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdAlmacen = txtIdAlmacen;
            this.txtIdProveedor = txtIdProveedor;

        }
        public DataGridView tabla;

        private void tabPage1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabla = dgvAlmacen;
            cn.fillTableAlmacen(tabla.Tag.ToString(), dgvAlmacen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabla = dgvProveedor;
            cn.fillTableProveedor(tabla.Tag.ToString(), dgvProveedor);

        }

        private void dgvAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AyudaFactura_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dgvAlmacen.CurrentCell != null)
            {


                string[] datos = cn.llenartablaAlmacen2(dgvAlmacen.CurrentRow.Cells[0].Value.ToString());
         

                txtIdAlmacen.Text = datos[0];
            
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.CurrentCell != null)
            {


                string[] datos = cn.llenartablaProveedor2(dgvProveedor.CurrentRow.Cells[0].Value.ToString());


                txtIdProveedor.Text = datos[0];

                this.Close();
            }
        }
    }
}
