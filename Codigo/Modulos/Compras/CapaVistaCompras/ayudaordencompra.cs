﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladorCompras;
namespace CapaVistaCompras
{
    public partial class ayudaordencompra : Form
    {
        csControlador cn = new csControlador();
        string table, ttipo;
        public ayudaordencompra(string tabla, string tipo)
        {
            InitializeComponent();
            table = tabla;
            ttipo = tipo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null)
            {


                cn.IDS = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                this.Close();



            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn.llenarfiltro(table, dataGridView1, ttipo, textBox1.Text);
        }

        private void ayudaordencompra_Load(object sender, EventArgs e)
        {
            cn.llenartablaa(table, dataGridView1);
        }
    }
}
