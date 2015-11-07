namespace CuentasPorCobrar
{
    partial class frmPrincipalCxC
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
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTransaccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocto = new System.Windows.Forms.TextBox();
            this.grdDocumentos = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPagoCobro = new System.Windows.Forms.Button();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalCxC));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbTransaccion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDocto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
>>>>>>> Josue
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTransaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaRecibosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
<<<<<<< HEAD
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
=======
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIrUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnIrPrimero = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnPagoCobro = new System.Windows.Forms.Button();
            this.grdDocumentos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).BeginInit();
>>>>>>> Josue
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Cliente";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(75, 11);
            this.txtCliente.Name = "txtCliente";
<<<<<<< HEAD
            this.txtCliente.Size = new System.Drawing.Size(152, 20);
            this.txtCliente.TabIndex = 1;
=======
            this.txtCliente.Size = new System.Drawing.Size(246, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
>>>>>>> Josue
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
            this.panel1.Controls.Add(this.cmbTransaccion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFecha);
=======
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.cmbTransaccion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
>>>>>>> Josue
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDocto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCliente);
<<<<<<< HEAD
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 76);
            this.panel1.TabIndex = 2;
            // 
=======
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 76);
            this.panel1.TabIndex = 2;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "yyyy-MM-dd";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(412, 12);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(233, 20);
            this.dtpFecha.TabIndex = 73;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
>>>>>>> Josue
            // cmbTransaccion
            // 
            this.cmbTransaccion.FormattingEnabled = true;
            this.cmbTransaccion.Items.AddRange(new object[] {
            "Cobros",
            "Pagos"});
<<<<<<< HEAD
            this.cmbTransaccion.Location = new System.Drawing.Point(346, 38);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(149, 21);
            this.cmbTransaccion.TabIndex = 7;
=======
            this.cmbTransaccion.Location = new System.Drawing.Point(412, 41);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(233, 21);
            this.cmbTransaccion.TabIndex = 7;
            this.cmbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cmbTransaccion_SelectedIndexChanged);
>>>>>>> Josue
            // 
            // label3
            // 
            this.label3.AutoSize = true;
<<<<<<< HEAD
            this.label3.Location = new System.Drawing.Point(271, 41);
=======
            this.label3.Location = new System.Drawing.Point(337, 44);
>>>>>>> Josue
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
<<<<<<< HEAD
            this.label4.Location = new System.Drawing.Point(271, 14);
=======
            this.label4.Location = new System.Drawing.Point(337, 17);
>>>>>>> Josue
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
<<<<<<< HEAD
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(346, 11);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(149, 20);
            this.txtFecha.TabIndex = 5;
            // 
=======
>>>>>>> Josue
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "No. Docto";
            // 
            // txtDocto
            // 
            this.txtDocto.Location = new System.Drawing.Point(75, 41);
            this.txtDocto.Name = "txtDocto";
<<<<<<< HEAD
            this.txtDocto.Size = new System.Drawing.Size(152, 20);
            this.txtDocto.TabIndex = 2;
            // 
            // grdDocumentos
            // 
            this.grdDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Fecha,
            this.Monto});
            this.grdDocumentos.Location = new System.Drawing.Point(12, 171);
            this.grdDocumentos.Name = "grdDocumentos";
            this.grdDocumentos.Size = new System.Drawing.Size(510, 193);
            this.grdDocumentos.TabIndex = 3;
            // 
            // Factura
            // 
            this.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
=======
            this.txtDocto.Size = new System.Drawing.Size(246, 20);
            this.txtDocto.TabIndex = 2;
            this.txtDocto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocto_KeyUp);
>>>>>>> Josue
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.label5);
<<<<<<< HEAD
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 48);
=======
            this.panel2.Location = new System.Drawing.Point(13, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 48);
>>>>>>> Josue
            this.panel2.TabIndex = 4;
            // 
            // txtValor
            // 
<<<<<<< HEAD
            this.txtValor.Location = new System.Drawing.Point(204, 15);
=======
            this.txtValor.Location = new System.Drawing.Point(287, 13);
>>>>>>> Josue
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
<<<<<<< HEAD
            this.label5.Location = new System.Drawing.Point(167, 18);
=======
            this.label5.Location = new System.Drawing.Point(250, 16);
>>>>>>> Josue
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor";
            // 
<<<<<<< HEAD
            // btnPagoCobro
            // 
            this.btnPagoCobro.Location = new System.Drawing.Point(230, 370);
            this.btnPagoCobro.Name = "btnPagoCobro";
            this.btnPagoCobro.Size = new System.Drawing.Size(75, 23);
            this.btnPagoCobro.TabIndex = 5;
            this.btnPagoCobro.Text = "Cobrar";
            this.btnPagoCobro.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> Josue
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< HEAD
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
=======
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
>>>>>>> Josue
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoTransaccionesToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.consultaToolStripMenuItem.Text = "Catalogos";
            // 
            // mantenimientoTransaccionesToolStripMenuItem
            // 
            this.mantenimientoTransaccionesToolStripMenuItem.Name = "mantenimientoTransaccionesToolStripMenuItem";
            this.mantenimientoTransaccionesToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.mantenimientoTransaccionesToolStripMenuItem.Text = "Mantenimiento Transacciones";
            this.mantenimientoTransaccionesToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoTransaccionesToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaRecibosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultaRecibosToolStripMenuItem
            // 
            this.consultaRecibosToolStripMenuItem.Name = "consultaRecibosToolStripMenuItem";
            this.consultaRecibosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultaRecibosToolStripMenuItem.Text = "Consulta Recibos";
            this.consultaRecibosToolStripMenuItem.Click += new System.EventHandler(this.consultaRecibosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
<<<<<<< HEAD
=======
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnIrUltimo);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Controls.Add(this.btnIrPrimero);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnRefrescar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 8;
            // 
            // btnIrUltimo
            // 
            this.btnIrUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnIrUltimo.Image")));
            this.btnIrUltimo.Location = new System.Drawing.Point(597, 4);
            this.btnIrUltimo.Name = "btnIrUltimo";
            this.btnIrUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnIrUltimo.TabIndex = 16;
            this.btnIrUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(489, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(48, 42);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnIrPrimero
            // 
            this.btnIrPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnIrPrimero.Image")));
            this.btnIrPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnIrPrimero.Name = "btnIrPrimero";
            this.btnIrPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnIrPrimero.TabIndex = 13;
            this.btnIrPrimero.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(381, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 42);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(327, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 42);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(273, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(219, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(111, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(57, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnPagoCobro
            // 
            this.btnPagoCobro.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoCobro.Image")));
            this.btnPagoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoCobro.Location = new System.Drawing.Point(311, 420);
            this.btnPagoCobro.Name = "btnPagoCobro";
            this.btnPagoCobro.Size = new System.Drawing.Size(77, 35);
            this.btnPagoCobro.TabIndex = 5;
            this.btnPagoCobro.Text = "Cobrar";
            this.btnPagoCobro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagoCobro.UseVisualStyleBackColor = true;
            this.btnPagoCobro.Click += new System.EventHandler(this.btnPagoCobro_Click);
            // 
            // grdDocumentos
            // 
            this.grdDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDocumentos.Location = new System.Drawing.Point(16, 220);
            this.grdDocumentos.Name = "grdDocumentos";
            this.grdDocumentos.Size = new System.Drawing.Size(649, 194);
            this.grdDocumentos.TabIndex = 10;
            // 
>>>>>>> Josue
            // frmPrincipalCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(534, 403);
            this.Controls.Add(this.btnPagoCobro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grdDocumentos);
=======
            this.ClientSize = new System.Drawing.Size(675, 463);
            this.Controls.Add(this.grdDocumentos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPagoCobro);
            this.Controls.Add(this.panel2);
>>>>>>> Josue
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipalCxC";
            this.Text = "frmPrincipalCxC";
            this.Load += new System.EventHandler(this.frmPrincipalCxC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).EndInit();
=======
>>>>>>> Josue
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
<<<<<<< HEAD
=======
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).EndInit();
>>>>>>> Josue
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTransaccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
<<<<<<< HEAD
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocto;
        private System.Windows.Forms.DataGridView grdDocumentos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPagoCobro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
=======
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
>>>>>>> Josue
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTransaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaRecibosToolStripMenuItem;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIrUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnIrPrimero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnPagoCobro;
        private System.Windows.Forms.DataGridView grdDocumentos;
        public System.Windows.Forms.DateTimePicker dtpFecha;
>>>>>>> Josue
    }
}