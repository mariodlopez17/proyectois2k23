using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;
//Comentado por George Mayén 25/02/2023
namespace Vista_Seguridad
{
    public partial class Usuario : Form
    {
        string table = "tbl_usuarios";
        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }


        //Métoco validaringre: llama al métoco checks y checkbox, luego verifica si los datos están vaciós para mostrar un mensaje que indica que debe completar la información
        //de lo contrario ingresa los datos ingresados den los textbox en un arreglo de textbox y posteriormente envía el usuario y contraseña a un método que es el de setHash, esta acción se registra en la bitacora
        public void validaringre()
        {
            checks();
            checkbox();
            if (txtusername.Text == "" || txtcontraseña.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtemail.Text == "" || TxtPAA.Text == "" || TxtPA.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {
                checks();
                checkbox();
                TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado, TxtPAA, TxtPA };
                txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                TxtPA.Text = Seguridad_Controlador.Controlador.SetHash(TxtPA.Text);
                cn.ingresar(textbox, table);
                cn.setBtitacora("1001", "Crea Nuevo Usuario");
                string message = "Registro Guardado";
                limpiar();
                MessageBox.Show(message);
            }

        }


        //Método validaractua: Valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método checks, checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se actualizan estos datos de acuerdo al id que se haya ingresado
        public void validaractua()
        {
            checks();
            checkbox();
            if (txtusername.Text == "" || txtcontraseña.Text == "" || txtnombre.Text == "" || txtapellido.Text == "" || txtemail.Text == "" || TxtPAA.Text == "" || TxtPA.Text == "")
            {

                MessageBox.Show("Debe completar la informacion");



            }
            else
            {
                checks();
                checkbox();
                TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado, TxtPAA, TxtPA };
                txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
                int valor1 = int.Parse(txtBusqueda.Text);
                string campo = "pk_id_usuario = ";
                cn.actualizar(textbox, table, campo, valor1);
                cn.setBtitacora("1001", "Actualiza Usuario");
            }

        }


        //Mëtodo limpiar: Limpia cada textbox, quitando los valores que tenía
        public void limpiar()
        {
            txtBusqueda.Text = "";
            txtusername.Text = "";
            txtcontraseña.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtemail.Text = "";
            txtestado.Text = "";
            CmbPA.Text = "";
            TxtPA.Text = "";
            TxtPAA.Text = "";
        }

        //Método checkbox: si se ha chequeado el estado del txtestado pasa a 1, de lo contrario pasa a 0
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

        //Método para salir del formulario
        private void button5_Click(object sender, EventArgs e)// boton salir
        {
            
            this.Hide();
        }

        //Método para validar si el valor obtenido en el combo box es igual al valor obtenido en el textbox
        public void checks()
        {
            string pregunta;
            pregunta = CmbPA.Text;

            TxtPAA.Text = pregunta;

        }

        //Método que busca a un usuario a través del método buscarusu de acuerdo al dato que se ingrese 
        private void llenap()
        {
            string[] permisos = new string[10];
            
            //MessageBox.Show(message);
            string[] dato = cn.buscarusu(txtBusqueda.Text);
            MessageBox.Show(" hola "+ dato[0]);

        }


        //Método que llama al método validaringre
        private void button3_Click(object sender, EventArgs e)//boton guardar
        {
            validaringre();
        }

        //Mëtodo que guarda los datos obtenidos de los textbox en un arreglo de tipo textbox y se busca el dato de acuerdo al id del usuario
        private void button1_Click(object sender, EventArgs e) //Boton Buscar
        {
            TextBox[] textbox = { txtnombre, txtapellido, txtcontraseña, txtusername, txtemail, txtestado };
            int valor1 = int.Parse(txtBusqueda.Text);
            string campo = "pk_id_usuario = ";
            cn.buscar(textbox,table, valor1,campo);
        }

        //Método que llama al método validaractua
        private void button4_Click(object sender, EventArgs e) //boton modificar
        {
            validaractua();
        }

        //Método que llama al método limpiar
        private void button2_Click(object sender, EventArgs e)// boton nuevo
        {
            limpiar();
        }

        //Método que oculta el estado
        private void Usuario_Load(object sender, EventArgs e)
        {
            txtestado.Visible = false;
        }
        //Método que muestra un mensaje para eliminar un registro, si se confirma se procece a eliminar al usuario de acuerdo al id ingresado y limpia los textbox
        //en caso contrario limpia los textbox y muestra un mensaje en donde indica que no se puede eliminar de acuerdo a los permisos asignados
        private void button7_Click(object sender, EventArgs e)// boton eliminar
        {
            string message = "Deseas Eliminar el Registro?";
            string title = "Eliminar Registro";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            try
            {


                if (result == DialogResult.Yes)
                {

                    int campo = int.Parse(txtBusqueda.Text);
                    string condicion = "pk_id_usuario = ";
                    cn.eliminar(table, condicion, campo);
                    cn.setBtitacora("1001", "Elimina un Usuario");
                    string message1 = "Registro eliminado / Estado de usuario deshabilitado";
                    limpiar();
                    MessageBox.Show(message1);
                }
                else
                {
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se puede eliminar por permisos asignados");
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar por permisos asignados");
            }
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {

        }

        //Método que llama al método de llenap
        private void button8_Click(object sender, EventArgs e)
        {
            llenap();

        }


        //Mëtodo para asignar un valor, si se ha chequeado asigna '\0', en caso contrario '*'
        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked == true)
            {
                // TBcontraseña.PasswordChar = '*';
                txtcontraseña.PasswordChar = '\0';
            }
            else
                      if (txtcontraseña.Text != "")
            {
                // TBcontraseña.PasswordChar = '\0';
                txtcontraseña.PasswordChar = '*';
            }
        }

        //Método que muestra el formulario de ayudausuario
        private void button6_Click(object sender, EventArgs e)
        {
            ayudausuario b = new ayudausuario();
            //b.MdiParent = this;
            b.Show();
        }
    }
}
