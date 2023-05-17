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
                string[] infoSaldos = cliente.Split('-');
                int salgoMes = int.Parse(infoSaldos[0]);
                int totalCargos = int.Parse(infoSaldos[1]);
                int abonosActuales = int.Parse(infoSaldos[2]);
                int nuevoAbono = int.Parse(abono);
                int nuevoTotalAbonado = abonosActuales + nuevoAbono;
                int nuevoSaldoMensual = nuevoTotalAbonado - totalCargos;
                sentencias.updateCargosClientes(id_cliente, nuevoTotalAbonado.ToString());
                sentencias.updateSaldoMensual(id_cliente, nuevoTotalAbonado.ToString());
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
            string[] almacenes = sentencias.getAlmacenes();
            foreach (string almacen in almacenes)
            {
                if (almacen != null)
                {
                    comboBox.Items.Add(almacen);
                }
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
        public Boolean validarPagosAnteriores(string id_factura, string id_almacen)
        {
            string[] datos = sentencias.getUltimoPago(id_factura, id_almacen);
            if (datos.Length > 0 && datos[0] != null)
            {
                return true;
            }
            return false;
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
    }
}
