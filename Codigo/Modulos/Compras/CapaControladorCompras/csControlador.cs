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
        public void insertardatagrid(DataGridView tabla, string spk_id_detalle_orden_compra,
            string sfk_codigo_almacen, string sfk_id_orden_compra, string sfk_id_listado_productos,
            string scantidad_detalle_orden_compra, string scosto_unitario, TextBox total, TextBox cantidadtotal,
            GroupBox group)
        {
            double cantidad = Convert.ToDouble(scantidad_detalle_orden_compra);
            string[] datos = new string[7];
            datos[0] = spk_id_detalle_orden_compra;
            datos[1] = sfk_codigo_almacen;
            datos[2] = sfk_id_orden_compra;
            datos[3] = sfk_id_listado_productos;
            datos[4] = cantidad.ToString();
            double costo_unitario = Convert.ToDouble(scosto_unitario);
            datos[5] = scosto_unitario;
            datos[6] = (cantidad * costo_unitario).ToString();


            tabla.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4], datos[5], datos[6]);
            double suma = 0, suma2=0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                suma += Convert.ToDouble(row.Cells["total_detalle_orden_compra"].Value);
                total.Text = suma.ToString();

                suma2 += Convert.ToDouble(row.Cells["cantidad_detalle_orden_compra"].Value);
                cantidadtotal.Text = suma2.ToString();
            }
            limpiardetalle(group);






        }

        public void insertarbddetalle(DataGridView tabla)
        {

            if (tabla.Rows.Count > 1)
            {
                
                    for (int x = 0; x < tabla.Rows.Count - 1; x++)
                    {
                        string pk_id_detalle_orden_compra = tabla.Rows[x].Cells[0].Value.ToString();
                        string fk_codigo_almacen = tabla.Rows[x].Cells[1].Value.ToString();
                        string fk_id_orden_compra = tabla.Rows[x].Cells[2].Value.ToString();
                        string fk_id_listado_productos = tabla.Rows[x].Cells[3].Value.ToString();
                        string cantidad_detalle_orden_compra = tabla.Rows[x].Cells[4].Value.ToString();
                        string costo_unitario = tabla.Rows[x].Cells[5].Value.ToString();
                        string total_detalle_orden_compra = tabla.Rows[x].Cells[6].Value.ToString();

                        string consultadetallepe = "'" + pk_id_detalle_orden_compra + "', '" + fk_codigo_almacen + "', '" + fk_id_orden_compra + "', '" + fk_id_listado_productos + "', '" + cantidad_detalle_orden_compra + "', '" + costo_unitario + "', '" + total_detalle_orden_compra + "'";
                        string consultadetallepe_campos = "pk_id_detalle_orden_compra, fk_codigo_almacen, fk_id_orden_compra, fk_id_listado_productos, cantidad_detalle_orden_compra,costo_unitario, total_detalle_orden_compra";
                        sn.insertar(consultadetallepe, consultadetallepe_campos, "tbl_detalle_orden_compra");
                    }
                
                
                
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
        public void desbloqueartextbox(TextBox[] textbox)
        {
            for (int x = 0; x < textbox.Length; x++)
            {
                textbox[x].Enabled = true;
            }
        }
        public void limpiardetallee(GroupBox[] group)
        {
            limpiardetalle(group[0]);
            limpiardetalle(group[1]);

        }

        void limpiardetalle(GroupBox group)
        {


            foreach (Control c in group.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }

            }
        }

        public void eliminarfilagrid(DataGridView tabla, TextBox total, TextBox cantidadtotal, GroupBox group)
        {
            int fila = tabla.Rows.Count - 1;

            if (fila > 0 && tabla.CurrentRow.Index < fila)
            {
                
                tabla.Rows.RemoveAt(tabla.CurrentRow.Index);

                double suma = 0, suma2 =0;
                foreach (DataGridViewRow row in tabla.Rows)
                {
                    suma += Convert.ToDouble(row.Cells["total_detalle_orden_compra"].Value);
                    total.Text = suma.ToString();
                    suma2 += Convert.ToDouble(row.Cells["total_detalle_orden_compra"].Value);
                    cantidadtotal.Text = suma2.ToString();
                }

            }
            limpiardetalle(group);

        }
    }
}
