namespace Login
{
    partial class frmOrden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrden));
            this.lOrden = new System.Windows.Forms.Label();
            this.lProducto = new System.Windows.Forms.Label();
            this.lInicio = new System.Windows.Forms.Label();
            this.lEntrega = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.lFabricar = new System.Windows.Forms.Label();
            this.txtFabricar = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
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
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtreferencia = new System.Windows.Forms.TextBox();
            this.txtcodreceta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnnavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lOrden
            // 
            this.lOrden.AutoSize = true;
            this.lOrden.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrden.Location = new System.Drawing.Point(11, 119);
            this.lOrden.Name = "lOrden";
            this.lOrden.Size = new System.Drawing.Size(53, 19);
            this.lOrden.TabIndex = 0;
            this.lOrden.Text = "Orden:";
            // 
            // lProducto
            // 
            this.lProducto.AutoSize = true;
            this.lProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProducto.Location = new System.Drawing.Point(335, 118);
            this.lProducto.Name = "lProducto";
            this.lProducto.Size = new System.Drawing.Size(70, 19);
            this.lProducto.TabIndex = 1;
            this.lProducto.Text = "Producto:";
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInicio.Location = new System.Drawing.Point(12, 167);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(48, 19);
            this.lInicio.TabIndex = 2;
            this.lInicio.Text = "Inicio:";
            // 
            // lEntrega
            // 
            this.lEntrega.AutoSize = true;
            this.lEntrega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEntrega.Location = new System.Drawing.Point(12, 207);
            this.lEntrega.Name = "lEntrega";
            this.lEntrega.Size = new System.Drawing.Size(63, 19);
            this.lEntrega.TabIndex = 3;
            this.lEntrega.Text = "Entrega:";
            // 
            // txtOrden
            // 
            this.txtOrden.Enabled = false;
            this.txtOrden.Location = new System.Drawing.Point(127, 120);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(161, 20);
            this.txtOrden.TabIndex = 5;
            // 
            // txtInicio
            // 
            this.txtInicio.Enabled = false;
            this.txtInicio.Location = new System.Drawing.Point(128, 168);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(161, 20);
            this.txtInicio.TabIndex = 8;
            this.txtInicio.Tag = "vinicioproduccion";
            // 
            // txtEntrega
            // 
            this.txtEntrega.Enabled = false;
            this.txtEntrega.Location = new System.Drawing.Point(128, 208);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(161, 20);
            this.txtEntrega.TabIndex = 9;
            this.txtEntrega.Tag = "ventregaproducto";
            // 
            // lFabricar
            // 
            this.lFabricar.AutoSize = true;
            this.lFabricar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFabricar.Location = new System.Drawing.Point(509, 169);
            this.lFabricar.Name = "lFabricar";
            this.lFabricar.Size = new System.Drawing.Size(144, 19);
            this.lFabricar.TabIndex = 17;
            this.lFabricar.Text = "Cantodad A Fabricar:";
            // 
            // txtFabricar
            // 
            this.txtFabricar.Enabled = false;
            this.txtFabricar.Location = new System.Drawing.Point(688, 167);
            this.txtFabricar.Name = "txtFabricar";
            this.txtFabricar.Size = new System.Drawing.Size(100, 20);
            this.txtFabricar.TabIndex = 20;
            this.txtFabricar.Tag = "ncantidadproductoafabricar";
            this.txtFabricar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFabricar_KeyPress);
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(600, 118);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(53, 19);
            this.lStatus.TabIndex = 23;
            this.lStatus.Text = "Status:";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 255);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(776, 222);
            this.dgvDetalle.TabIndex = 26;
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
            this.pnnavegador.Location = new System.Drawing.Point(62, 23);
            this.pnnavegador.Name = "pnnavegador";
            this.pnnavegador.Size = new System.Drawing.Size(650, 67);
            this.pnnavegador.TabIndex = 27;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnimprimir.Location = new System.Drawing.Point(327, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(47, 50);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnnuevo.Location = new System.Drawing.Point(11, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 50);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnirUltimo.Location = new System.Drawing.Point(592, 8);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(47, 50);
            this.btnirUltimo.TabIndex = 9;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnsiguiente.Location = new System.Drawing.Point(539, 8);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(47, 50);
            this.btnsiguiente.TabIndex = 8;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnanterior.Location = new System.Drawing.Point(486, 8);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(47, 50);
            this.btnanterior.TabIndex = 7;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnirPrimero.Location = new System.Drawing.Point(433, 8);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(47, 50);
            this.btnirPrimero.TabIndex = 6;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btneditar.Location = new System.Drawing.Point(64, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(47, 50);
            this.btneditar.TabIndex = 5;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Login.Properties.Resources.delete;
            this.btncancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btncancelar.Location = new System.Drawing.Point(223, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(47, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.btnbuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnbuscar.Location = new System.Drawing.Point(380, 8);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btneliminar.Location = new System.Drawing.Point(117, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 50);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnguardar.Location = new System.Drawing.Point(170, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(47, 50);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalir.Location = new System.Drawing.Point(737, 528);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 58;
            this.lblSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Login.Properties.Resources.salir;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(728, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 42);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Location = new System.Drawing.Point(687, 118);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(100, 20);
            this.txtstatus.TabIndex = 59;
            this.txtstatus.Tag = "vestatusorden";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(421, 120);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(151, 21);
            this.cmbProducto.TabIndex = 60;
            this.cmbProducto.SelectedValueChanged += new System.EventHandler(this.cmbProducto_SelectedValueChanged);
            // 
            // txtreferencia
            // 
            this.txtreferencia.Enabled = false;
            this.txtreferencia.Location = new System.Drawing.Point(361, 157);
            this.txtreferencia.Name = "txtreferencia";
            this.txtreferencia.Size = new System.Drawing.Size(100, 20);
            this.txtreferencia.TabIndex = 61;
            this.txtreferencia.Tag = "vreferenciaproducto";
            this.txtreferencia.Visible = false;
            // 
            // txtcodreceta
            // 
            this.txtcodreceta.Enabled = false;
            this.txtcodreceta.Location = new System.Drawing.Point(361, 183);
            this.txtcodreceta.Name = "txtcodreceta";
            this.txtcodreceta.Size = new System.Drawing.Size(100, 20);
            this.txtcodreceta.TabIndex = 62;
            this.txtcodreceta.Tag = "ncodreceta";
            this.txtcodreceta.Visible = false;
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 549);
            this.ControlBox = false;
            this.Controls.Add(this.txtcodreceta);
            this.Controls.Add(this.txtreferencia);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnnavegador);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.txtFabricar);
            this.Controls.Add(this.lFabricar);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.lEntrega);
            this.Controls.Add(this.lInicio);
            this.Controls.Add(this.lProducto);
            this.Controls.Add(this.lOrden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Seguimiento por Orden";
            this.Load += new System.EventHandler(this.frmOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnnavegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lOrden;
        private System.Windows.Forms.Label lProducto;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.Label lEntrega;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Label lFabricar;
        private System.Windows.Forms.TextBox txtFabricar;
        private System.Windows.Forms.Label lStatus;
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
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtreferencia;
        private System.Windows.Forms.TextBox txtcodreceta;
    }
}

