using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorCompras;

namespace CapaVistaCompras
{
    public partial class ayudaproveedor : Form
    {
        csControlador cn = new csControlador();
        string table, ttipo;

        private void ayudaproveedor_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(table, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {


                cn.IDS = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                this.Close();


            }
        }

        public ayudaproveedor(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

    }
}
