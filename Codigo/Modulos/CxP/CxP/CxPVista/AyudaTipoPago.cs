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
    public partial class AyudaTipoPago : Form
    {
        GControlador cn = new GControlador();
        string table;
        TextBox txtIdTipo, txtNombreTipo;
        public AyudaTipoPago(string tabla, TextBox txtIdTipo, TextBox txtNombreTipo)
        {
            InitializeComponent();
            table = tabla;
            this.txtIdTipo = txtIdTipo;
            this.txtNombreTipo = txtNombreTipo;
        }

        private void Txt_codigo_TextChanged(object sender, EventArgs e)
        {
            //cn.llenarfiltro(table, Dgv_ayudaTipo, ttipo, Txt_codigo.Text);

        }
        private void btninsertar_Click(object sender, EventArgs e)
        {
            if(Dgv_ayudaTipo.CurrentCell != null)
            {
                txtIdTipo.Text  = Dgv_ayudaTipo.CurrentRow.Cells[0].Value.ToString();
                txtNombreTipo.Text = Dgv_ayudaTipo.CurrentRow.Cells[1].Value.ToString();
                this.Close();
            }
        }
        private void AyudaTipoPago_Load(object sender, EventArgs e)
        {
            cn.llenartablaa2(table, Dgv_ayudaTipo);
        }
    }
}
