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
    public partial class AyudaMoneda : Form
    {
        GControlador cn = new GControlador();
        string table;
        TextBox txtIdMoneda, txtMoneda, txtCambio;
        private void AyudaMoneda_Load(object sender, EventArgs e)
        {
            cn.llenartablaa2(table, Dgv_ayudaMoneda);
        }
        public AyudaMoneda(string tabla,TextBox txtIdMoneda, TextBox txtMoneda, TextBox txtCambio)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdMoneda = txtIdMoneda;
            this.txtMoneda = txtMoneda;
            this.txtCambio = txtCambio;
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudaMoneda.CurrentCell != null)
            {
                txtIdMoneda.Text  = Dgv_ayudaMoneda.CurrentRow.Cells[0].Value.ToString();
                txtMoneda.Text = Dgv_ayudaMoneda.CurrentRow.Cells[1].Value.ToString();
                txtCambio.Text = Dgv_ayudaMoneda.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
        }
    }
}
