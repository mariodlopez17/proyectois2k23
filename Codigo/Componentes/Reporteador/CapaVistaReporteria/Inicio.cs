using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel;
using System.Windows.Forms;


namespace CapaVistaReporteria
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            cargarCategorias();
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
                 
            OpenFileDialog v1 = new OpenFileDialog();
            v1.Filter = "All files (*.*)|*.*";
            if (v1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = v1.FileName;
                string[] separatingStrings = { "\\" };
                string text = textBox1.Text;
                string[] words = text.Split(separatingStrings, System.StringSplitOptions.RemoveEmptyEntries);
                string db = "";
                Boolean ruta = false;
                for (int i = 0; i < words.Length; i++)
                {
                    if (ruta)
                    {
                        if (i < words.Length - 1)
                        {
                            db += words[i] + '\\';
                        }
                        else
                        {
                            db += words[i];
                        }
                    }
                    if (words[i].Equals("Reportes"))
                    {
                        ruta = true;
                    }
                }
                textBox1.Text = db;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }

        private void btn_ver_reporte_Click(object sender, EventArgs e)
        {
        }
        void GridFill()
        {

        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
        }

        void Clear()
        {
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabla_registro_DoubleClick(object sender, EventArgs e)
        {
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }

        private void cargarCategorias()
        {
            
        }
    }
}
