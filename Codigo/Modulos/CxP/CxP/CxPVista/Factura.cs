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
            AyudaFactura ayudafactura = new AyudaFactura("tbl_factura", txtIdAlmacen, txtIdProveedor);
            ayudafactura.ShowDialog();
            //Ocultar submenu
            //hideSubMenu();
        }

        public void actualizardataview() {
            tabla = dgvFactura;
            cn.fillTableFactura(tabla.Tag.ToString(), dgvFactura);
        }

        public void habilitarTextBox() {
            txtIdAlmacen.Enabled = false;
            txtIdProveedor.Enabled = false;
            txtEstatus.Enabled = true;
            txtfecha.Enabled = true;
            txtEstatus.Enabled = false;
            txtTotalFactura.Enabled = true;
            dtpEmisionFactura.Enabled = true;
            dtpVencimientoFactura.Enabled = true;
            cb_estado.Enabled = true;
            btnAyudaFactura.Enabled = true;
            btnSave.Enabled = true;
        }

        public void limpiezaTextBox() {
            TextBox[] textBoxes = { txtIdAlmacen, txtIdProveedor, txtTotalFactura, txtEstatus, txtfecha };
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
            cb_estado.Items.Add("0) Inactivo");
            cb_estado.Items.Add("1) Activo");
            
            cn.inicio(txtid, btnAyudaFactura, dtpEmisionFactura,dtpVencimientoFactura, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtVencimiento ,txtTotalFactura);
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
                dtpEmisionFactura.Text = dgvFactura.CurrentRow.Cells[3].Value.ToString();
                txtVencimiento.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
                dtpVencimientoFactura.Text = dgvFactura.CurrentRow.Cells[4].Value.ToString();
                //dtpEmisionFactura.Text = dgvFactura.CurrentRow.Cells[1].Value.ToString();
                txtTotalFactura.Text = dgvFactura.CurrentRow.Cells[5].Value.ToString();
                txtEstatus.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
                cb_estado.Text = dgvFactura.CurrentRow.Cells[6].Value.ToString();
                btnSave.Enabled = false;
            }
            catch { 
            
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox[] Grupo = { txtid, txtIdAlmacen, txtIdProveedor, txtTotalFactura, txtEstatus, txtfecha, txtVencimiento };
                txtfecha.Text = dtpEmisionFactura.Value.ToString("yyyy-MM-dd");
                txtVencimiento.Text = dtpVencimientoFactura.Value.ToString("yyyy-MM-dd");

                bool valido = validacionllenado(Grupo);
                if(valido == true)
                {
                   
                    cn.ingresar(Grupo, dgvFactura);
                    //cn.ingresarcxp(Grupo);
                    actualizardataview();
                    limpiezaTextBox();
                    cn.inicio(txtid, btnAyudaFactura, dtpEmisionFactura, dtpVencimientoFactura, txtIdAlmacen, txtIdProveedor, txtEstatus, txtfecha, txtVencimiento, txtTotalFactura);
                }
                else
                {
                    MessageBox.Show("Por Favor llenar todos los campos");
                }

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
            TextBox[] Grupo = { txtid, txtIdAlmacen, txtIdProveedor, txtTotalFactura };
            bool valido = validacionllenado(Grupo);
            if (valido == true)
            {
               
                cn.delete(Grupo, dgvFactura);
                actualizardataview();
                limpiezaTextBox();
            }
            else
            {
                MessageBox.Show("Por Favor llenar todos los campos");
            }

            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start("CxPVista/bin/Debug/AyudaFactura/AyudaFactura.chm");

                string rutaAyuda = "../../../../../../../Ayuda/Modulos/CxP/AyudaFactura/AyudaFactura.chm";
                Help.ShowHelp(ParentForm, rutaAyuda, "Factura.html");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtEstatus.Text = cb_estado.SelectedItem.ToString();
            if (cb_estado.SelectedIndex == 0)
            {
                txtEstatus.Text = "0";
            }
            else if (cb_estado.SelectedIndex == 1)
            {
                txtEstatus.Text = "1";
            }
        }

        bool validacionllenado(TextBox[] textBoxes)
        {
            bool validacion = false;

            for (int x = 0; x < textBoxes.Length; x++)
            {
                if (textBoxes[x].TextLength == 0)
                {
                    validacion = false;
                    break;
                }
                else
                {
                    validacion = true;
                }
            }
            return validacion;
        }
    }
}
