namespace Errores
{
    partial class frmErrores
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
            this.components = new System.ComponentModel.Container();
            this.dgvErroresSistema = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            this.cmbError = new System.Windows.Forms.ComboBox();
            this.cmbAplicacion = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAplicacion = new System.Windows.Forms.Label();
            this.lblActualizar = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErroresSistema
            // 
            this.dgvErroresSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErroresSistema.Location = new System.Drawing.Point(28, 76);
            this.dgvErroresSistema.Name = "dgvErroresSistema";
            this.dgvErroresSistema.Size = new System.Drawing.Size(865, 443);
            this.dgvErroresSistema.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(47, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 15);
            this.lblbuscar.TabIndex = 48;
            this.lblbuscar.Text = "Buscar";
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::Errores.Properties.Resources.buscar;
            this.btnsearch.Location = new System.Drawing.Point(50, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 42);
            this.btnsearch.TabIndex = 47;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Errores.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(837, 560);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 42);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(844, 605);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 50;
            this.lblSalir.Text = "Salir";
            // 
            // cmbError
            // 
            this.cmbError.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbError.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbError.FormattingEnabled = true;
            this.cmbError.Location = new System.Drawing.Point(188, 32);
            this.cmbError.Name = "cmbError";
            this.cmbError.Size = new System.Drawing.Size(146, 21);
            this.cmbError.TabIndex = 51;
            this.cmbError.SelectedValueChanged += new System.EventHandler(this.cmbError_SelectedValueChanged);
            // 
            // cmbAplicacion
            // 
            this.cmbAplicacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAplicacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAplicacion.FormattingEnabled = true;
            this.cmbAplicacion.Location = new System.Drawing.Point(388, 33);
            this.cmbAplicacion.Name = "cmbAplicacion";
            this.cmbAplicacion.Size = new System.Drawing.Size(146, 21);
            this.cmbAplicacion.TabIndex = 52;
            this.cmbAplicacion.SelectedValueChanged += new System.EventHandler(this.cmbAplicacion_SelectedValueChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(234, 56);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 15);
            this.lblError.TabIndex = 53;
            this.lblError.Text = "Error";
            // 
            // lblAplicacion
            // 
            this.lblAplicacion.AutoSize = true;
            this.lblAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacion.Location = new System.Drawing.Point(429, 56);
            this.lblAplicacion.Name = "lblAplicacion";
            this.lblAplicacion.Size = new System.Drawing.Size(73, 15);
            this.lblAplicacion.TabIndex = 54;
            this.lblAplicacion.Text = "Aplicacion";
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizar.Location = new System.Drawing.Point(826, 56);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(70, 15);
            this.lblActualizar.TabIndex = 56;
            this.lblActualizar.Text = "Actualizar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.Image = global::Errores.Properties.Resources.refresh;
            this.btnActualizar.Location = new System.Drawing.Point(835, 11);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(46, 42);
            this.btnActualizar.TabIndex = 55;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(640, 56);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(53, 15);
            this.lblFecha.TabIndex = 57;
            this.lblFecha.Text = "Fechas";
            // 
            // btnFecha
            // 
            this.btnFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFecha.Image = global::Errores.Properties.Resources.CALENDARIO;
            this.btnFecha.Location = new System.Drawing.Point(643, 11);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(46, 42);
            this.btnFecha.TabIndex = 58;
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // frmErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 629);
            this.ControlBox = false;
            this.Controls.Add(this.btnFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblActualizar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblAplicacion);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.cmbAplicacion);
            this.Controls.Add(this.cmbError);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgvErroresSistema);
            this.Name = "frmErrores";
            this.Text = "Errores del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErroresSistema;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.ComboBox cmbError;
        private System.Windows.Forms.ComboBox cmbAplicacion;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAplicacion;
        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnFecha;
    }
}