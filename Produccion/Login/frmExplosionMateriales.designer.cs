namespace Login
{
    partial class frmExplosionMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExplosionMateriales));
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pnnavegador = new System.Windows.Forms.Panel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnirUltimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnirPrimero = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lOrden = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnnavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(13, 180);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(647, 293);
            this.dgvDetalle.TabIndex = 0;
            // 
            // pnnavegador
            // 
            this.pnnavegador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnnavegador.Controls.Add(this.btnimprimir);
            this.pnnavegador.Controls.Add(this.btnnuevo);
            this.pnnavegador.Controls.Add(this.btnirUltimo);
            this.pnnavegador.Controls.Add(this.btnsiguiente);
            this.pnnavegador.Controls.Add(this.btnanterior);
            this.pnnavegador.Controls.Add(this.btnirPrimero);
            this.pnnavegador.Controls.Add(this.btneditar);
            this.pnnavegador.Controls.Add(this.btncancelar);
            this.pnnavegador.Controls.Add(this.btnrefrescar);
            this.pnnavegador.Controls.Add(this.btnbuscar);
            this.pnnavegador.Controls.Add(this.btneliminar);
            this.pnnavegador.Controls.Add(this.btnguardar);
            this.pnnavegador.Location = new System.Drawing.Point(13, 25);
            this.pnnavegador.Name = "pnnavegador";
            this.pnnavegador.Size = new System.Drawing.Size(650, 67);
            this.pnnavegador.TabIndex = 4;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(327, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(47, 50);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(11, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 50);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last1;
            this.btnirUltimo.Location = new System.Drawing.Point(592, 8);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(47, 50);
            this.btnirUltimo.TabIndex = 9;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next1;
            this.btnsiguiente.Location = new System.Drawing.Point(539, 8);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(47, 50);
            this.btnsiguiente.TabIndex = 8;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(486, 8);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(47, 50);
            this.btnanterior.TabIndex = 7;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(433, 8);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(47, 50);
            this.btnirPrimero.TabIndex = 6;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(64, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(47, 50);
            this.btneditar.TabIndex = 5;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Login.Properties.Resources.delete;
            this.btncancelar.Location = new System.Drawing.Point(223, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(47, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(276, 8);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(47, 50);
            this.btnrefrescar.TabIndex = 3;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(380, 8);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(117, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 50);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(170, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(47, 50);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(16, 138);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 9;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedValueChanged);
            // 
            // lOrden
            // 
            this.lOrden.AutoSize = true;
            this.lOrden.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrden.Location = new System.Drawing.Point(12, 116);
            this.lOrden.Name = "lOrden";
            this.lOrden.Size = new System.Drawing.Size(66, 19);
            this.lOrden.TabIndex = 10;
            this.lOrden.Text = "Producto";
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(613, 150);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 52;
            this.lblSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Login.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(606, 105);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 42);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmExplosionMateriales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 485);
            this.ControlBox = false;
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lOrden);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.pnnavegador);
            this.Controls.Add(this.dgvDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExplosionMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Explosion De Materiales";
            this.Load += new System.EventHandler(this.frmExplosionMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnnavegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnnavegador;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnirUltimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnirPrimero;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lOrden;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnSalir;
    }
}