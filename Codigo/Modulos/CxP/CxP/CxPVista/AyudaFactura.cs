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
        public AyudaFactura()
        {
            InitializeComponent();
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
    }
}
