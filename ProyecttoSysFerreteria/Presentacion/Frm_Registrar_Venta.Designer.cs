using System;

namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_Registrar_Venta
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
            this.BtnGuardarVenta = new System.Windows.Forms.Button();
            this.BtnSearchProducto = new System.Windows.Forms.Button();
            this.TxtProducto = new System.Windows.Forms.TextBox();
            this.PbxImgProducto = new System.Windows.Forms.PictureBox();
            this.BtnAumentarItem = new System.Windows.Forms.Button();
            this.BtnDisminuirItem = new System.Windows.Forms.Button();
            this.TxtCantidadItem = new System.Windows.Forms.TextBox();
            this.GbxResumen = new System.Windows.Forms.GroupBox();
            this.RLblTotal = new System.Windows.Forms.Label();
            this.RLblIgv = new System.Windows.Forms.Label();
            this.RLblSubTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnQuitar = new System.Windows.Forms.Button();
            this.GbxDetalle = new System.Windows.Forms.GroupBox();
            this.MLVDetalle = new System.Windows.Forms.ListView();
            this.GbxCliente = new System.Windows.Forms.GroupBox();
            this.LblIDCliente = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.BtnSearchCliente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.GbxComprobante = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtFechaEmision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSerie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxTipoComprobante = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxImgProducto)).BeginInit();
            this.GbxResumen.SuspendLayout();
            this.GbxDetalle.SuspendLayout();
            this.GbxCliente.SuspendLayout();
            this.GbxComprobante.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnGuardarVenta
            // 
            this.BtnGuardarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnGuardarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGuardarVenta.FlatAppearance.BorderSize = 0;
            this.BtnGuardarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGuardarVenta.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarVenta.Location = new System.Drawing.Point(12, 500);
            this.BtnGuardarVenta.Name = "BtnGuardarVenta";
            this.BtnGuardarVenta.Size = new System.Drawing.Size(163, 40);
            this.BtnGuardarVenta.TabIndex = 33;
            this.BtnGuardarVenta.Text = "GUARDAR VENTA";
            this.BtnGuardarVenta.UseVisualStyleBackColor = false;
            this.BtnGuardarVenta.Click += new System.EventHandler(this.BtnGuardarVenta_Click);
            // 
            // BtnSearchProducto
            // 
            this.BtnSearchProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnSearchProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearchProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchProducto.FlatAppearance.BorderSize = 0;
            this.BtnSearchProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchProducto.ForeColor = System.Drawing.Color.White;
            this.BtnSearchProducto.Location = new System.Drawing.Point(736, 201);
            this.BtnSearchProducto.Name = "BtnSearchProducto";
            this.BtnSearchProducto.Size = new System.Drawing.Size(30, 27);
            this.BtnSearchProducto.TabIndex = 31;
            this.BtnSearchProducto.UseVisualStyleBackColor = false;
            this.BtnSearchProducto.Click += new System.EventHandler(this.BtnSearchProducto_Click);
            // 
            // TxtProducto
            // 
            this.TxtProducto.BackColor = System.Drawing.Color.White;
            this.TxtProducto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProducto.Location = new System.Drawing.Point(584, 201);
            this.TxtProducto.Name = "TxtProducto";
            this.TxtProducto.Size = new System.Drawing.Size(146, 27);
            this.TxtProducto.TabIndex = 32;
            // 
            // PbxImgProducto
            // 
            this.PbxImgProducto.Location = new System.Drawing.Point(584, 15);
            this.PbxImgProducto.Name = "PbxImgProducto";
            this.PbxImgProducto.Size = new System.Drawing.Size(180, 180);
            this.PbxImgProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbxImgProducto.TabIndex = 30;
            this.PbxImgProducto.TabStop = false;
            // 
            // BtnAumentarItem
            // 
            this.BtnAumentarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnAumentarItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAumentarItem.FlatAppearance.BorderSize = 0;
            this.BtnAumentarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAumentarItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAumentarItem.ForeColor = System.Drawing.Color.White;
            this.BtnAumentarItem.Location = new System.Drawing.Point(112, 438);
            this.BtnAumentarItem.Name = "BtnAumentarItem";
            this.BtnAumentarItem.Size = new System.Drawing.Size(33, 23);
            this.BtnAumentarItem.TabIndex = 29;
            this.BtnAumentarItem.Text = "+";
            this.BtnAumentarItem.UseVisualStyleBackColor = false;
            this.BtnAumentarItem.Click += new System.EventHandler(this.BtnAumentarItem_Click);
            // 
            // BtnDisminuirItem
            // 
            this.BtnDisminuirItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BtnDisminuirItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDisminuirItem.FlatAppearance.BorderSize = 0;
            this.BtnDisminuirItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisminuirItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisminuirItem.ForeColor = System.Drawing.Color.White;
            this.BtnDisminuirItem.Location = new System.Drawing.Point(12, 438);
            this.BtnDisminuirItem.Name = "BtnDisminuirItem";
            this.BtnDisminuirItem.Size = new System.Drawing.Size(33, 23);
            this.BtnDisminuirItem.TabIndex = 28;
            this.BtnDisminuirItem.Text = "-";
            this.BtnDisminuirItem.UseVisualStyleBackColor = false;
            // 
            // TxtCantidadItem
            // 
            this.TxtCantidadItem.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadItem.Location = new System.Drawing.Point(46, 438);
            this.TxtCantidadItem.Name = "TxtCantidadItem";
            this.TxtCantidadItem.Size = new System.Drawing.Size(65, 23);
            this.TxtCantidadItem.TabIndex = 27;
            this.TxtCantidadItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.GbxResumen.Location = new System.Drawing.Point(490, 440);
            this.GbxResumen.Name = "GbxResumen";
            this.GbxResumen.Size = new System.Drawing.Size(282, 100);
            this.GbxResumen.TabIndex = 26;
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
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
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
            // BtnQuitar
            // 
            this.BtnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuitar.FlatAppearance.BorderSize = 0;
            this.BtnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnQuitar.Location = new System.Drawing.Point(155, 438);
            this.BtnQuitar.Name = "BtnQuitar";
            this.BtnQuitar.Size = new System.Drawing.Size(75, 23);
            this.BtnQuitar.TabIndex = 25;
            this.BtnQuitar.Text = "QUITAR";
            this.BtnQuitar.UseVisualStyleBackColor = false;
            this.BtnQuitar.Click += new System.EventHandler(this.BtnQuitar_Click_1);
            // 
            // GbxDetalle
            // 
            this.GbxDetalle.Controls.Add(this.MLVDetalle);
            this.GbxDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GbxDetalle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDetalle.Location = new System.Drawing.Point(12, 234);
            this.GbxDetalle.Name = "GbxDetalle";
            this.GbxDetalle.Size = new System.Drawing.Size(760, 200);
            this.GbxDetalle.TabIndex = 24;
            this.GbxDetalle.TabStop = false;
            this.GbxDetalle.Text = "Detalle del documento";
            // 
            // MLVDetalle
            // 
            this.MLVDetalle.Location = new System.Drawing.Point(6, 20);
            this.MLVDetalle.Name = "MLVDetalle";
            this.MLVDetalle.Size = new System.Drawing.Size(730, 163);
            this.MLVDetalle.TabIndex = 0;
            this.MLVDetalle.UseCompatibleStateImageBehavior = false;
            this.MLVDetalle.SelectedIndexChanged += new System.EventHandler(this.MLVDetalle_SelectedIndexChanged_1);
            // 
            // GbxCliente
            // 
            this.GbxCliente.Controls.Add(this.LblIDCliente);
            this.GbxCliente.Controls.Add(this.label7);
            this.GbxCliente.Controls.Add(this.TxtDireccion);
            this.GbxCliente.Controls.Add(this.BtnSearchCliente);
            this.GbxCliente.Controls.Add(this.label6);
            this.GbxCliente.Controls.Add(this.TxtNombres);
            this.GbxCliente.Controls.Add(this.label5);
            this.GbxCliente.Controls.Add(this.TxtNumeroDocumento);
            this.GbxCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxCliente.Location = new System.Drawing.Point(12, 98);
            this.GbxCliente.Name = "GbxCliente";
            this.GbxCliente.Size = new System.Drawing.Size(550, 130);
            this.GbxCliente.TabIndex = 23;
            this.GbxCliente.TabStop = false;
            this.GbxCliente.Text = "Cliente";
            // 
            // LblIDCliente
            // 
            this.LblIDCliente.AutoSize = true;
            this.LblIDCliente.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIDCliente.Location = new System.Drawing.Point(167, 21);
            this.LblIDCliente.Name = "LblIDCliente";
            this.LblIDCliente.Size = new System.Drawing.Size(15, 13);
            this.LblIDCliente.TabIndex = 22;
            this.LblIDCliente.Text = "0";
            this.LblIDCliente.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.BackColor = System.Drawing.Color.White;
            this.TxtDireccion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDireccion.Location = new System.Drawing.Point(18, 90);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ReadOnly = true;
            this.TxtDireccion.Size = new System.Drawing.Size(512, 27);
            this.TxtDireccion.TabIndex = 18;
            // 
            // BtnSearchCliente
            // 
            this.BtnSearchCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.BtnSearchCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSearchCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearchCliente.FlatAppearance.BorderSize = 0;
            this.BtnSearchCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearchCliente.ForeColor = System.Drawing.Color.White;
            this.BtnSearchCliente.Location = new System.Drawing.Point(188, 37);
            this.BtnSearchCliente.Name = "BtnSearchCliente";
            this.BtnSearchCliente.Size = new System.Drawing.Size(30, 27);
            this.BtnSearchCliente.TabIndex = 17;
            this.BtnSearchCliente.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Nombres";
            // 
            // TxtNombres
            // 
            this.TxtNombres.BackColor = System.Drawing.Color.White;
            this.TxtNombres.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombres.Location = new System.Drawing.Point(224, 37);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.ReadOnly = true;
            this.TxtNombres.Size = new System.Drawing.Size(306, 27);
            this.TxtNombres.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número Documento";
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(18, 37);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(164, 27);
            this.TxtNumeroDocumento.TabIndex = 14;
            // 
            // GbxComprobante
            // 
            this.GbxComprobante.Controls.Add(this.label4);
            this.GbxComprobante.Controls.Add(this.TxtFechaEmision);
            this.GbxComprobante.Controls.Add(this.label3);
            this.GbxComprobante.Controls.Add(this.TxtNumero);
            this.GbxComprobante.Controls.Add(this.label2);
            this.GbxComprobante.Controls.Add(this.TxtSerie);
            this.GbxComprobante.Controls.Add(this.label1);
            this.GbxComprobante.Controls.Add(this.CbxTipoComprobante);
            this.GbxComprobante.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxComprobante.Location = new System.Drawing.Point(12, 12);
            this.GbxComprobante.Name = "GbxComprobante";
            this.GbxComprobante.Size = new System.Drawing.Size(550, 80);
            this.GbxComprobante.TabIndex = 22;
            this.GbxComprobante.TabStop = false;
            this.GbxComprobante.Text = "Comprobante";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(407, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha";
            // 
            // TxtFechaEmision
            // 
            this.TxtFechaEmision.BackColor = System.Drawing.Color.White;
            this.TxtFechaEmision.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFechaEmision.Location = new System.Drawing.Point(410, 37);
            this.TxtFechaEmision.Name = "TxtFechaEmision";
            this.TxtFechaEmision.ReadOnly = true;
            this.TxtFechaEmision.Size = new System.Drawing.Size(120, 27);
            this.TxtFechaEmision.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número";
            // 
            // TxtNumero
            // 
            this.TxtNumero.BackColor = System.Drawing.Color.White;
            this.TxtNumero.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumero.Location = new System.Drawing.Point(264, 37);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.ReadOnly = true;
            this.TxtNumero.Size = new System.Drawing.Size(140, 27);
            this.TxtNumero.TabIndex = 10;
            this.TxtNumero.Text = "########";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Serie";
            // 
            // TxtSerie
            // 
            this.TxtSerie.BackColor = System.Drawing.Color.White;
            this.TxtSerie.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSerie.Location = new System.Drawing.Point(188, 37);
            this.TxtSerie.Name = "TxtSerie";
            this.TxtSerie.ReadOnly = true;
            this.TxtSerie.Size = new System.Drawing.Size(70, 27);
            this.TxtSerie.TabIndex = 1;
            this.TxtSerie.Text = "####";
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
            this.CbxTipoComprobante.Size = new System.Drawing.Size(164, 26);
            this.CbxTipoComprobante.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(810, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 26);
            this.button5.TabIndex = 39;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Registrar_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(845, 566);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.BtnGuardarVenta);
            this.Controls.Add(this.BtnSearchProducto);
            this.Controls.Add(this.TxtProducto);
            this.Controls.Add(this.PbxImgProducto);
            this.Controls.Add(this.BtnAumentarItem);
            this.Controls.Add(this.BtnDisminuirItem);
            this.Controls.Add(this.TxtCantidadItem);
            this.Controls.Add(this.GbxResumen);
            this.Controls.Add(this.BtnQuitar);
            this.Controls.Add(this.GbxDetalle);
            this.Controls.Add(this.GbxCliente);
            this.Controls.Add(this.GbxComprobante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Registrar_Venta";
            this.Text = "Frm_Registrar_Venta";
            this.Load += new System.EventHandler(this.Frm_Registrar_Venta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbxImgProducto)).EndInit();
            this.GbxResumen.ResumeLayout(false);
            this.GbxResumen.PerformLayout();
            this.GbxDetalle.ResumeLayout(false);
            this.GbxCliente.ResumeLayout(false);
            this.GbxCliente.PerformLayout();
            this.GbxComprobante.ResumeLayout(false);
            this.GbxComprobante.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void BtnQuitar_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

     

        #endregion

        private System.Windows.Forms.Button BtnGuardarVenta;
        private System.Windows.Forms.Button BtnSearchProducto;
        public System.Windows.Forms.TextBox TxtProducto;
        public System.Windows.Forms.PictureBox PbxImgProducto;
        private System.Windows.Forms.Button BtnAumentarItem;
        private System.Windows.Forms.Button BtnDisminuirItem;
        private System.Windows.Forms.TextBox TxtCantidadItem;
        private System.Windows.Forms.GroupBox GbxResumen;
        private System.Windows.Forms.Label RLblTotal;
        private System.Windows.Forms.Label RLblIgv;
        private System.Windows.Forms.Label RLblSubTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnQuitar;
        private System.Windows.Forms.GroupBox GbxDetalle;
        private System.Windows.Forms.GroupBox GbxCliente;
        public System.Windows.Forms.Label LblIDCliente;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Button BtnSearchCliente;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.GroupBox GbxComprobante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtFechaEmision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxTipoComprobante;
        private System.Windows.Forms.ListView MLVDetalle;
        private System.Windows.Forms.Button button5;
    }
}