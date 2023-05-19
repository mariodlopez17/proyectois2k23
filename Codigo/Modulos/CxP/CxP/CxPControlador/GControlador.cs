using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxPModelo;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CxPControlador
{
    public class GControlador
    {
        GSentencia sn = new GSentencia();
        private static double ids;
        public double IDS
        {
            get { return ids; }
            set { ids = value; }
        }
        public void llenartablaa2(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla2(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public void llenartablaa(DataGridView tabla, string idProveedor)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(idProveedor);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }
        public string[] llenartabla3(string idFactura, string proveedor, string almacen)//Funcion para llenar tabla
        {
            string[] datos = new string[7];
            try
            {
                OdbcDataAdapter dt = sn.llenartabla3(idFactura, proveedor, almacen);
                DataTable table = new DataTable();
                dt.Fill(table);
                for (int x = 0; x < datos.Length; x++)
                {
                    datos[x] = table.Rows[table.Rows.Count - 1][x].ToString();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
            return datos;
        }

        string ingresar(TextBox[] textbox, string tabla)//Crea cadenas de datos para la insercion
        {
            string dato = " ";
            string tipo = " ";
            for (int x = 0; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += "'" + textbox[x].Text + "'";
                    tipo += textbox[x].Tag.ToString();
                }
                else
                {
                    dato += "'" + textbox[x].Text + "',";
                    tipo += textbox[x].Tag.ToString() + ",";
                }

            }

            string sql = "insert into " + tabla + "(" + tipo + ") values (" + dato + ")";
            return sql;
        }


        string actualizar(TextBox[] textbox, string tabla)//Crea cadenas de datos para la actualizacion
        {//Crea cadenas de datos para la actualizacion


            string dato = " ";
            string condicion = textbox[0].Tag.ToString() + " = " + textbox[0].Text;

            for (int x = 1; x < textbox.Length; x++)
            {

                if (x == textbox.Length - 1)
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "' ";

                }
                else if (x == 1)
                {
                    dato += "SET " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }
                else
                {
                    dato += " " + textbox[x].Tag.ToString() + " = '" + textbox[x].Text + "', ";

                }

            }

            string sql = "Update " + tabla + " " + dato + " where " + condicion;



            return sql;

        }



        string actualizar2(string cargo, string abono, string proveedor)//Crea cadenas de datos para la actualizacion
        {//Crea cadenas de datos para la actualizacion
            string sql = "Update tbl_proveedor set cargo_del_mes_proveedor = " + cargo + " , abonos_del_mes_proveedor = " + abono + " where  pk_id_proveedor = " + proveedor;

            return sql;

        }

        public void operacionCxP(TextBox[] textbox, string tabla, double[] montos, string idProveedor)
        {
            string sql = "";
            double nuevoSaldo = 0;

            if (IDS == 0)
            {

                sql = actualizar(textbox, tabla);
            }
            else if (IDS > 0)
            {
                sql = ingresar(textbox, tabla);
            }

            string cambioProveedor = actualizar2(montos[0].ToString(), montos[1].ToString(), idProveedor);
            MessageBox.Show("sql: " + sql);
            MessageBox.Show("Cambio proveedor: " + cambioProveedor);
            MessageBox.Show("IDS: " + IDS);
            sn.actualizartransaccion(sql, cambioProveedor);
        }


        public void crearid(TextBox textbox, string tabla, string codigo, string campo)//Crea el id siguiente a ingresar
        {

            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox.Text = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox.Text = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }
        public void Inicio(TextBox id, TextBox fecha, TextBox[] group)
        {
            limpiar(group);
            crearid(id, "tbl_cuentaporpagar", " ", "pk_id_cuentaporpagar");
            IDS = -1;
            fecha.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");


        }
        void limpiar(TextBox[] group)
        {


            for (int x = 0; x < group.Length; x++)
            {
                group[x].Clear();

            }
        }

        public double operacionConcepto(double[] montos, string factura, string almacen, string proveedor)
        {
            double saldoactual = 0;
            string idMoneda = sn.idMoneda(factura, almacen, proveedor);
            string tipo = sn.tipomoneda(Convert.ToInt32(idMoneda));
            if (montos[1] != 0)
            {
                //suma
                if (tipo.Equals("cargo", StringComparison.OrdinalIgnoreCase))
                {
                    saldoactual = montos[0] + montos[1];
                }
                //resta
                else if (tipo.Equals("abono", StringComparison.OrdinalIgnoreCase))
                {
                    saldoactual = montos[0] - montos[1];
                }

            }


            return saldoactual;
        }

    }
}
