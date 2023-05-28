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


namespace CPC_Vista
{
    public partial class Mant_venta : Form
    {
        public Mant_venta()
        {
            InitializeComponent();
            llenarcbxnalmacen();
            llenarcbxnmoneda();
            llenarcbxncliente();
        }

        CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();

        public void llenarcbxnalmacen()
        {
            try
            {
                cbx_nombre_almacen.Items.Clear();
                OdbcDataReader datareader = controlador.llenarnalmacen();
                while (datareader.Read())
                {
                    cbx_nombre_almacen.Items.Add(datareader[0].ToString());
                }
                cbx_nombre_almacen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxidalmacen()
        {
            try
            {
                almacen.Items.Clear();
                OdbcDataReader datareader = controlador.llenaridalmacen(cbx_nombre_almacen.Text);
                while (datareader.Read())
                {
                    almacen.Items.Add(datareader[0].ToString());
                }
                almacen.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxnmoneda()
        {
            try
            {
                cbx_nombre_moneda.Items.Clear();
                OdbcDataReader datareader = controlador.llenarnmoneda();
                while (datareader.Read())
                {
                    cbx_nombre_moneda.Items.Add(datareader[0].ToString());
                }
                cbx_nombre_moneda.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxidmoneda()
        {
            try
            {
                moneda.Items.Clear();
                OdbcDataReader datareader = controlador.llenaridmoneda(cbx_nombre_moneda.Text);
                while (datareader.Read())
                {
                    moneda.Items.Add(datareader[0].ToString());
                }
                moneda.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxncliente()
        {
            try
            {
                cbx_nombre_cliente.Items.Clear();
                OdbcDataReader datareader = controlador.llenarnclientes();
                while (datareader.Read())
                {
                    cbx_nombre_cliente.Items.Add(datareader[0].ToString());
                }
                cbx_nombre_cliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxidcliente()
        {
            try
            {
                id_cliente.Items.Clear();
                OdbcDataReader datareader = controlador.llenaridclientes(cbx_nombre_cliente.Text);
                while (datareader.Read())
                {
                    id_cliente.Items.Add(datareader[0].ToString());
                }
                id_cliente.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "4002";
            TextBox[] Grupotextbox = { txt_id_venta, txt_id_almacen, txt_fecha_venta, txt_descuento, txt_iva, txt_total, txt_estado, txt_fecha_vencimiento, txt_moneda, txt_id_cliente};
            TextBox[] Idtextbox = { txt_id_venta, txt_id_almacen, txt_fecha_venta, txt_descuento, txt_iva, txt_total, txt_estado, txt_fecha_vencimiento, txt_moneda, txt_id_cliente };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = tbl_venta;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(tbl_venta, Grupotextbox, "colchoneria");
        }

        private void almacen_SelectedIndexChanged(object sender, EventArgs e){txt_id_almacen.Text = almacen.Text;}
        private void fecha_venta_ValueChanged(object sender, EventArgs e){txt_fecha_venta.Text = fecha_venta.Text;}
        private void estado_SelectedIndexChanged(object sender, EventArgs e){txt_estado.Text = estado.Text;}
        private void fecha_vencimiento_ValueChanged(object sender, EventArgs e){txt_fecha_vencimiento.Text = fecha_vencimiento.Text;}
        private void moneda_SelectedIndexChanged(object sender, EventArgs e){txt_moneda.Text = moneda.Text;}
        private void id_cliente_SelectedIndexChanged(object sender, EventArgs e){txt_id_cliente.Text = id_cliente.Text;}

        private void cbx_nombre_almacen_SelectedIndexChanged(object sender, EventArgs e)
        {llenarcbxidalmacen();}

        private void cbx_nombre_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {llenarcbxidmoneda();}

        private void cbx_nombre_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {llenarcbxidcliente();}
    }
}
