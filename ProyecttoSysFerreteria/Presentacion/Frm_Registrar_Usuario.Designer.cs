namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_Registrar_Usuario
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
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnCambiarClave = new System.Windows.Forms.Button();
            this.GbxCargo = new System.Windows.Forms.GroupBox();
            this.TxtCargo = new System.Windows.Forms.TextBox();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.GbxDatosContacto = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.GbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.GbxDocumento = new System.Windows.Forms.GroupBox();
            this.TxtTipoDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.GbxCargo.SuspendLayout();
            this.GbxDatosContacto.SuspendLayout();
            this.GbxDatosPersonales.SuspendLayout();
            this.GbxDocumento.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(193, 379);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(150, 30);
            this.BtnModificar.TabIndex = 33;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnCambiarClave
            // 
            this.BtnCambiarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnCambiarClave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCambiarClave.FlatAppearance.BorderSize = 0;
            this.BtnCambiarClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCambiarClave.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCambiarClave.ForeColor = System.Drawing.Color.White;
            this.BtnCambiarClave.Location = new System.Drawing.Point(364, 379);
            this.BtnCambiarClave.Name = "BtnCambiarClave";
            this.BtnCambiarClave.Size = new System.Drawing.Size(226, 30);
            this.BtnCambiarClave.TabIndex = 32;
            this.BtnCambiarClave.Text = "CAMBIAR CONTRASEÑA";
            this.BtnCambiarClave.UseVisualStyleBackColor = false;
            this.BtnCambiarClave.Click += new System.EventHandler(this.BtnCambiarClave_Click);
            // 
            // GbxCargo
            // 
            this.GbxCargo.Controls.Add(this.TxtCargo);
            this.GbxCargo.Location = new System.Drawing.Point(12, 102);
            this.GbxCargo.Name = "GbxCargo";
            this.GbxCargo.Size = new System.Drawing.Size(330, 62);
            this.GbxCargo.TabIndex = 31;
            this.GbxCargo.TabStop = false;
            this.GbxCargo.Text = "Cargo";
            // 
            // TxtCargo
            // 
            this.TxtCargo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCargo.Location = new System.Drawing.Point(15, 29);
            this.TxtCargo.Name = "TxtCargo";
            this.TxtCargo.ReadOnly = true;
            this.TxtCargo.Size = new System.Drawing.Size(300, 27);
            this.TxtCargo.TabIndex = 20;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardar.Enabled = false;
            this.BtnGuardar.FlatAppearance.BorderSize = 0;
            this.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.ForeColor = System.Drawing.Color.White;
            this.BtnGuardar.Location = new System.Drawing.Point(28, 379);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(150, 30);
            this.BtnGuardar.TabIndex = 27;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // GbxDatosContacto
            // 
            this.GbxDatosContacto.Controls.Add(this.label10);
            this.GbxDatosContacto.Controls.Add(this.label9);
            this.GbxDatosContacto.Controls.Add(this.label8);
            this.GbxDatosContacto.Controls.Add(this.label7);
            this.GbxDatosContacto.Controls.Add(this.label6);
            this.GbxDatosContacto.Controls.Add(this.TxtTelefono);
            this.GbxDatosContacto.Controls.Add(this.TxtPais);
            this.GbxDatosContacto.Controls.Add(this.TxtCiudad);
            this.GbxDatosContacto.Controls.Add(this.TxtDireccion);
            this.GbxDatosContacto.Controls.Add(this.TxtEmail);
            this.GbxDatosContacto.Location = new System.Drawing.Point(348, 98);
            this.GbxDatosContacto.Name = "GbxDatosContacto";
            this.GbxDatosContacto.Size = new System.Drawing.Size(330, 240);
            this.GbxDatosContacto.TabIndex = 30;
            this.GbxDatosContacto.TabStop = false;
            this.GbxDatosContacto.Text = "Datos de Contacto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Teléfono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Correo Electrónico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(169, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ciudad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "País";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(15, 201);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(300, 27);
            this.TxtTelefono.TabIndex = 10;
            // 
            // TxtPais
            // 
            this.TxtPais.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPais.Location = new System.Drawing.Point(15, 39);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(143, 27);
            this.TxtPais.TabIndex = 6;
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.Location = new System.Drawing.Point(172, 39);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(143, 27);
            this.TxtCiudad.TabIndex = 7;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(15, 93);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(300, 27);
            this.TxtDireccion.TabIndex = 8;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(15, 148);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 27);
            this.TxtEmail.TabIndex = 9;
            // 
            // GbxDatosPersonales
            // 
            this.GbxDatosPersonales.Controls.Add(this.label5);
            this.GbxDatosPersonales.Controls.Add(this.label4);
            this.GbxDatosPersonales.Controls.Add(this.label3);
            this.GbxDatosPersonales.Controls.Add(this.TxtNombres);
            this.GbxDatosPersonales.Controls.Add(this.TxtApellidos);
            this.GbxDatosPersonales.Controls.Add(this.DtpFechaNacimiento);
            this.GbxDatosPersonales.Location = new System.Drawing.Point(12, 175);
            this.GbxDatosPersonales.Name = "GbxDatosPersonales";
            this.GbxDatosPersonales.Size = new System.Drawing.Size(330, 198);
            this.GbxDatosPersonales.TabIndex = 29;
            this.GbxDatosPersonales.TabStop = false;
            this.GbxDatosPersonales.Text = "Datos Personales";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(15, 39);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(300, 27);
            this.TxtNombres.TabIndex = 3;
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellidos.Location = new System.Drawing.Point(15, 93);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(300, 27);
            this.TxtApellidos.TabIndex = 4;
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DtpFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.DtpFechaNacimiento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(15, 148);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(200, 27);
            this.DtpFechaNacimiento.TabIndex = 5;
            // 
            // GbxDocumento
            // 
            this.GbxDocumento.Controls.Add(this.TxtTipoDocumento);
            this.GbxDocumento.Controls.Add(this.label2);
            this.GbxDocumento.Controls.Add(this.label1);
            this.GbxDocumento.Controls.Add(this.TxtNumeroDocumento);
            this.GbxDocumento.Location = new System.Drawing.Point(12, 12);
            this.GbxDocumento.Name = "GbxDocumento";
            this.GbxDocumento.Size = new System.Drawing.Size(661, 80);
            this.GbxDocumento.TabIndex = 28;
            this.GbxDocumento.TabStop = false;
            this.GbxDocumento.Text = "Documento";
            // 
            // TxtTipoDocumento
            // 
            this.TxtTipoDocumento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipoDocumento.Location = new System.Drawing.Point(15, 40);
            this.TxtTipoDocumento.Name = "TxtTipoDocumento";
            this.TxtTipoDocumento.ReadOnly = true;
            this.TxtTipoDocumento.Size = new System.Drawing.Size(391, 27);
            this.TxtTipoDocumento.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Numero de Documento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tipo de Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(412, 40);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.ReadOnly = true;
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(239, 27);
            this.TxtNumeroDocumento.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(679, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 26);
            this.button5.TabIndex = 39;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Registrar_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 430);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnCambiarClave);
            this.Controls.Add(this.GbxCargo);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.GbxDatosContacto);
            this.Controls.Add(this.GbxDatosPersonales);
            this.Controls.Add(this.GbxDocumento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Registrar_Usuario";
            this.Text = "Frm_Buscar_Usuario";
            this.Load += new System.EventHandler(this.Frm_Registrar_Usuario_Load);
            this.GbxCargo.ResumeLayout(false);
            this.GbxCargo.PerformLayout();
            this.GbxDatosContacto.ResumeLayout(false);
            this.GbxDatosContacto.PerformLayout();
            this.GbxDatosPersonales.ResumeLayout(false);
            this.GbxDatosPersonales.PerformLayout();
            this.GbxDocumento.ResumeLayout(false);
            this.GbxDocumento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button BtnModificar;
        public System.Windows.Forms.Button BtnCambiarClave;
        private System.Windows.Forms.GroupBox GbxCargo;
        public System.Windows.Forms.TextBox TxtCargo;
        public System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.GroupBox GbxDatosContacto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtTelefono;
        public System.Windows.Forms.TextBox TxtPais;
        public System.Windows.Forms.TextBox TxtCiudad;
        public System.Windows.Forms.TextBox TxtDireccion;
        public System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.GroupBox GbxDatosPersonales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtNombres;
        public System.Windows.Forms.TextBox TxtApellidos;
        public System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.GroupBox GbxDocumento;
        public System.Windows.Forms.TextBox TxtTipoDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.Button button5;
    }
}