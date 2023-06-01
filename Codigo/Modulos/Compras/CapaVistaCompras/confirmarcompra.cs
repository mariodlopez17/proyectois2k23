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
    public partial class confirmarcompra : Form
    {
        csControlador cn = new csControlador();
        public confirmarcompra()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextBox[] llenar = {textBox24, txt_almacen, txt_proveedor, txt_fcreacion, textBox21, txt_fentrega,
                txt_tipopago, textBox4};
            cn.bloqueartextbox(llenar);
            button7.Enabled = false;
            button9.Enabled = false;
            button14.Enabled = false;
            button5.Enabled = false;

            cn.insertardatagridcompra(dataGridView1, textBox7.Text, textBox8.Text, textBox6.Text,
                textBox1.Text, textBox2.Text, textBox9.Text, txt_total, textBox10, groupBox2);
            textBox19.Text = txt_total.Text;

           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ayudaproductos a = new ayudaproductos("tbl_producto", "pk_codigo_producto");


            if (cn.IDS == null && textBox33.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox33.Text = cn.IDS;
                cn.IDS = null;
            }
            textBox11.Text = textBox37.Text;
            textBox12.Text = textBox30.Text;
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.TextLength > 0)
            {
                TextBox[] llenar = {textBox33, textBox34, textBox31, textBox32, textBox30,
                textBox29, textBox28, textBox27, textBox26, textBox35, textBox36, textBox37 };
                cn.llenartxt("tbl_producto", llenar);
            }
            textBox1.Text = textBox33.Text;
            textBox9.Text = textBox29.Text;
            textBox44.Text = textBox33.Text;
            textBox15.Text = textBox33.Text;

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox24.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                //bloquear botones
                TextBox[] llenar = {textBox24, txt_almacen, txt_proveedor, txt_fcreacion, textBox21, txt_fentrega,
                txt_tipopago, textBox4};
                cn.desbloqueartextbox(llenar);
                button7.Enabled = true;
                button9.Enabled = true;
                button14.Enabled = true;
                button5.Enabled = true;



                //boton agregar compra
                string[] datos = { textBox24.Text, txt_almacen.Text, txt_proveedor.Text, txt_fcreacion.Text, textBox21.Text, txt_fentrega.Text,
                txt_total.Text, txt_tipopago.Text , textBox4.Text, txt_estatus.Text};
                string[] tipos = { "pk_id_compra", "fk_codigo_almacen", "fk_id_proveedor", "fecha_creacion_compra",
                "prioridad_compra", "fecha_entrega_compra", "total_compra", "fk_id_tipoPago",
                "tipo_compra", "estatus_compra"};
                cn.ingresar(tipos, datos, "tbl_compra");

                //Agregar registro de tabla a detalle orden de compra
                cn.insertarbddetallecompra(dataGridView1);

                //modificar tabla producto

                //Agregar a la tabla almacen

                //****************
                TextBox[] textbox = { txt_almacen, txt_proveedor, txt_fcreacion, txt_fentrega, txt_total, txt_estatus, txt_tipopago };
                cn.ingresarfacturabd(textbox);


                //Limpiar tabla
                dataGridView1.Rows.Clear();
            }
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox14.Text = txt_almacen.Text;
            textBox43.Text = txt_almacen.Text;
            textBox8.Text = txt_almacen.Text;
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            textBox13.Text = textBox30.Text;
            textBox41.Text = textBox30.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ayudacompra a = new ayudacompra("tbl_compra", "pk_id_compra");
            if (cn.IDS == null && textBox24.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox24.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ayudacodigoalmacen a = new ayudacodigoalmacen("tbl_almacen", "pk_codigo_almacen");
            if (cn.IDS == null && txt_almacen.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                txt_almacen.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ayudaproveedor a = new ayudaproveedor("tbl_proveedor", "pk_id_proveedor");
            if (cn.IDS == null && txt_proveedor.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                txt_proveedor.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ayudacodigoalmacen a = new ayudacodigoalmacen("tbl_almacen", "pk_codigo_almacen");
            if (cn.IDS == null && textBox8.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox8.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ayudadetallecompra a = new ayudadetallecompra("tbl_detalle_compra", "pk_id_detalle_compra");
            if (cn.IDS == null && textBox7.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox7.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.eliminarfilagrid(dataGridView1, txt_total, textBox10, groupBox2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            GroupBox[] groupBoxes = { groupBox3, groupBox2 };
            cn.limpiardetallee(groupBoxes);
            dataGridView1.Rows.Clear();
            txt_total.Clear();
            textBox10.Clear();

            TextBox[] llenar = {textBox24, txt_almacen, txt_proveedor, txt_fcreacion, textBox21, txt_fentrega,
                txt_tipopago, textBox4};
            cn.desbloqueartextbox(llenar);
            button7.Enabled = true;
            button9.Enabled = true;
            button14.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayuda/Modulos/Compras/AyudaRisko/Ayudacompras.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "Compra.html");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ayudatipopago a = new ayudatipopago("tbl_tipopago", "pk_id_tipopago");
            if (cn.IDS == null && txt_tipopago.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                txt_tipopago.Text = cn.IDS;
                cn.IDS = null;
            }
        }
    }
}
