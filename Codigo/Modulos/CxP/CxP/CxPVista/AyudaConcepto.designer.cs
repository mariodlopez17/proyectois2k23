
namespace CxPVista
{
    partial class AyudaConcepto
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
            this.Dgv_ayudaConcepto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaConcepto)).BeginInit();
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
            this.btninsertar.Location = new System.Drawing.Point(499, 45);
            this.btninsertar.Name = "btninsertar";
            this.btninsertar.Size = new System.Drawing.Size(69, 61);
            this.btninsertar.TabIndex = 70;
            this.btninsertar.Text = "Insertar";
            this.btninsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninsertar.UseVisualStyleBackColor = true;
            this.btninsertar.Click += new System.EventHandler(this.btninsertar_Click);
            // 
            // Dgv_ayudaConcepto
            // 
            this.Dgv_ayudaConcepto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ayudaConcepto.Location = new System.Drawing.Point(12, 112);
            this.Dgv_ayudaConcepto.Name = "Dgv_ayudaConcepto";
            this.Dgv_ayudaConcepto.Size = new System.Drawing.Size(560, 201);
            this.Dgv_ayudaConcepto.TabIndex = 69;
            // 
            // AyudaConcepto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(93)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(580, 321);
            this.Controls.Add(this.btninsertar);
            this.Controls.Add(this.Dgv_ayudaConcepto);
            this.Name = "AyudaConcepto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AyudaConcepto";
            this.Load += new System.EventHandler(this.AyudaConcepto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ayudaConcepto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btninsertar;
        private System.Windows.Forms.DataGridView Dgv_ayudaConcepto;
    }
}