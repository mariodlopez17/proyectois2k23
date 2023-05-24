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
        int cantidadCicksBuscar = 0;
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
            txt_monto_cargo.Enabled = false;
            txt_vuelto.Enabled = false;
            txt_no_cuenta.Enabled = false;
            btn_eliminar.Enabled = false;
        }
        private void llenarCombobox()
        {
            controlador.llenarCbxMoneda(txt_id_moneda);
            controlador.llenarCbxAlmacen(txt_id_almacen);
            controlador.llenarCbxAlmacen(txt_id_almacen);
            controlador.llenarCbxConceptoXCobrar(txt_id_concepto);
            controlador.llenarCbxTipoDePago(txt_id_tipoPago);
        }
        private void limpiar()
        {
            cargarId();
            llenarCombobox();
            btn_guardar.Enabled = true;
            btn_buscar_factura.Enabled = true;
            btn_eliminar.Enabled = true;
            txt_id_factura.Text = "";
            txt_id_cliente.Text = "";
            txt_nombre_cliente.Text = "";
            txt_monto_cargo.Text = "";
            txt_monto_pago.Text = "";
            txt_no_cuenta.Text = "";
            txt_no_cuenta.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] infoIdFactura = txt_id_factura.Text.Split('-');
            btn_eliminar.Enabled = false;
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


        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_id_factura.Text != null && txt_id_almacen.SelectedItem != null && txt_id_moneda.SelectedItem != null 
                && txt_id_concepto.SelectedItem != null && txt_id_tipoPago.SelectedItem != null )
            {
                string[] infoIdFactura = txt_id_factura.Text.Split('-');
                string[] infoAlmacen = txt_id_almacen.SelectedItem.ToString().Split('-');
                string[] infoMoneda = txt_id_moneda.SelectedItem.ToString().Split('-');
                string[] infoConcepto = txt_id_concepto.SelectedItem.ToString().Split('/');
                string[] infoTipoPago = txt_id_tipoPago.SelectedItem.ToString().Split('-');

                DateTime fechaFactura = DateTime.ParseExact(txt_fecha_factura.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fechaFacturaFormateado = fechaFactura.ToString("yyyy-MM-dd");

                DateTime fechaPago = DateTime.ParseExact(txt_fecha_pago.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string fechaPagoFormateado = fechaPago.ToString("yyyy-MM-dd");

                float nuevoSaldo = float.Parse(infoConcepto[2]) * float.Parse(txt_monto_pago.Text);

                List<string> datos = new List<string>();
                datos.Add(txt_comprante.Text);
                datos.Add(infoIdFactura[0]);
                datos.Add(infoIdFactura[1]);
                datos.Add(infoAlmacen[0]);
                datos.Add(txt_id_cliente.Text);
                datos.Add(infoTipoPago[0]);
                datos.Add(infoMoneda[0]);
                datos.Add(infoConcepto[0]);
                datos.Add(fechaFacturaFormateado);
                datos.Add(fechaPagoFormateado);
                datos.Add(infoMoneda[2]);
                datos.Add(txt_monto_cargo.Text);
                datos.Add(nuevoSaldo.ToString());
                datos.Add("1");
                controlador.guardarPago(datos);
                controlador.actualizarSaldo(txt_id_cliente.Text, nuevoSaldo.ToString());
                MessageBox.Show("Pago realizado correctamente");
                limpiar();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_id_tipoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txt_id_tipoPago.SelectedItem != null)
            {
                string[] infoTipoPago = txt_id_tipoPago.Text.Split('-');
                if (infoTipoPago.Length > 1)
                {
                    if (infoTipoPago[1].ToLower() != "efectivo")
                    {
                        txt_no_cuenta.Enabled = true;
                    }
                    else
                    {
                        txt_no_cuenta.Enabled = false;
                    }
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            controlador.eliminarPago(txt_comprante.Text);
            float montoNegativo = float.Parse(txt_monto_pago.Text)*-1;
            Console.WriteLine(montoNegativo);
            controlador.actualizarSaldo(txt_id_cliente.Text, montoNegativo.ToString());
            MessageBox.Show("factura cancelada correctamente");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cantidadCicksBuscar == 0)
            {
                limpiar();
                btn_guardar.Enabled = false;
                btn_buscar_factura.Enabled = false;
                txt_comprante.Enabled = true;
                cantidadCicksBuscar++;
            }
            else if (cantidadCicksBuscar == 1)
            {
                txt_comprante.Enabled = false;
                cantidadCicksBuscar = 0;
                ComboBox[] comboBoxes = { txt_id_almacen, txt_id_tipoPago, txt_id_moneda, txt_id_concepto};
                TextBox[] textBoxes = { txt_id_factura, txt_id_cliente, txt_monto_cargo, txt_monto_pago};
                DateTimePicker[] dateTimePickers = { txt_fecha_factura, txt_fecha_pago };
                controlador.getPago(txt_comprante.Text, dateTimePickers, textBoxes, comboBoxes);
            }
        }

        private void txt_id_moneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_id_moneda.SelectedItem != null)
            {
                string[] infoMoneda = txt_id_moneda.SelectedItem.ToString().Split('-');
                if (txt_monto_pago.Text!=null)
                {
                    try
                    {
                        string pago = txt_monto_pago.Text;
                        float cargo = float.Parse(txt_monto_cargo.Text);
                        float nuevoMontoPago = float.Parse(infoMoneda[2]) * float.Parse(pago);
                        if (cargo < nuevoMontoPago)
                        {
                            float vuelto = nuevoMontoPago - cargo;
                            txt_monto_pago.Text = nuevoMontoPago.ToString();
                            txt_vuelto.Text = vuelto.ToString();
                        }
                        txt_monto_pago.Text = nuevoMontoPago.ToString();
                        txt_vuelto.Text = "0";
                    }
                    catch (FormatException)
                    {

                    }
                }
            }
        }
    }
}
