using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CxPModelo
{
    public class TSentencia
    {
        Conexion con = new Conexion();

        public OdbcDataAdapter llenartabla(string tabla)
        {
            OdbcDataAdapter datatable = null;
            try
            {
                string sql = "select * from " + tabla + ";";
                 datatable = new OdbcDataAdapter(sql, con.conexion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex);
            }
           
            return datatable;
        }
        public OdbcDataAdapter llenarcamposEspecificos(string tabla, string campos, string condicion)
        {
            OdbcDataAdapter datatable = null;
            try
            {
                string sql = "select "+ campos +" from " + tabla + " where"+ condicion +";";
                datatable = new OdbcDataAdapter(sql, con.conexion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }

            return datatable;
        }

        public OdbcDataAdapter filtro(string tabla, string tipodato, string dato)
        {
            OdbcDataAdapter datatable = null;
            try
            {
                string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
                datatable = new OdbcDataAdapter(sql, con.conexion());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            

            return datatable;
        }

        public OdbcDataAdapter filtroproveedor(string tabla, string tipodato, string dato, string campos, string condicion)
        {
            OdbcDataAdapter datatable = null;
            try
            {
                string sql = "select "+ campos +" from " + tabla + " where " + tipodato + " like ('" + dato + "%') and "+ condicion  +";";
                datatable = new OdbcDataAdapter(sql, con.conexion());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


            return datatable;
        }

        public void actualizar(string dato, string condicion, string tabla)
        {
            try
            {
                string sql = "Update " + tabla + " " + dato + " where " + condicion;
                OdbcCommand cmd = new OdbcCommand(sql, con.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }


        }

        public void actualizartransaccion(string dato, string condicion, string tabla)
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

                    string sql = "Update " + tabla + " " + dato + " where " + condicion;           
                    command.CommandText = sql;
                    command.ExecuteNonQuery();

                    transaction.Commit();
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

        public List<string> queryReportw(string id_aplicacion)
        {
            List<string> datos = new List<string>();
            string sql = "SELECT ruta, estado FROM tbl_regreporteria WHERE aplicacion = " + id_aplicacion + ";";
            try
            {
                OdbcCommand command = new OdbcCommand(sql, con.conexion());
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
            catch (Exception ex) { Console.WriteLine(ex.Message.ToString() + " \nError en obtener el almacen de la tabla de tbl_almacen"); }


            return datos;
        }

    }
}
