using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CxPModelo;
using System.Data.Odbc;
using System.Data;
using System.Windows;
using System.Windows.Forms;

namespace CxPControlador
{
    public class JControlador
    {
        JSentencia sn = new JSentencia();
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        public void fillTableFactura(string ntabla, DataGridView tabla)
        {
            //llenamos nuestro dataTable, entre consulta y el datagridview

            try
            {
                OdbcDataAdapter dt = sn.llenarTablaFactura(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }
        }

        public void ingresar(TextBox[] textbox, DataGridView tabla)//Crea cadenas de datos para la insercion
        {
            try
            {
                string dato = " ";
                string tipo = " ";
                string datocxp = ingresarcxp(textbox);
                string proveedor = ingresarcambiosfactura(textbox);

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
                //sn.insertar(dato, tipo, tabla.Tag.ToString());
    
                sn.actualizartransaccion(dato, tipo, tabla.Tag.ToString(), datocxp, proveedor );
                cnseg.setBtitacora("5103", "Ingreso Factura");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

         string ingresarcxp(TextBox[] textbox)//Crea cadenas de datos para la insercion
        {
                string dato;
            //string tipo = " ";
            string idcxp = crearidwo("tbl_cuentaporpagar", "pk_id_cuentaporpagar");
            dato = " "+ idcxp + " , " + textbox[1].Text + " , " + textbox[2].Text + " , " + textbox[0].Text + " , 1, 1, 1, 1 " + " , '" + textbox[5].Text + "' , '" + textbox[5].Text + "' , " + textbox[3].Text + " , 0, 1 ";

                return dato;

        }
        public string ingresarcambiosfactura(TextBox[] textbox)//Crea cadenas de datos para la insercion
        {
            string sql;
            string idProveedor = textbox[2].Text;
            string[] datosProveedor = sn.datosProveedor(idProveedor);

            double nuevosaldo = Convert.ToDouble(datosProveedor[0]) + Convert.ToDouble(textbox[3].Text);
            double nuevocargo = Convert.ToDouble(datosProveedor[1]) + Convert.ToDouble(textbox[3].Text);


            sql = "Update tbl_proveedor Set saldo_actual_proveedor = " + nuevosaldo + ", cargo_del_mes_proveedor = " + nuevocargo + " where pk_id_proveedor = " + idProveedor + " ;";
            return sql;

        }

        public string ingresarcambiosfactura2(TextBox[] textbox)//Crea cadenas de datos para la insercion
        {
            string sql;
            string idProveedor = textbox[2].Text;
            string[] datosProveedor = sn.datosProveedor(idProveedor);

            double nuevosaldo = Convert.ToDouble(datosProveedor[0]) - Convert.ToDouble(textbox[3].Text);
            double nuevocargo = Convert.ToDouble(datosProveedor[1]) - Convert.ToDouble(textbox[3].Text);


            sql = "Update tbl_proveedor Set saldo_actual_proveedor = " + nuevosaldo + ", cargo_del_mes_proveedor = " + nuevocargo + " where pk_id_proveedor = " + idProveedor + " ;";
            return sql;

        }

        public void fillTableAlmacen(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablaAlmacen(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }


        } //Fin codigo Almacen


        public void fillTableProveedor(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartablaProveedor(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        } //Fin codigo Proveedor


 

        public void limpiarTextbox(TextBox[] textBoxes)//Metodo para limpiar textbox
        {
            for (int x = 0; x < textBoxes.Length; x++)
            {
                textBoxes[x].Clear();
            }
        }

        public void inicio(TextBox id, Button ayudafact, DateTimePicker emision, DateTimePicker vencimiento, TextBox almacen, TextBox proveedor, TextBox estado, TextBox fecha, TextBox fechaVencimiento,TextBox total)
        {
           /* emision.Enabled = false;
            almacen.Enabled = false;
            proveedor.Enabled = false;
            estado.Enabled = false;
            fecha.Enabled = false;
            total.Enabled = false;*/

            emision.Enabled = false;
            almacen.Enabled = false;
            vencimiento.Enabled = false;
            proveedor.Enabled = false;
            estado.Enabled = false;
            fecha.Enabled = false;
            fechaVencimiento.Enabled = false;
            total.Enabled = false;
            ayudafact.Enabled = false;

            id.Enabled = false;

            //crearid(id, "tbl_Producto","p");
            crearid(id, "tbl_factura", " ", "pk_id_factura");
            crearidwo("tbl_cuentaporpagar", "pk_id_cuentaporpagar");


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

        public string crearidwo(string tabla, string campo)//Crea el id para tbl_cuentasPorPagar
        {
            string textbox = "";
            try
            {
                int incremento = 0;

                int permiso = comprobacionvacio(tabla);
                if (permiso != 0)
                {
                    string resultado = sn.buscarid(tabla, campo);
                    incremento = Convert.ToInt32(resultado) + 1;
                    textbox = incremento.ToString();
                }
                else
                {
                    incremento = 1;
                    textbox = incremento.ToString();
                }



            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            return textbox;
        }
        public int comprobacionvacio(string tabla)
        {
            int resultado = 0;
            resultado = sn.estadotabla(tabla);

            return resultado;
        }


        /*-----------BOTON BORRAR----------*/

        public void  delete(TextBox[] textbox, DataGridView tabla)
        {
            try
            {
                string sqlProveedor = ingresarcambiosfactura2(textbox);
                sn.eliminardatos(textbox[0].Text, textbox[2].Text, textbox[1].Text, sqlProveedor);
                cnseg.setBtitacora("5103", "Eliminar Factura");


            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }

       
        public string[] llenartablaAlmacen2(string almacen)//Funcion para llenar tabla
        {
            string[] datos = new string[1];
            try
            {
                OdbcDataAdapter dt = sn.llenartablaAlmacen2(almacen);
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
        public string[] llenartablaProveedor2(string almacen)//Funcion para llenar tabla
        {
            string[] datos = new string[1];
            try
            {
                OdbcDataAdapter dt = sn.llenartablaProveedor2(almacen);
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


    }
}
