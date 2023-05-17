
namespace CPC_Vista
{
    partial class Pcs_CobroCuenta
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
            this.txt_comprante = new System.Windows.Forms.TextBox();
            this.txt_id_factura = new System.Windows.Forms.TextBox();
            this.btn_buscar_factura = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id_cliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre_cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_fecha_factura = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_fecha_pago = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_id_concepto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_monto_cargo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_monto_pago = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_id_tipoPago = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_no_cuenta = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.txt_id_almacen = new System.Windows.Forms.ComboBox();
            this.txt_id_moneda = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_vuelto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COMPRABANTE DE PAGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID FACTURA";
            // 
            // txt_comprante
            // 
            this.txt_comprante.Location = new System.Drawing.Point(224, 11);
            this.txt_comprante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_comprante.Name = "txt_comprante";
            this.txt_comprante.Size = new System.Drawing.Size(101, 22);
            this.txt_comprante.TabIndex = 2;
            // 
            // txt_id_factura
            // 
            this.txt_id_factura.Location = new System.Drawing.Point(579, 11);
            this.txt_id_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_factura.Name = "txt_id_factura";
            this.txt_id_factura.Size = new System.Drawing.Size(199, 22);
            this.txt_id_factura.TabIndex = 3;
            // 
            // btn_buscar_factura
            // 
            this.btn_buscar_factura.Location = new System.Drawing.Point(790, 7);
            this.btn_buscar_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar_factura.Name = "btn_buscar_factura";
            this.btn_buscar_factura.Size = new System.Drawing.Size(95, 29);
            this.btn_buscar_factura.TabIndex = 4;
            this.btn_buscar_factura.Text = "CARGAR";
            this.btn_buscar_factura.UseVisualStyleBackColor = true;
            this.btn_buscar_factura.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID ALMACEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID CLIENTE";
            // 
            // txt_id_cliente
            // 
            this.txt_id_cliente.Location = new System.Drawing.Point(224, 170);
            this.txt_id_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_cliente.Name = "txt_id_cliente";
            this.txt_id_cliente.Size = new System.Drawing.Size(201, 22);
            this.txt_id_cliente.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "NOMBRE DEL CLIENTE";
            // 
            // txt_nombre_cliente
            // 
            this.txt_nombre_cliente.Location = new System.Drawing.Point(654, 172);
            this.txt_nombre_cliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_nombre_cliente.Name = "txt_nombre_cliente";
            this.txt_nombre_cliente.Size = new System.Drawing.Size(232, 22);
            this.txt_nombre_cliente.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID MONEDA";
            // 
            // txt_fecha_factura
            // 
            this.txt_fecha_factura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_factura.Location = new System.Drawing.Point(224, 110);
            this.txt_fecha_factura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_factura.Name = "txt_fecha_factura";
            this.txt_fecha_factura.Size = new System.Drawing.Size(201, 22);
            this.txt_fecha_factura.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "FECHA EMISIÓN DE FACT.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "FECHA DE PAGO:";
            // 
            // txt_fecha_pago
            // 
            this.txt_fecha_pago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_pago.Location = new System.Drawing.Point(654, 110);
            this.txt_fecha_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_fecha_pago.Name = "txt_fecha_pago";
            this.txt_fecha_pago.Size = new System.Drawing.Size(232, 22);
            this.txt_fecha_pago.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 286);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "ID CONCEPTO DE COBRO";
            // 
            // txt_id_concepto
            // 
            this.txt_id_concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_id_concepto.FormattingEnabled = true;
            this.txt_id_concepto.Location = new System.Drawing.Point(224, 282);
            this.txt_id_concepto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_concepto.Name = "txt_id_concepto";
            this.txt_id_concepto.Size = new System.Drawing.Size(662, 24);
            this.txt_id_concepto.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "MONTO A PAGAR:";
            // 
            // txt_monto_cargo
            // 
            this.txt_monto_cargo.Location = new System.Drawing.Point(224, 224);
            this.txt_monto_cargo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_monto_cargo.Name = "txt_monto_cargo";
            this.txt_monto_cargo.Size = new System.Drawing.Size(201, 22);
            this.txt_monto_cargo.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 17);
            this.label14.TabIndex = 28;
            this.label14.Text = "PAGO:";
            // 
            // txt_monto_pago
            // 
            this.txt_monto_pago.Location = new System.Drawing.Point(520, 224);
            this.txt_monto_pago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_monto_pago.Name = "txt_monto_pago";
            this.txt_monto_pago.Size = new System.Drawing.Size(127, 22);
            this.txt_monto_pago.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 402);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 17);
            this.label15.TabIndex = 30;
            this.label15.Text = "ID TIPO DE PAGO";
            // 
            // txt_id_tipoPago
            // 
            this.txt_id_tipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_id_tipoPago.FormattingEnabled = true;
            this.txt_id_tipoPago.Location = new System.Drawing.Point(224, 397);
            this.txt_id_tipoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_tipoPago.Name = "txt_id_tipoPago";
            this.txt_id_tipoPago.Size = new System.Drawing.Size(201, 24);
            this.txt_id_tipoPago.TabIndex = 31;
            this.txt_id_tipoPago.SelectedIndexChanged += new System.EventHandler(this.txt_id_tipoPago_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 396);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "#";
            // 
            // txt_no_cuenta
            // 
            this.txt_no_cuenta.Location = new System.Drawing.Point(654, 394);
            this.txt_no_cuenta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_no_cuenta.Name = "txt_no_cuenta";
            this.txt_no_cuenta.Size = new System.Drawing.Size(232, 22);
            this.txt_no_cuenta.TabIndex = 34;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(330, 7);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 29);
            this.btn_buscar.TabIndex = 35;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(790, 438);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(95, 29);
            this.btn_eliminar.TabIndex = 36;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(682, 438);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(95, 29);
            this.btn_guardar.TabIndex = 37;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.button4_Click);
            // 
            // txt_id_almacen
            // 
            this.txt_id_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_id_almacen.FormattingEnabled = true;
            this.txt_id_almacen.Location = new System.Drawing.Point(224, 54);
            this.txt_id_almacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_almacen.Name = "txt_id_almacen";
            this.txt_id_almacen.Size = new System.Drawing.Size(662, 24);
            this.txt_id_almacen.TabIndex = 39;
            // 
            // txt_id_moneda
            // 
            this.txt_id_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_id_moneda.FormattingEnabled = true;
            this.txt_id_moneda.Location = new System.Drawing.Point(224, 341);
            this.txt_id_moneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_id_moneda.Name = "txt_id_moneda";
            this.txt_id_moneda.Size = new System.Drawing.Size(662, 24);
            this.txt_id_moneda.TabIndex = 40;
            this.txt_id_moneda.SelectedIndexChanged += new System.EventHandler(this.txt_id_moneda_SelectedIndexChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(545, 438);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(119, 29);
            this.btn_cancelar.TabIndex = 41;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(669, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "VUELTO:";
            // 
            // txt_vuelto
            // 
            this.txt_vuelto.Location = new System.Drawing.Point(758, 222);
            this.txt_vuelto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_vuelto.Name = "txt_vuelto";
            this.txt_vuelto.Size = new System.Drawing.Size(127, 22);
            this.txt_vuelto.TabIndex = 43;
            // 
            // Pcs_CobroCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 508);
            this.Controls.Add(this.txt_vuelto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_id_moneda);
            this.Controls.Add(this.txt_id_almacen);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_no_cuenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_id_tipoPago);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_monto_pago);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_monto_cargo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_id_concepto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_fecha_pago);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_fecha_factura);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_nombre_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_id_cliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_buscar_factura);
            this.Controls.Add(this.txt_id_factura);
            this.Controls.Add(this.txt_comprante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Pcs_CobroCuenta";
            this.Text = "Pcs_CobroCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_comprante;
        private System.Windows.Forms.TextBox txt_id_factura;
        private System.Windows.Forms.Button btn_buscar_factura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id_cliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txt_fecha_factura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker txt_fecha_pago;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txt_id_concepto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_monto_cargo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_monto_pago;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox txt_id_tipoPago;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_no_cuenta;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ComboBox txt_id_almacen;
        private System.Windows.Forms.ComboBox txt_id_moneda;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_vuelto;
    }
}