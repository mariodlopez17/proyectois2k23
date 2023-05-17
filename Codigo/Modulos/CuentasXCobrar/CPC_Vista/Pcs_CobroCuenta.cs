using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Vista
{
    public partial class Pcs_CobroCuenta : Form
    {
        CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();
        public Pcs_CobroCuenta()
        {
            InitializeComponent();
            cargarId();
            cargarFecha();
            bloquearTextBox();
            llenarCombobox();
        }

        private void cargarId()
        {
            txt_comprante.Text = controlador.generarID();
        }
        private void cargarFecha()
        {
            DateTime fechaActual = DateTime.Now;
            txt_fecha_pago.Value = fechaActual;
        }
        private void bloquearTextBox()
        {
            txt_comprante.Enabled = false;
            txt_fecha_pago.Enabled = false;
            txt_id_cliente.Enabled = false;
            txt_nombre_cliente.Enabled = false;
            txt_fecha_factura.Enabled = false;
            txt_cambio.Enabled = false;
            txt_monto_cargo.Enabled = false;
        }
        private void llenarCombobox()
        {
            controlador.llenarCbxMoneda(txt_id_moneda);
            controlador.llenarCbxAlmacen(txt_id_almacen);
            controlador.llenarCbxAlmacen(txt_id_almacen);
            controlador.llenarCbxConceptoXCobrar(txt_id_concepto);
        }
        private void limpiar()
        {
            cargarId();
            llenarCombobox();
            txt_id_factura.Text = "";
            txt_id_cliente.Text = "";
            txt_nombre_cliente.Text = "";
            txt_cambio.Text = "";
            txt_monto_cargo.Text = "";
            txt_no_cuenta.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] infoIdFactura = txt_id_factura.Text.Split('-');

            if (infoIdFactura.Length == 2)
            {
                if (controlador.validarPagosAnteriores(infoIdFactura[0], infoIdFactura[1]))
                {
                    int nuevoSaldo = 0;
                    string[] datos = controlador.getDatosPagoAnterior(infoIdFactura[0], infoIdFactura[1]);
                    if (datos.Length > 0)
                    {
                        txt_id_cliente.Text = datos[0];
                        controlador.buscarCliente(txt_id_cliente.Text, txt_nombre_cliente);
                        DateTime Fecha = Convert.ToDateTime(datos[1]);
                        txt_fecha_factura.Value = Fecha;
                        nuevoSaldo = int.Parse(datos[2]) - int.Parse(datos[3]);
                        txt_monto_cargo.Text = nuevoSaldo.ToString();
                    }
                    else
                    {
                        MessageBox.Show("La factura ya se encuentra cancelada en su totalidad.");
                    }
                }
                else
                {
                    TextBox[] componentes = { txt_monto_cargo, txt_id_cliente };
                    controlador.getDatosVenta(infoIdFactura[0], infoIdFactura[1], txt_fecha_factura, componentes);
                    controlador.buscarCliente(txt_id_cliente.Text, txt_nombre_cliente);
                }
            }
        }

        private void txt_id_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_id_moneda.SelectedItem != null)
            {
                string[] infoMoneda = txt_id_moneda.SelectedItem.ToString().Split('-');

                txt_cambio.Text = infoMoneda[2];
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_id_factura.Text != null && txt_id_almacen.SelectedItem != null && txt_id_moneda.SelectedItem != null && txt_id_concepto.SelectedItem != null  )
            {
                string[] infoIdFactura = txt_id_factura.Text.Split('-');
                string[] infoAlmacen = txt_id_almacen.SelectedItem.ToString().Split('-');
                string[] infoMoneda = txt_id_moneda.SelectedItem.ToString().Split('-');
                string[] infoConcepto = txt_id_concepto.SelectedItem.ToString().Split('/');

                DateTime fechaFactura = DateTime.ParseExact(txt_fecha_factura.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fechaFacturaFormateado = fechaFactura.ToString("yyyy-MM-dd");

                DateTime fechaPago = DateTime.ParseExact(txt_fecha_pago.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fechaPagoFormateado = fechaPago.ToString("yyyy-MM-dd");

                List<string> datos = new List<string>();
                datos.Add(txt_comprante.Text);
                datos.Add(infoIdFactura[0]);
                datos.Add(infoIdFactura[1]);
                datos.Add(infoAlmacen[0]);
                datos.Add(txt_id_cliente.Text);
                datos.Add("1");
                datos.Add(infoMoneda[0]);
                datos.Add(infoConcepto[0]);
                datos.Add(fechaFacturaFormateado);
                datos.Add(fechaPagoFormateado);
                datos.Add(infoMoneda[2]);
                datos.Add(txt_monto_cargo.Text);
                datos.Add(txt_monto_pago.Text);
                datos.Add("1");
                controlador.guardarPago(datos);
                controlador.actualizarSaldo(txt_id_cliente.Text, txt_monto_pago.Text);
                MessageBox.Show("Pago realizado correctamente");
                limpiar();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
