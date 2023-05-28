using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPC_Vista
{
    public partial class Pcs_venta : Form
    {
        CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();
        public Pcs_venta()
        {
            InitializeComponent();
            llenarComboBox();
            cargarTablas();
            cargarFecha();
            bloquearBotones();
            limpiar();
        }
        private void limpiar()
        {
            txt_descuento.Text = "0";
        }
        private void bloquearBotones()
        {
            txt_factura.Enabled = false;
            txt_fecha_actual.Enabled = false;
            txt_fecha_vencimiento.Enabled = false;
            txt_moneda.Enabled = false;
            txt_cliente.Enabled = false;
            txt_iva.Enabled = false;
            txt_descuento.Enabled = false;
            txt_total.Enabled = false;
            txt_total.Text = "0";
            txt_guardar.Enabled = false;
            agregar.Enabled = false;
            quitar.Enabled = false;
        }

        private void cargarTablas()
        {
            DataTable data = controlador.MostrarProductos();
            tbl_productos.DataSource = data;
            tbl_productos.RowHeadersVisible = false;


            tbl_detalle_venta.Columns.Add("Columna1", "ID");
            tbl_detalle_venta.Columns.Add("Columna2", "Cantidad");
            tbl_detalle_venta.Columns.Add("Columna2", "Precio");
            tbl_detalle_venta.Columns.Add("Columna2", "Total");
        }

        private void cargarFecha()
        {
            DateTime fechaActual = DateTime.Now;
            txt_fecha_actual.Value = fechaActual;
        }

        private void generarId()
        {
            string[] infoAlmacen = txt_almacen.SelectedItem.ToString().Split('-');
            txt_factura.Text = controlador.getIdVentas(infoAlmacen[0]);
        }

        private void llenarComboBox()
        {
            controlador.llenarCbxAlmacen(txt_almacen);
            controlador.llenarCbxMoneda(txt_moneda);
            controlador.llenarCbxCliente(txt_cliente);
        }

        private void txt_almacen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_almacen.SelectedItem != null)
            {
                generarId();
                txt_moneda.Enabled = true;
                txt_cliente.Enabled = true;
                txt_descuento.Enabled = true;
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if (txt_moneda.SelectedItem != null && txt_cliente.SelectedItem != null)
            {
                bloquearBotones();
                agregar.Enabled = true;
                quitar.Enabled = true;
                txt_guardar.Enabled = true;
            }
        }
        private void CalcularTotal()
        {
            float total = 0;
            string[] infoMoneda = txt_moneda.SelectedItem.ToString().Split('-');
            foreach (DataGridViewRow row in tbl_detalle_venta.Rows)
            {
                total += float.Parse(row.Cells[3].Value.ToString());
            }
            total = total * float.Parse(infoMoneda[2]);
            txt_iva.Text = (total * 0.12).ToString();
            total = total;
            txt_total.Text = total.ToString();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            if (tbl_productos.RowCount > 0)
            {
                DataGridViewCell selectedCell = tbl_productos.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
                var value1 = selectedRow.Cells[0].Value.ToString();
                var value2 = selectedRow.Cells[2].Value.ToString();
                string cantidadStr = Interaction.InputBox("Ingrese una cantidad:", "Cantidad", "");

                // Validar si se ingresó una cantidad
                if (!string.IsNullOrEmpty(cantidadStr))
                {
                    if (float.TryParse(cantidadStr, out float cantidad))
                    {
                        if (cantidad <= float.Parse(selectedRow.Cells[3].Value.ToString()))
                        {
                            float value3 = float.Parse(value2) * cantidad;

                            newRow.Cells[0].Value = value1;
                            newRow.Cells[1].Value = cantidad.ToString();
                            newRow.Cells[2].Value = value2;
                            newRow.Cells[3].Value = value3.ToString();
                            float nuevaCantidad = float.Parse(selectedRow.Cells[3].Value.ToString()) - cantidad;
                            selectedRow.Cells[3].Value = nuevaCantidad;

                            bool idExistente = false;
                            int filaExistenteIndex = -1;

                            foreach (DataGridViewRow row in tbl_detalle_venta.Rows)
                            {
                                string idExistenteStr = row.Cells[0].Value.ToString();
                                if (idExistenteStr == value1)
                                {
                                    idExistente = true;
                                    filaExistenteIndex = row.Index;
                                    break;
                                }
                            }

                            if (idExistente)
                            {
                                DataGridViewRow filaExistente = tbl_detalle_venta.Rows[filaExistenteIndex];
                                float cantidadExistente = float.Parse(filaExistente.Cells[1].Value.ToString());
                                float totalExistente = float.Parse(filaExistente.Cells[3].Value.ToString());
                                float nuevaCantidadExistente = cantidadExistente + cantidad;
                                float nuevoTotalExistente = totalExistente + (float.Parse(value2) * cantidad);
                                filaExistente.Cells[1].Value = nuevaCantidadExistente.ToString();
                                filaExistente.Cells[3].Value = nuevoTotalExistente.ToString();
                            }
                            else
                            {
                                tbl_detalle_venta.Rows.Add(newRow);
                            }
                            //calcular total
                            CalcularTotal();

                        }
                        else
                        {
                            MessageBox.Show("Las existencias son insuficientes para lo que pide.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cantidad ingresada no es válida.");
                    }
                }
                else
                {
                    MessageBox.Show("No se ingresó ninguna cantidad.");
                }
            }

        }

        private void quitar_Click(object sender, EventArgs e)
        {
            if (tbl_detalle_venta.SelectedRows.Count > 0)
            {
                DataGridViewCell selectedCell = tbl_productos.SelectedCells[0];
                DataGridViewRow selectedRow = selectedCell.OwningRow;
                var value1 = selectedRow.Cells[0].Value.ToString();
                var value2 = selectedRow.Cells[2].Value.ToString();
                var value3 = selectedRow.Cells[1].Value.ToString();

                // Devolver las existencias a tbl_productos
                foreach (DataGridViewRow row in tbl_productos.Rows)
                {
                    if (row.Cells[0].Value.ToString() == value1)
                    {
                        float existenciaProducto = float.Parse(row.Cells[3].Value.ToString());
                        float cantidadQuitar = float.Parse(value3);
                        float nuevaExistencia = existenciaProducto + cantidadQuitar;
                        row.Cells[3].Value = nuevaExistencia.ToString();
                        break;
                    }
                }

                // Eliminar la fila seleccionada de tbl_detalle_venta
                tbl_detalle_venta.Rows.Remove(selectedRow);

                // Recalcular el total
                CalcularTotal();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna fila para quitar.");
            }
        }

        private void txt_guardar_Click(object sender, EventArgs e)
        {
            if (float.Parse(txt_descuento.Text) <= float.Parse(txt_total.Text) 
                && txt_almacen.SelectedIndex != null && txt_moneda.SelectedIndex != null)
            {
                List<string> encabezado = new List<string>();
                string[] infoAlmacen = txt_almacen.SelectedItem.ToString().Split('-');
                string[] infoMoneda = txt_moneda.SelectedItem.ToString().Split('-');
                string[] infCliente = txt_cliente.SelectedItem.ToString().Split('-');
                txt_total.Text = (float.Parse(txt_total.Text) - float.Parse(txt_descuento.Text)).ToString();

                DateTime now = DateTime.Now;
                DateTime fechaSumada = now.AddDays(90);
                string fechaFormateada = fechaSumada.ToString("yyyy-MM-dd");
                string fechaMysql = now.ToString("yyyy-MM-dd HH:mm:ss");

                encabezado.Add(txt_factura.Text);
                encabezado.Add(infoAlmacen[0]);
                encabezado.Add(fechaMysql);
                encabezado.Add(txt_descuento.Text);
                encabezado.Add(txt_iva.Text);
                encabezado.Add(txt_total.Text);
                encabezado.Add("1");
                encabezado.Add(fechaFormateada);
                encabezado.Add(infoAlmacen[0]);
                encabezado.Add(infCliente[0]);
                encabezado.Add(infoAlmacen[0]+ txt_factura.Text);
                encabezado.Add(infoAlmacen[0]+ txt_factura.Text);
                encabezado.Add(infoAlmacen[0]+ txt_factura.Text);
                List<string> detalle = new List<string>();
                List<string> existencias = new List<string>();
                foreach (DataGridViewRow row in tbl_detalle_venta.Rows)
                {
                    detalle.Add("("+infoAlmacen[0]+","+ txt_factura.Text + "," + txt_factura.Text + "," +
                        row.Cells[0].Value.ToString() + "," + row.Cells[1].Value.ToString() + "," + row.Cells[2].Value.ToString() + "," +
                        row.Cells[3].Value.ToString() +" , 1)");
                    existencias.Add(row.Cells[0].Value.ToString() + "-"+ row.Cells[1].Value.ToString());
                }
                controlador.registrarVenta(encabezado, detalle);
                controlador.actualizarSaldoVenta(infCliente[0], txt_total.Text);
                controlador.actualizarExistencias(existencias);
            }
        
        }
    }
}
