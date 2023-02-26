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
    public partial class ListAplicaciones : Form
    {

        Controlador cn = new Controlador();
        string res;
        public ListAplicaciones()
        {
            InitializeComponent();
        }

        //Método que llena la lista de aplicaciones de acuerdo a los tag
        private void ListAplicaciones_Load(object sender, EventArgs e)
        {
            cn.llenarListAplicaciones(listAplicacionesDB.Tag.ToString(), listAplicacionesDB);
            //desabilitar();
        }

        //Método utilizado para obtener las aplicaciones del perfil de acuerdo al id que se tenga en caso contrario muestra un mensaje de error
        public string getIds()
        {
            try
            {
                string dato;
                dato = listAplicacionesDB.CurrentCell.Value.ToString();
                //MessageBox.Show("Valor optenido es :  " + dato);
                //MessageBox.Show("Valor optenido es :  " + txtIds.Text);
                if (txtIds.Text == "")
                {
                    txtIds.Text = dato;
                }
                else
                {
                    string valor = txtIds.Text;
                    res = valor + "," + dato;
                    txtIds.Text = res;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nError en obtener las aplicaciones del perfil");
            }
            return res;
        }

        //Méotod que muestra el valor obtenido o id
        public string muestraIds()
        {
            string info = txtIds.Text;
            MessageBox.Show("Valor optenido es :  " + info);
            return info;
        }


        //Método que llama al método getIds
        private void listAplicacionesDB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getIds();
            //muestraIds();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*AsignacionAplicacion b = new AsignacionAplicacion();
            MessageBox.Show("Valor optenido es :  " + txtIds.Text);
            this.Hide();*/
        }
        //Método que llama al m´´etodo meustraIds
        private void button2_Click(object sender, EventArgs e)
        { 
            muestraIds();
        }
    }
}
