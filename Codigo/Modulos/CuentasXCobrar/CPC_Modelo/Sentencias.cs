using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Modelo
{
    public class Sentencias
    {

        Conexion conexion = new Conexion();
        public OdbcDataAdapter DisplayReportes(string tabla)// metodo  que obtinene el contenio de la tabla reportes
        {
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla " + tabla);
            }
            return dataTable;
        }

        public OdbcDataReader llenarcbxIdCliente()
        {
            string sql = "select Pk_idCliente from tbl_clientes;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataReader llenartxtNCliente(string id_cliente)
        {
            string sql = "select Nombres_cl from tbl_clientes where Pk_idCliente = '" + id_cliente + "';";

            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public OdbcDataAdapter displayProductos()
        {
            string sql = "select pk_codigo_producto as ID, nombre_producto as Nombre, preciouni_producto as prcio, existencia_producto as existencias from  tbl_producto where estatus_producto = 1 AND existencia_producto > 1;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter();
            try
            {
                dataTable = new OdbcDataAdapter(sql, conexion.conexion());
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo consultar la tabla tbl_producto");
            }
            return dataTable;
        }


        public void newEncabezado(string valuesEncabezado)
        {
            string encabezado = "INSERT INTO tbl_venta VALUES (" + valuesEncabezado + ");";
            try
            {
                OdbcCommand command = new OdbcCommand(encabezado, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void newDetalle(string valuesDetalle)
        {
            string detalle = "INSERT INTO tbl_detalle_venta VALUES " + valuesDetalle + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(detalle, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Close();
                Console.WriteLine("VENTA EXITOSA");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateCargosClientes(string id_cliente, string saldo )
        {
            string sql = "UPDATE tbl_clientes SET CargoMes_clientes = '" + saldo + "' WHERE (`Pk_idClientes` = " + id_cliente + ");";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en actualizar en la tabla de tbl_clientes"); }
        }

        public List<string> buscarExistencias()
        {
            List<string> datos = new List<string>();
            string sql = "SELECT pk_codigo_producto, existencia_producto FROM tbl_producto;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el producto de la tabla de tbl_producto"); }
            return datos;
        }
        public void updateExistencias(string id_producto, string values)
        {
            string sql = "UPDATE tbl_producto SET existencia_producto = '" + values+"' WHERE (`pk_codigo_producto` = " + id_producto + ");";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en actualizar en la tabla de tbl_producto"); }
        }
        public void newPago(string values)
        {
            string campos = "pk_comprobante_cxc,fk_id_factura,fk_id_almacen_venta,fk_id_almacen_pago,fk_id_cliente,fk_id_tipoPago," +
                "fk_id_moneda,fk_id_concepto_cxc,fecha_emision_cxc,fecha_pago_cxc,cambio_moneda_pago_cxc,monto_cobro_cxc,monto_pago_cxc,estado_cxc";
            string sql = "INSERT INTO tbl_CuentaPorCobrar(" + campos + ") VALUES (" + values + ");";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en insertar en la tabla de tbl_CuentaPorCobrar"); }
        }
        public void deletePago(string id_comprobante)
        {
            string sql = "UPDATE tbl_cuentaporcobrar SET `estado_cxc` = '2' WHERE (`pk_comprobante_cxc` = '"+ id_comprobante + "');";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en insertar en la tabla de tbl_CuentaPorCobrar"); }
        }
        public int getNewId()
        {
            string sql = "SELECT COALESCE(MAX(pk_comprobante_cxc), 0) FROM tbl_CuentaPorCobrar;";
            int id = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el id de la tabla de tbl_CuentaPorCobrar"); }
            return id;
        }
        public int getNewIdVenta(string id_almacen)
        {
            string sql = "SELECT COALESCE(MAX(Pk_idVenta), 0) FROM tbl_venta where codigo_almacen = "+ id_almacen + ";";
            int id = 0;
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetValue(0).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el id de la tabla de tbl_CuentaPorCobrar"); }
            return id;
        }
        public List<string> queryReportw(string id_aplicacion)
        {
            List<string> datos = new List<string>();
            string sql = "SELECT ruta, estado FROM tbl_regreporteria WHERE aplicacion = " + id_aplicacion + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader.GetValue(1).ToString().ToLower().Equals("visible"))
                    {
                        datos.Add(reader.GetValue(0).ToString());
                    }
                    else
                    {
                        MessageBox.Show("El reporte esta con estado no visible");
                    }
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el reporte de la tabla de tbl_regreporteria"); }


            return datos;
        }
        public List<string> getAlmacenes()
        {
            List<string> datos = new List<string>();
            string sql = "SELECT pk_codigo_almacen, nombre_almacen FROM tbl_almacen WHERE estatus_almacen = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el almacen de la tabla de tbl_almacen"); }


            return datos;
        }
        public List<string> getTiposDePago()
        {
            List<string> datos = new List<string>();
            string sql = "SELECT pk_id_tipopago, nombre_tipopago FROM tbl_tipopago WHERE estado_tipopago = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los tipos de pago de la tabla de tbl_tipopago"); }
            return datos;
        }
        public List<string> getSaldoCliente(string id_cliente)
        {
            List<string> datos = new List<string>();
            string sql = "SELECT SActual_clientes, CargoMes_clientes, AbonosMes_clientes FROM tbl_clientes WHERE Pk_idClientes = " + id_cliente + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString()+"/"+ reader.GetValue(1).ToString() + "/" + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el saldo de los clientes de la tabla de tbl_clientes"); }
            return datos;
        }

        public List<string> getClientes(string id_cliente)
        {
            List<string> datos = new List<string>();


            string sql = "SELECT Nombres_clientes, Apellidos_clientes FROM tbl_clientes WHERE Pk_idClientes = " + id_cliente + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + " " + reader.GetValue(1).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los clientes de la tabla de tbl_clientes"); }
            return datos;
        }
        public List<string> getAllClientes()
        {
            List<string> datos = new List<string>();


            string sql = "SELECT Pk_idClientes, Nombres_clientes, Apellidos_clientes FROM tbl_clientes ;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + " "+ reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los clientes de la tabla de tbl_clientes"); }
            return datos;
        }
        public List<string> getMoneda()
        {
            List<string> datos = new List<string>();

            string sql = "SELECT pk_id_moneda, nombre_moneda, cambio_moneda FROM tbl_moneda WHERE estado_moneda = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener la moneda de la tabla de tbl_moneda"); }
            return datos;
        }
        public List<string> getConceptoXCobrar()
        {
            List<string> datos = new List<string>();

            string sql = "SELECT pk_id_concepto_cxc, descripcion_concepto_cxc, tipoconcepto_concepto_cxc FROM tbl_conceptocuentaporcobrar WHERE estado_concepto_cxc = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "/" + reader.GetValue(1).ToString() + "/" + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener los conceptos por cobrar de la tabla de tbl_conceptocuentaporcobrar"); }
            return datos;
        }
        public List<string> getVenta(string id_venta, string id_almacen)
        {
            List<string> datos = new List<string>();

            string sql = "SELECT fecha_venta, Total_venta, Pk_idClientes FROM tbl_venta WHERE Pk_idVenta = " + id_venta + " AND codigo_almacen = " + id_almacen + " AND Estado_fac_venta = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos.Add(reader.GetValue(0).ToString() + "-" + reader.GetValue(1).ToString() + "-" + reader.GetValue(2).ToString());
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener la venta de la tabla de tbl_venta"); }
            return datos;
        }

        public void updateAbonosClientes(string id_cliente, string saldo)
        {
            string sql = "UPDATE tbl_clientes SET AbonosMes_clientes = '"+saldo+"' WHERE (`Pk_idClientes` = "+id_cliente+");";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en actualizar en la tabla de tbl_clientes"); }
        }

        public void updateSaldoMensual(string id_cliente, string saldo)
        {
            string sql = "UPDATE tbl_clientes SET SActual_clientes = '" + saldo + "' WHERE (`Pk_idClientes` = " + id_cliente + ");";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en actualizar en la tabla de tbl_clientes"); }
        }

        public string[] getUltimoPago(string id_factura, string id_almacen)
        {
            string[] datos = new string[4];

            string sql = "SELECT fk_id_cliente, fecha_emision_cxc, monto_cobro_cxc, monto_pago_cxc FROM tbl_CuentaPorCobrar WHERE estado_cxc = 1 AND fk_id_factura = " + id_factura + " AND fk_id_almacen_venta = " + id_almacen + " ORDER BY pk_comprobante_cxc DESC LIMIT 1; ";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos[0] = reader.GetValue(0).ToString();
                    datos[1] = reader.GetValue(1).ToString();
                    datos[2] = reader.GetValue(2).ToString();
                    datos[3] = reader.GetValue(3).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el pago anterior de la tabla de tbl_CuentaPorCobrar"); }


            return datos;
        }

        public string[] queryPago(string id_comprobante)
        {
            string[] datos = new string[10];

            string sql = "SELECT * FROM tbl_CuentaPorCobrar WHERE pk_comprobante_cxc = " + id_comprobante + " AND estado_cxc = 1;";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    datos[0] = reader.GetValue(1).ToString()+"-"+ reader.GetValue(2).ToString();
                    datos[1] = reader.GetValue(3).ToString();
                    datos[2] = reader.GetValue(4).ToString();
                    datos[3] = reader.GetValue(5).ToString();
                    datos[4] = reader.GetValue(6).ToString();
                    datos[5] = reader.GetValue(7).ToString();
                    datos[6] = reader.GetValue(8).ToString();
                    datos[7] = reader.GetValue(9).ToString();
                    datos[8] = reader.GetValue(11).ToString();
                    datos[9] = reader.GetValue(12).ToString();
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el pago de la tabla de tbl_CuentaPorCobrar"); }
            return datos;
        }

        // Inicio de Estado Cuenta -------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader getid()
        {
            string sql = "select Pk_idClientes from tbl_clientes;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el nombre de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getNombre(string id_cliente)
        {
            string sql = "select Nombres_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el nombre de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getNit(string id_cliente)
        {
            string sql = "select nit_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el NIT de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getDpi(string id_cliente)
        {
            string sql = "select Dpi_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el DPI de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getTelefono(string id_cliente)
        {
            string sql = "select telefono_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Telefono de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getDireccion(string id_cliente)
        {
            string sql = "select direccion_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Direccion de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getAnterior(string id_cliente)
        {
            string sql = "select SActual_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Saldo Actual de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getCargo(string id_cliente)
        {
            string sql = "select CargoMes_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Cargo del Mes de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getAbono(string id_cliente)
        {
            string sql = "select AbonosMes_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Abono del Mes de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getCargos(string id_cliente)
        {
            string sql = "select CargosAcumulados_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Cargos Acumulados de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getAbonos(string id_cliente)
        {
            string sql = "select AbonosAcumulados_clientes from tbl_clientes where Pk_idClientes = '" + id_cliente + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener el Abonos Acumulados de la tabla tbl_clientes");
                return null;
            }
        }

        public void modificarsaldoscliente(string saldo1, string saldo2, string saldo3, string saldo4, string id_cliente)
        {
            string sql = "update tbl_clientes set SMesAnterior_clientes = '" + saldo1 + "', SActual_clientes = '" + saldo2 + "', CargoMes_clientes = '" + saldo2 + "', AbonosMes_clientes = '" + saldo2 + "', CargosAcumulados_clientes = '" + saldo3 + "', AbonosAcumulados_clientes = '" + saldo4 + "'  where(Pk_idClientes = '" + id_cliente + "');";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Balance Generado con Exito");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en actualizar el dato de la tabla tbl_clientes");
            }
        }

        // Fin de Estado Cuenta ----------------------------------------------------------------------------------------------------------------------------------

        // Inicio Venta ------------------------------------------------------------------------------------------------------------------------------------------

        public OdbcDataReader getNAlmacen()
        {
            string sql = "select  nombre_almacen from tbl_almacen;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener nombre de almacen de la tabla tbl_almacen");
                return null;
            }
        }

        public OdbcDataReader getidAlmacen(string nombre)
        {
            string sql = "select codigo_almacen from tbl_almacen where nombre_almacen = '" + nombre + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener id de almacen de la tabla tbl_almacen");
                return null;
            }
        }

        public OdbcDataReader getNMoneda()
        {
            string sql = "select nombre_moneda from tbl_moneda;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener nombre de moneda de la tabla tbl_moneda");
                return null;
            }
        }

        public OdbcDataReader getidMoneda(string nombre)
        {
            string sql = "select pk_id_moneda from tbl_moneda where nombre_moneda = '" + nombre + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener id de moneda de la tabla tbl_moneda");
                return null;
            }
        }

        public OdbcDataReader getNCliente()
        {
            string sql = "select Nombres_clientes from tbl_clientes;";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener id de cliente de la tabla tbl_clientes");
                return null;
            }
        }

        public OdbcDataReader getidCliente(string nombre)
        {
            string sql = "select Pk_idClientes from tbl_clientes where Nombres_clientes = '" + nombre + "';";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                OdbcDataReader leer = cmd.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + "\nError en obtener id de cliente de la tabla tbl_clientes");
                return null;
            }
        }

        // Fin de Venta ------------------------------------------------------------------------------------------------------------------------------------------


    }
}
