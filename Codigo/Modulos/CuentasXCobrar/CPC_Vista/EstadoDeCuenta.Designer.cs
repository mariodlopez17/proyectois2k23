
namespace CPC_Vista
{
    partial class EstadoDeCuenta
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
            this.display = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.ActiveViewIndex = -1;
            this.display.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Cursor = System.Windows.Forms.Cursors.Default;
            this.display.DisplayStatusBar = false;
            this.display.Location = new System.Drawing.Point(8, 8);
            this.display.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.display.Name = "display";
            this.display.ShowGroupTreeButton = false;
            this.display.ShowLogo = false;
            this.display.ShowParameterPanelButton = false;
            this.display.ShowTextSearchButton = false;
            this.display.Size = new System.Drawing.Size(1016, 529);
            this.display.TabIndex = 4;
            this.display.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // EstadoDeCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 543);
            this.Controls.Add(this.display);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EstadoDeCuenta";
            this.Text = "EstadoDeCuenta";
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer display;
    }
}