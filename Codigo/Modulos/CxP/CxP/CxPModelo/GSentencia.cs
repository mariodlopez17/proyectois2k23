using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CxPModelo
{
    public class GSentencia
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenarmitabla(string tabla,string idProveedor)
        {
            string sql = "select * from " + tabla + " where pk_id_proveedor = "+idProveedor+";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartabla2(string tabla)
        {
            string sql = "select * from " + tabla + ";";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartabla(string idProveedor)
        {
            string sql = "SELECT tbl_proveedor.nombre_proveedor FROM tbl_factura INNER JOIN tbl_proveedor ON " + idProveedor + " = tbl_proveedor.pk_id_proveedor; ";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }
        public OdbcDataAdapter llenartabla3(string idFactura, string proveedor, string almacen)
        {
            string sql = "select pk_id_cuentaporpagar,pk_id_almacen,pk_id_proveedor,pk_id_factura,DATE_FORMAT(fecha_emision_cuentaporpagar, '%Y-%m-%d'),saldo_pago_cuentaporpagar,monto_pago_cuentaporpagar from tbl_cuentaporpagar where pk_id_factura = " + idFactura + " and pk_id_almacen= " + almacen + " and pk_id_proveedor= " + proveedor + " ;";
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;
        }

        public void actualizartransaccion(string sql1, string sql2)
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


                command.CommandText = sql1;
                command.ExecuteNonQuery();



                command.CommandText = sql2;
                command.ExecuteNonQuery();

                transaction.Commit();
                Console.WriteLine("guardado en base de datos");
                MessageBox.Show("Realizado con Exito");
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
        public string tipomoneda(int id)
        {
            string dato = " ";
            string sql = "select  tipoconcepto_conceptocuentaporpagar from tbl_conceptocuentaporpagar where pk_id_conceptocuentaporpagar = '" + id + "' ;";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetString(0);


            }
            return dato;
        }



        public string idMoneda(string factura, string almacen, string proveedor)
        {
            string dato = " ";
            string sql = "select fk_id_conceptocuentaporpagar from tbl_cuentaporpagar where pk_id_factura = " + factura + " and pk_id_almacen= " + almacen + " and pk_id_proveedor= " + proveedor + " ;";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetString(0);

            }
            return dato;
        }

        public string[] datosProveedor(string idproveedor)
        {
            string[] dato = new string[4];
            try
            {

                string sql = "select saldo_mes_anterior_proveedor, saldo_actual_proveedor, cargo_del_mes_proveedor, abonos_del_mes_proveedor from tbl_proveedor where pk_id_proveedor =  " + idproveedor + " ;";
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                OdbcDataReader lr = cmd.ExecuteReader();
                while (lr.Read())
                {
                    dato[0] = lr.GetString(0);
                    dato[1] = lr.GetString(1);
                    dato[2] = lr.GetString(2);
                    dato[3] = lr.GetString(3);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }


            return dato;
        }

        public string TipoConcepto(string id)
        {
            string dato = " ";
            string sql = "select tipoconcepto_conceptocuentaporpagar from tbl_conceptocuentaporpagar where pk_id_conceptocuentaporpagar = " + id + " ;";
            OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
            OdbcDataReader lr = cmd.ExecuteReader();
            while (lr.Read())
            {

                dato = lr.GetString(0);

            }
            return dato;
        }


    }
}
