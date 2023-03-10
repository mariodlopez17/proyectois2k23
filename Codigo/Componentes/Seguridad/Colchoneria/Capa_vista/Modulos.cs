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
       

        Controlador cn = new Controlador();

        public Modulos()
        {
            InitializeComponent();
        }

        //Método que limpia los textbox, elimina el contenido que había
        public void Limpiar()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //Método que limpia los textbox
        private void btnNuevo_Click(object sender, EventArgs e)
        {
          
        }
        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se crea un modulo de acuerdo al id que se haya ingresado y se guarda en la bitacora
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            
            
        }
        //Método que guarda el valor de los textbox en un arreglo de tipo textbox y posteriormente se busca el módulo de acuerdo al id 
        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
        }

        //Método que valida si no se han llenado los textbox muestra un mensaje que indica que complete la información, en caso contrario llama al método  checkbox,
        //los textbox ingresados se guardan en un arreglo de textbox y se actualiza el modulo de acuerdo al id ingresado y se guarda en la bitacora
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        //Método que muestra un mensaje para eliminar un registro, si se confirma se procece a eliminar al modulo de acuerdo al id ingresado y se registra esta eliminación en la bitacora
        //en caso contrario limpia los textbox 
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }
        //Método que muestra el formulario de ayudaModulo
        private void btnAyuda_Click(object sender, EventArgs e)
        {
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1003";
            navegador1.actual = this;
            navegador1.tabla = Dgv_modulos;
            TextBox[] Grupotextbox = { txtIdModulo, txtNombre, txtDescripcion, txtact };
            TextBox[] Idtextbox = { txtIdModulo, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_modulos, Grupotextbox, "colchoneria");
        }
    }
}
