namespace Login
{
    partial class frmCrearCreditoDebito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearCreditoDebito));
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.dtNFecha = new System.Windows.Forms.DateTimePicker();
            this.txtFechad = new System.Windows.Forms.TextBox();
            this.cmbCFact = new System.Windows.Forms.ComboBox();
            this.txtCodFact = new System.Windows.Forms.TextBox();
            this.cmbDocumento = new System.Windows.Forms.ComboBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.cmbMontoFact = new System.Windows.Forms.ComboBox();
            this.cmbNit = new System.Windows.Forms.ComboBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblMontoFact = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblFactura = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.pnlInformacion.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdDatos
            // 
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(26, 271);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(653, 173);
            this.grdDatos.TabIndex = 22;
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.dtNFecha);
            this.pnlInformacion.Controls.Add(this.txtFechad);
            this.pnlInformacion.Controls.Add(this.cmbCFact);
            this.pnlInformacion.Controls.Add(this.txtCodFact);
            this.pnlInformacion.Controls.Add(this.cmbDocumento);
            this.pnlInformacion.Controls.Add(this.lblDocumento);
            this.pnlInformacion.Controls.Add(this.cmbMontoFact);
            this.pnlInformacion.Controls.Add(this.cmbNit);
            this.pnlInformacion.Controls.Add(this.cmbCliente);
            this.pnlInformacion.Controls.Add(this.txtMonto);
            this.pnlInformacion.Controls.Add(this.lblMonto);
            this.pnlInformacion.Controls.Add(this.lblMontoFact);
            this.pnlInformacion.Controls.Add(this.txtFactura);
            this.pnlInformacion.Controls.Add(this.lblNit);
            this.pnlInformacion.Controls.Add(this.lblFecha);
            this.pnlInformacion.Controls.Add(this.lblFactura);
            this.pnlInformacion.Controls.Add(this.lblCliente);
            this.pnlInformacion.Location = new System.Drawing.Point(26, 80);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(653, 185);
            this.pnlInformacion.TabIndex = 21;
            // 
            // dtNFecha
            // 
            this.dtNFecha.CustomFormat = "yyyy-MM-dd";
            this.dtNFecha.Enabled = false;
            this.dtNFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNFecha.Location = new System.Drawing.Point(111, 52);
            this.dtNFecha.Name = "dtNFecha";
            this.dtNFecha.Size = new System.Drawing.Size(200, 20);
            this.dtNFecha.TabIndex = 37;
            this.dtNFecha.Tag = "nfecha";
            // 
            // txtFechad
            // 
            this.txtFechad.Location = new System.Drawing.Point(111, 78);
            this.txtFechad.Name = "txtFechad";
            this.txtFechad.Size = new System.Drawing.Size(175, 20);
            this.txtFechad.TabIndex = 36;
            this.txtFechad.Tag = "dfecha";
            this.txtFechad.Visible = false;
            // 
            // cmbCFact
            // 
            this.cmbCFact.FormattingEnabled = true;
            this.cmbCFact.Location = new System.Drawing.Point(425, 24);
            this.cmbCFact.Name = "cmbCFact";
            this.cmbCFact.Size = new System.Drawing.Size(121, 21);
            this.cmbCFact.TabIndex = 35;
            this.cmbCFact.Visible = false;
            // 
            // txtCodFact
            // 
            this.txtCodFact.Location = new System.Drawing.Point(581, 25);
            this.txtCodFact.Name = "txtCodFact";
            this.txtCodFact.Size = new System.Drawing.Size(36, 20);
            this.txtCodFact.TabIndex = 34;
            this.txtCodFact.Tag = "ncodfactura";
            this.txtCodFact.Visible = false;
            // 
            // cmbDocumento
            // 
            this.cmbDocumento.Enabled = false;
            this.cmbDocumento.FormattingEnabled = true;
            this.cmbDocumento.Location = new System.Drawing.Point(111, 12);
            this.cmbDocumento.Name = "cmbDocumento";
            this.cmbDocumento.Size = new System.Drawing.Size(200, 21);
            this.cmbDocumento.TabIndex = 33;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(13, 15);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(65, 13);
            this.lblDocumento.TabIndex = 32;
            this.lblDocumento.Text = "Documento:";
            // 
            // cmbMontoFact
            // 
            this.cmbMontoFact.Enabled = false;
            this.cmbMontoFact.FormattingEnabled = true;
            this.cmbMontoFact.Location = new System.Drawing.Point(111, 144);
            this.cmbMontoFact.Name = "cmbMontoFact";
            this.cmbMontoFact.Size = new System.Drawing.Size(200, 21);
            this.cmbMontoFact.TabIndex = 31;
            // 
            // cmbNit
            // 
            this.cmbNit.Enabled = false;
            this.cmbNit.FormattingEnabled = true;
            this.cmbNit.Location = new System.Drawing.Point(425, 101);
            this.cmbNit.Name = "cmbNit";
            this.cmbNit.Size = new System.Drawing.Size(192, 21);
            this.cmbNit.TabIndex = 30;
            this.cmbNit.Visible = false;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Enabled = false;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(111, 104);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(200, 21);
            this.cmbCliente.TabIndex = 19;
            this.cmbCliente.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(425, 144);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(192, 20);
            this.txtMonto.TabIndex = 29;
            this.txtMonto.Tag = "nmonto";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(327, 144);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(40, 13);
            this.lblMonto.TabIndex = 28;
            this.lblMonto.Text = "Monto:";
            // 
            // lblMontoFact
            // 
            this.lblMontoFact.AutoSize = true;
            this.lblMontoFact.Location = new System.Drawing.Point(13, 147);
            this.lblMontoFact.Name = "lblMontoFact";
            this.lblMontoFact.Size = new System.Drawing.Size(76, 13);
            this.lblMontoFact.TabIndex = 26;
            this.lblMontoFact.Text = "Monto Factura";
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(425, 60);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(192, 20);
            this.txtFactura.TabIndex = 25;
            this.txtFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFactura_KeyUp);
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(324, 104);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(23, 13);
            this.lblNit.TabIndex = 21;
            this.lblNit.Text = "Nit:";
            this.lblNit.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(13, 60);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(92, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha de la Nota:";
            // 
            // lblFactura
            // 
            this.lblFactura.AutoSize = true;
            this.lblFactura.Location = new System.Drawing.Point(324, 60);
            this.lblFactura.Name = "lblFactura";
            this.lblFactura.Size = new System.Drawing.Size(86, 13);
            this.lblFactura.TabIndex = 11;
            this.lblFactura.Text = "Afecta a Factura";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 104);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 16;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.Visible = false;
            // 
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
            this.panel3.Location = new System.Drawing.Point(26, 23);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 20;
            // 
            // btnIrUltimo
            // 
            this.btnIrUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnIrUltimo.Image")));
            this.btnIrUltimo.Location = new System.Drawing.Point(597, 4);
            this.btnIrUltimo.Name = "btnIrUltimo";
            this.btnIrUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnIrUltimo.TabIndex = 16;
            this.btnIrUltimo.UseVisualStyleBackColor = true;
            this.btnIrUltimo.Click += new System.EventHandler(this.btnIrUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(489, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(48, 42);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnIrPrimero
            // 
            this.btnIrPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnIrPrimero.Image")));
            this.btnIrPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnIrPrimero.Name = "btnIrPrimero";
            this.btnIrPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnIrPrimero.TabIndex = 13;
            this.btnIrPrimero.UseVisualStyleBackColor = true;
            this.btnIrPrimero.Click += new System.EventHandler(this.btnIrPrimero_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Enabled = false;
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
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(219, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCrearCreditoDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 457);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.panel3);
            this.Name = "frmCrearCreditoDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearCreditoDebito";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.DateTimePicker dtNFecha;
        private System.Windows.Forms.TextBox txtFechad;
        private System.Windows.Forms.ComboBox cmbCFact;
        private System.Windows.Forms.TextBox txtCodFact;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ComboBox cmbMontoFact;
        private System.Windows.Forms.ComboBox cmbNit;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMontoFact;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblCliente;
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
    }
}