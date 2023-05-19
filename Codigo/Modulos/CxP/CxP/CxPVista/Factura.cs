using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CxPControlador;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CxPVista
{
    public partial class Factura : Form
    {

        string emp = "tblFactura";

        JControlador cn = new JControlador();
        public Factura()
        {
            InitializeComponent();
        }

        public DataGridView tabla;
        public TextBox[] textboxi = { };

        /* public void actualizardatagriew()
         {
             //le pasamos el parametro de la tabla a consultar
             DataTable dt = cn.llenarTbl(emp);
             dgvFactura.DataSource = dt;

         }*/

        private void button1_Click(object sender, EventArgs e)
        {
            //Codigo
            AyudaFactura ayudafactura = new AyudaFactura();
            ayudafactura.Show();
            //Ocultar submenu
            //hideSubMenu();
        }

        public void actualizardataview() {
            tabla = dgvFactura;
            cn.fillTableFactura(tabla.Tag.ToString(), dgvFactura);
        }

        public void habilitarTextBox() {
            txtIdAlmacen.Enabled = true;
            txtIdProveedor.Enabled = true;
            txtEstatus.Enabled = true;
            txtfecha.Enabled = true;
            txtEstatus.Enabled = true;
            txtTotalFactura.Enabled = true;
            dtpEmisionFactura.Enabled = true;
        }

        public void limpiezaTextBox() {
            TextBox[] textBoxes = { txtid, txtIdAlmacen, txtIdProveedor, txtTotalFactura, txtEstatus, txtfecha };
            cn.limpiarTextbox(textBoxes);
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

            habilitarTextBox();
            //cn.inicio(txtid, dtpEmisionFactura, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtTotalFactura);

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*tabla = dgvFactura;
            cn.fillTableFactura(tabla.Tag.ToString(), dgvFactura);*/
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            cn.inicio(txtid, dtpEmisionFactura, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtTotalFactura);
            actualizardataview();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            /*txtid.Text = "";
            txtIdAlmacen.Text = "";
            txtIdProveedor.Text = "";
            txtTotalFactura.Text = "";
            txtEstatus.Text = "";
            txtfecha.Text = "";*/
            limpiezaTextBox();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtid.Text = dgvFactura.CurrentRow.Cells[0].Value.ToString();
                txtIdAlmacen.Text = dgvFactura.CurrentRow.Cells[1].Value.ToString();
                txtIdProveedor.Text = dgvFactura.CurrentRow.Cells[2].Value.ToString();
                txtfecha.Text = dgvFactura.CurrentRow.Cells[3].Value.ToString();
                //dtpEmisionFactura.Text = dgvFactura.CurrentRow.Cells[1].Value.ToString();
                txtTotalFactura.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
                txtEstatus.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
            }
            catch { 
            
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                txtfecha.Text = dtpEmisionFactura.Value.ToString("yyyy-MM-dd");
                TextBox[] Grupo = { txtid, txtIdAlmacen, txtIdProveedor, txtTotalFactura, txtEstatus, txtfecha };
                cn.ingresar(Grupo, dgvFactura);
                //cn.ingresarcxp(Grupo);
                actualizardataview();
                limpiezaTextBox();
                cn.inicio(txtid, dtpEmisionFactura, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtTotalFactura);
            }
            catch (Exception es)
            {
                MessageBox.Show("Error:" + es);
            }


        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            TextBox[] Grupo = { txtid, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtTotalFactura };
            cn.delete(Grupo, dgvFactura);
            actualizardataview();
            limpiezaTextBox();
        }
    }
}
