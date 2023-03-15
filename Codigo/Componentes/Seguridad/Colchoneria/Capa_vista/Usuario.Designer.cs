
namespace Vista_Seguridad
{
    partial class Usuario
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
            this.Dgv_usuario = new System.Windows.Forms.DataGridView();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.TxtPA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ultimacon = new System.Windows.Forms.TextBox();
            this.navegador1 = new NavegadorVista.Navegador();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_usuario
            // 
            this.Dgv_usuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuario.Location = new System.Drawing.Point(15, 331);
            this.Dgv_usuario.Name = "Dgv_usuario";
            this.Dgv_usuario.Size = new System.Drawing.Size(671, 316);
            this.Dgv_usuario.TabIndex = 33;
            this.Dgv_usuario.Tag = "tbl_usuarios";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(201, 286);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(177, 20);
            this.txt2.TabIndex = 82;
            this.txt2.Tag = "pregunta";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(464, 260);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(177, 20);
            this.txt1.TabIndex = 81;
            this.txt1.Tag = "estado_usuario";
            // 
            // TxtPA
            // 
            this.TxtPA.Location = new System.Drawing.Point(464, 286);
            this.TxtPA.Name = "TxtPA";
            this.TxtPA.Size = new System.Drawing.Size(177, 20);
            this.TxtPA.TabIndex = 74;
            this.TxtPA.Tag = "respuesta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Respuesta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Estado";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 78;
            this.label9.Text = "Última conexión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Pregunta de autentificacion";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(464, 234);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(177, 20);
            this.txtemail.TabIndex = 72;
            this.txtemail.Tag = "email_usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(400, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "email";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(201, 234);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(177, 20);
            this.txtcontraseña.TabIndex = 69;
            this.txtcontraseña.Tag = "password_usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(400, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Id";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(464, 208);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(177, 20);
            this.txtusername.TabIndex = 71;
            this.txtusername.Tag = "username_usuario";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(201, 208);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(177, 20);
            this.txtapellido.TabIndex = 68;
            this.txtapellido.Tag = "apellido_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Apellido";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(201, 182);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(177, 20);
            this.txtId.TabIndex = 62;
            this.txtId.Tag = "pk_id_usuario";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(464, 182);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(177, 20);
            this.txtnombre.TabIndex = 65;
            this.txtnombre.Tag = "nombre_usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nombre";
            // 
            // Ultimacon
            // 
            this.Ultimacon.Location = new System.Drawing.Point(201, 260);
            this.Ultimacon.Name = "Ultimacon";
            this.Ultimacon.Size = new System.Drawing.Size(177, 20);
            this.Ultimacon.TabIndex = 79;
            this.Ultimacon.Tag = "ultima_conexion_usuario";
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(60, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(590, 152);
            this.navegador1.TabIndex = 83;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load_1);
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(698, 659);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.TxtPA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Ultimacon);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtapellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dgv_usuario);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgv_usuario;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox TxtPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Ultimacon;
        private NavegadorVista.Navegador navegador1;
    }
}