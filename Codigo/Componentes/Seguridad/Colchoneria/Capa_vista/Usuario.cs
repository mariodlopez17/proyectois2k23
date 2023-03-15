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
        Controlador cn = new Controlador();

        public Usuario()
        {
            InitializeComponent();
        }
      

     
        private void navegador1_Load_1(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "1001";
            navegador1.actual = this;
            navegador1.tabla = Dgv_usuario;
            TextBox[] Grupotextbox = { txtId, txtnombre, txtapellido, txtusername, txtcontraseña, txtemail, Ultimacon, txt1, txt2, TxtPA };
            txtcontraseña.Text = Seguridad_Controlador.Controlador.SetHash(txtcontraseña.Text);
            TxtPA.Text = Seguridad_Controlador.Controlador.SetHash(TxtPA.Text);
            cn.setBtitacora("1001", "Crea Nuevo Usuario");
            TextBox[] Idtextbox = { txtId, txtnombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(Dgv_usuario, Grupotextbox, "colchoneria");
        }
    }
}
