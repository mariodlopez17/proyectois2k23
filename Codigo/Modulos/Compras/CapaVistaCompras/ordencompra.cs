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
    public partial class ordencompra : Form
    {
        csControlador cn = new csControlador();
        public ordencompra()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton agregar
            string[] datos = { textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text,
                textBox7.Text, textBox8.Text, textBox9.Text };
            string[] tipos = { "pk_id_orden_compra", "fk_codigo_almacen", "fk_id_proveedor", "fecha_creacion_orden_compra",
                "prioridad_orden_compra", "fecha_ini_orden_compra", "fecha_entre_orden_compra", "total_orden_compra",
                "estatus_orden_compra" };
            cn.ingresar(tipos, datos, "tbl_orden_compra");

        }
    }
}
