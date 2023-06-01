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
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "productoscompras")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                productoscompras rep = new productoscompras();
                rep.MdiParent = this;
                rep.Show();
            }
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_compra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_compra rep = new mantenimiento_compra();
                rep.MdiParent = this;
                rep.Show();
            }
           */
        }

        private void ordenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_ordencompra")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_ordencompra rep = new mantenimiento_ordencompra();
                rep.MdiParent = this;
                rep.Show();
            }
            */
        }

        private void facturaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_factura")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_factura rep = new mantenimiento_factura();
                rep.MdiParent = this;
                rep.Show();
            }
            */
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_marca")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_marca rep = new mantenimiento_marca();
                rep.MdiParent = this;
                rep.Show();
            }
            */
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_linea")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_linea rep = new mantenimiento_linea();
                rep.MdiParent = this;
                rep.Show();
            }
            */
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_proveedor")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_proveedor rep = new mantenimiento_proveedor();
                rep.MdiParent = this;
                rep.Show();
            }
            

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ayudaMantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayuda/Modulos/Compras/AyudaRisko/Ayudacompras.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "MantenimientoProv.html");
        }
    }
}
