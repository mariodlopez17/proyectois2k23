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
        
        Controlador cn = new Controlador();

        public Aplicacion()
        {
            InitializeComponent();
        }

        //Método que valida si el checkbox se ha chequeado muestra en txtact 1, en caso contrario 0
        public void checkbox()
        {
           
        }
        //Método que limpia los textbox
        public void limpiar()
        {
           
        }
        //Método que oculta el formulario
        private void button7_Click(object sender, EventArgs e)
        {
            
           
        }

        //Método que limpia los textbox
        private void button3_Click(object sender, EventArgs e)
        {
           

        }
        //Método que valida si completa la información, si no la completa muestra un mensaje indicando que debe completarla,
        //en caso contrario registra la aplicación de acuerdo al id de la aplicación ingresado
        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
        
        }

        //Método que busca la aplicación de acuero al id
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        //Método que valida si completa la información, si no la completa muestra un mensaje indicando que debe completarla,
        //en caso contrario actualiza la aplicación de acuerdo al id de la aplicación ingresado
        private void button4_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Aplicacion_Load(object sender, EventArgs e)
        {
            
        }

        //Método que muestra un mensaje de eliminación y si se responde con si, elimina el registro de acuerdo al id de la aplicación
        private void button5_Click(object sender, EventArgs e)
        {
           

            
        }

        //Método que llama al formulario indicado
        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1002";
            navegador1.actual = this;
            navegador1.tabla = Dgv_modulos;
            TextBox[] Grupotextbox = { idapp, txtNombre, txtDescripcion, txtact };
            TextBox[] Idtextbox = { idapp, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_modulos, Grupotextbox, "colchoneria");
        }
    }
}
