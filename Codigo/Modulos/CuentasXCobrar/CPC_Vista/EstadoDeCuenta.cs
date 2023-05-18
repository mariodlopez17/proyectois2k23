using CrystalDecisions.CrystalReports.Engine;
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
    public partial class EstadoDeCuenta : Form
    {
        CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();
        public EstadoDeCuenta()
        {
            InitializeComponent();
            /*
             
            ReportDocument crystalrpt = new ReportDocument();
            EstadoCuenta estadoCuenta = new EstadoCuenta();
            display.ReportSource = estadoCuenta;
            estadoCuenta.Refresh();
            display.Show();
             */
        }
    }
}
