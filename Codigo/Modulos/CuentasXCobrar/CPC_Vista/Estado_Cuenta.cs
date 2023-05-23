using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CPC_Vista
{
    public partial class Estado_Cuenta : Form
    {
        public Estado_Cuenta()
        {
            InitializeComponent();
        }

        CPC_Controlador.Controlador controlador = new CPC_Controlador.Controlador();

        public void limpiartxt()
        {
            txt_id.Text = "";
            txt_nombre.Text = ""; 
            txt_nit.Text = ""; 
            txt_dpi.Text = ""; 
            txt_telefono.Text = "";
            txt_direccion.Text = "";
            txt_anterior.Text = "";
            txt_cargosacumulados.Text = "";
            txt_cargosdelmes.Text = "";
            txt_abonosacumulados.Text = "";
            txt_abonodelmes.Text = "";
            txt_cargo.Text = "";
            txt_abono.Text = "";
            txt_saldocargosacumulados.Text = "";
            txt_saldoabonosacumulados.Text = "";
            txt_saldomesanterior.Text = "";
            txt_final.Text = "";
        }

        public void llenarcbxnombre()
        {
            try
            {
                cbx_nombre.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxNom(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_nombre.Items.Add(datareader[0].ToString());
                }
                cbx_nombre.SelectedIndex = 0;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxnit()
        {
            try
            {
                cbx_nit.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxNit(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_nit.Items.Add(datareader[0].ToString());
                }
                cbx_nit.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxdpi()
        {
            try
            {
                cbx_dpi.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxDpi(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_dpi.Items.Add(datareader[0].ToString());
                }
                cbx_dpi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxtelefono()
        {
            try
            {
                cbx_telefono.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxTel(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_telefono.Items.Add(datareader[0].ToString());
                }
                cbx_telefono.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxdireccion()
        {
            try
            {
                cbx_direccion.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxDir(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_direccion.Items.Add(datareader[0].ToString());
                }
                cbx_direccion.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxanterior()
        {
            try
            {
                cbx_anterior.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxAnt(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_anterior.Items.Add(datareader[0].ToString());
                }
                cbx_anterior.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxcargo()
        {
            try
            {
                cbx_cargo.Items.Clear();
                cbx_cargosdelmes.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxCar(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_cargosdelmes.Items.Add(datareader[0].ToString());
                    cbx_cargo.Items.Add(datareader[0].ToString());
                }
                cbx_cargosdelmes.SelectedIndex = 0;
                cbx_cargo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxabono()
        {
            try
            {
                cbx_abono.Items.Clear();
                cbx_abonodelmes.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxAbo(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_abonodelmes.Items.Add(datareader[0].ToString());
                    cbx_abono.Items.Add(datareader[0].ToString());
                }
                cbx_abonodelmes.SelectedIndex = 0;
                cbx_abono.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxcargos()
        {
            try
            {
                cbx_cargosacumulados.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxCarg(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_cargosacumulados.Items.Add(datareader[0].ToString());
                }
                cbx_cargosacumulados.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void llenarcbxabonos()
        {
            try
            {
                cbx_abonosacumulados.Items.Clear();
                OdbcDataReader datareader = controlador.llenarcbxAbon(txt_id.Text);
                while (datareader.Read())
                {
                    cbx_abonosacumulados.Items.Add(datareader[0].ToString());
                }
                cbx_abonosacumulados.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void cbx_nombre_SelectedIndexChanged(object sender, EventArgs e){txt_nombre.Text = cbx_nombre.Text;}
        private void cbx_nit_SelectedIndexChanged(object sender, EventArgs e){ txt_nit.Text = cbx_nit.Text;}
        private void cbx_dpi_SelectedIndexChanged(object sender, EventArgs e){txt_dpi.Text = cbx_dpi.Text;}
        private void cbx_telefono_SelectedIndexChanged(object sender, EventArgs e){txt_telefono.Text = cbx_telefono.Text;}
        private void cbx_direccion_SelectedIndexChanged(object sender, EventArgs e){txt_direccion.Text = cbx_direccion.Text;}
        private void cbx_anterior_SelectedIndexChanged(object sender, EventArgs e){txt_anterior.Text = cbx_anterior.Text;}
        private void cbx_cargo_SelectedIndexChanged(object sender, EventArgs e){txt_cargo.Text = cbx_cargo.Text;}
        private void cbx_abono_SelectedIndexChanged(object sender, EventArgs e){txt_abono.Text = cbx_abono.Text;}

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            llenarcbxnombre();
            llenarcbxnit();
            llenarcbxdpi();
            llenarcbxtelefono();
            llenarcbxdireccion();
            llenarcbxanterior();
            llenarcbxcargo();
            llenarcbxabono();
            llenarcbxcargos();
            llenarcbxabonos();
        }

        private void btn_balance_Click(object sender, EventArgs e)
        {
            double cargomes, abonomes, cargoacumulado, abonoacumulado, resta, suma1, suma2;


            cargomes = Convert.ToDouble(txt_cargo.Text);
            abonomes = Convert.ToDouble(txt_abono.Text);
            cargoacumulado = Convert.ToDouble(txt_cargosacumulados.Text);
            abonoacumulado = Convert.ToDouble(txt_abonosacumulados.Text);

            suma1 = cargomes + cargoacumulado;
            suma2 = abonomes + abonoacumulado;
            resta = cargomes - abonomes;

            txt_saldocargosacumulados.Text = Convert.ToString(suma1);
            txt_saldoabonosacumulados.Text = Convert.ToString(suma2);
            txt_final.Text = "-" + Convert.ToString(resta);
            txt_saldomesanterior.Text = "-" + Convert.ToString(resta);

            string saldo = "0";

            controlador.Modificarsaldosclientes(Convert.ToString(resta), saldo, Convert.ToString(suma1), Convert.ToString(suma2), txt_id.Text);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            limpiartxt();
        }

        private void cbx_cargosacumulados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cargosacumulados.Text = cbx_cargosacumulados.Text;
        }

        private void cbx_cargosdelmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cargosdelmes.Text = cbx_cargosdelmes.Text;
        }

        private void cbx_abonosacumulados_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_abonosacumulados.Text = cbx_abonosacumulados.Text;
        }

        private void cbx_abonodelmes_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_abonodelmes.Text = cbx_abonodelmes.Text;
        }
        
    }
}
