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
            try {
                double n1, n2, ns, r;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                ns = Convert.ToDouble(textBox16.Text);
                r = ns + (n1 * n2);
                textBox3.Text = r.ToString();

            }
            catch 
            {
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double n1, n2, ns, r;
                n1 = Convert.ToDouble(textBox1.Text);
                n2 = Convert.ToDouble(textBox2.Text);
                ns = Convert.ToDouble(textBox16.Text);
                r = ns + (n1 * n2);
                textBox3.Text = r.ToString();

            }
            catch
            {

            }
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
            textBox16.Text = textBox3.Text;
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
    }
}
