
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.check = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CmbPA = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtPA = new System.Windows.Forms.TextBox();
            this.TxtPAA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnInsert = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.check);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtusername);
            this.groupBox2.Controls.Add(this.txtcontraseña);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(44, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 128);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario";
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Location = new System.Drawing.Point(36, 97);
            this.check.Margin = new System.Windows.Forms.Padding(2);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(70, 17);
            this.check.TabIndex = 9;
            this.check.Text = "Visualizar";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(105, 33);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(220, 20);
            this.txtusername.TabIndex = 7;
            this.txtusername.Tag = "username_usuario";
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(105, 64);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.PasswordChar = '*';
            this.txtcontraseña.Size = new System.Drawing.Size(220, 20);
            this.txtcontraseña.TabIndex = 5;
            this.txtcontraseña.Tag = "password_usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtapellido);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtnombre);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(407, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 137);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Personales";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(105, 98);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(215, 20);
            this.txtemail.TabIndex = 7;
            this.txtemail.Tag = "email_usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "email";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(105, 64);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(215, 20);
            this.txtapellido.TabIndex = 5;
            this.txtapellido.Tag = "apellido_usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Apellido";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(105, 30);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(215, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Tag = "nombre_usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtestado);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(80, 311);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(288, 77);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(165, 31);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(40, 20);
            this.txtestado.TabIndex = 8;
            this.txtestado.Tag = "estado_usuario";
            this.txtestado.TextChanged += new System.EventHandler(this.txtestado_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(63, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Activo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CmbPA);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TxtPA);
            this.groupBox5.Controls.Add(this.TxtPAA);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(407, 319);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 69);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Recuperacion";
            // 
            // CmbPA
            // 
            this.CmbPA.FormattingEnabled = true;
            this.CmbPA.Items.AddRange(new object[] {
            "PRIMER MASCOTA",
            "COLOR FAVORITO",
            "CIUDAD NACIMIENTO",
            "SEGUNDO APELLIDO DEL PADRE",
            "PRIMER CENTRO DE ESTUDIO"});
            this.CmbPA.Location = new System.Drawing.Point(6, 33);
            this.CmbPA.Name = "CmbPA";
            this.CmbPA.Size = new System.Drawing.Size(121, 21);
            this.CmbPA.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Respuesta";
            // 
            // TxtPA
            // 
            this.TxtPA.Location = new System.Drawing.Point(183, 33);
            this.TxtPA.Name = "TxtPA";
            this.TxtPA.Size = new System.Drawing.Size(114, 20);
            this.TxtPA.TabIndex = 9;
            this.TxtPA.Tag = "respuesta";
            // 
            // TxtPAA
            // 
            this.TxtPAA.Location = new System.Drawing.Point(133, 34);
            this.TxtPAA.Name = "TxtPAA";
            this.TxtPAA.Size = new System.Drawing.Size(19, 20);
            this.TxtPAA.TabIndex = 12;
            this.TxtPAA.Tag = "pregunta";
            this.TxtPAA.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pregunta de autentificacion";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.btnExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnExit.IconSize = 40;
            this.btnExit.Location = new System.Drawing.Point(467, 109);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 61);
            this.btnExit.TabIndex = 78;
            this.btnExit.Text = "Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnModificar.IconSize = 40;
            this.btnModificar.Location = new System.Drawing.Point(317, 109);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(69, 61);
            this.btnModificar.TabIndex = 77;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnInsert.FlatAppearance.BorderSize = 2;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnInsert.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btnInsert.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnInsert.IconSize = 40;
            this.btnInsert.Location = new System.Drawing.Point(240, 109);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(69, 61);
            this.btnInsert.TabIndex = 74;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.BorderSize = 2;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.DimGray;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 40;
            this.btnDelete.Location = new System.Drawing.Point(392, 109);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 61);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBusqueda);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(192, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 82);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modificar";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(110, 33);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(177, 20);
            this.txtBusqueda.TabIndex = 1;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(788, 451);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CmbPA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtPA;
        private System.Windows.Forms.TextBox TxtPAA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnInsert;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBusqueda;
    }
}