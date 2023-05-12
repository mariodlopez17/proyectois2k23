
namespace CPC_Vista
{
    partial class Mant_tipoPago
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_estado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbl_tipopago = new System.Windows.Forms.DataGridView();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tipopago)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "ESTADO";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(175, 256);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(239, 26);
            this.txt_id.TabIndex = 5;
            this.txt_id.Tag = "pk_id_tipopago";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(175, 299);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(239, 26);
            this.txt_nombre.TabIndex = 6;
            this.txt_nombre.Tag = "nombre_tipopago";
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(179, 384);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Size = new System.Drawing.Size(239, 26);
            this.txt_estado.TabIndex = 8;
            this.txt_estado.Tag = "estado_tipopago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "1: Activo    2: Inactivo";
            // 
            // tbl_tipopago
            // 
            this.tbl_tipopago.AllowUserToAddRows = false;
            this.tbl_tipopago.AllowUserToDeleteRows = false;
            this.tbl_tipopago.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbl_tipopago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_tipopago.Location = new System.Drawing.Point(434, 253);
            this.tbl_tipopago.Name = "tbl_tipopago";
            this.tbl_tipopago.ReadOnly = true;
            this.tbl_tipopago.RowHeadersWidth = 62;
            this.tbl_tipopago.RowTemplate.Height = 28;
            this.tbl_tipopago.Size = new System.Drawing.Size(532, 373);
            this.tbl_tipopago.TabIndex = 10;
            this.tbl_tipopago.Tag = "tbl_tipopago";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(56, 11);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(861, 234);
            this.navegador1.TabIndex = 11;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // Mant_tipoPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 638);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.tbl_tipopago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Mant_tipoPago";
            this.Text = "Mant_tipoPago";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tipopago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_estado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tbl_tipopago;
        private NavegadorVista.Navegador navegador1;
    }
}