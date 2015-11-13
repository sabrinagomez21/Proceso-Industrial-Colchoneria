namespace Login
{
    partial class frmCrearNotaCreaditoDebito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearNotaCreaditoDebito));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnirUltimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnirPrimero = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
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
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnirUltimo);
            this.panel3.Controls.Add(this.btnsiguiente);
            this.panel3.Controls.Add(this.btnanterior);
            this.panel3.Controls.Add(this.btnirPrimero);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.btnimprimir);
            this.panel3.Controls.Add(this.btnrefrescar);
            this.panel3.Controls.Add(this.btncancelar);
            this.panel3.Controls.Add(this.btnguardar);
            this.panel3.Controls.Add(this.btneliminar);
            this.panel3.Controls.Add(this.btneditar);
            this.panel3.Controls.Add(this.btnnuevo);
            this.panel3.Location = new System.Drawing.Point(15, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 17;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnirUltimo.Image")));
            this.btnirUltimo.Location = new System.Drawing.Point(597, 4);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnirUltimo.TabIndex = 16;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            this.btnirUltimo.Click += new System.EventHandler(this.btnIrUltimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnsiguiente.TabIndex = 15;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(489, 4);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(48, 42);
            this.btnanterior.TabIndex = 14;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnirPrimero.Image")));
            this.btnirPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnirPrimero.TabIndex = 13;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            this.btnirPrimero.Click += new System.EventHandler(this.btnIrPrimero_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(381, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(48, 42);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(327, 4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(48, 42);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.Location = new System.Drawing.Point(273, 4);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnrefrescar.TabIndex = 10;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(219, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(48, 42);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(165, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(48, 42);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(111, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(48, 42);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(57, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(48, 42);
            this.btneditar.TabIndex = 6;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(3, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(48, 42);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.pnlInformacion.Location = new System.Drawing.Point(15, 69);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(653, 185);
            this.pnlInformacion.TabIndex = 18;
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
            this.lblDocumento.Click += new System.EventHandler(this.label1_Click);
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
            this.lblNit.Click += new System.EventHandler(this.lblNit_Click);
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
            // grdDatos
            // 
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(15, 260);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDatos.Size = new System.Drawing.Size(653, 173);
            this.grdDatos.TabIndex = 19;
            // 
            // frmCrearNotaCreaditoDebito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 445);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.pnlInformacion);
            this.Controls.Add(this.panel3);
            this.Name = "frmCrearNotaCreaditoDebito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearNotaCreaditoDebito";
            this.Load += new System.EventHandler(this.frmCrearNotaCreaditoDebito_Load);
            this.panel3.ResumeLayout(false);
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnirUltimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnirPrimero;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblFactura;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblMontoFact;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.ComboBox cmbMontoFact;
        private System.Windows.Forms.ComboBox cmbNit;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.ComboBox cmbDocumento;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtCodFact;
        private System.Windows.Forms.ComboBox cmbCFact;
        private System.Windows.Forms.TextBox txtFechad;
        private System.Windows.Forms.DateTimePicker dtNFecha;
    }
}