using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Threading.Tasks;
using CPC_Modelo;
using System.Windows.Forms;

namespace CPC_Controlador
{

    public class Controlador
    {
        Sentencias sentencias = new Sentencias();

        public OdbcDataReader llenarcbxIdC()
        {
            return sentencias.llenarcbxIdCliente();
        }

        public OdbcDataReader llenartxtCli(string id_cliente)
        {
            return sentencias.llenartxtNCliente(id_cliente);
        }

        public void guardarPago(List<string> lista)
        {
            string values = "";
            foreach (string datos in lista)
            {
                values += "'" + datos + "',";
            }
            char[] caracteresEliminar = { ',' };

            values = values.TrimEnd(caracteresEliminar);
            sentencias.newPago(values);
        }
        public void actualizarSaldo(string id_cliente, string abono)
        {
            List<string> datos = sentencias.getSaldoCliente(id_cliente);
            foreach (string cliente in datos)
            {
                string[] infoSaldos = cliente.Split('/');
                float totalCargos = float.Parse(infoSaldos[1]);
                float abonosActuales = float.Parse(infoSaldos[2]);
                float nuevoAbono = float.Parse(abono);
                float nuevoTotalAbonado = abonosActuales + nuevoAbono;
                float nuevoSaldoMensual = nuevoTotalAbonado - totalCargos;
                sentencias.updateCargosClientes(id_cliente, nuevoTotalAbonado.ToString());
                sentencias.updateSaldoMensual(id_cliente, nuevoSaldoMensual.ToString());
            }
        }

        public void displayReporte(string id_aplicacion)
        {
            List<string> reporte = sentencias.queryReportw(id_aplicacion);
            foreach (string path in reporte)
            {
                CapaVistaReporteria.visualizar b = new CapaVistaReporteria.visualizar(path);
                b.Show();
            }
        }

        public string generarID()
        {
            int newId = 0;
            newId = sentencias.getNewId() + 1;
            return newId.ToString();
        }
        public void llenarCbxAlmacen(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> almacenes = sentencias.getAlmacenes();
            foreach (string almacen in almacenes)
            {
                 comboBox.Items.Add(almacen);
            }
        }
        public void buscarCliente(string id_cliente, TextBox textBox)
        {
            List<string> datos = sentencias.getClientes(id_cliente);
            foreach (string cliente in datos)
            {
                textBox.Text = cliente;
            }
        }
        public void llenarCbxMoneda(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> datos = sentencias.getMoneda();
            foreach (string moneda in datos)
            {
                comboBox.Items.Add(moneda);
            }
        }
        public void llenarCbxConceptoXCobrar(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> datos = sentencias.getConceptoXCobrar();
            foreach (string conceptoxc in datos)
            {
                comboBox.Items.Add(conceptoxc);
            }
        }
        public void llenarCbxTipoDePago(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> datos = sentencias.getTiposDePago();
            foreach (string tipo in datos)
            {
                comboBox.Items.Add(tipo);
            }
        }

        public void llenarCbxClientes(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            List<string> datos = sentencias.getAllClientes();
            foreach (string cliente in datos)
            {
                comboBox.Items.Add(cliente);
            }
        }

        public Boolean validarPagosAnteriores(string id_factura, string id_almacen)
        {
            string[] datos = sentencias.getUltimoPago(id_factura, id_almacen);
            if (datos.Length > 0 && datos[0] != null)
            {
                return true;
            }
            return false;
        }
        
       public void eliminarPago(string id_comprobante)
        {
            sentencias.deletePago(id_comprobante);
        } 
        public string[] getDatosPagoAnterior(string id_factura, string id_almacen)
        {
            string[] datos = sentencias.getUltimoPago(id_factura, id_almacen);
            int nuevoPago = int.Parse(datos[2]) - int.Parse(datos[3]);
            if (nuevoPago > 0)
            {
                return datos;
            }
            string[] nada = { };
            return nada;
        }
        public void getDatosVenta(string id_venta, string id_almacen, DateTimePicker dateTimePicker, TextBox[] textBoxes)
        {
            List<string> datos = sentencias.getVenta(id_venta, id_almacen);
            foreach (string venta in datos)
            {
                string[] infoVenta = venta.Split('-');

                DateTime fecha = DateTime.Parse(infoVenta[0]);
                dateTimePicker.Value = fecha;

                textBoxes[0].Text = infoVenta[1];
                textBoxes[1].Text = infoVenta[2];
            }
        }
        public void getPago(string id_comprobante, DateTimePicker[] dateTimePicker, TextBox[] textBoxes, ComboBox[] comboBox)
        {
            string[] datos = sentencias.queryPago(id_comprobante);
            
            if (datos[6] != null)
            {
                DateTime FechaFactura = Convert.ToDateTime(datos[6]);
                DateTime FechaPago = Convert.ToDateTime(datos[7]);

                List<string> datoAlmacen = sentencias.getAlmacenes();
                foreach (string almacen in datoAlmacen)
                {
                    string[] infoAlmacen = almacen.Split('-');
                    if (infoAlmacen[0].Equals(datos[1]))
                    {
                        comboBox[0].SelectedItem = almacen;
                    }
                }

                List<string> datoTipoPago = sentencias.getTiposDePago();
                foreach (string tipo in datoTipoPago)
                {
                    string[] infoMoneda = tipo.Split('-');
                    if (infoMoneda[0].Equals(datos[3]))
                    {
                        comboBox[1].SelectedItem = tipo;
                    }
                }

                List<string> datoMoneda = sentencias.getMoneda();
                foreach (string moneda in datoMoneda)
                {
                    string[] infoMoneda = moneda.Split('-');
                    if (infoMoneda[0].Equals(datos[4]))
                    {
                        comboBox[2].SelectedItem = moneda;
                    }
                }

                List<string> datosConcept = sentencias.getConceptoXCobrar();
                foreach (string concepto in datosConcept)
                {
                    string[] infoConcepto = concepto.Split('/');
                    if (infoConcepto[0].Equals(datos[5]))
                    {
                        comboBox[3].SelectedItem = concepto;
                    }
                }

                textBoxes[0].Text = datos[0];
                textBoxes[1].Text = datos[2];
                dateTimePicker[0].Value = FechaFactura;
                dateTimePicker[1].Value = FechaPago;
                textBoxes[2].Text = datos[8];
                textBoxes[3].Text = datos[9];
            }
        }
    }
}
