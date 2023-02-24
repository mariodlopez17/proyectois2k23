using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CapaVistaReporteria
{
    public partial class reporteria_usuario : Form
    {
        string connectionString = @"Server=colchoneria.mysql.database.azure.com;Database=colchoneria;Uid=administrador;Pwd=Jm123456;";
        int idregistro = 0;
        public reporteria_usuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void reporteria_usuario_Load(object sender, EventArgs e)
        {

        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
