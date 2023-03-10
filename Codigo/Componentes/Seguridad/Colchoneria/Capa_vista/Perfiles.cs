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

        }

        //Método que muestra 1 en el textbox estado si el checkbox se ha checkeado, en caso contrario indica 0 en el textbox estado
        public void checkbox()
        {
 
        }

        //Método que oculta el formulario
        private void button8_Click(object sender, EventArgs e)
        {
          
        }

        //Método que llama a mandar al método limpiar
        private void button2_Click(object sender, EventArgs e) //Boton Nuevo
        {
 
        }
        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se crea un perfil de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void button3_Click(object sender, EventArgs e) //Boton Ingresar
        {


        }

        //Método que oculta el txtestado
        private void Perfiles_Load(object sender, EventArgs e)
        {
   
        }

        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se actualizan estos datos de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void button4_Click(object sender, EventArgs e) //Boton Actualizar
        {
 
        }

        //Método que muestra un mensaje para eliminar un registro, si se confirma se procece a eliminar al usuario de acuerdo al id ingresado y limpia los textbox
        //en caso contrario limpia los textbox 
        private void button7_Click(object sender, EventArgs e) //Boton Eliminar
        {
          
        }

        //Método que muestra el formulario de ayuda perfiles
        private void button6_Click(object sender, EventArgs e)
        {
   
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = Dgv_perfiles;
            TextBox[] Grupotextbox = { txtIdPerfiles, txtNombre, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { txtIdPerfiles, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_perfiles, Grupotextbox, "colchoneria");
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
