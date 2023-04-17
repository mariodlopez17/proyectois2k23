using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCompras
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void realizarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "ordencompra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                ordencompra rep = new ordencompra();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void detalleOrdenCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "detalleordencompra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                detalleordencompra rep = new detalleordencompra();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void devolucionCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "devolucioncompra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                devolucioncompra rep = new devolucioncompra();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void confirmarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "confirmarcompra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                confirmarcompra rep = new confirmarcompra();
                rep.MdiParent = this;
                rep.Show();
            }
        }

        private void detalleFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "detallefactura")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                detallefactura rep = new detallefactura();
                rep.MdiParent = this;
                rep.Show();
            }
        }
    }
}
