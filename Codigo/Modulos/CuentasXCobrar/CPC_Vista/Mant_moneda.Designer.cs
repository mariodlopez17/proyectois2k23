
namespace CPC_Vista
{
    partial class Mant_moneda
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_simbolo = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbl_Moneda = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cambio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Moneda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SIMBOLO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 463);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ESTADO";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(178, 271);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(238, 26);
            this.txt_id.TabIndex = 5;
            this.txt_id.Tag = "pk_id_moneda";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(178, 318);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(238, 26);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.Tag = "nombre_moneda";
            // 
            // txt_simbolo
            // 
            this.txt_simbolo.Location = new System.Drawing.Point(178, 365);
            this.txt_simbolo.Name = "txt_simbolo";
            this.txt_simbolo.Size = new System.Drawing.Size(238, 26);
            this.txt_simbolo.TabIndex = 7;
            this.txt_simbolo.Tag = "simbolo_moneda";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(178, 504);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(238, 26);
            this.txt_estado.TabIndex = 8;
            this.txt_estado.Tag = "estado_moneda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 463);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "1: Activo    2: Inactivo";
            // 
            // tbl_Moneda
            // 
            this.tbl_Moneda.AllowUserToAddRows = false;
            this.tbl_Moneda.AllowUserToDeleteRows = false;
            this.tbl_Moneda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_Moneda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_Moneda.Location = new System.Drawing.Point(438, 271);
            this.tbl_Moneda.Name = "tbl_Moneda";
            this.tbl_Moneda.ReadOnly = true;
            this.tbl_Moneda.RowHeadersWidth = 62;
            this.tbl_Moneda.RowTemplate.Height = 28;
            this.tbl_Moneda.Size = new System.Drawing.Size(528, 355);
            this.tbl_Moneda.TabIndex = 10;
            this.tbl_Moneda.Tag = "tbl_moneda";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(42, 14);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 11;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "CAMBIO";
            // 
            // txt_cambio
            // 
            this.txt_cambio.Location = new System.Drawing.Point(178, 414);
            this.txt_cambio.Name = "txt_cambio";
            this.txt_cambio.Size = new System.Drawing.Size(238, 26);
            this.txt_cambio.TabIndex = 13;
            this.txt_cambio.Tag = "cambio_moneda";
            // 
            // Mant_moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 638);
            this.Controls.Add(this.txt_cambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.tbl_Moneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_simbolo);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mant_moneda";
            this.Text = "Mant_moneda";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Moneda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_simbolo;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tbl_Moneda;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cambio;
    }
}