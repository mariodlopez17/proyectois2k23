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
    public partial class detalleordencompra : Form
    {
        csControlador cn = new csControlador();
        public detalleordencompra()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton agregar
            string[] datos = { textBox7.Text, textBox8.Text, textBox5.Text, textBox6.Text, textBox1.Text, textBox2.Text };
            string[] tipos = { "pk_id_detalle_orden_compra", "fk_codigo_almacen", "fk_id_orden_compra", "fk_id_listado_productos",
                "cantidad_detalle_orden_compra", "costo_unitario" };
            cn.ingresar(tipos, datos, "tbl_detalle_orden_compra");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string[] datos = { textBox15.Text, textBox12.Text, textBox13.Text, textBox11.Text, textBox10.Text, textBox4.Text,
                textBox3.Text, textBox9.Text };
            string[] tipos = { "fk_codigo_almacen", "fk_id_proveedor", "fecha_creacion_orden_compra",
                "prioridad_orden_compra", "fecha_ini_orden_compra", "fecha_entre_orden_compra", "total_orden_compra",
                "estatus_orden_compra" };
            cn.actualizar(tipos, datos, "tbl_orden_compra", textBox14);
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                double n1, n2, ns, r, ns2, r2;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                ns = Convert.ToDouble(textBox16.Text);
                ns2 = Convert.ToDouble(textBox38.Text);

                r = ns + (n1 * n2);
                r2 = ns2 + n1; ;
                textBox3.Text = r.ToString();
                textBox37.Text = r2.ToString();

            }
            catch
            {

            }
            */
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*try
            {
                double n1, n2, ns, r, ns2,r2;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                ns = Convert.ToDouble(textBox16.Text);
                ns2 = Convert.ToDouble(textBox38.Text);

                r = ns + (n1 * n2);
                r2 = ns2 + n1; ;
                textBox3.Text = r.ToString();
                textBox37.Text = r2.ToString();

            }
            catch
            {

            }
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.TextLength >0)
            {
                TextBox[] llenar = {textBox14, textBox15, textBox12, textBox13, textBox11,
                textBox10, textBox4, textBox3, textBox9};
                cn.llenartxt("tbl_orden_compra", llenar);
            }
            textBox5.Text = textBox14.Text;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TextBox[] llenar = {textBox14, textBox15, textBox12, textBox13, textBox11,
                textBox10, textBox4, textBox3, textBox9};
            cn.vaciartextbox(llenar);
        }

        private void detalleordencompra_Load(object sender, EventArgs e)
        {
            TextBox[] llenar = {textBox14, textBox15, textBox12, textBox13, textBox11,
                textBox10, textBox4, textBox3, textBox9};
            cn.bloqueartextbox(llenar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayudaordencompra a = new ayudaordencompra("tbl_orden_compra", "pk_id_orden_compra");


            if (cn.IDS == null && textBox14.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox14.Text = cn.IDS;
                cn.IDS = null;
            }
            
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            
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
            textBox38.Text = textBox37.Text;
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

        private void button9_Click(object sender, EventArgs e)
        {
            ayudaproveedor a = new ayudaproveedor("tbl_proveedor", "pk_id_proveedor");


            if (cn.IDS == null && textBox22.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox22.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            ayudacodigoalmacen a = new ayudacodigoalmacen("tbl_almacen", "pk_codigo_almacen");


            if (cn.IDS == null && textBox25.Text.Length == 0)
            {
                cn.IDS = null;
                a.Show();
            }
            else
            {
                textBox25.Text = cn.IDS;
                cn.IDS = null;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //boton agregar
            string[] datos = { textBox24.Text, textBox25.Text, textBox22.Text, textBox23.Text, textBox21.Text, textBox20.Text,
                textBox19.Text, textBox18.Text, textBox17.Text };
            string[] tipos = { "pk_id_orden_compra", "fk_codigo_almacen", "fk_id_proveedor", "fecha_creacion_orden_compra",
                "prioridad_orden_compra", "fecha_ini_orden_compra", "fecha_entre_orden_compra", "total_orden_compra",
                "estatus_orden_compra" };
            cn.ingresar(tipos, datos, "tbl_orden_compra");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
            

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.TextLength > 0)
            {
                TextBox[] llenar = {textBox33, textBox34, textBox31, textBox32, textBox30,
                textBox29, textBox28, textBox27, textBox26, textBox35, textBox36, textBox37 };
                cn.llenartxt("tbl_producto", llenar);
            }
            textBox6.Text = textBox33.Text;
            textBox2.Text = textBox29.Text;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string[] datos = { textBox34.Text, textBox31.Text, textBox32.Text, textBox30.Text,
                textBox29.Text, textBox28.Text, textBox27.Text, textBox26.Text, textBox35.Text, textBox36.Text,
                textBox37.Text };
            string[] tipos = { "nombre_producto", "fk_codigo_linea",
                "fk_codigo_marca", "existencia_producto", "costouni_producto", "preciouni_producto",
                "fechaultentrada_marca", "fechaultsalida_marca", "estatus_producto", "fecha_aprox_ingreso",
                "productos_por_ingresar"};
            cn.actualizar(tipos, datos, "tbl_producto", textBox33);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TextBox[] llenar = {textBox24, textBox25, textBox22, textBox23, textBox21, textBox20,
                textBox19, textBox17};
            cn.bloqueartextbox(llenar);
            button7.Enabled = false;
            button9.Enabled = false;
            button14.Enabled = false;


            cn.insertardatagrid(dataGridView1,textBox7.Text, textBox8.Text, textBox5.Text,
                textBox6.Text, textBox1.Text, textBox2.Text, textBox39,textBox40,groupBox2);
            textBox18.Text = textBox39.Text;

          /*  try{
                int n1, ns2, r2;
                n1 = Convert.ToInt32(textBox40.Text);
                ns2 = Convert.ToInt32(textBox38.Text);

                r2 = ns2 + n1; ;
                textBox37.Text = r2.ToString();


            }catch (Exception i)
            {
                MessageBox.Show("Error: " + i);
            }*/

            




        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                TextBox[] llenar = {textBox24, textBox25, textBox22, textBox23, textBox21, textBox20,
                textBox19, textBox17};
                cn.desbloqueartextbox(llenar);
                button7.Enabled = true;
                button9.Enabled = true;
                button14.Enabled = true;

                TextBox[] textBoxesingresarorden = { textBox24, textBox25, textBox22, textBox23, textBox21
                , textBox20, textBox19, textBox39, textBox17};
                TextBox[] textBoxesmodificarproductos = { textBox33, textBox39 };

                //boton agregar orden compra
                string[] datos = { textBox24.Text, textBox25.Text, textBox22.Text, textBox23.Text, textBox21.Text, textBox20.Text,
                textBox19.Text, textBox39.Text, textBox17.Text };
                string[] tipos = { "pk_id_orden_compra", "fk_codigo_almacen", "fk_id_proveedor", "fecha_creacion_orden_compra",
                "prioridad_orden_compra", "fecha_ini_orden_compra", "fecha_entre_orden_compra", "total_orden_compra",
                "estatus_orden_compra" };
                cn.ingresar(tipos, datos, "tbl_orden_compra");
                
                //Agregar registro de tabla a detalle orden de compra
                cn.insertarbddetalle(dataGridView1);

                //modificar tabla producto

                //Limpiar tabla
                dataGridView1.Rows.Clear();

            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox24.Text;
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            cn.eliminarfilagrid(dataGridView1, textBox39, textBox40, groupBox2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            ayudaordencompra a = new ayudaordencompra("tbl_orden_compra", "pk_id_orden_compra");


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

        private void button16_Click(object sender, EventArgs e)
        {
            ayudadetalleordencompra a = new ayudadetalleordencompra("tbl_detalle_orden_compra", "pk_id_detalle_orden_compra");
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

        private void button15_Click(object sender, EventArgs e)
        {
            GroupBox[] groupBoxes = { groupBox3, groupBox2 };
            cn.limpiardetallee(groupBoxes);
            dataGridView1.Rows.Clear();
            textBox39.Clear();
            textBox40.Clear();

            TextBox[] llenar = {textBox24, textBox25, textBox22, textBox23, textBox21, textBox20,
                textBox19, textBox17};
            cn.desbloqueartextbox(llenar);
            button7.Enabled = true;
            button9.Enabled = true;
            button14.Enabled = true;
        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            TextBox[] llenar = {textBox24, textBox25, textBox22, textBox23, textBox21, textBox20,
                textBox19, textBox17};
            cn.desbloqueartextbox(llenar);
            button7.Enabled = true;
            button9.Enabled = true;
            button14.Enabled = false;
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            string rutaAyuda = "../../../../../../../Ayuda/Modulos/Compras/AyudaRisko/Ayudacompras.chm";
            Help.ShowHelp(ParentForm, rutaAyuda, "Ordencompra.html");
        }
    }
}
