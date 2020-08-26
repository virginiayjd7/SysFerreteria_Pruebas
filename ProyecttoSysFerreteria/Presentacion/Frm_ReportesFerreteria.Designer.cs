namespace ProyecttoSysFerreteria.Presentacion
{
    partial class Frm_ReportesFerreteria
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
            this.BtnVentasDia = new System.Windows.Forms.Button();
            this.BtnProductosVendidos = new System.Windows.Forms.Button();
            this.BtnExistenciaProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVentasDia
            // 
            this.BtnVentasDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnVentasDia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVentasDia.FlatAppearance.BorderSize = 0;
            this.BtnVentasDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentasDia.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentasDia.ForeColor = System.Drawing.Color.White;
            this.BtnVentasDia.Location = new System.Drawing.Point(177, 251);
            this.BtnVentasDia.Name = "BtnVentasDia";
            this.BtnVentasDia.Size = new System.Drawing.Size(210, 40);
            this.BtnVentasDia.TabIndex = 13;
            this.BtnVentasDia.Text = "Ganancias del Día";
            this.BtnVentasDia.UseVisualStyleBackColor = false;
            this.BtnVentasDia.Click += new System.EventHandler(this.BtnVentasDia_Click);
            // 
            // BtnProductosVendidos
            // 
            this.BtnProductosVendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnProductosVendidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductosVendidos.FlatAppearance.BorderSize = 0;
            this.BtnProductosVendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductosVendidos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductosVendidos.ForeColor = System.Drawing.Color.White;
            this.BtnProductosVendidos.Location = new System.Drawing.Point(177, 205);
            this.BtnProductosVendidos.Name = "BtnProductosVendidos";
            this.BtnProductosVendidos.Size = new System.Drawing.Size(210, 40);
            this.BtnProductosVendidos.TabIndex = 12;
            this.BtnProductosVendidos.Text = "Productos Vendidos";
            this.BtnProductosVendidos.UseVisualStyleBackColor = false;
            // 
            // BtnExistenciaProductos
            // 
            this.BtnExistenciaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.BtnExistenciaProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExistenciaProductos.FlatAppearance.BorderSize = 0;
            this.BtnExistenciaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExistenciaProductos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExistenciaProductos.ForeColor = System.Drawing.Color.White;
            this.BtnExistenciaProductos.Location = new System.Drawing.Point(177, 159);
            this.BtnExistenciaProductos.Name = "BtnExistenciaProductos";
            this.BtnExistenciaProductos.Size = new System.Drawing.Size(210, 40);
            this.BtnExistenciaProductos.TabIndex = 11;
            this.BtnExistenciaProductos.Text = "Existencia de Productos";
            this.BtnExistenciaProductos.UseVisualStyleBackColor = false;
            // 
            // Frm_ReportesFerreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.BtnVentasDia);
            this.Controls.Add(this.BtnProductosVendidos);
            this.Controls.Add(this.BtnExistenciaProductos);
            this.Name = "Frm_ReportesFerreteria";
            this.Text = "Frm_ReportesFerreteria";
            this.Load += new System.EventHandler(this.Frm_ReportesFerreteria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVentasDia;
        private System.Windows.Forms.Button BtnProductosVendidos;
        private System.Windows.Forms.Button BtnExistenciaProductos;
    }
}