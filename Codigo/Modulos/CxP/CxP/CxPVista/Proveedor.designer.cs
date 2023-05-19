
namespace CxPVista
{
    partial class Proveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtrubro = new System.Windows.Forms.TextBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.dtgProveedor = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtcargoacum = new System.Windows.Forms.TextBox();
            this.txtabono = new System.Windows.Forms.TextBox();
            this.txtsaldoactual = new System.Windows.Forms.TextBox();
            this.txtsaldoanterior = new System.Windows.Forms.TextBox();
            this.txtabonoacum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(50, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(48, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(43, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direccion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(48, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(48, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(48, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Rubro";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(50, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Estado";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtid.Location = new System.Drawing.Point(102, 166);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 25);
            this.txtid.TabIndex = 8;
            this.txtid.Tag = "pk_id_proveedor";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtnombre.Location = new System.Drawing.Point(165, 224);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 25);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.Tag = "nombre_proveedor";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtdireccion.Location = new System.Drawing.Point(165, 254);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(164, 25);
            this.txtdireccion.TabIndex = 10;
            this.txtdireccion.Tag = "direccion_proveedor";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txttelefono.Location = new System.Drawing.Point(165, 285);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(164, 25);
            this.txttelefono.TabIndex = 11;
            this.txttelefono.Tag = "telefono_proveedor";
            // 
            // txtcorreo
            // 
            this.txtcorreo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtcorreo.Location = new System.Drawing.Point(165, 316);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(180, 25);
            this.txtcorreo.TabIndex = 12;
            this.txtcorreo.Tag = "correo_proveedor";
            // 
            // txtrubro
            // 
            this.txtrubro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtrubro.Location = new System.Drawing.Point(165, 347);
            this.txtrubro.Name = "txtrubro";
            this.txtrubro.Size = new System.Drawing.Size(180, 25);
            this.txtrubro.TabIndex = 13;
            this.txtrubro.Tag = "rubro_proveedor";
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtestado.Location = new System.Drawing.Point(165, 378);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(37, 25);
            this.txtestado.TabIndex = 14;
            this.txtestado.Tag = "estado_proveedor";
            // 
            // dtgProveedor
            // 
            this.dtgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedor.Location = new System.Drawing.Point(24, 413);
            this.dtgProveedor.Name = "dtgProveedor";
            this.dtgProveedor.Size = new System.Drawing.Size(801, 226);
            this.dtgProveedor.TabIndex = 15;
            this.dtgProveedor.Tag = "tbl_proveedor";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(126, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 16;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtcargo
            // 
            this.txtcargo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtcargo.Location = new System.Drawing.Point(579, 258);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(138, 25);
            this.txtcargo.TabIndex = 17;
            this.txtcargo.Tag = "cargo_del_mes_proveedor";
            // 
            // txtcargoacum
            // 
            this.txtcargoacum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtcargoacum.Location = new System.Drawing.Point(579, 334);
            this.txtcargoacum.Name = "txtcargoacum";
            this.txtcargoacum.Size = new System.Drawing.Size(138, 25);
            this.txtcargoacum.TabIndex = 18;
            this.txtcargoacum.Tag = "cargos_acumulados_proveedor";
            // 
            // txtabono
            // 
            this.txtabono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtabono.Location = new System.Drawing.Point(579, 289);
            this.txtabono.Name = "txtabono";
            this.txtabono.Size = new System.Drawing.Size(138, 25);
            this.txtabono.TabIndex = 19;
            this.txtabono.Tag = "abonos_del_mes_proveedor";
            // 
            // txtsaldoactual
            // 
            this.txtsaldoactual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtsaldoactual.Location = new System.Drawing.Point(579, 218);
            this.txtsaldoactual.Name = "txtsaldoactual";
            this.txtsaldoactual.Size = new System.Drawing.Size(138, 25);
            this.txtsaldoactual.TabIndex = 20;
            this.txtsaldoactual.Tag = "saldo_actual_proveedor";
            // 
            // txtsaldoanterior
            // 
            this.txtsaldoanterior.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtsaldoanterior.Location = new System.Drawing.Point(579, 187);
            this.txtsaldoanterior.Name = "txtsaldoanterior";
            this.txtsaldoanterior.Size = new System.Drawing.Size(138, 25);
            this.txtsaldoanterior.TabIndex = 21;
            this.txtsaldoanterior.Tag = "saldo_mes_anterior_proveedor";
            // 
            // txtabonoacum
            // 
            this.txtabonoacum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtabonoacum.Location = new System.Drawing.Point(579, 365);
            this.txtabonoacum.Name = "txtabonoacum";
            this.txtabonoacum.Size = new System.Drawing.Size(138, 25);
            this.txtabonoacum.TabIndex = 22;
            this.txtabonoacum.Tag = "abonos_acumulados_proveedor";
            this.txtabonoacum.TextChanged += new System.EventHandler(this.txtabonoacum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label8.Location = new System.Drawing.Point(401, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Saldo del mes anterior";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label9.Location = new System.Drawing.Point(401, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Saldo del mes actual";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label10.Location = new System.Drawing.Point(401, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cargo del mes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label11.Location = new System.Drawing.Point(401, 297);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Abono del mes";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label12.Location = new System.Drawing.Point(401, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cargo acumulado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label13.Location = new System.Drawing.Point(401, 365);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Abono acumulado";
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(93)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(848, 651);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtabonoacum);
            this.Controls.Add(this.txtsaldoanterior);
            this.Controls.Add(this.txtsaldoactual);
            this.Controls.Add(this.txtabono);
            this.Controls.Add(this.txtcargoacum);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtrubro);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dtgProveedor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            this.Load += new System.EventHandler(this.Proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtrubro;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.DataGridView dtgProveedor;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtcargoacum;
        private System.Windows.Forms.TextBox txtabono;
        private System.Windows.Forms.TextBox txtsaldoactual;
        private System.Windows.Forms.TextBox txtsaldoanterior;
        private System.Windows.Forms.TextBox txtabonoacum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
   
    }
}