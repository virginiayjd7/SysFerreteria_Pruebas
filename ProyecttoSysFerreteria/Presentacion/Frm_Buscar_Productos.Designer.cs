namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_Buscar_Productos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnListarTodo = new System.Windows.Forms.Button();
            this.PanelActions = new System.Windows.Forms.Panel();
            this.TxtCodigoImagen = new System.Windows.Forms.TextBox();
            this.PtbImageProdcucto = new System.Windows.Forms.PictureBox();
            this.BtnInventario = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnSubCategorias = new System.Windows.Forms.Button();
            this.BtnMarcas = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvProducto = new System.Windows.Forms.DataGridView();
            this.TxtBusqueda = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.PanelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImageProdcucto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListarTodo
            // 
            this.BtnListarTodo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarTodo.BackColor = System.Drawing.Color.DimGray;
            this.BtnListarTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnListarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnListarTodo.FlatAppearance.BorderSize = 0;
            this.BtnListarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnListarTodo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListarTodo.ForeColor = System.Drawing.Color.White;
            this.BtnListarTodo.Location = new System.Drawing.Point(475, 26);
            this.BtnListarTodo.Name = "BtnListarTodo";
            this.BtnListarTodo.Size = new System.Drawing.Size(81, 27);
            this.BtnListarTodo.TabIndex = 26;
            this.BtnListarTodo.Text = "Todos";
            this.BtnListarTodo.UseVisualStyleBackColor = false;
            this.BtnListarTodo.Click += new System.EventHandler(this.BtnListarTodo_Click);
            // 
            // PanelActions
            // 
            this.PanelActions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            this.PanelActions.Controls.Add(this.button5);
            this.PanelActions.Controls.Add(this.TxtCodigoImagen);
            this.PanelActions.Controls.Add(this.PtbImageProdcucto);
            this.PanelActions.Controls.Add(this.BtnInventario);
            this.PanelActions.Controls.Add(this.BtnCategorias);
            this.PanelActions.Controls.Add(this.BtnSubCategorias);
            this.PanelActions.Controls.Add(this.BtnMarcas);
            this.PanelActions.Controls.Add(this.BtnModificar);
            this.PanelActions.Controls.Add(this.BtnNuevo);
            this.PanelActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelActions.Location = new System.Drawing.Point(600, 0);
            this.PanelActions.Name = "PanelActions";
            this.PanelActions.Size = new System.Drawing.Size(200, 612);
            this.PanelActions.TabIndex = 21;
            // 
            // TxtCodigoImagen
            // 
            this.TxtCodigoImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoImagen.Location = new System.Drawing.Point(22, 303);
            this.TxtCodigoImagen.Name = "TxtCodigoImagen";
            this.TxtCodigoImagen.ReadOnly = true;
            this.TxtCodigoImagen.Size = new System.Drawing.Size(160, 20);
            this.TxtCodigoImagen.TabIndex = 9;
            this.TxtCodigoImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PtbImageProdcucto
            // 
            this.PtbImageProdcucto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PtbImageProdcucto.Location = new System.Drawing.Point(22, 133);
            this.PtbImageProdcucto.Name = "PtbImageProdcucto";
            this.PtbImageProdcucto.Size = new System.Drawing.Size(160, 168);
            this.PtbImageProdcucto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PtbImageProdcucto.TabIndex = 8;
            this.PtbImageProdcucto.TabStop = false;
            // 
            // BtnInventario
            // 
            this.BtnInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInventario.BackColor = System.Drawing.Color.Gray;
            this.BtnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnInventario.FlatAppearance.BorderSize = 0;
            this.BtnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInventario.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInventario.ForeColor = System.Drawing.Color.White;
            this.BtnInventario.Location = new System.Drawing.Point(22, 462);
            this.BtnInventario.Name = "BtnInventario";
            this.BtnInventario.Size = new System.Drawing.Size(160, 30);
            this.BtnInventario.TabIndex = 7;
            this.BtnInventario.Text = "INVENTARIO";
            this.BtnInventario.UseVisualStyleBackColor = false;
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCategorias.BackColor = System.Drawing.Color.Gray;
            this.BtnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCategorias.FlatAppearance.BorderSize = 0;
            this.BtnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCategorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnCategorias.Location = new System.Drawing.Point(22, 498);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(160, 30);
            this.BtnCategorias.TabIndex = 6;
            this.BtnCategorias.Text = "CATEGORIAS";
            this.BtnCategorias.UseVisualStyleBackColor = false;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnSubCategorias
            // 
            this.BtnSubCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSubCategorias.BackColor = System.Drawing.Color.Gray;
            this.BtnSubCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSubCategorias.FlatAppearance.BorderSize = 0;
            this.BtnSubCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSubCategorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubCategorias.ForeColor = System.Drawing.Color.White;
            this.BtnSubCategorias.Location = new System.Drawing.Point(22, 534);
            this.BtnSubCategorias.Name = "BtnSubCategorias";
            this.BtnSubCategorias.Size = new System.Drawing.Size(160, 30);
            this.BtnSubCategorias.TabIndex = 5;
            this.BtnSubCategorias.Text = "SUB CATEGORIAS";
            this.BtnSubCategorias.UseVisualStyleBackColor = false;
            this.BtnSubCategorias.Click += new System.EventHandler(this.BtnSubCategorias_Click);
            // 
            // BtnMarcas
            // 
            this.BtnMarcas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMarcas.BackColor = System.Drawing.Color.Gray;
            this.BtnMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMarcas.FlatAppearance.BorderSize = 0;
            this.BtnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMarcas.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarcas.ForeColor = System.Drawing.Color.White;
            this.BtnMarcas.Location = new System.Drawing.Point(22, 570);
            this.BtnMarcas.Name = "BtnMarcas";
            this.BtnMarcas.Size = new System.Drawing.Size(160, 30);
            this.BtnMarcas.TabIndex = 4;
            this.BtnMarcas.Text = "MARCAS";
            this.BtnMarcas.UseVisualStyleBackColor = false;
            this.BtnMarcas.Click += new System.EventHandler(this.BtnMarcas_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.Color.White;
            this.BtnModificar.Location = new System.Drawing.Point(22, 87);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(160, 40);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "MODIFICAR";
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.ForeColor = System.Drawing.Color.White;
            this.BtnNuevo.Location = new System.Drawing.Point(22, 41);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(160, 40);
            this.BtnNuevo.TabIndex = 1;
            this.BtnNuevo.Text = "NUEVO";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 14);
            this.label1.TabIndex = 25;
            this.label1.Text = "Búsqueda por Código o Nombre";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.BtnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBuscar.FlatAppearance.BorderSize = 0;
            this.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.ForeColor = System.Drawing.Color.White;
            this.BtnBuscar.Location = new System.Drawing.Point(388, 26);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(81, 27);
            this.BtnBuscar.TabIndex = 24;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = false;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvProducto
            // 
            this.DgvProducto.AllowUserToAddRows = false;
            this.DgvProducto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DgvProducto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.DgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProducto.ColumnHeadersHeight = 40;
            this.DgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProducto.DefaultCellStyle = dataGridViewCellStyle7;
            this.DgvProducto.EnableHeadersVisualStyles = false;
            this.DgvProducto.GridColor = System.Drawing.Color.White;
            this.DgvProducto.Location = new System.Drawing.Point(6, 59);
            this.DgvProducto.MultiSelect = false;
            this.DgvProducto.Name = "DgvProducto";
            this.DgvProducto.ReadOnly = true;
            this.DgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvProducto.RowHeadersVisible = false;
            this.DgvProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DgvProducto.RowTemplate.Height = 30;
            this.DgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProducto.Size = new System.Drawing.Size(550, 378);
            this.DgvProducto.TabIndex = 22;
            this.DgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProducto_CellClick);
            // 
            // TxtBusqueda
            // 
            this.TxtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBusqueda.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusqueda.Location = new System.Drawing.Point(6, 26);
            this.TxtBusqueda.Name = "TxtBusqueda";
            this.TxtBusqueda.Size = new System.Drawing.Size(376, 27);
            this.TxtBusqueda.TabIndex = 23;
            this.TxtBusqueda.TextChanged += new System.EventHandler(this.TxtBusqueda_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(167, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(33, 26);
            this.button5.TabIndex = 39;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Frm_Buscar_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.BtnListarTodo);
            this.Controls.Add(this.PanelActions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.DgvProducto);
            this.Controls.Add(this.TxtBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Buscar_Productos";
            this.Text = "Frm_Productos";
            this.Load += new System.EventHandler(this.Frm_Buscar_Productos_Load);
            this.PanelActions.ResumeLayout(false);
            this.PanelActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtbImageProdcucto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnListarTodo;
        private System.Windows.Forms.Panel PanelActions;
        private System.Windows.Forms.TextBox TxtCodigoImagen;
        private System.Windows.Forms.PictureBox PtbImageProdcucto;
        private System.Windows.Forms.Button BtnInventario;
        private System.Windows.Forms.Button BtnCategorias;
        private System.Windows.Forms.Button BtnSubCategorias;
        private System.Windows.Forms.Button BtnMarcas;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridView DgvProducto;
        private System.Windows.Forms.TextBox TxtBusqueda;
        private System.Windows.Forms.Button button5;
    }
}