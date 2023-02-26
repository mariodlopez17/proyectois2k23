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
    public partial class Perfiles : Form
    {

        string table = "tbl_perfiles";
        Controlador cn = new Controlador();

        public Perfiles()
        {
            InitializeComponent();
        }
        //Método que limpia los textbox, elimina el contenido que había
        public void limpiar()
        {
            txtbuscar.Text = "";
            txtdescripcion.Text = "";
            txtestado.Text = "";
            txtnombre.Text = "";
        }

        //Método que muestra 1 en el textbox estado si el checkbox se ha checkeado, en caso contrario indica 0 en el textbox estado
        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtestado.Text = "1";
            }
            else
            {
                txtestado.Text = "0";
            }
        }

        //Método que oculta el formulario
        private void button8_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        //Método que llama a mandar al método limpiar
        private void button2_Click(object sender, EventArgs e) //Boton Nuevo
        {
            limpiar();
        }
        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se crea un perfil de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void button3_Click(object sender, EventArgs e) //Boton Ingresar
        {
            if (txtdescripcion.Text == "" || txtnombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtdescripcion, txtestado, txtnombre };
                cn.ingresar(textbox, table);
                cn.setBtitacora("1004", "Crea un perfil");
                string message = "Registro Guardado";
                limpiar();
                MessageBox.Show(message);
            }

        }

        //Método que oculta el txtestado
        private void Perfiles_Load(object sender, EventArgs e)
        {
            txtestado.Visible = false;
        }

        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se actualizan estos datos de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void button4_Click(object sender, EventArgs e) //Boton Actualizar
        {
            if (txtdescripcion.Text == "" || txtnombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtdescripcion, txtestado, txtnombre };
                int valor1 = int.Parse(txtbuscar.Text);
                string campo = "pk_id_perfil = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1004", "Modifico un perfil");
                string message2 = "Registro actualizado";
                limpiar();
                MessageBox.Show(message2);
            }
        }

        //Método que muestra un mensaje para eliminar un registro, si se confirma se procece a eliminar al usuario de acuerdo al id ingresado y limpia los textbox
        //en caso contrario limpia los textbox 
        private void button7_Click(object sender, EventArgs e) //Boton Eliminar
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtbuscar.Text);
                string condicion = "pk_id_perfil = ";
                cn.eliminar(table, condicion, campo);
                cn.setBtitacora("1004", "Elimino un perfil");
                string message1 = "Registro eliminado";
                limpiar();
                MessageBox.Show(message1);
            }
            else
            {
                limpiar();
            }
        }

        //Método que muestra el formulario de ayuda perfiles
        private void button6_Click(object sender, EventArgs e)
        {
            AyudaPerfiles b = new AyudaPerfiles();
            b.Show();
        }
    }
}
