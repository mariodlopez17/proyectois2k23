
namespace CPC_Vista
{
    partial class Estado_Cuenta
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.cbx_direccion = new System.Windows.Forms.ComboBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.cbx_telefono = new System.Windows.Forms.ComboBox();
            this.txt_dpi = new System.Windows.Forms.TextBox();
            this.cbx_dpi = new System.Windows.Forms.ComboBox();
            this.txt_nit = new System.Windows.Forms.TextBox();
            this.cbx_nit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_final = new System.Windows.Forms.TextBox();
            this.cbx_final = new System.Windows.Forms.ComboBox();
            this.txt_abono = new System.Windows.Forms.TextBox();
            this.cbx_abono = new System.Windows.Forms.ComboBox();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.cbx_cargo = new System.Windows.Forms.ComboBox();
            this.txt_anterior = new System.Windows.Forms.TextBox();
            this.cbx_anterior = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_balance = new System.Windows.Forms.Button();
            this.cbx_nombre = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID CLIENTE";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(82, 6);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(81, 20);
            this.txt_id.TabIndex = 2;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(169, 4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOMBRE CLIENTE";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(363, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(348, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.cbx_direccion);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.cbx_telefono);
            this.panel1.Controls.Add(this.txt_dpi);
            this.panel1.Controls.Add(this.cbx_dpi);
            this.panel1.Controls.Add(this.txt_nit);
            this.panel1.Controls.Add(this.cbx_nit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(14, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 71);
            this.panel1.TabIndex = 7;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(389, 38);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(306, 20);
            this.txt_direccion.TabIndex = 12;
            // 
            // cbx_direccion
            // 
            this.cbx_direccion.FormattingEnabled = true;
            this.cbx_direccion.Location = new System.Drawing.Point(389, 38);
            this.cbx_direccion.Name = "cbx_direccion";
            this.cbx_direccion.Size = new System.Drawing.Size(306, 21);
            this.cbx_direccion.TabIndex = 14;
            this.cbx_direccion.SelectedIndexChanged += new System.EventHandler(this.cbx_direccion_SelectedIndexChanged);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(389, 11);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(143, 20);
            this.txt_telefono.TabIndex = 13;
            // 
            // cbx_telefono
            // 
            this.cbx_telefono.FormattingEnabled = true;
            this.cbx_telefono.Location = new System.Drawing.Point(389, 11);
            this.cbx_telefono.Name = "cbx_telefono";
            this.cbx_telefono.Size = new System.Drawing.Size(143, 21);
            this.cbx_telefono.TabIndex = 12;
            this.cbx_telefono.SelectedIndexChanged += new System.EventHandler(this.cbx_telefono_SelectedIndexChanged);
            // 
            // txt_dpi
            // 
            this.txt_dpi.Location = new System.Drawing.Point(89, 39);
            this.txt_dpi.Name = "txt_dpi";
            this.txt_dpi.Size = new System.Drawing.Size(141, 20);
            this.txt_dpi.TabIndex = 11;
            // 
            // cbx_dpi
            // 
            this.cbx_dpi.FormattingEnabled = true;
            this.cbx_dpi.Location = new System.Drawing.Point(89, 39);
            this.cbx_dpi.Name = "cbx_dpi";
            this.cbx_dpi.Size = new System.Drawing.Size(141, 21);
            this.cbx_dpi.TabIndex = 12;
            this.cbx_dpi.SelectedIndexChanged += new System.EventHandler(this.cbx_dpi_SelectedIndexChanged);
            // 
            // txt_nit
            // 
            this.txt_nit.Location = new System.Drawing.Point(89, 12);
            this.txt_nit.Name = "txt_nit";
            this.txt_nit.Size = new System.Drawing.Size(141, 20);
            this.txt_nit.TabIndex = 10;
            // 
            // cbx_nit
            // 
            this.cbx_nit.FormattingEnabled = true;
            this.cbx_nit.Location = new System.Drawing.Point(89, 12);
            this.cbx_nit.Name = "cbx_nit";
            this.cbx_nit.Size = new System.Drawing.Size(141, 21);
            this.cbx_nit.TabIndex = 12;
            this.cbx_nit.SelectedIndexChanged += new System.EventHandler(this.cbx_nit_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(320, 42);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DIRECCION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "TELEFONO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "NIT";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_final);
            this.panel2.Controls.Add(this.cbx_final);
            this.panel2.Controls.Add(this.txt_abono);
            this.panel2.Controls.Add(this.cbx_abono);
            this.panel2.Controls.Add(this.txt_cargo);
            this.panel2.Controls.Add(this.cbx_cargo);
            this.panel2.Controls.Add(this.txt_anterior);
            this.panel2.Controls.Add(this.cbx_anterior);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(14, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 118);
            this.panel2.TabIndex = 8;
            // 
            // txt_final
            // 
            this.txt_final.Location = new System.Drawing.Point(156, 88);
            this.txt_final.Name = "txt_final";
            this.txt_final.Size = new System.Drawing.Size(100, 20);
            this.txt_final.TabIndex = 12;
            // 
            // cbx_final
            // 
            this.cbx_final.FormattingEnabled = true;
            this.cbx_final.Location = new System.Drawing.Point(156, 88);
            this.cbx_final.Name = "cbx_final";
            this.cbx_final.Size = new System.Drawing.Size(100, 21);
            this.cbx_final.TabIndex = 19;
            // 
            // txt_abono
            // 
            this.txt_abono.Location = new System.Drawing.Point(156, 61);
            this.txt_abono.Name = "txt_abono";
            this.txt_abono.Size = new System.Drawing.Size(100, 20);
            this.txt_abono.TabIndex = 12;
            // 
            // cbx_abono
            // 
            this.cbx_abono.FormattingEnabled = true;
            this.cbx_abono.Location = new System.Drawing.Point(156, 61);
            this.cbx_abono.Name = "cbx_abono";
            this.cbx_abono.Size = new System.Drawing.Size(100, 21);
            this.cbx_abono.TabIndex = 12;
            this.cbx_abono.SelectedIndexChanged += new System.EventHandler(this.cbx_abono_SelectedIndexChanged);
            // 
            // txt_cargo
            // 
            this.txt_cargo.Location = new System.Drawing.Point(156, 33);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(100, 20);
            this.txt_cargo.TabIndex = 12;
            // 
            // cbx_cargo
            // 
            this.cbx_cargo.FormattingEnabled = true;
            this.cbx_cargo.Location = new System.Drawing.Point(156, 33);
            this.cbx_cargo.Name = "cbx_cargo";
            this.cbx_cargo.Size = new System.Drawing.Size(100, 21);
            this.cbx_cargo.TabIndex = 18;
            this.cbx_cargo.SelectedIndexChanged += new System.EventHandler(this.cbx_cargo_SelectedIndexChanged);
            // 
            // txt_anterior
            // 
            this.txt_anterior.Location = new System.Drawing.Point(156, 7);
            this.txt_anterior.Name = "txt_anterior";
            this.txt_anterior.Size = new System.Drawing.Size(100, 20);
            this.txt_anterior.TabIndex = 12;
            // 
            // cbx_anterior
            // 
            this.cbx_anterior.FormattingEnabled = true;
            this.cbx_anterior.Location = new System.Drawing.Point(156, 7);
            this.cbx_anterior.Name = "cbx_anterior";
            this.cbx_anterior.Size = new System.Drawing.Size(100, 21);
            this.cbx_anterior.TabIndex = 12;
            this.cbx_anterior.SelectedIndexChanged += new System.EventHandler(this.cbx_anterior_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "SALDO ANTERIOR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 92);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "SALDO FINAL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 65);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "ABONO DEL MES";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 37);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "CARGO DEL MES";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(599, 224);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(117, 23);
            this.btn_guardar.TabIndex = 9;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_balance
            // 
            this.btn_balance.Location = new System.Drawing.Point(323, 224);
            this.btn_balance.Name = "btn_balance";
            this.btn_balance.Size = new System.Drawing.Size(134, 23);
            this.btn_balance.TabIndex = 10;
            this.btn_balance.Text = "Generar Balance";
            this.btn_balance.UseVisualStyleBackColor = true;
            this.btn_balance.Click += new System.EventHandler(this.btn_balance_Click);
            // 
            // cbx_nombre
            // 
            this.cbx_nombre.FormattingEnabled = true;
            this.cbx_nombre.Location = new System.Drawing.Point(363, 4);
            this.cbx_nombre.Name = "cbx_nombre";
            this.cbx_nombre.Size = new System.Drawing.Size(348, 21);
            this.cbx_nombre.TabIndex = 11;
            this.cbx_nombre.SelectedIndexChanged += new System.EventHandler(this.cbx_nombre_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // Estado_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 253);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.cbx_nombre);
            this.Controls.Add(this.btn_balance);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Estado_Cuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado Cuenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_dpi;
        private System.Windows.Forms.TextBox txt_nit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_balance;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.ComboBox cbx_direccion;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.ComboBox cbx_telefono;
        private System.Windows.Forms.ComboBox cbx_dpi;
        private System.Windows.Forms.ComboBox cbx_nit;
        private System.Windows.Forms.TextBox txt_final;
        private System.Windows.Forms.TextBox txt_abono;
        private System.Windows.Forms.ComboBox cbx_abono;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.ComboBox cbx_cargo;
        private System.Windows.Forms.TextBox txt_anterior;
        private System.Windows.Forms.ComboBox cbx_anterior;
        private System.Windows.Forms.ComboBox cbx_nombre;
        private System.Windows.Forms.ComboBox cbx_final;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}