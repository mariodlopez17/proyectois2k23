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
    public partial class Aplicacion : Form
    {
        string table = "tbl_Aplicaciones";
        Controlador cn = new Controlador();

        public Aplicacion()
        {
            InitializeComponent();
        }

        //Método que valida si el checkbox se ha chequeado muestra en txtact 1, en caso contrario 0
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
        //Método que limpia los textbox
        public void limpiar()
        {
           
            txtNombre.Text = "";
            
            txtDescripcion.Text = "";
            txtact.Text = "";
            idapp.Text = "";
        }
        //Método que oculta el formulario
        private void button7_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        //Método que limpia los textbox
        private void button3_Click(object sender, EventArgs e)
        {
            txtact.Text = "";
            txtBusacar.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";

        }
        //Método que valida si completa la información, si no la completa muestra un mensaje indicando que debe completarla,
        //en caso contrario registra la aplicación de acuerdo al id de la aplicación ingresado
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtNombre.Text == "" || idapp.Text=="")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else { 
                checkbox();
            TextBox[] textbox = { idapp, txtNombre, txtDescripcion, txtact };
            cn.ingresar(textbox, table);
                cn.setBtitacora("1002", "Se creo nueva Aplicacion");
                string message = "Registro Guardado";

            limpiar();
            MessageBox.Show(message);
        }
        
        }

        //Método que busca la aplicación de acuero al id
        private void button1_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtNombre, txtDescripcion, txtact };
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "pk_id_aplicacion = ";
            //string num = txtBusacar.Tag.ToString();
            cn.buscar(textbox, table, valor1, campo);
        }
        //Método que valida si completa la información, si no la completa muestra un mensaje indicando que debe completarla,
        //en caso contrario actualiza la aplicación de acuerdo al id de la aplicación ingresado
        private void button4_Click(object sender, EventArgs e)
        {
            if (txtDescripcion.Text == "" || txtNombre.Text == "")
            {
                MessageBox.Show("COMPLETAR INFORMACION");
            }
            else
            {
                checkbox();
                TextBox[] textbox = { txtNombre, txtDescripcion, txtact };
                int valor1 = int.Parse(txtBusacar.Text);
                string campo = "pk_id_aplicacion = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1002", "Actualiza Aplicacion");
            }
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            
        }

        //Método que muestra un mensaje de eliminación y si se responde con si, elimina el registro de acuerdo al id de la aplicación
        private void button5_Click(object sender, EventArgs e)
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                int campo = int.Parse(txtBusacar.Text);
                string condicion = "pk_id_aplicacion = ";
                cn.eliminar(table, condicion, campo);
                cn.setBtitacora("1002", "Elimino Aplicacion");
                //this.Close();
            }
            else
            {
                limpiar();
                //this.Close();
            }

            
        }

        //Método que llama al formulario indicado
        private void button6_Click(object sender, EventArgs e)
        {
            ayudaaplicacion b = new ayudaaplicacion();
           // b.MdiParent = this;
            b.Show();
        }
    }
}
