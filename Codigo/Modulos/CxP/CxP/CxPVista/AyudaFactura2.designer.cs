
namespace CxPVista
{
    partial class AyudaFactura2
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
            this.btninsertar = new FontAwesome.Sharp.IconButton();
            this.Dgv_ayudaFactura = new System.Windows.Forms.DataGridView();
            this.Dgv_ayudaProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btninsertar
            // 
            this.btninsertar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btninsertar.FlatAppearance.BorderSize = 2;
            this.btninsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsertar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btninsertar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btninsertar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btninsertar.IconSize = 40;
            this.btninsertar.Location = new System.Drawing.Point(610, 30);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 68;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Dgv_ayudaFactura
            // 
            this.Dgv_ayudaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ayudaFactura.Location = new System.Drawing.Point(21, 158);
            this.Dgv_ayudaFactura.Name = "Dgv_ayudaFactura";
            this.Dgv_ayudaFactura.Size = new System.Drawing.Size(759, 274);
            this.Dgv_ayudaFactura.TabIndex = 67;
            // 
            // Dgv_ayudaProveedores
            // 
            this.Dgv_ayudaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ayudaProveedores.Location = new System.Drawing.Point(567, 452);
            this.Dgv_ayudaProveedores.Name = "Dgv_ayudaProveedores";
            this.Dgv_ayudaProveedores.Size = new System.Drawing.Size(213, 125);
            this.Dgv_ayudaProveedores.TabIndex = 75;
            // 
            // AyudaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(93)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.Dgv_ayudaProveedores);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.Dgv_ayudaFactura);
            this.Name = "AyudaFactura";
            this.Text = "AyudaFactura";
            this.Load += new System.EventHandler(this.AyudaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.DataGridView Dgv_ayudaFactura;
        private System.Windows.Forms.DataGridView Dgv_ayudaProveedores;
    }
}