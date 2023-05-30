using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Windows;

namespace CxPModelo
{
    public class JSentencia
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenarTablaFactura(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            //string sql = "SELECT PkId_Cotizaciones as IdCotizaciones ,fk_codigo_producto as IdProducto,FkId_Vendedores as IdVendedores,FkId_Clientes as IdClientes, Descripcion_Cotizaciones as Descripcion,FechaEmision_Cotizaciones as FechaEmision,FechaVencimiento_Cotizaciones  as FechaVencimiento,Cuotas_Cotizaciones as Cuota,Total_Cotizaciones as Total FROM " + tabla + "  ;";
            string sql = "SELECT pk_id_factura as IdFactura, pk_id_almacen as IdAlmacen, pk_id_proveedor as IdProveedor, fecha_emision_factura as FechaEmision, fecha_vencimiento_factura as FechaVencimiento, total_factura as TotalFactura, estatus_factura as Estado FROM " + tabla;
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenartablaAlmacen(string tabla)
        {
            string sql = "select pk_codigo_almacen as ID, nombre_almacen as Nombre from " + tabla;
            /*string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');"; */
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }

        public OdbcDataAdapter llenartablaProveedor(string tabla)
        {
            string sql = "select pk_id_proveedor as ID, nombre_proveedor as Nombre from " + tabla;
            /*string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');"; */
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }


        public void actualizartransaccion(string dato, string tipo, string tabla, string datocxp, string proveedor)
        {

            OdbcCommand command = new OdbcCommand();
            OdbcTransaction transaction = null;
            OdbcConnection conn = con.connection;
            command.Connection = conn;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command.Connection = conn;
                command.Transaction = transaction;

                string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
                command.CommandText = sql;
                command.ExecuteNonQuery();

                

                string sqlcxp = "Insert into tbl_cuentaporpagar(pk_id_cuentaporpagar, pk_id_almacen, pk_id_proveedor, pk_id_factura, fk_id_tipopago, fk_id_moneda, fk_id_conceptocuentaporpagar, cambio_moneda_cuentaporpagar, fecha_emision_cuentaporpagar, fecha_movimiento_cuentaporpagar, saldo_pago_cuentaporpagar, monto_pago_cuentaporpagar, estado_cuentaporpagar ) values ( " + datocxp + " );";
                command.CommandText = sqlcxp;
                command.ExecuteNonQuery();

                
                command.CommandText = proveedor;
                command.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Realizado con Exito");
                Console.WriteLine("guardado en base de datos");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {

                    transaction.Rollback();
                }
                catch
                {

                }
                finally 
                {
                    conn.Close();
                }
            }


        }


        public void eliminardatos(string idfactura, string idproveedor, string idalmacen, string proveedor)
        {

            OdbcCommand command = new OdbcCommand();
            OdbcTransaction transaction = null;
            OdbcConnection conn = con.connection;
            command.Connection = conn;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command.Connection = conn;
                command.Transaction = transaction;

                command.CommandText = proveedor;
                command.ExecuteNonQuery();

                string sqlcxp = "delete from tbl_CuentaPorPagar where pk_id_factura = " + idfactura + " and pk_id_proveedor = " + idproveedor + " and pk_id_almacen = " + idalmacen + " ;";
                command.CommandText = sqlcxp;
                command.ExecuteNonQuery();

                string sql = "delete from tbl_factura where pk_id_factura = " + idfactura + " and pk_id_proveedor = " + idproveedor + " and pk_id_almacen = " + idalmacen + " ;";
                //string sql = "delete from " + tabla + "(" + tipo + ") values (" + dato + ")";

                command.CommandText = sql;
                command.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Datos eliminados");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {

                    transaction.Rollback();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }


        }

        public void eliminardatoscxp(int clave, string campo, string tabla)
        {

            OdbcCommand command = new OdbcCommand();
            OdbcTransaction transaction = null;
            OdbcConnection conn = con.connection;
            command.Connection = conn;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction();
                command.Connection = conn;
                command.Transaction = transaction;

                 string sqlcxp = "delete from " + tabla + " where " + campo + "=" + clave + ";";
                 command.CommandText = sqlcxp;
                 command.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("Datos eliminados");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                try
                {

                    transaction.Rollback();
                }
                catch
                {

                }
                finally
                {
                    conn.Close();
                }
            }


        }

        public int estadotabla(string tabla)
        {
            int dato = 0;
            string sql = "select count(*) as total from " + tabla;
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetInt32(0);


            }
            return dato;
        }
        public string buscarid(string tabla, string tipo)
        {
            string dato = " ";
            try
            {

                string sql = "select " + tipo + " from " + tabla + " Order by " + tipo + " Desc Limit 1";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato = lr.GetString(0);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }

        
            public string[] datosProveedor(string idproveedor)
        {
            string[] dato = new string[2];
            try
            {

                string sql = "select saldo_actual_proveedor, cargo_del_mes_proveedor from tbl_proveedor where pk_id_proveedor =  " + idproveedor + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato[0] = lr.GetString(0);
                    dato[1] = lr.GetString(1);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }

        public OdbcDataAdapter llenartablaAlmacen2(string almacen)
        {
            string sql = "select pk_codigo_almacen from tbl_almacen where pk_codigo_almacen= " + almacen + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public OdbcDataAdapter llenartablaProveedor2(string proveedor)
        {
            string sql = "select pk_id_proveedor from tbl_proveedor where pk_id_proveedor= " + proveedor + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
    }
}
