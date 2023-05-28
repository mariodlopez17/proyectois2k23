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
    public partial class CPC_MDI : Form
    {
        public CPC_MDI()
        {
            InitializeComponent();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_moneda mant_Moneda = new Mant_moneda();
            mant_Moneda.MdiParent = this;
            mant_Moneda.Show();
        }

        private void tipoDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_tipoPago mant_TipoPago = new Mant_tipoPago();
            mant_TipoPago.MdiParent = this;
            mant_TipoPago.Show();
        }

        private void morasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_moras mant_Moras = new Mant_moras();
            mant_Moras.MdiParent = this;
            mant_Moras.Show();
        }

        private void conceptoCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mant_conceptoCXC man_ConceptoCXC = new Mant_conceptoCXC();
            man_ConceptoCXC.MdiParent = this;
            man_ConceptoCXC.Show();
        }

        private void cobroDeDeudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pcs_CobroCuenta cobroCuenta = new Pcs_CobroCuenta();
            cobroCuenta.MdiParent = this;
            cobroCuenta.Show();
        }

        private void reporteDeEstadoDeCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();
            controlador.displayReporte("4201");
        }

        private void reporteDeEstadoDeCuentaCardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();
            controlador.displayReporte("4202");
        }

        private void cierreCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado_Cuenta estado = new Estado_Cuenta();
            estado.MdiParent = this;
            estado.Show();           
        }

        private void ventaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Pcs_venta venta = new Pcs_venta();
            venta.MdiParent = this;
            venta.Show();
        }
    }
}
