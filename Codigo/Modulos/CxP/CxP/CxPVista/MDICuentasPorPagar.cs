using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CxPControlador;

namespace CxPVista
{
    public partial class MDICuentasPorPagar : Form
    {
        Seguridad_Controlador.Controlador cnseg = new Seguridad_Controlador.Controlador();
        TControlador controlador = new TControlador();
        public MDICuentasPorPagar()
        {
            InitializeComponent();
            customizeDesing();
            Button[] apps = { btnProveedor, btnConcepto, btnTipoPago, btnMoneda, btnMoviminetos, btnBalance,btnFactura, btnreportemovimientos, btnAntiguedad,btnCardex };
            cnseg.deshabilitarApps(apps);

            cnseg.getAccesoApp(5001, apps[0]);
            cnseg.getAccesoApp(5004, apps[1]);
            cnseg.getAccesoApp(5003, apps[2]);
            cnseg.getAccesoApp(5002, apps[3]);
            cnseg.getAccesoApp(5101, apps[4]);
            cnseg.getAccesoApp(5102, apps[5]);
            cnseg.getAccesoApp(5103, apps[6]);
            cnseg.getAccesoApp(5201, apps[7]);
            cnseg.getAccesoApp(5202, apps[8]);
            cnseg.getAccesoApp(5202, apps[9]);
        }

        private void customizeDesing()
        {
            //Metodo para cubrir los paneles
            panelcatalogo.Visible = false;
            panelProcesos.Visible = false;
            panelReportes.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelcatalogo.Visible == true)
                panelcatalogo.Visible = false;
            if (panelProcesos.Visible == true)
                panelProcesos.Visible = false;
            if (panelReportes.Visible == true)
                panelReportes.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = true;
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelcatalogo);
        }

        private void btnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProcesos);
        }

        private void btnMoviminetos_Click(object sender, EventArgs e)
        {
            //Codigo
            Moviminetos_CxP moviminetos = new Moviminetos_CxP();
            moviminetos.MdiParent = this;
            moviminetos.Show();

            //Ocultar submenu
            hideSubMenu();
        }

        private void btnreportemovimientos_Click(object sender, EventArgs e)
        {
            /*Codigo
            Reporte_Cuentas_Por_Pagar rmoviminetos = new Reporte_Cuentas_Por_Pagar();
            rmoviminetos.MdiParent = this;
            rmoviminetos.Show();
            //Ocultar submenu
            hideSubMenu();*/
            
            controlador.displayReporte("5201");
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            //Codigo
            Proveedor proveedor = new Proveedor();
            proveedor.MdiParent = this;
            proveedor.Show();

            //Ocultar submenu
            hideSubMenu();
        }

        private void btnConcepto_Click(object sender, EventArgs e)
        {
            //Codigo
            Concepto concepto = new Concepto();
            concepto.MdiParent = this;
            concepto.Show();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReportes);
        }

        private void btnTipoPago_Click(object sender, EventArgs e)
        {
            //Codigo
            TipoPago tipo = new TipoPago();
            tipo.MdiParent = this;
            tipo.Show();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {
            //Codigo
            Moneda moneda = new Moneda();
            moneda.MdiParent = this;
            moneda.Show();
            //Ocultar submenu
            hideSubMenu();
        }

        private void btnAntiguedad_Click(object sender, EventArgs e)
        {
            /*//Codigo
            Antiguedad_de_saldos antiguedad = new Antiguedad_de_saldos();
            antiguedad.MdiParent = this;
            antiguedad.Show();
            //Ocultar submenu
            hideSubMenu();*/
            controlador.displayReporte("5202");
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            //Codigo
            Balance balance = new Balance();
            balance.MdiParent = this;
            balance.Show();
            //Ocultar submenu
            hideSubMenu();

        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //Codigo
            Factura factura = new Factura();
            factura.MdiParent = this;
            factura.Show();
            //Ocultar submenu
            hideSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlador.displayReporte("5203");
        }
    }
}
