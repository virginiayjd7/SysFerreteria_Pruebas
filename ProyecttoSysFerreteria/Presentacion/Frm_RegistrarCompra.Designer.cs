namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_RegistrarCompra
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
            this.GbxProducto = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValorUnitario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.BtnBuscarProducto = new System.Windows.Forms.Button();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.GbxResumen = new System.Windows.Forms.GroupBox();
            this.RLblTotal = new System.Windows.Forms.Label();
            this.RLblIgv = new System.Windows.Forms.Label();
            this.RLblSubTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAumentarItem = new System.Windows.Forms.Button();
            this.BtnDisminuirItem = new System.Windows.Forms.Button();
            this.TxtCantidadItem = new System.Windows.Forms.TextBox();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.LblIDProveedor = new System.Windows.Forms.Label();
            this.BtnSearchProveedor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtRucProveedor = new System.Windows.Forms.TextBox();
            this.GbxComprobante = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.BtnGuardarCompra = new System.Windows.Forms.Button();
            this.GbxDetalle = new System.Windows.Forms.GroupBox();
            this.MLVDetalle = new System.Windows.Forms.ListView();
            this.button5 = new System.Windows.Forms.Button();
            this.GbxProducto.SuspendLayout();
            this.GbxResumen.SuspendLayout();
            this.GbxCliente.SuspendLayout();
            this.GbxComprobante.SuspendLayout();
            this.GbxDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbxProducto
            // 
            this.GbxProducto.BackColor = System.Drawing.Color.Honeydew;
            this.GbxProducto.Controls.Add(this.BtnAgregar);
            this.GbxProducto.Controls.Add(this.label4);
            this.GbxProducto.Controls.Add(this.TxtValorUnitario);
            this.GbxProducto.Controls.Add(this.label11);
            this.GbxProducto.Controls.Add(this.label7);
            this.GbxProducto.Controls.Add(this.TxtNombre);
            this.GbxProducto.Controls.Add(this.BtnBuscarProducto);
            this.GbxProducto.Controls.Add(this.TxtCodigo);
            this.GbxProducto.Location = new System.Drawing.Point(12, 184);
            this.GbxProducto.Name = "GbxProducto";
            this.GbxProducto.Size = new System.Drawing.Size(760, 73);
            this.GbxProducto.TabIndex = 32;
            this.GbxProducto.TabStop = false;
            this.GbxProducto.Text = "Producto";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(145)))), ((int)(((byte)(88)))));
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(659, 35);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(95, 27);
            this.BtnAgregar.TabIndex = 24;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Valor Unitario";
            // 
            // TxtValorUnitario
            // 
            this.TxtValorUnitario.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorUnitario.Location = new System.Drawing.Point(552, 35);
            this.TxtValorUnitario.Name = "TxtValorUnitario";
            this.TxtValorUnitario.Size = new System.Drawing.Size(101, 27);
            this.TxtValorUnitario.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(185, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Código";
            // 
            // TxtNombre
            // 
            this.TxtNombre.BackColor = System.Drawing.Color.White;
            this.TxtNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(188, 35);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(358, 27);
            this.TxtNombre.TabIndex = 10;
            // 
            // BtnBuscarProducto
            // 
            this.BtnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscarProducto.FlatAppearance.BorderSize = 0;
            this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProducto.Location = new System.Drawing.Point(153, 35);
            this.BtnBuscarProducto.Name = "BtnBuscarProducto";
            this.BtnBuscarProducto.Size = new System.Drawing.Size(30, 27);
            this.BtnBuscarProducto.TabIndex = 9;
            this.BtnBuscarProducto.UseVisualStyleBackColor = false;
            this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(18, 35);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(129, 27);
            this.TxtCodigo.TabIndex = 8;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // GbxResumen
            // 
            this.GbxResumen.Controls.Add(this.RLblTotal);
            this.GbxResumen.Controls.Add(this.RLblIgv);
            this.GbxResumen.Controls.Add(this.RLblSubTotal);
            this.GbxResumen.Controls.Add(this.label10);
            this.GbxResumen.Controls.Add(this.label9);
            this.GbxResumen.Controls.Add(this.label8);
            this.GbxResumen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxResumen.Location = new System.Drawing.Point(490, 469);
            this.GbxResumen.Name = "GbxResumen";
            this.GbxResumen.Size = new System.Drawing.Size(282, 100);
            this.GbxResumen.TabIndex = 29;
            this.GbxResumen.TabStop = false;
            this.GbxResumen.Text = "Resumen";
            // 
            // RLblTotal
            // 
            this.RLblTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.RLblTotal.Location = new System.Drawing.Point(110, 73);
            this.RLblTotal.Name = "RLblTotal";
            this.RLblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblTotal.Size = new System.Drawing.Size(161, 16);
            this.RLblTotal.TabIndex = 5;
            this.RLblTotal.Text = "S/. 00.00";
            // 
            // RLblIgv
            // 
            this.RLblIgv.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblIgv.Location = new System.Drawing.Point(109, 48);
            this.RLblIgv.Name = "RLblIgv";
            this.RLblIgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblIgv.Size = new System.Drawing.Size(162, 13);
            this.RLblIgv.TabIndex = 4;
            this.RLblIgv.Text = "S/. 00.00";
            // 
            // RLblSubTotal
            // 
            this.RLblSubTotal.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RLblSubTotal.Location = new System.Drawing.Point(119, 22);
            this.RLblSubTotal.Name = "RLblSubTotal";
            this.RLblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RLblSubTotal.Size = new System.Drawing.Size(152, 13);
            this.RLblSubTotal.TabIndex = 3;
            this.RLblSubTotal.Text = "S/. 00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "IGV: (18%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sub Total:";
            // 
            // BtnAumentarItem
            // 
            this.BtnAumentarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnAumentarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAumentarItem.FlatAppearance.BorderSize = 0;
            this.BtnAumentarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAumentarItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAumentarItem.ForeColor = System.Drawing.Color.White;
            this.BtnAumentarItem.Location = new System.Drawing.Point(112, 469);
            this.BtnAumentarItem.Name = "BtnAumentarItem";
            this.BtnAumentarItem.Size = new System.Drawing.Size(33, 23);
            this.BtnAumentarItem.TabIndex = 28;
            this.BtnAumentarItem.Text = "+";
            this.BtnAumentarItem.UseVisualStyleBackColor = false;
            // 
            // BtnDisminuirItem
            // 
            this.BtnDisminuirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnDisminuirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDisminuirItem.FlatAppearance.BorderSize = 0;
            this.BtnDisminuirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisminuirItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisminuirItem.ForeColor = System.Drawing.Color.White;
            this.BtnDisminuirItem.Location = new System.Drawing.Point(12, 469);
            this.BtnDisminuirItem.Name = "BtnDisminuirItem";
            this.BtnDisminuirItem.Size = new System.Drawing.Size(33, 23);
            this.BtnDisminuirItem.TabIndex = 30;
            this.BtnDisminuirItem.Text = "-";
            this.BtnDisminuirItem.UseVisualStyleBackColor = false;
            // 
            // TxtCantidadItem
            // 
            this.TxtCantidadItem.BackColor = System.Drawing.Color.White;
            this.TxtCantidadItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadItem.Location = new System.Drawing.Point(46, 469);
            this.TxtCantidadItem.Name = "TxtCantidadItem";
            this.TxtCantidadItem.Size = new System.Drawing.Size(65, 23);
            this.TxtCantidadItem.TabIndex = 27;
            this.TxtCantidadItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitar.FlatAppearance.BorderSize = 0;
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.ForeColor = System.Drawing.Color.White;
            this.BtnQuitar.Location = new System.Drawing.Point(155, 469);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitar.TabIndex = 31;
            this.BtnQuitar.Text = "QUITAR";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click);
            // 
            // GbxCliente
            // 
            this.GbxCliente.BackColor = System.Drawing.Color.Honeydew;
            this.GbxCliente.Controls.Add(this.LblIDProveedor);
            this.GbxCliente.Controls.Add(this.BtnSearchProveedor);
            this.GbxCliente.Controls.Add(this.label6);
            this.GbxCliente.Controls.Add(this.TxtRazonSocial);
            this.GbxCliente.Controls.Add(this.label5);
            this.GbxCliente.Controls.Add(this.TxtRucProveedor);
            this.GbxCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCliente.Location = new System.Drawing.Point(12, 98);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(760, 80);
            this.GbxCliente.TabIndex = 25;
            this.GbxCliente.TabStop = false;
            this.GbxCliente.Text = "Proveedor";
            // 
            // LblIDProveedor
            // 
            this.LblIDProveedor.AutoSize = true;
            this.LblIDProveedor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDProveedor.Location = new System.Drawing.Point(218, 21);
            this.LblIDProveedor.Name = "LblIDProveedor";
            this.LblIDProveedor.Size = new System.Drawing.Size(15, 13);
            this.LblIDProveedor.TabIndex = 17;
            this.LblIDProveedor.Text = "0";
            this.LblIDProveedor.Visible = false;
            // 
            // BtnSearchProveedor
            // 
            this.BtnSearchProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnSearchProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearchProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchProveedor.FlatAppearance.BorderSize = 0;
            this.BtnSearchProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchProveedor.ForeColor = System.Drawing.Color.White;
            this.BtnSearchProveedor.Location = new System.Drawing.Point(239, 37);
            this.BtnSearchProveedor.Name = "BtnSearchProveedor";
            this.BtnSearchProveedor.Size = new System.Drawing.Size(30, 27);
            this.BtnSearchProveedor.TabIndex = 6;
            this.BtnSearchProveedor.UseVisualStyleBackColor = false;
            this.BtnSearchProveedor.Click += new System.EventHandler(this.BtnSearchProveedor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Razon Social o Nombre";
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.BackColor = System.Drawing.Color.White;
            this.TxtRazonSocial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRazonSocial.Location = new System.Drawing.Point(275, 37);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.ReadOnly = true;
            this.TxtRazonSocial.Size = new System.Drawing.Size(471, 27);
            this.TxtRazonSocial.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "RUC";
            // 
            // TxtRucProveedor
            // 
            this.TxtRucProveedor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRucProveedor.Location = new System.Drawing.Point(18, 37);
            this.TxtRucProveedor.Name = "TxtRucProveedor";
            this.TxtRucProveedor.Size = new System.Drawing.Size(215, 27);
            this.TxtRucProveedor.TabIndex = 5;
            this.TxtRucProveedor.TextChanged += new System.EventHandler(this.TxtRucProveedor_TextChanged);
            // 
            // GbxComprobante
            // 
            this.GbxComprobante.BackColor = System.Drawing.Color.Honeydew;
            this.GbxComprobante.Controls.Add(this.label12);
            this.GbxComprobante.Controls.Add(this.DtpFecha);
            this.GbxComprobante.Controls.Add(this.label3);
            this.GbxComprobante.Controls.Add(this.TxtNumero);
            this.GbxComprobante.Controls.Add(this.label2);
            this.GbxComprobante.Controls.Add(this.TxtSerie);
            this.GbxComprobante.Controls.Add(this.label1);
            this.GbxComprobante.Controls.Add(this.CbxTipoComprobante);
            this.GbxComprobante.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxComprobante.Location = new System.Drawing.Point(12, 12);
            this.GbxComprobante.Name = "GbxComprobante";
            this.GbxComprobante.Size = new System.Drawing.Size(760, 80);
            this.GbxComprobante.TabIndex = 24;
            this.GbxComprobante.TabStop = false;
            this.GbxComprobante.Text = "Comprobante";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(562, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Fecha";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFecha.Location = new System.Drawing.Point(565, 38);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(181, 27);
            this.DtpFecha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(346, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.White;
            this.TxtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(349, 38);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(210, 27);
            this.TxtNumero.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serie";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BackColor = System.Drawing.Color.White;
            this.TxtSerie.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerie.Location = new System.Drawing.Point(234, 38);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.Size = new System.Drawing.Size(109, 27);
            this.TxtSerie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tipo de comprobante";
            // 
            // CbxTipoComprobante
            // 
            this.CbxTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxTipoComprobante.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxTipoComprobante.FormattingEnabled = true;
            this.CbxTipoComprobante.Location = new System.Drawing.Point(18, 38);
            this.CbxTipoComprobante.Name = "CbxTipoComprobante";
            this.CbxTipoComprobante.Size = new System.Drawing.Size(210, 26);
            this.CbxTipoComprobante.TabIndex = 1;
            // 
            // BtnGuardarCompra
            // 
            this.BtnGuardarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnGuardarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarCompra.FlatAppearance.BorderSize = 0;
            this.BtnGuardarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarCompra.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarCompra.ForeColor = System.Drawing.Color.White;
            this.BtnGuardarCompra.Location = new System.Drawing.Point(12, 518);
            this.BtnGuardarCompra.Name = "BtnGuardarCompra";
            this.BtnGuardarCompra.Size = new System.Drawing.Size(163, 40);
            this.BtnGuardarCompra.TabIndex = 33;
            this.BtnGuardarCompra.Text = "GUARDAR COMPRA";
            this.BtnGuardarCompra.UseVisualStyleBackColor = false;
            this.BtnGuardarCompra.Click += new System.EventHandler(this.BtnGuardarCompra_Click);
            // 
            // GbxDetalle
            // 
            this.GbxDetalle.Controls.Add(this.MLVDetalle);
            this.GbxDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDetalle.Location = new System.Drawing.Point(12, 263);
            this.GbxDetalle.Name = "GbxDetalle";
            this.GbxDetalle.Size = new System.Drawing.Size(760, 200);
            this.GbxDetalle.TabIndex = 26;
            this.GbxDetalle.TabStop = false;
            this.GbxDetalle.Text = "Detalle del documento";
            // 
            // MLVDetalle
            // 
            this.MLVDetalle.Location = new System.Drawing.Point(6, 20);
            this.MLVDetalle.Name = "MLVDetalle";
            this.MLVDetalle.Size = new System.Drawing.Size(725, 174);
            this.MLVDetalle.TabIndex = 0;
            this.MLVDetalle.UseCompatibleStateImageBehavior = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(874, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 26);
            this.button5.TabIndex = 39;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_RegistrarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(909, 573);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnGuardarCompra);
            this.Controls.Add(this.GbxProducto);
            this.Controls.Add(this.GbxResumen);
            this.Controls.Add(this.BtnAumentarItem);
            this.Controls.Add(this.BtnDisminuirItem);
            this.Controls.Add(this.TxtCantidadItem);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.GbxDetalle);
            this.Controls.Add(this.GbxCliente);
            this.Controls.Add(this.GbxComprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_RegistrarCompra";
            this.Text = "Frm_RegistrarCompra";
            this.Load += new System.EventHandler(this.Frm_RegistrarCompra_Load);
            this.GbxProducto.ResumeLayout(false);
            this.GbxProducto.PerformLayout();
            this.GbxResumen.ResumeLayout(false);
            this.GbxResumen.PerformLayout();
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            this.GbxComprobante.ResumeLayout(false);
            this.GbxComprobante.PerformLayout();
            this.GbxDetalle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbxProducto;
        public System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValorUnitario;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button BtnBuscarProducto;
        public System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.GroupBox GbxResumen;
        private System.Windows.Forms.Label RLblTotal;
        private System.Windows.Forms.Label RLblIgv;
        private System.Windows.Forms.Label RLblSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAumentarItem;
        private System.Windows.Forms.Button BtnDisminuirItem;
        private System.Windows.Forms.TextBox TxtCantidadItem;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.GroupBox GbxCliente;
        public System.Windows.Forms.Label LblIDProveedor;
        private System.Windows.Forms.Button BtnSearchProveedor;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtRucProveedor;
        private System.Windows.Forms.GroupBox GbxComprobante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipoComprobante;
        private System.Windows.Forms.Button BtnGuardarCompra;
        private System.Windows.Forms.GroupBox GbxDetalle;
        private System.Windows.Forms.ListView MLVDetalle;
        private System.Windows.Forms.Button button5;
    }
}