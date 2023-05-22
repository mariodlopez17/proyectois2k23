
namespace CPC_Vista
{
    partial class CPC_MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDePagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobroDeDeudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEstadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoToolStripMenuItem,
            this.catalogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.cerrarSesiónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            this.catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            this.catalogoToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.catalogoToolStripMenuItem.Text = "Archivos";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedaToolStripMenuItem,
            this.tipoDePagosToolStripMenuItem,
            this.conceptoCuentaToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // monedaToolStripMenuItem
            // 
            this.monedaToolStripMenuItem.Name = "monedaToolStripMenuItem";
            this.monedaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.monedaToolStripMenuItem.Text = "Moneda";
            this.monedaToolStripMenuItem.Click += new System.EventHandler(this.monedaToolStripMenuItem_Click);
            // 
            // tipoDePagosToolStripMenuItem
            // 
            this.tipoDePagosToolStripMenuItem.Name = "tipoDePagosToolStripMenuItem";
            this.tipoDePagosToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.tipoDePagosToolStripMenuItem.Text = "Tipo de Pagos";
            this.tipoDePagosToolStripMenuItem.Click += new System.EventHandler(this.tipoDePagosToolStripMenuItem_Click);
            // 
            // conceptoCuentaToolStripMenuItem
            // 
            this.conceptoCuentaToolStripMenuItem.Name = "conceptoCuentaToolStripMenuItem";
            this.conceptoCuentaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.conceptoCuentaToolStripMenuItem.Text = "Concepto Cuenta";
            this.conceptoCuentaToolStripMenuItem.Click += new System.EventHandler(this.conceptoCuentaToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cobroDeDeudaToolStripMenuItem,
            this.estadoCuentaToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 22);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // cobroDeDeudaToolStripMenuItem
            // 
            this.cobroDeDeudaToolStripMenuItem.Name = "cobroDeDeudaToolStripMenuItem";
            this.cobroDeDeudaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cobroDeDeudaToolStripMenuItem.Text = "Cobro de Deuda";
            this.cobroDeDeudaToolStripMenuItem.Click += new System.EventHandler(this.cobroDeDeudaToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeEstadoDeCuentaToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // reporteDeEstadoDeCuentaToolStripMenuItem
            // 
            this.reporteDeEstadoDeCuentaToolStripMenuItem.Name = "reporteDeEstadoDeCuentaToolStripMenuItem";
            this.reporteDeEstadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.reporteDeEstadoDeCuentaToolStripMenuItem.Text = "Reporte de Estado de Cuenta";
            this.reporteDeEstadoDeCuentaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEstadoDeCuentaToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // estadoCuentaToolStripMenuItem
            // 
            this.estadoCuentaToolStripMenuItem.Name = "estadoCuentaToolStripMenuItem";
            this.estadoCuentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.estadoCuentaToolStripMenuItem.Text = "Estado Cuenta";
            this.estadoCuentaToolStripMenuItem.Click += new System.EventHandler(this.estadoCuentaToolStripMenuItem_Click);
            // 
            // CPC_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 679);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CPC_MDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CPC_MDI";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDePagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobroDeDeudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEstadoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoCuentaToolStripMenuItem;
    }
}