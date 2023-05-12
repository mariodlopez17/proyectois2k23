using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
