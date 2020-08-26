namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelNavegacionn = new System.Windows.Forms.Panel();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblHeaderTitle = new System.Windows.Forms.Label();
            this.PanelState = new System.Windows.Forms.Panel();
            this.LblMessage = new System.Windows.Forms.Label();
            this.PanelNavegacion = new System.Windows.Forms.Panel();
            this.PanelProfile = new System.Windows.Forms.Panel();
            this.PbbPerfil = new System.Windows.Forms.PictureBox();
            this.PbbConfiguracion = new System.Windows.Forms.PictureBox();
            this.LblUDescripcion = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.LblUNombre = new System.Windows.Forms.Label();
            this.PbxUFoto = new System.Windows.Forms.PictureBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnventas = new System.Windows.Forms.Button();
            this.btnAddMiembro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbbMaximizar = new System.Windows.Forms.PictureBox();
            this.PbbRestaurar = new System.Windows.Forms.PictureBox();
            this.PbbMinimizar = new System.Windows.Forms.PictureBox();
            this.PbbCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PanelContainer.SuspendLayout();
            this.PanelNavegacionn.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.PanelState.SuspendLayout();
            this.PanelNavegacion.SuspendLayout();
            this.PanelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.PanelNavegacionn);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1034, 526);
            this.PanelContainer.TabIndex = 5;
            // 
            // PanelNavegacionn
            // 
            this.PanelNavegacionn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelNavegacionn.Controls.Add(this.PanelHeader);
            this.PanelNavegacionn.Controls.Add(this.PanelState);
            this.PanelNavegacionn.Controls.Add(this.PanelNavegacion);
            this.PanelNavegacionn.Controls.Add(this.panel3);
            this.PanelNavegacionn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNavegacionn.Location = new System.Drawing.Point(0, 0);
            this.PanelNavegacionn.Name = "PanelNavegacionn";
            this.PanelNavegacionn.Size = new System.Drawing.Size(1034, 526);
            this.PanelNavegacionn.TabIndex = 5;
            this.PanelNavegacionn.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNavegacionn_Paint);
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.White;
            this.PanelHeader.Controls.Add(this.LblFecha);
            this.PanelHeader.Controls.Add(this.LblHeaderTitle);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(218, 71);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(816, 50);
            this.PanelHeader.TabIndex = 53;
            // 
            // LblFecha
            // 
            this.LblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(437, 14);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LblFecha.Size = new System.Drawing.Size(367, 18);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Sábado, 27 de Octubre del 2018";
            this.LblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblHeaderTitle
            // 
            this.LblHeaderTitle.AutoSize = true;
            this.LblHeaderTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.LblHeaderTitle.Location = new System.Drawing.Point(16, 14);
            this.LblHeaderTitle.Name = "LblHeaderTitle";
            this.LblHeaderTitle.Size = new System.Drawing.Size(0, 23);
            this.LblHeaderTitle.TabIndex = 0;
            // 
            // PanelState
            // 
            this.PanelState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(194)))), ((int)(((byte)(199)))));
            this.PanelState.Controls.Add(this.LblMessage);
            this.PanelState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelState.Location = new System.Drawing.Point(218, 486);
            this.PanelState.Name = "PanelState";
            this.PanelState.Size = new System.Drawing.Size(816, 40);
            this.PanelState.TabIndex = 52;
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMessage.Location = new System.Drawing.Point(17, 11);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(26, 18);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "...";
            this.LblMessage.Visible = false;
            // 
            // PanelNavegacion
            // 
            this.PanelNavegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.PanelNavegacion.Controls.Add(this.PanelProfile);
            this.PanelNavegacion.Controls.Add(this.button11);
            this.PanelNavegacion.Controls.Add(this.button10);
            this.PanelNavegacion.Controls.Add(this.btnConsultas);
            this.PanelNavegacion.Controls.Add(this.btnPlanes);
            this.PanelNavegacion.Controls.Add(this.btnventas);
            this.PanelNavegacion.Controls.Add(this.btnAddMiembro);
            this.PanelNavegacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelNavegacion.Location = new System.Drawing.Point(0, 71);
            this.PanelNavegacion.Name = "PanelNavegacion";
            this.PanelNavegacion.Size = new System.Drawing.Size(218, 455);
            this.PanelNavegacion.TabIndex = 51;
            // 
            // PanelProfile
            // 
            this.PanelProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.PanelProfile.Controls.Add(this.PbbPerfil);
            this.PanelProfile.Controls.Add(this.PbbConfiguracion);
            this.PanelProfile.Controls.Add(this.LblUDescripcion);
            this.PanelProfile.Controls.Add(this.btnCerrar);
            this.PanelProfile.Controls.Add(this.LblUNombre);
            this.PanelProfile.Controls.Add(this.PbxUFoto);
            this.PanelProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelProfile.Location = new System.Drawing.Point(0, 0);
            this.PanelProfile.Name = "PanelProfile";
            this.PanelProfile.Size = new System.Drawing.Size(218, 130);
            this.PanelProfile.TabIndex = 84;
            // 
            // PbbPerfil
            // 
            this.PbbPerfil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbPerfil.BackgroundImage")));
            this.PbbPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbPerfil.ErrorImage = ((System.Drawing.Image)(resources.GetObject("PbbPerfil.ErrorImage")));
            this.PbbPerfil.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbbPerfil.InitialImage")));
            this.PbbPerfil.Location = new System.Drawing.Point(69, 100);
            this.PbbPerfil.Name = "PbbPerfil";
            this.PbbPerfil.Size = new System.Drawing.Size(25, 25);
            this.PbbPerfil.TabIndex = 4;
            this.PbbPerfil.TabStop = false;
            this.PbbPerfil.Click += new System.EventHandler(this.PbbPerfil_Click);
            // 
            // PbbConfiguracion
            // 
            this.PbbConfiguracion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbConfiguracion.BackgroundImage")));
            this.PbbConfiguracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbConfiguracion.Location = new System.Drawing.Point(18, 100);
            this.PbbConfiguracion.Name = "PbbConfiguracion";
            this.PbbConfiguracion.Size = new System.Drawing.Size(25, 25);
            this.PbbConfiguracion.TabIndex = 3;
            this.PbbConfiguracion.TabStop = false;
            // 
            // LblUDescripcion
            // 
            this.LblUDescripcion.AutoSize = true;
            this.LblUDescripcion.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUDescripcion.ForeColor = System.Drawing.Color.Silver;
            this.LblUDescripcion.Location = new System.Drawing.Point(78, 48);
            this.LblUDescripcion.Name = "LblUDescripcion";
            this.LblUDescripcion.Size = new System.Drawing.Size(111, 18);
            this.LblUDescripcion.TabIndex = 2;
            this.LblUDescripcion.Text = "Administrador";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(110, 100);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(27, 25);
            this.btnCerrar.TabIndex = 67;
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // LblUNombre
            // 
            this.LblUNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUNombre.ForeColor = System.Drawing.Color.White;
            this.LblUNombre.Location = new System.Drawing.Point(12, 9);
            this.LblUNombre.Name = "LblUNombre";
            this.LblUNombre.Size = new System.Drawing.Size(182, 18);
            this.LblUNombre.TabIndex = 1;
            this.LblUNombre.Text = "Yaneth Virginia Aquino Huallpa";
            // 
            // PbxUFoto
            // 
            this.PbxUFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbxUFoto.Location = new System.Drawing.Point(15, 30);
            this.PbxUFoto.Name = "PbxUFoto";
            this.PbxUFoto.Size = new System.Drawing.Size(52, 45);
            this.PbxUFoto.TabIndex = 0;
            this.PbxUFoto.TabStop = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(0, 377);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(202, 40);
            this.button11.TabIndex = 83;
            this.button11.Text = "Reportes";
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(-44, 273);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(238, 52);
            this.button10.TabIndex = 82;
            this.button10.Text = "Compra";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultas.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Image")));
            this.btnConsultas.Location = new System.Drawing.Point(-8, 227);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(202, 40);
            this.btnConsultas.TabIndex = 74;
            this.btnConsultas.Text = "Venta";
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnPlanes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPlanes.FlatAppearance.BorderSize = 0;
            this.btnPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlanes.Image = ((System.Drawing.Image)(resources.GetObject("btnPlanes.Image")));
            this.btnPlanes.Location = new System.Drawing.Point(-42, 177);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(236, 40);
            this.btnPlanes.TabIndex = 70;
            this.btnPlanes.Text = "Productos";
            this.btnPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlanes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnventas
            // 
            this.btnventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnventas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnventas.FlatAppearance.BorderSize = 0;
            this.btnventas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.btnventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnventas.Image = ((System.Drawing.Image)(resources.GetObject("btnventas.Image")));
            this.btnventas.Location = new System.Drawing.Point(-8, 331);
            this.btnventas.Name = "btnventas";
            this.btnventas.Size = new System.Drawing.Size(202, 40);
            this.btnventas.TabIndex = 71;
            this.btnventas.Text = "Clientes";
            this.btnventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventas.UseVisualStyleBackColor = false;
            this.btnventas.Click += new System.EventHandler(this.btnventas_Click);
            // 
            // btnAddMiembro
            // 
            this.btnAddMiembro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnAddMiembro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAddMiembro.FlatAppearance.BorderSize = 0;
            this.btnAddMiembro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAddMiembro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(178)))), ((int)(((byte)(204)))));
            this.btnAddMiembro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMiembro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMiembro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMiembro.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMiembro.Image")));
            this.btnAddMiembro.Location = new System.Drawing.Point(-45, 131);
            this.btnAddMiembro.Name = "btnAddMiembro";
            this.btnAddMiembro.Size = new System.Drawing.Size(239, 40);
            this.btnAddMiembro.TabIndex = 68;
            this.btnAddMiembro.Text = " Personal";
            this.btnAddMiembro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMiembro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMiembro.UseVisualStyleBackColor = false;
            this.btnAddMiembro.Click += new System.EventHandler(this.btnAddMiembro_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.PbbMaximizar);
            this.panel3.Controls.Add(this.PbbRestaurar);
            this.panel3.Controls.Add(this.PbbMinimizar);
            this.panel3.Controls.Add(this.PbbCerrar);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1034, 71);
            this.panel3.TabIndex = 50;
            // 
            // PbbMaximizar
            // 
            this.PbbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMaximizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbMaximizar.BackgroundImage")));
            this.PbbMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMaximizar.Location = new System.Drawing.Point(951, 29);
            this.PbbMaximizar.Name = "PbbMaximizar";
            this.PbbMaximizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMaximizar.TabIndex = 5;
            this.PbbMaximizar.TabStop = false;
            this.PbbMaximizar.Click += new System.EventHandler(this.PbbMaximizar_Click);
            // 
            // PbbRestaurar
            // 
            this.PbbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbRestaurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbRestaurar.BackgroundImage")));
            this.PbbRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbRestaurar.Location = new System.Drawing.Point(951, 29);
            this.PbbRestaurar.Name = "PbbRestaurar";
            this.PbbRestaurar.Size = new System.Drawing.Size(35, 35);
            this.PbbRestaurar.TabIndex = 6;
            this.PbbRestaurar.TabStop = false;
            // 
            // PbbMinimizar
            // 
            this.PbbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbMinimizar.BackgroundImage")));
            this.PbbMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbMinimizar.Location = new System.Drawing.Point(913, 29);
            this.PbbMinimizar.Name = "PbbMinimizar";
            this.PbbMinimizar.Size = new System.Drawing.Size(35, 35);
            this.PbbMinimizar.TabIndex = 7;
            this.PbbMinimizar.TabStop = false;
            this.PbbMinimizar.Click += new System.EventHandler(this.PbbMinimizar_Click);
            // 
            // PbbCerrar
            // 
            this.PbbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PbbCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PbbCerrar.BackgroundImage")));
            this.PbbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PbbCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PbbCerrar.Location = new System.Drawing.Point(989, 29);
            this.PbbCerrar.Name = "PbbCerrar";
            this.PbbCerrar.Size = new System.Drawing.Size(35, 35);
            this.PbbCerrar.TabIndex = 4;
            this.PbbCerrar.TabStop = false;
            this.PbbCerrar.Click += new System.EventHandler(this.PbbCerrar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.ErrorImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.InitialImage")));
            this.pictureBox4.Location = new System.Drawing.Point(0, -9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(216, 77);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1034, 526);
            this.Controls.Add(this.PanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Principal";
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.PanelContainer.ResumeLayout(false);
            this.PanelNavegacionn.ResumeLayout(false);
            this.PanelHeader.ResumeLayout(false);
            this.PanelHeader.PerformLayout();
            this.PanelState.ResumeLayout(false);
            this.PanelState.PerformLayout();
            this.PanelNavegacion.ResumeLayout(false);
            this.PanelProfile.ResumeLayout(false);
            this.PanelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbbPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxUFoto)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbbMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelNavegacionn;
        private System.Windows.Forms.Panel PanelHeader;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel PanelState;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Panel PanelNavegacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbbMaximizar;
        private System.Windows.Forms.PictureBox PbbRestaurar;
        private System.Windows.Forms.PictureBox PbbMinimizar;
        private System.Windows.Forms.PictureBox PbbCerrar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.Button btnventas;
        private System.Windows.Forms.Button btnAddMiembro;
        private System.Windows.Forms.Label LblHeaderTitle;
        private System.Windows.Forms.Panel PanelProfile;
        private System.Windows.Forms.PictureBox PbbPerfil;
        private System.Windows.Forms.PictureBox PbbConfiguracion;
        private System.Windows.Forms.Label LblUDescripcion;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label LblUNombre;
        private System.Windows.Forms.PictureBox PbxUFoto;
    }
}