using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CPC_Controlador;

namespace CPC_Vista
{
    public partial class Cobro_Facturas : Form
    {
        public Cobro_Facturas()
        {
            InitializeComponent();
            llenarcbxidcliente();
            DateTime fh = DateTime.Now;
            txtFechaOperacion.Text = fh.ToString("yyyy'-'MM'-'dd");
        }

        Controlador controlador = new Controlador();

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        public void llenarcbxidcliente()
        {
            try
            {
                cbxIdCliente.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxIdC();
                while (datareader.Read())
                {
                    cbxIdCliente.Items.Add(datareader[0].ToString());
                }
                cbxIdCliente.SelectedIndex = 0;
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex); }
        }

        public void llenartxtnombrecliente()
        {
        }

        private void cbxIdCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
