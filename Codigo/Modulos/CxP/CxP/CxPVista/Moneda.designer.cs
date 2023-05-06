
namespace CxPVista
{
    partial class Moneda
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.txtabreviatura = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 226);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.Tag = "tbl_moneda";
            // 
            // txtestado
            // 
            this.txtestado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtestado.Location = new System.Drawing.Point(409, 242);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(37, 25);
            this.txtestado.TabIndex = 30;
            this.txtestado.Tag = "estado_moneda";
            // 
            // txtcambio
            // 
            this.txtcambio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtcambio.Location = new System.Drawing.Point(409, 194);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(138, 25);
            this.txtcambio.TabIndex = 27;
            this.txtcambio.Tag = "cambio_moneda";
            // 
            // txtabreviatura
            // 
            this.txtabreviatura.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtabreviatura.Location = new System.Drawing.Point(118, 269);
            this.txtabreviatura.Name = "txtabreviatura";
            this.txtabreviatura.Size = new System.Drawing.Size(164, 25);
            this.txtabreviatura.TabIndex = 26;
            this.txtabreviatura.Tag = "simbolo_moneda";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtnombre.Location = new System.Drawing.Point(119, 230);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(164, 25);
            this.txtnombre.TabIndex = 25;
            this.txtnombre.Tag = "nombre_moneda";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.txtid.Location = new System.Drawing.Point(119, 191);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 25);
            this.txtid.TabIndex = 24;
            this.txtid.Tag = "pk_id_moneda";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(320, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(315, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(17, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Abreviatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(17, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(17, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(574, 152);
            this.navegador1.TabIndex = 32;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // Moneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(93)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(593, 571);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.txtabreviatura);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Moneda";
            this.Text = "Moneda";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.TextBox txtabreviatura;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NavegadorVista.Navegador navegador1;
    }
}