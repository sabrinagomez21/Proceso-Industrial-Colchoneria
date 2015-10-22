namespace Bitacora
{
    partial class Presentacion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGVBitacora = new System.Windows.Forms.DataGridView();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblaplicacion = new System.Windows.Forms.Label();
            this.lblrefrescar = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVBitacora
            // 
            this.dGVBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBitacora.Location = new System.Drawing.Point(13, 88);
            this.dGVBitacora.Name = "dGVBitacora";
            this.dGVBitacora.Size = new System.Drawing.Size(834, 330);
            this.dGVBitacora.TabIndex = 1;
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(29, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 15);
            this.lblbuscar.TabIndex = 46;
            this.lblbuscar.Text = "Buscar";
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAplicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(521, 32);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(121, 21);
            this.cmbAplicacion.TabIndex = 48;
            this.cmbAplicacion.SelectedValueChanged += new System.EventHandler(this.cmbAplicacion_SelectedIndexChanged);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.Location = new System.Drawing.Point(286, 57);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(53, 15);
            this.lblfecha.TabIndex = 49;
            this.lblfecha.Text = "Fechas";
            // 
            // lblaplicacion
            // 
            this.lblaplicacion.AutoSize = true;
            this.lblaplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaplicacion.Location = new System.Drawing.Point(554, 56);
            this.lblaplicacion.Name = "lblaplicacion";
            this.lblaplicacion.Size = new System.Drawing.Size(73, 15);
            this.lblaplicacion.TabIndex = 50;
            this.lblaplicacion.Text = "Aplicacion";
            // 
            // lblrefrescar
            // 
            this.lblrefrescar.AutoSize = true;
            this.lblrefrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrefrescar.Location = new System.Drawing.Point(742, 57);
            this.lblrefrescar.Name = "lblrefrescar";
            this.lblrefrescar.Size = new System.Drawing.Size(69, 15);
            this.lblrefrescar.TabIndex = 52;
            this.lblrefrescar.Text = "Refrescar";
            // 
            // btnFecha
            // 
            this.btnFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecha.Image = global::Bitacora.Properties.Resources.CALENDARIO;
            this.btnFecha.Location = new System.Drawing.Point(289, 11);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(46, 42);
            this.btnFecha.TabIndex = 53;
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Image = global::Bitacora.Properties.Resources.refresh;
            this.btnRefrescar.Location = new System.Drawing.Point(750, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(46, 42);
            this.btnRefrescar.TabIndex = 51;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::Bitacora.Properties.Resources.buscar;
            this.btnsearch.Location = new System.Drawing.Point(32, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 42);
            this.btnsearch.TabIndex = 45;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 430);
            this.ControlBox = false;
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.lblrefrescar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.lblaplicacion);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.cmbAplicacion);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dGVBitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitacora del Sistema";
            this.Load += new System.EventHandler(this.Presentacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dGVBitacora;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblaplicacion;
        private System.Windows.Forms.Label lblrefrescar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnFecha;
    }
}

