using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CxPModelo;
using System.Data;

namespace CxPControlador
{
    public class TControlador
    {
        TSentencia sn = new TSentencia();
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();

        void llenartablaProveedores(string ntabla, DataGridView tabla, string campos, string condicion)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenarcamposEspecificos(ntabla, campos, condicion);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenarfiltro(string ntabla, DataGridView tabla, string tipo, string dato)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.filtro(ntabla, tipo, dato);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

         void llenarfiltroproveedores(string ntabla, DataGridView tabla, string tipo, string dato, string condicion, string campos)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.filtroproveedor(ntabla, tipo, dato, campos, condicion);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void llenardatosproveedorfiltro(string ntabla, DataGridView tabla, string tipo, string dato)
        {
            string campos = "pk_id_proveedor as Id, nombre_proveedor as Nombre, " +
                "saldo_mes_anterior_proveedor as SaldoMesAnterior, saldo_actual_proveedor as SaldoActual, " +
                "cargo_del_mes_proveedor as CargosDelMes, abonos_del_mes_proveedor as AbonosDelMes, " +
                "cargos_acumulados_proveedor as CargosAcumulados, abonos_acumulados_proveedor as AbonosAcumulados";
            string condicion = " estado_proveedor = 1";
            llenarfiltroproveedores(ntabla, tabla, tipo, dato, condicion,campos);
        }

        public void llenardatosproveedor(string ntabla, DataGridView tabla)
        {
            string campos = "pk_id_proveedor as Id, nombre_proveedor as Nombre, " +
                "saldo_mes_anterior_proveedor as SaldoMesAnterior, saldo_actual_proveedor as SaldoActual, " +
                "cargo_del_mes_proveedor as CargosDelMes, abonos_del_mes_proveedor as AbonosDelMes, " +
                "cargos_acumulados_proveedor as CargosAcumulados, abonos_acumulados_proveedor as AbonosAcumulados";
            string condicion = " estado_proveedor = 1";
            llenartablaProveedores(ntabla, tabla, campos, condicion);
        }

        public void balance(DataGridView tabla)
        {
            string[] campos = new string[6] { "saldo_mes_anterior_proveedor", "saldo_actual_proveedor", "cargo_del_mes_proveedor", "abonos_del_mes_proveedor", "cargos_acumulados_proveedor", "abonos_acumulados_proveedor" };
            string[] datos = new string[6];
            for (int fila = 0; fila < tabla.RowCount - 1; fila++)
            {
                double cargoMes = Convert.ToDouble(tabla.Rows[fila].Cells[4].Value);
                double abonoMes = Convert.ToDouble(tabla.Rows[fila].Cells[5].Value);
                double saldoActual = Convert.ToDouble(tabla.Rows[fila].Cells[3].Value);
                double saldoAnterior = Convert.ToDouble(tabla.Rows[fila].Cells[2].Value);
                double CargosAcumulados = Convert.ToDouble(tabla.Rows[fila].Cells[6].Value);
                double AbonosAcumulados = Convert.ToDouble(tabla.Rows[fila].Cells[7].Value);
                string id = tabla.Rows[fila].Cells[0].Value.ToString();
               
                   
                    
                 datos[0] = saldoActual.ToString();
                 datos[1] = saldoActual.ToString();
                 datos[2] = "0";
                 datos[3] = "0";
                 datos[4] = (CargosAcumulados + cargoMes).ToString();
                 datos[5] = (AbonosAcumulados + abonoMes).ToString();
                 string condicion = " pk_id_proveedor = "+ id + " ;";
                
                actualizacion(campos, datos, condicion, "tbl_Proveedor");
                    llenardatosproveedor("tbl_Proveedor", tabla);
                
                
                



            }
            cnseg.setBtitacora("5102", "Balance general proveedores");
        }

      void actualizacion(string[] campo, string[] dato, string condicion, string tabla)
        {
            string datos = " ";
            for (int x = 0; x < campo.Length ; x++)
            {

                if (x == campo.Length - 1)
                {
                    datos += " " + campo[x] + " = '" + dato[x] + "' ";

                }
                else if (x == 0)
                {
                    datos += "SET " + campo[x] + " = '" + dato[x] + "', ";

                }
                else
                {
                    datos += " " + campo[x] + " = '" + dato[x] + "', ";

                }

            }

            sn.actualizartransaccion(datos, condicion, tabla);
        }

        public void displayReporte(string id_aplicacion)
        {
            List<string> reporte = sn.queryReportw(id_aplicacion);
            foreach (string path in reporte)
            {
                CapaVistaReporteria.visualizar b = new CapaVistaReporteria.visualizar(path);
                b.Show();
            }
        }

    }
}
