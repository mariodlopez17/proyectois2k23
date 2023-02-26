using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Modulos : Form
    {
        string table = "tbl_modulos";

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }

        //Método que limpia los textbox, elimina el contenido que había
        public void Limpiar()
        {
            txtBuscar.Text = "";
            txtDescripcion.Text = "";
            txtIdModulo.Text = "";
            txtNombre.Text = "";
        }
        //Método que muestra 1 en el textbox estado si el checkbox se ha checkeado, en caso contrario indica 0 en el textbox estado
        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtact.Text = "1";
            }
            else
            {
                txtact.Text = "0";
            }
        }


        //Método que oculta el formulario
        private void button8_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Método que limpia los textbox
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se crea un modulo de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtIdModulo.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtIdModulo, txtDescripcion, txtNombre, txtact };
                cn.ingresar(textbox, table);
                cn.setBtitacora("1003", "Creo Modulo");
                string message = "Registro Guardado";
                Limpiar();
                MessageBox.Show(message);
                //actualizardatagriew();
            }
        }
        //Método que guarda el valor de los textbox en un arreglo de tipo textbox y posteriormente se busca el módulo de acuerdo al id 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TextBox[] textbox = { txtBuscar, txtDescripcion, txtIdModulo, txtNombre };
            int valor1 = int.Parse(txtBuscar.Text);
            string campo = "idModulo = ";
            //string num = txtBusqueda.Tag.ToString();
            cn.buscar(textbox, table, valor1, campo);
        }

        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se actualiza el modulo de acuerdo al id ingresado y se guarda en la bitacora
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtIdModulo.Text == "" || txtDescripcion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtBuscar, txtDescripcion, txtNombre, txtact };
                int valor1 = int.Parse(txtBuscar.Text);
                string campo = "pk_id_modulos = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1003", "Modifico Modulo");
            }
        }

        //Método que muestra un mensaje para eliminar un registro, si se confirma se procece a eliminar al modulo de acuerdo al id ingresado y se registra esta eliminación en la bitacora
        //en caso contrario limpia los textbox 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBuscar.Text);
                string condicion = "pk_id_modulos = ";
                cn.eliminar(table, condicion, campo);
                cn.setBtitacora("1003", "Elimino Modulo");
                //this.Close();
            }
            else
            {
                Limpiar();
                //this.Close();
            }
        }
        //Método que muestra el formulario de ayudaModulo
        private void btnAyuda_Click(object sender, EventArgs e)
        {
            AyudaModulo b = new AyudaModulo();
            b.Show();
        }
    }
}
