﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaControladorReporteria
{
    public class Controlador
    {

        CapaModeloReporteria.Sentencias sentencias = new CapaModeloReporteria.Sentencias();

        public DataTable MostrarReportes()
        {
            OdbcDataAdapter data = sentencias.DisplayReportes();
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }

        public int guardarReporte(String[] datosReporte)
        {
            string campos = "";
            //validamos si existen campos vacios
            for (int i = 0; i <= datosReporte.Length-1; i++)
            {
                if (datosReporte[i].Length < 1)
                {
                    MessageBox.Show("Existen campos que no pueden esatar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            //luego craemos una variable plana con todos los datos del arreglo para agregarlo al sql de guardar reporte
            for (int i = 0; i <= datosReporte.Length - 2; i++)
            {
                campos = campos +"'" +datosReporte[i] + "',";
            }
            campos = campos + "'"+datosReporte[datosReporte.Length-1]+"'";
            sentencias.registrarReporte(campos);
            return 1;
        }

        public int borrar_reporte(TextBox idReporte)
        {
            //se valida que el textbox no este vacio o con espacios en blanco
            if (string.IsNullOrEmpty(idReporte.Text))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //luego rectificamos que el usuario quiere barrar el reporte
            DialogResult result = MessageBox.Show("¿Desea eliminar el reporte #"+idReporte.Text+"?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                MessageBox.Show("No se borró el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            sentencias.eliminarReporte(idReporte.Text);
            return 1;
        }
        public void ModReporteria(string ruta, string nombre_archivo, string aplicacion, string estado, string id)
        {
            //esta variables nos sirven para que la ruta no salga con vasura
            string exc = @"\\";
            string orgn = @"\";
            ruta = ruta.Replace(orgn, exc);
            //aqui con los datos que recibimos de la capavista a hora la mandamos a la funicon ModificarReporte en sentencias.cs
            sentencias.ModificarReporte(ruta, nombre_archivo, aplicacion, estado, id);
        }
    }
}
