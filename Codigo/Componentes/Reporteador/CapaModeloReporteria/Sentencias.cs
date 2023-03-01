using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaModeloReporteria
{
    public class Sentencias
    {
        string tabla_reporteria = "tbl_regreporteria";
        Conexion conexion = new Conexion();

        public OdbcDataAdapter DisplayReportes()// metodo  que obtinene el contenio de la tabla reportes
        {
            string sql = "SELECT * FROM " + tabla_reporteria + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conexion.conexion());
            return dataTable;
        }

        public void registrarReporte(string datos)
        {
            //la variable campos es una variable plana donde se ponen los nombres de las columnas para guardar el reporte
            string campos = "ruta, nombre_archivo, aplicacion, estado";
            string sql = "insert into " + tabla_reporteria + "(" + campos + ") values (" + datos + ");";
            try
            {
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se pudo guardar el registro en la tabla " + tabla_reporteria);
            }
        }

        public void eliminarReporte(string id_reporte)
        {
            //funcion para eliminar el reporte seleccionado, donde se utiliza la tabla declarada globalmente y el numero de reporte que se pasa por parametro.
            try
            {
                string sql = "delete from " + tabla_reporteria + " where idregistro = " + id_reporte + "; ";
                OdbcCommand cmd = new OdbcCommand(sql, conexion.conexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString() + " \nNo se puede eliminar el registro "+id_reporte+" en la tabla "+tabla_reporteria);
            }
        }
    }
}
