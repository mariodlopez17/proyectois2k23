
namespace CPC_Vista
{
    partial class Pcs_venta
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
            this.txt_almacen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fecha_actual = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_moneda = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_descuento = new System.Windows.Forms.TextBox();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbl_detalle_venta = new System.Windows.Forms.DataGridView();
            this.tbl_productos = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.Button();
            this.quitar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_guardar = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID ALMACEN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID FACTURA:";
            // 
            // txt_almacen
            // 
            this.txt_almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_almacen.FormattingEnabled = true;
            this.txt_almacen.Location = new System.Drawing.Point(180, 12);
            this.txt_almacen.Name = "txt_almacen";
            this.txt_almacen.Size = new System.Drawing.Size(303, 28);
            this.txt_almacen.TabIndex = 2;
            this.txt_almacen.SelectedIndexChanged += new System.EventHandler(this.txt_almacen_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA ACTUAL:";
            // 
            // txt_fecha_actual
            // 
            this.txt_fecha_actual.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_actual.Location = new System.Drawing.Point(180, 77);
            this.txt_fecha_actual.Name = "txt_fecha_actual";
            this.txt_fecha_actual.Size = new System.Drawing.Size(303, 26);
            this.txt_fecha_actual.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA VENCIMIENTO:";
            // 
            // txt_fecha_vencimiento
            // 
            this.txt_fecha_vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_fecha_vencimiento.Location = new System.Drawing.Point(766, 77);
            this.txt_fecha_vencimiento.Name = "txt_fecha_vencimiento";
            this.txt_fecha_vencimiento.Size = new System.Drawing.Size(269, 26);
            this.txt_fecha_vencimiento.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "MONEDA:";
            // 
            // txt_moneda
            // 
            this.txt_moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_moneda.FormattingEnabled = true;
            this.txt_moneda.Location = new System.Drawing.Point(180, 157);
            this.txt_moneda.Name = "txt_moneda";
            this.txt_moneda.Size = new System.Drawing.Size(303, 28);
            this.txt_moneda.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID CLIENTE:";
            // 
            // txt_cliente
            // 
            this.txt_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txt_cliente.FormattingEnabled = true;
            this.txt_cliente.Location = new System.Drawing.Point(704, 157);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(331, 28);
            this.txt_cliente.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "IVA:";
            // 
            // txt_iva
            // 
            this.txt_iva.Location = new System.Drawing.Point(180, 239);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(303, 26);
            this.txt_iva.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(564, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "DESCUENTO:";
            // 
            // txt_descuento
            // 
            this.txt_descuento.Location = new System.Drawing.Point(704, 242);
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(331, 26);
            this.txt_descuento.TabIndex = 15;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.Location = new System.Drawing.Point(892, 309);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(143, 44);
            this.btn_siguiente.TabIndex = 16;
            this.btn_siguiente.Text = "SIGUIENTE";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(704, 9);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(175, 26);
            this.txt_factura.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(892, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 31);
            this.button3.TabIndex = 19;
            this.button3.Text = "BUSCAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tbl_detalle_venta
            // 
            this.tbl_detalle_venta.AllowUserToAddRows = false;
            this.tbl_detalle_venta.AllowUserToDeleteRows = false;
            this.tbl_detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_detalle_venta.Location = new System.Drawing.Point(568, 373);
            this.tbl_detalle_venta.Name = "tbl_detalle_venta";
            this.tbl_detalle_venta.ReadOnly = true;
            this.tbl_detalle_venta.RowHeadersWidth = 62;
            this.tbl_detalle_venta.RowTemplate.Height = 28;
            this.tbl_detalle_venta.Size = new System.Drawing.Size(467, 319);
            this.tbl_detalle_venta.TabIndex = 20;
            // 
            // tbl_productos
            // 
            this.tbl_productos.AllowUserToAddRows = false;
            this.tbl_productos.AllowUserToDeleteRows = false;
            this.tbl_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_productos.Location = new System.Drawing.Point(16, 373);
            this.tbl_productos.Name = "tbl_productos";
            this.tbl_productos.ReadOnly = true;
            this.tbl_productos.RowHeadersWidth = 62;
            this.tbl_productos.RowTemplate.Height = 28;
            this.tbl_productos.Size = new System.Drawing.Size(467, 319);
            this.tbl_productos.TabIndex = 21;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(489, 485);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(73, 41);
            this.agregar.TabIndex = 22;
            this.agregar.Text = ">";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // quitar
            // 
            this.quitar.Location = new System.Drawing.Point(489, 532);
            this.quitar.Name = "quitar";
            this.quitar.Size = new System.Drawing.Size(73, 41);
            this.quitar.TabIndex = 23;
            this.quitar.Text = "<";
            this.quitar.UseVisualStyleBackColor = true;
            this.quitar.Click += new System.EventHandler(this.quitar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "TOTAL:";
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(180, 318);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(303, 26);
            this.txt_total.TabIndex = 25;
            // 
            // txt_guardar
            // 
            this.txt_guardar.Location = new System.Drawing.Point(892, 698);
            this.txt_guardar.Name = "txt_guardar";
            this.txt_guardar.Size = new System.Drawing.Size(143, 44);
            this.txt_guardar.TabIndex = 26;
            this.txt_guardar.Text = "GUARDAR";
            this.txt_guardar.UseVisualStyleBackColor = true;
            this.txt_guardar.Click += new System.EventHandler(this.txt_guardar_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(704, 698);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 44);
            this.button7.TabIndex = 27;
            this.button7.Text = "CANCELAR";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Pcs_venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 754);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txt_guardar);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.quitar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.tbl_productos);
            this.Controls.Add(this.tbl_detalle_venta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_factura);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.txt_descuento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_moneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_fecha_vencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_fecha_actual);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_almacen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pcs_venta";
            this.Text = "Pcs_venta";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_detalle_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txt_almacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txt_fecha_actual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txt_fecha_vencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txt_moneda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txt_cliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_descuento;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView tbl_detalle_venta;
        private System.Windows.Forms.DataGridView tbl_productos;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button quitar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button txt_guardar;
        private System.Windows.Forms.Button button7;
    }
}