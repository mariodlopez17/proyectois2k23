using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaInventario
{
    public partial class menu_inventario : Form
    {
        public menu_inventario()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_producto")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_producto rep = new mantenimiento_producto();
                rep.MdiParent = this;
                rep.Show();
            
            }
            
        }

        private void mantenimientoLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
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
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
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
        }

        private void mantenimientoAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool abierto = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "mantenimiento_almacen")
                {
                    abierto = true;
                    f.Focus();
                    break;
                }
            }
            if (abierto == false)
            {
                mantenimiento_almacen rep = new mantenimiento_almacen();
                rep.MdiParent = this;
                rep.Show();

            }
        }
    }
}
