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
    public partial class AyudaConcepto : Form
    {
        GControlador cn = new GControlador();
        string table;
        TextBox txtIdConcepto, txtConcepto, txtTipoConcepto;
        public AyudaConcepto(string tabla, TextBox txtIdConcepto, TextBox txtConcepto, TextBox txtTipoConcepto)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdConcepto = txtIdConcepto;
            this.txtConcepto = txtConcepto;
            this.txtTipoConcepto = txtTipoConcepto;
        }

        private void AyudaConcepto_Load(object sender, EventArgs e)
        {
            cn.llenartablaa2(table, Dgv_ayudaConcepto);
        }

        private void btninsertar_Click(object sender, EventArgs e)
        {
            if (Dgv_ayudaConcepto.CurrentCell != null)
            {
                txtIdConcepto.Text = Dgv_ayudaConcepto.CurrentRow.Cells[0].Value.ToString();
                txtConcepto.Text = Dgv_ayudaConcepto.CurrentRow.Cells[1].Value.ToString();
                txtTipoConcepto.Text = Dgv_ayudaConcepto.CurrentRow.Cells[3].Value.ToString();
                this.Close();
            }
        }
    }
}
