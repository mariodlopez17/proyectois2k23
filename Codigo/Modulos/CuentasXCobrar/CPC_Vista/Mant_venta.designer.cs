
namespace CPC_Vista
{
    partial class Mant_venta
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id_venta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.almacen = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_venta = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.estado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.moneda = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.id_cliente = new System.Windows.Forms.ComboBox();
            this.tbl_venta = new System.Windows.Forms.DataGridView();
            this.txt_id_almacen = new System.Windows.Forms.TextBox();
            this.txt_fecha_venta = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.txt_fecha_vencimiento = new System.Windows.Forms.TextBox();
            this.txt_moneda = new System.Windows.Forms.TextBox();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.cbx_nombre_almacen = new System.Windows.Forms.ComboBox();
            this.cbx_nombre_moneda = new System.Windows.Forms.ComboBox();
            this.cbx_nombre_cliente = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(212, 75);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 12;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID DE VENTA:";
            // 
            // txt_id_venta
            // 
            this.txt_id_venta.Location = new System.Drawing.Point(112, 263);
            this.txt_id_venta.Name = "txt_id_venta";
            this.txt_id_venta.Size = new System.Drawing.Size(100, 20);
            this.txt_id_venta.TabIndex = 15;
            this.txt_id_venta.Tag = "Pk_idVenta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "ID DE ALMACEN:";
            // 
            // almacen
            // 
            this.almacen.FormattingEnabled = true;
            this.almacen.Location = new System.Drawing.Point(112, 300);
            this.almacen.Name = "almacen";
            this.almacen.Size = new System.Drawing.Size(100, 21);
            this.almacen.TabIndex = 17;
            this.almacen.Tag = "";
            this.almacen.SelectedIndexChanged += new System.EventHandler(this.almacen_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "FECHA VENTA:";
            // 
            // fecha_venta
            // 
            this.fecha_venta.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.fecha_venta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_venta.Location = new System.Drawing.Point(104, 338);
            this.fecha_venta.Name = "fecha_venta";
            this.fecha_venta.Size = new System.Drawing.Size(126, 20);
            this.fecha_venta.TabIndex = 19;
            this.fecha_venta.Tag = "fecha_venta";
            this.fecha_venta.ValueChanged += new System.EventHandler(this.fecha_venta_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "DESCUENTO DE VENTA:";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(384, 262);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(100, 20);
            this.txt_descuento.TabIndex = 21;
            this.txt_descuento.Tag = "Descuento_venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "IVA DE VENTA:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(384, 299);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 23;
            this.txt_iva.Tag = "IVA_venta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "TOTAL DE VENTA:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(384, 338);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 25;
            this.txt_total.Tag = "Total_venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "ESTADO VENTA:";
            // 
            // estado
            // 
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Habilitado",
            "Desabilitado"});
            this.estado.Location = new System.Drawing.Point(658, 260);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(100, 21);
            this.estado.TabIndex = 27;
            this.estado.Tag = "";
            this.estado.SelectedIndexChanged += new System.EventHandler(this.estado_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(525, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "FECHA VENCIMIENTO:";
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.CustomFormat = "yyyy-MM-dd";
            this.fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha_vencimiento.Location = new System.Drawing.Point(658, 298);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(100, 20);
            this.fecha_vencimiento.TabIndex = 29;
            this.fecha_vencimiento.Tag = "";
            this.fecha_vencimiento.ValueChanged += new System.EventHandler(this.fecha_vencimiento_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 341);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "MONEDA DE VENTA:";
            // 
            // moneda
            // 
            this.moneda.FormattingEnabled = true;
            this.moneda.Location = new System.Drawing.Point(658, 337);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(100, 21);
            this.moneda.TabIndex = 31;
            this.moneda.Tag = "";
            this.moneda.SelectedIndexChanged += new System.EventHandler(this.moneda_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(792, 266);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "ID CLIENTE";
            // 
            // id_cliente
            // 
            this.id_cliente.FormattingEnabled = true;
            this.id_cliente.Location = new System.Drawing.Point(864, 262);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(100, 21);
            this.id_cliente.TabIndex = 33;
            this.id_cliente.Tag = "";
            this.id_cliente.SelectedIndexChanged += new System.EventHandler(this.id_cliente_SelectedIndexChanged);
            // 
            // tbl_venta
            // 
            this.tbl_venta.AllowUserToAddRows = false;
            this.tbl_venta.AllowUserToDeleteRows = false;
            this.tbl_venta.AllowUserToOrderColumns = true;
            this.tbl_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_venta.Location = new System.Drawing.Point(15, 372);
            this.tbl_venta.Name = "tbl_venta";
            this.tbl_venta.ReadOnly = true;
            this.tbl_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tbl_venta.Size = new System.Drawing.Size(959, 249);
            this.tbl_venta.TabIndex = 34;
            this.tbl_venta.Tag = "tbl_venta";
            // 
            // txt_id_almacen
            // 
            this.txt_id_almacen.Location = new System.Drawing.Point(112, 301);
            this.txt_id_almacen.Name = "txt_id_almacen";
            this.txt_id_almacen.Size = new System.Drawing.Size(100, 20);
            this.txt_id_almacen.TabIndex = 35;
            this.txt_id_almacen.Tag = "codigo_almacen";
            // 
            // txt_fecha_venta
            // 
            this.txt_fecha_venta.Location = new System.Drawing.Point(104, 338);
            this.txt_fecha_venta.Name = "txt_fecha_venta";
            this.txt_fecha_venta.Size = new System.Drawing.Size(126, 20);
            this.txt_fecha_venta.TabIndex = 36;
            this.txt_fecha_venta.Tag = "fecha_venta";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(658, 261);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(100, 20);
            this.txt_estado.TabIndex = 37;
            this.txt_estado.Tag = "Estado_fac_venta";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(658, 298);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(100, 20);
            this.txt_fecha_vencimiento.TabIndex = 38;
            this.txt_fecha_vencimiento.Tag = "fecha_venci_venta";
            // 
            // txt_moneda
            // 
            this.txt_moneda.Location = new System.Drawing.Point(658, 338);
            this.txt_moneda.Name = "txt_moneda";
            this.txt_moneda.Size = new System.Drawing.Size(100, 20);
            this.txt_moneda.TabIndex = 39;
            this.txt_moneda.Tag = "moneda_venta";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(864, 263);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(100, 20);
            this.txt_id_cliente.TabIndex = 40;
            this.txt_id_cliente.Tag = "Pk_idClientes";
            // 
            // cbx_nombre_almacen
            // 
            this.cbx_nombre_almacen.FormattingEnabled = true;
            this.cbx_nombre_almacen.Location = new System.Drawing.Point(112, 300);
            this.cbx_nombre_almacen.Name = "cbx_nombre_almacen";
            this.cbx_nombre_almacen.Size = new System.Drawing.Size(100, 21);
            this.cbx_nombre_almacen.TabIndex = 41;
            this.cbx_nombre_almacen.SelectedIndexChanged += new System.EventHandler(this.cbx_nombre_almacen_SelectedIndexChanged);
            // 
            // cbx_nombre_moneda
            // 
            this.cbx_nombre_moneda.FormattingEnabled = true;
            this.cbx_nombre_moneda.Location = new System.Drawing.Point(658, 337);
            this.cbx_nombre_moneda.Name = "cbx_nombre_moneda";
            this.cbx_nombre_moneda.Size = new System.Drawing.Size(100, 21);
            this.cbx_nombre_moneda.TabIndex = 42;
            this.cbx_nombre_moneda.SelectedIndexChanged += new System.EventHandler(this.cbx_nombre_moneda_SelectedIndexChanged);
            // 
            // cbx_nombre_cliente
            // 
            this.cbx_nombre_cliente.FormattingEnabled = true;
            this.cbx_nombre_cliente.Location = new System.Drawing.Point(864, 262);
            this.cbx_nombre_cliente.Name = "cbx_nombre_cliente";
            this.cbx_nombre_cliente.Size = new System.Drawing.Size(100, 21);
            this.cbx_nombre_cliente.TabIndex = 43;
            this.cbx_nombre_cliente.SelectedIndexChanged += new System.EventHandler(this.cbx_nombre_cliente_SelectedIndexChanged);
            // 
            // Mant_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 633);
            this.Controls.Add(this.cbx_nombre_cliente);
            this.Controls.Add(this.cbx_nombre_moneda);
            this.Controls.Add(this.cbx_nombre_almacen);
            this.Controls.Add(this.tbl_venta);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.moneda);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.fecha_vencimiento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fecha_venta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.almacen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id_venta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt_id_almacen);
            this.Controls.Add(this.txt_fecha_venta);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_fecha_vencimiento);
            this.Controls.Add(this.txt_moneda);
            this.Controls.Add(this.txt_id_cliente);
            this.Name = "Mant_venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_venta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id_venta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox almacen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fecha_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fecha_vencimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox moneda;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox id_cliente;
        private System.Windows.Forms.DataGridView tbl_venta;
        private System.Windows.Forms.TextBox txt_id_almacen;
        private System.Windows.Forms.TextBox txt_fecha_venta;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.TextBox txt_fecha_vencimiento;
        private System.Windows.Forms.TextBox txt_moneda;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.ComboBox cbx_nombre_almacen;
        private System.Windows.Forms.ComboBox cbx_nombre_moneda;
        private System.Windows.Forms.ComboBox cbx_nombre_cliente;
    }
}