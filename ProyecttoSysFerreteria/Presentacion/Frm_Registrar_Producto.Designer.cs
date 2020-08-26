namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_Registrar_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registrar_Producto));
            this.label5 = new System.Windows.Forms.Label();
            this.CbxMarca = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRemoverImagen = new System.Windows.Forms.Button();
            this.BtnUpImage = new System.Windows.Forms.Button();
            this.PtbImagen = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxUnidadMedida = new System.Windows.Forms.ComboBox();
            this.CbxTipoExistencia = new System.Windows.Forms.ComboBox();
            this.CbxSubCategoria = new System.Windows.Forms.ComboBox();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(12, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "Marca";
            // 
            // CbxMarca
            // 
            this.CbxMarca.BackColor = System.Drawing.Color.White;
            this.CbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxMarca.DropDownWidth = 270;
            this.CbxMarca.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxMarca.FormattingEnabled = true;
            this.CbxMarca.IntegralHeight = false;
            this.CbxMarca.Location = new System.Drawing.Point(15, 258);
            this.CbxMarca.Name = "CbxMarca";
            this.CbxMarca.Size = new System.Drawing.Size(370, 26);
            this.CbxMarca.TabIndex = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnRemoverImagen);
            this.groupBox1.Controls.Add(this.BtnUpImage);
            this.groupBox1.Controls.Add(this.PtbImagen);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(402, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 312);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imagen";
            // 
            // BtnRemoverImagen
            // 
            this.BtnRemoverImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnRemoverImagen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(112)))));
            this.BtnRemoverImagen.FlatAppearance.BorderSize = 0;
            this.BtnRemoverImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(51)))));
            this.BtnRemoverImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoverImagen.ForeColor = System.Drawing.Color.White;
            this.BtnRemoverImagen.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemoverImagen.Image")));
            this.BtnRemoverImagen.Location = new System.Drawing.Point(129, 271);
            this.BtnRemoverImagen.Name = "BtnRemoverImagen";
            this.BtnRemoverImagen.Size = new System.Drawing.Size(127, 37);
            this.BtnRemoverImagen.TabIndex = 139;
            this.BtnRemoverImagen.Text = "Eliminar";
            this.BtnRemoverImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRemoverImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRemoverImagen.UseVisualStyleBackColor = false;
            this.BtnRemoverImagen.Click += new System.EventHandler(this.BtnRemoverImagen_Click);
            // 
            // BtnUpImage
            // 
            this.BtnUpImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnUpImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(112)))));
            this.BtnUpImage.FlatAppearance.BorderSize = 0;
            this.BtnUpImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(51)))));
            this.BtnUpImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpImage.ForeColor = System.Drawing.Color.White;
            this.BtnUpImage.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpImage.Image")));
            this.BtnUpImage.Location = new System.Drawing.Point(6, 270);
            this.BtnUpImage.Name = "BtnUpImage";
            this.BtnUpImage.Size = new System.Drawing.Size(117, 38);
            this.BtnUpImage.TabIndex = 140;
            this.BtnUpImage.Text = "Imagen";
            this.BtnUpImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpImage.UseVisualStyleBackColor = false;
            this.BtnUpImage.Click += new System.EventHandler(this.BtnUpImage_Click);
            // 
            // PtbImagen
            // 
            this.PtbImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbImagen.Location = new System.Drawing.Point(6, 17);
            this.PtbImagen.Name = "PtbImagen";
            this.PtbImagen.Size = new System.Drawing.Size(250, 250);
            this.PtbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbImagen.TabIndex = 14;
            this.PtbImagen.TabStop = false;
            this.PtbImagen.Click += new System.EventHandler(this.PtbImagen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label7.Location = new System.Drawing.Point(12, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Unidad de Medida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo de Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 35;
            this.label4.Text = "Sub Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // CbxUnidadMedida
            // 
            this.CbxUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxUnidadMedida.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxUnidadMedida.FormattingEnabled = true;
            this.CbxUnidadMedida.Location = new System.Drawing.Point(15, 362);
            this.CbxUnidadMedida.Name = "CbxUnidadMedida";
            this.CbxUnidadMedida.Size = new System.Drawing.Size(370, 26);
            this.CbxUnidadMedida.TabIndex = 31;
            // 
            // CbxTipoExistencia
            // 
            this.CbxTipoExistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoExistencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoExistencia.FormattingEnabled = true;
            this.CbxTipoExistencia.Location = new System.Drawing.Point(15, 310);
            this.CbxTipoExistencia.Name = "CbxTipoExistencia";
            this.CbxTipoExistencia.Size = new System.Drawing.Size(370, 26);
            this.CbxTipoExistencia.TabIndex = 30;
            // 
            // CbxSubCategoria
            // 
            this.CbxSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSubCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxSubCategoria.FormattingEnabled = true;
            this.CbxSubCategoria.Location = new System.Drawing.Point(15, 204);
            this.CbxSubCategoria.Name = "CbxSubCategoria";
            this.CbxSubCategoria.Size = new System.Drawing.Size(370, 26);
            this.CbxSubCategoria.TabIndex = 29;
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.BackColor = System.Drawing.Color.White;
            this.CbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxCategoria.DropDownWidth = 270;
            this.CbxCategoria.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.IntegralHeight = false;
            this.CbxCategoria.Location = new System.Drawing.Point(15, 145);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(370, 26);
            this.CbxCategoria.TabIndex = 28;
            this.CbxCategoria.SelectedIndexChanged += new System.EventHandler(this.CbxCategoria_SelectedIndexChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(15, 87);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(370, 27);
            this.TxtNombre.TabIndex = 27;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(15, 30);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(370, 27);
            this.TxtCodigo.TabIndex = 26;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(112)))));
            this.btnguardar.FlatAppearance.BorderSize = 0;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(51)))));
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(27, 401);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(135, 37);
            this.btnguardar.TabIndex = 137;
            this.btnguardar.Text = "  Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(642, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 26);
            this.button5.TabIndex = 141;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Registrar_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbxMarca);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbxUnidadMedida);
            this.Controls.Add(this.CbxTipoExistencia);
            this.Controls.Add(this.CbxSubCategoria);
            this.Controls.Add(this.CbxCategoria);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Registrar_Producto";
            this.Text = "Frm_Registrar_Producto";
            this.Load += new System.EventHandler(this.Frm_Registrar_Producto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PtbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox CbxMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.PictureBox PtbImagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox CbxUnidadMedida;
        public System.Windows.Forms.ComboBox CbxTipoExistencia;
        public System.Windows.Forms.ComboBox CbxSubCategoria;
        public System.Windows.Forms.ComboBox CbxCategoria;
        public System.Windows.Forms.TextBox TxtNombre;
        public System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Button BtnUpImage;
        private System.Windows.Forms.Button BtnRemoverImagen;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button5;
    }
}