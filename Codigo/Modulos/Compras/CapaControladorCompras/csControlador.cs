using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloCompras;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;

namespace CapaControladorCompras
{
    public class csControlador
    {
        Sentencias sn = new Sentencias();
        private static string ids;
        public string IDS
        {
            get { return ids; }
            set { ids = value; }
        }
        public void ingresar(string[] tipos, string[] datos, string tabla)//Crea cadenas de datos para la insercion
        {
            try
            {
                string dato = " ";
                string tipo = " ";
                for (int x = 0; x < datos.Length; x++)
                {

                    if (x == datos.Length - 1)
                    {
                        dato += "'" + datos[x] + "'";
                        tipo += tipos[x];
                    }
                    else
                    {
                        dato += "'" + datos[x] + "',";
                        tipo += tipos[x] + ",";
                    }

                }
                sn.insertar(dato, tipo, tabla);

                MessageBox.Show("Dato Insertado");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }

        }
        public void actualizar(string[] tipos, string[] datos, string tabla, TextBox id)//Crea cadenas de datos para la actualizacion
        {
            try
            {
                string dato = " ";
                string condicion = "(" + id.Tag.ToString() + " = '" + id.Text + "')";

                for (int x = 1; x < tipos.Length; x++)
                {

                    if (x == tipos.Length - 1)
                    {
                        dato += " " + tipos[x] + " = '" + datos[x] + "' ";

                    }
                    else if (x == 1)
                    {
                        dato += "SET " + tipos[x] + " = '" + datos[x] + "', ";

                    }
                    else
                    {
                        dato += " " + tipos[x] + " = '" + datos[x] + "', ";

                    }

                }
                sn.actualizar(dato, condicion, tabla);

                MessageBox.Show("Dato actualizado");

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }



        }
        //------------------------------------
        public void llenartxt(string tabla, TextBox[] textbox)
        {
            try
            {
                string condicion = " where " + textbox[0].Tag.ToString()+" = '"+textbox[0].Text+"' ;";
                OdbcDataAdapter dt = sn.llenartabla(tabla,condicion);
                DataTable table = new DataTable();
                dt.Fill(table);
                int longitud = textbox.Length;
                int contador = 0;

                    for(int x = 0; x < longitud; x++)
                    {
                        textbox[x].Text = table.Rows[contador][x].ToString();

                    }
                


            }
            catch (Exception e)
            {
                MessageBox.Show(" " + e);
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

        public void llenartablaa(string ntabla, DataGridView tabla)//Funcion para llenar tabla
        {
            try
            {
                OdbcDataAdapter dt = sn.llenartabla(ntabla);
                DataTable table = new DataTable();
                dt.Fill(table);
                tabla.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:" + e);
            }

        }

        public void vaciartextbox(TextBox[] textbox)
        {
            for(int x = 0; x < textbox.Length; x++)
            {
                textbox[x].Clear();
            }
        }

        public void bloqueartextbox(TextBox[] textbox)
        {
            for (int x = 0; x < textbox.Length; x++)
            {
                textbox[x].Enabled=false;
            }
        }
    }
}
