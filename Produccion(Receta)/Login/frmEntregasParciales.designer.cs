namespace Login
{
    partial class frmEntregasParciales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
       

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntregasParciales));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatusOrden = new System.Windows.Forms.TextBox();
            this.cbxNoOrden = new System.Windows.Forms.ComboBox();
            this.ffechaMovimiento = new System.Windows.Forms.DateTimePicker();
            this.txtfechaEntrega = new System.Windows.Forms.TextBox();
            this.dFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.txtTotalDeLaEntrega = new System.Windows.Forms.TextBox();
            this.txtCostoUnitario = new System.Windows.Forms.TextBox();
            this.lTotalDeLaEntrega = new System.Windows.Forms.Label();
            this.lCostoUnitario = new System.Windows.Forms.Label();
            this.txtCantidadaEntregar = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtFechaMovimiento = new System.Windows.Forms.TextBox();
            this.lCantidadaEntregar = new System.Windows.Forms.Label();
            this.lDocumento = new System.Windows.Forms.Label();
            this.lFechaMovimiento = new System.Windows.Forms.Label();
            this.txtCantidadaFabricar = new System.Windows.Forms.TextBox();
            this.lCantidadaFabricar = new System.Windows.Forms.Label();
            this.lFechaEntrega = new System.Windows.Forms.Label();
            this.txtProductoaFabricar = new System.Windows.Forms.TextBox();
            this.lProductoaFabricar = new System.Windows.Forms.Label();
            this.lNumero = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnirPrimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnirUltimo = new System.Windows.Forms.Button();
            this.dgvEntregasParciales = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasParciales)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatusOrden);
            this.groupBox1.Controls.Add(this.cbxNoOrden);
            this.groupBox1.Controls.Add(this.ffechaMovimiento);
            this.groupBox1.Controls.Add(this.txtfechaEntrega);
            this.groupBox1.Controls.Add(this.dFechaEntrega);
            this.groupBox1.Controls.Add(this.txtTotalDeLaEntrega);
            this.groupBox1.Controls.Add(this.txtCostoUnitario);
            this.groupBox1.Controls.Add(this.lTotalDeLaEntrega);
            this.groupBox1.Controls.Add(this.lCostoUnitario);
            this.groupBox1.Controls.Add(this.txtCantidadaEntregar);
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.txtFechaMovimiento);
            this.groupBox1.Controls.Add(this.lCantidadaEntregar);
            this.groupBox1.Controls.Add(this.lDocumento);
            this.groupBox1.Controls.Add(this.lFechaMovimiento);
            this.groupBox1.Controls.Add(this.txtCantidadaFabricar);
            this.groupBox1.Controls.Add(this.lCantidadaFabricar);
            this.groupBox1.Controls.Add(this.lFechaEntrega);
            this.groupBox1.Controls.Add(this.txtProductoaFabricar);
            this.groupBox1.Controls.Add(this.lProductoaFabricar);
            this.groupBox1.Controls.Add(this.lNumero);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // txtStatusOrden
            // 
            this.txtStatusOrden.Location = new System.Drawing.Point(756, 140);
            this.txtStatusOrden.Name = "txtStatusOrden";
            this.txtStatusOrden.Size = new System.Drawing.Size(18, 27);
            this.txtStatusOrden.TabIndex = 32;
            this.txtStatusOrden.Tag = "ncodstatusorden";
            this.txtStatusOrden.Visible = false;
            // 
            // cbxNoOrden
            // 
            this.cbxNoOrden.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxNoOrden.FormattingEnabled = true;
            this.cbxNoOrden.Location = new System.Drawing.Point(161, 38);
            this.cbxNoOrden.Name = "cbxNoOrden";
            this.cbxNoOrden.Size = new System.Drawing.Size(121, 27);
            this.cbxNoOrden.TabIndex = 31;
            this.cbxNoOrden.DropDownClosed += new System.EventHandler(this.cbxNoOrden_DropDownClosed);
            // 
            // ffechaMovimiento
            // 
            this.ffechaMovimiento.Location = new System.Drawing.Point(177, 182);
            this.ffechaMovimiento.Name = "ffechaMovimiento";
            this.ffechaMovimiento.Size = new System.Drawing.Size(200, 27);
            this.ffechaMovimiento.TabIndex = 30;
            this.ffechaMovimiento.Tag = "vultimomovimiento";
            // 
            // txtfechaEntrega
            // 
            this.txtfechaEntrega.Enabled = false;
            this.txtfechaEntrega.Location = new System.Drawing.Point(756, 71);
            this.txtfechaEntrega.Name = "txtfechaEntrega";
            this.txtfechaEntrega.Size = new System.Drawing.Size(10, 27);
            this.txtfechaEntrega.TabIndex = 29;
            this.txtfechaEntrega.Visible = false;
            // 
            // dFechaEntrega
            // 
            this.dFechaEntrega.Enabled = false;
            this.dFechaEntrega.Location = new System.Drawing.Point(531, 38);
            this.dFechaEntrega.Name = "dFechaEntrega";
            this.dFechaEntrega.Size = new System.Drawing.Size(260, 27);
            this.dFechaEntrega.TabIndex = 28;
            this.dFechaEntrega.Tag = "ventregaproducto";
            // 
            // txtTotalDeLaEntrega
            // 
            this.txtTotalDeLaEntrega.Location = new System.Drawing.Point(501, 253);
            this.txtTotalDeLaEntrega.Name = "txtTotalDeLaEntrega";
            this.txtTotalDeLaEntrega.Size = new System.Drawing.Size(189, 27);
            this.txtTotalDeLaEntrega.TabIndex = 25;
            this.txtTotalDeLaEntrega.Click += new System.EventHandler(this.txtTotalDeLaEntrega_Click);
            // 
            // txtCostoUnitario
            // 
            this.txtCostoUnitario.Location = new System.Drawing.Point(501, 220);
            this.txtCostoUnitario.Name = "txtCostoUnitario";
            this.txtCostoUnitario.Size = new System.Drawing.Size(189, 27);
            this.txtCostoUnitario.TabIndex = 23;
            this.txtCostoUnitario.TextChanged += new System.EventHandler(this.txtCostoUnitario_TextChanged);
            // 
            // lTotalDeLaEntrega
            // 
            this.lTotalDeLaEntrega.AutoSize = true;
            this.lTotalDeLaEntrega.Location = new System.Drawing.Point(360, 256);
            this.lTotalDeLaEntrega.Name = "lTotalDeLaEntrega";
            this.lTotalDeLaEntrega.Size = new System.Drawing.Size(135, 19);
            this.lTotalDeLaEntrega.TabIndex = 21;
            this.lTotalDeLaEntrega.Text = "Total de la Entrega:";
            // 
            // lCostoUnitario
            // 
            this.lCostoUnitario.AutoSize = true;
            this.lCostoUnitario.Location = new System.Drawing.Point(360, 223);
            this.lCostoUnitario.Name = "lCostoUnitario";
            this.lCostoUnitario.Size = new System.Drawing.Size(106, 19);
            this.lCostoUnitario.TabIndex = 19;
            this.lCostoUnitario.Text = "Costo Unitario:";
            // 
            // txtCantidadaEntregar
            // 
            this.txtCantidadaEntregar.Location = new System.Drawing.Point(177, 248);
            this.txtCantidadaEntregar.Name = "txtCantidadaEntregar";
            this.txtCantidadaEntregar.Size = new System.Drawing.Size(161, 27);
            this.txtCantidadaEntregar.TabIndex = 17;
            this.txtCantidadaEntregar.Tag = "ncantidadnoproductoterminado";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(177, 215);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(161, 27);
            this.txtDocumento.TabIndex = 16;
            this.txtDocumento.Tag = "nnodocumento";
            // 
            // txtFechaMovimiento
            // 
            this.txtFechaMovimiento.Location = new System.Drawing.Point(404, 185);
            this.txtFechaMovimiento.Name = "txtFechaMovimiento";
            this.txtFechaMovimiento.Size = new System.Drawing.Size(28, 27);
            this.txtFechaMovimiento.TabIndex = 15;
            this.txtFechaMovimiento.Visible = false;
            // 
            // lCantidadaEntregar
            // 
            this.lCantidadaEntregar.AutoSize = true;
            this.lCantidadaEntregar.Location = new System.Drawing.Point(11, 249);
            this.lCantidadaEntregar.Name = "lCantidadaEntregar";
            this.lCantidadaEntregar.Size = new System.Drawing.Size(142, 19);
            this.lCantidadaEntregar.TabIndex = 14;
            this.lCantidadaEntregar.Text = "Cantidad a Entregar:";
            // 
            // lDocumento
            // 
            this.lDocumento.AutoSize = true;
            this.lDocumento.Location = new System.Drawing.Point(11, 218);
            this.lDocumento.Name = "lDocumento";
            this.lDocumento.Size = new System.Drawing.Size(87, 19);
            this.lDocumento.TabIndex = 13;
            this.lDocumento.Text = "Documento:";
            // 
            // lFechaMovimiento
            // 
            this.lFechaMovimiento.AutoSize = true;
            this.lFechaMovimiento.Location = new System.Drawing.Point(11, 182);
            this.lFechaMovimiento.Name = "lFechaMovimiento";
            this.lFechaMovimiento.Size = new System.Drawing.Size(156, 19);
            this.lFechaMovimiento.TabIndex = 12;
            this.lFechaMovimiento.Text = "Fecha del Movimiento:";
            // 
            // txtCantidadaFabricar
            // 
            this.txtCantidadaFabricar.Enabled = false;
            this.txtCantidadaFabricar.Location = new System.Drawing.Point(161, 117);
            this.txtCantidadaFabricar.Name = "txtCantidadaFabricar";
            this.txtCantidadaFabricar.Size = new System.Drawing.Size(179, 27);
            this.txtCantidadaFabricar.TabIndex = 10;
            this.txtCantidadaFabricar.Tag = "ncantidadproductoafabricar";
            // 
            // lCantidadaFabricar
            // 
            this.lCantidadaFabricar.AutoSize = true;
            this.lCantidadaFabricar.Location = new System.Drawing.Point(11, 117);
            this.lCantidadaFabricar.Name = "lCantidadaFabricar";
            this.lCantidadaFabricar.Size = new System.Drawing.Size(139, 19);
            this.lCantidadaFabricar.TabIndex = 9;
            this.lCantidadaFabricar.Text = "Cantidad a Fabricar:";
            // 
            // lFechaEntrega
            // 
            this.lFechaEntrega.AutoSize = true;
            this.lFechaEntrega.Location = new System.Drawing.Point(400, 38);
            this.lFechaEntrega.Name = "lFechaEntrega";
            this.lFechaEntrega.Size = new System.Drawing.Size(125, 19);
            this.lFechaEntrega.TabIndex = 6;
            this.lFechaEntrega.Text = "Fecha de Entrega:";
            // 
            // txtProductoaFabricar
            // 
            this.txtProductoaFabricar.Enabled = false;
            this.txtProductoaFabricar.Location = new System.Drawing.Point(161, 78);
            this.txtProductoaFabricar.Name = "txtProductoaFabricar";
            this.txtProductoaFabricar.Size = new System.Drawing.Size(216, 27);
            this.txtProductoaFabricar.TabIndex = 2;
            this.txtProductoaFabricar.Tag = "vreferenciaproducto";
            // 
            // lProductoaFabricar
            // 
            this.lProductoaFabricar.AutoSize = true;
            this.lProductoaFabricar.Location = new System.Drawing.Point(16, 78);
            this.lProductoaFabricar.Name = "lProductoaFabricar";
            this.lProductoaFabricar.Size = new System.Drawing.Size(141, 19);
            this.lProductoaFabricar.TabIndex = 1;
            this.lProductoaFabricar.Text = "Producto a Entregar:";
            // 
            // lNumero
            // 
            this.lNumero.AutoSize = true;
            this.lNumero.Location = new System.Drawing.Point(16, 38);
            this.lNumero.Name = "lNumero";
            this.lNumero.Size = new System.Drawing.Size(64, 19);
            this.lNumero.TabIndex = 0;
            this.lNumero.Text = "Número:";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(22, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 54;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(74, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(46, 43);
            this.btneditar.TabIndex = 55;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(126, 12);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 43);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::Login.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(178, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 43);
            this.btnguardar.TabIndex = 57;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::Login.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(230, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 43);
            this.btncancelar.TabIndex = 58;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Enabled = false;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(282, 12);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(46, 43);
            this.btnrefrescar.TabIndex = 59;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(334, 12);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 43);
            this.btnimprimir.TabIndex = 60;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(386, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(46, 43);
            this.btnbuscar.TabIndex = 61;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Enabled = false;
            this.btnirPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(438, 12);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(46, 43);
            this.btnirPrimero.TabIndex = 62;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(490, 12);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 43);
            this.btnanterior.TabIndex = 63;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.Location = new System.Drawing.Point(542, 12);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(46, 43);
            this.btnsiguiente.TabIndex = 64;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(594, 12);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(46, 43);
            this.btnirUltimo.TabIndex = 65;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // dgvEntregasParciales
            // 
            this.dgvEntregasParciales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntregasParciales.Location = new System.Drawing.Point(22, 406);
            this.dgvEntregasParciales.Name = "dgvEntregasParciales";
            this.dgvEntregasParciales.Size = new System.Drawing.Size(811, 150);
            this.dgvEntregasParciales.TabIndex = 66;
            // 
            // frmEntregasParciales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 580);
            this.Controls.Add(this.dgvEntregasParciales);
            this.Controls.Add(this.btnirUltimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnirPrimero);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.btnrefrescar);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntregasParciales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "frmEntregasParciales";
            this.Text = "Entregas Parciales";
            this.Load += new System.EventHandler(this.frmEntregasParciales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregasParciales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lProductoaFabricar;
        private System.Windows.Forms.Label lNumero;
        private System.Windows.Forms.Label lFechaEntrega;
        private System.Windows.Forms.TextBox txtProductoaFabricar;
        private System.Windows.Forms.Label lCantidadaEntregar;
        private System.Windows.Forms.Label lDocumento;
        private System.Windows.Forms.Label lFechaMovimiento;
        private System.Windows.Forms.TextBox txtCantidadaFabricar;
        private System.Windows.Forms.Label lCantidadaFabricar;
        private System.Windows.Forms.TextBox txtCantidadaEntregar;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtFechaMovimiento;
        private System.Windows.Forms.TextBox txtTotalDeLaEntrega;
        private System.Windows.Forms.TextBox txtCostoUnitario;
        private System.Windows.Forms.Label lTotalDeLaEntrega;
        private System.Windows.Forms.Label lCostoUnitario;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dFechaEntrega;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnirPrimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnirUltimo;
        private System.Windows.Forms.TextBox txtfechaEntrega;
        private System.Windows.Forms.DateTimePicker ffechaMovimiento;
        public System.Windows.Forms.ComboBox cbxNoOrden;
        private System.Windows.Forms.TextBox txtStatusOrden;
        public System.Windows.Forms.DataGridView dgvEntregasParciales;
    }
}