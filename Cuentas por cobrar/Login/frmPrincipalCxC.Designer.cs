namespace Login
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
            this.txtTempCliente = new System.Windows.Forms.TextBox();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTempTotal = new System.Windows.Forms.TextBox();
            this.txtExpira = new System.Windows.Forms.TextBox();
            this.txtTempNo = new System.Windows.Forms.TextBox();
            this.txtTempCodFact = new System.Windows.Forms.TextBox();
            this.txtTransaccion = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.txtTotalCobro = new System.Windows.Forms.TextBox();
            this.cmbTrans = new System.Windows.Forms.ComboBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.txtTemporalCuenta = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnPagoCobro = new System.Windows.Forms.Button();
            this.grdDocumentos = new System.Windows.Forms.DataGridView();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtFacDoc = new System.Windows.Forms.TextBox();
            this.cmbcodDocu = new System.Windows.Forms.ComboBox();
            this.txtFechaCobro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).BeginInit();
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
            this.txtCliente.Location = new System.Drawing.Point(92, 11);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(229, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.Enter += new System.EventHandler(this.txtCliente_Enter);
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            this.txtCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.cmbTransaccion);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDocto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCliente);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 73);
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
            // cmbTransaccion
            // 
            this.cmbTransaccion.FormattingEnabled = true;
            this.cmbTransaccion.Items.AddRange(new object[] {
            "Cobros",
            "Pagos"});
            this.cmbTransaccion.Location = new System.Drawing.Point(412, 41);
            this.cmbTransaccion.Name = "cmbTransaccion";
            this.cmbTransaccion.Size = new System.Drawing.Size(233, 21);
            this.cmbTransaccion.TabIndex = 7;
            this.cmbTransaccion.SelectedIndexChanged += new System.EventHandler(this.cmbTransaccion_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(337, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transaccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha";
            // 
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
            this.txtDocto.Location = new System.Drawing.Point(92, 41);
            this.txtDocto.Name = "txtDocto";
            this.txtDocto.Size = new System.Drawing.Size(229, 20);
            this.txtDocto.TabIndex = 2;
            this.txtDocto.Enter += new System.EventHandler(this.txtDocto_Enter);
            this.txtDocto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDocto_KeyPress);
            this.txtDocto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDocto_KeyUp);
            // 
            // txtTempCliente
            // 
            this.txtTempCliente.Location = new System.Drawing.Point(626, 12);
            this.txtTempCliente.Name = "txtTempCliente";
            this.txtTempCliente.Size = new System.Drawing.Size(10, 20);
            this.txtTempCliente.TabIndex = 85;
            this.txtTempCliente.Tag = "ncodcliente";
            this.txtTempCliente.Visible = false;
            // 
            // txtPagado
            // 
            this.txtPagado.Location = new System.Drawing.Point(612, 14);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(8, 20);
            this.txtPagado.TabIndex = 84;
            this.txtPagado.Tag = "cpagado";
            this.txtPagado.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(595, 12);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(11, 20);
            this.txtEstado.TabIndex = 83;
            this.txtEstado.Tag = "cestado";
            this.txtEstado.Visible = false;
            // 
            // txtTempTotal
            // 
            this.txtTempTotal.Location = new System.Drawing.Point(576, 12);
            this.txtTempTotal.Name = "txtTempTotal";
            this.txtTempTotal.Size = new System.Drawing.Size(13, 20);
            this.txtTempTotal.TabIndex = 82;
            this.txtTempTotal.Tag = "ntotal";
            this.txtTempTotal.Visible = false;
            // 
            // txtExpira
            // 
            this.txtExpira.Location = new System.Drawing.Point(558, 12);
            this.txtExpira.Name = "txtExpira";
            this.txtExpira.Size = new System.Drawing.Size(12, 20);
            this.txtExpira.TabIndex = 81;
            this.txtExpira.Tag = "dfechaexpiracion";
            this.txtExpira.Visible = false;
            // 
            // txtTempNo
            // 
            this.txtTempNo.Location = new System.Drawing.Point(536, 13);
            this.txtTempNo.Name = "txtTempNo";
            this.txtTempNo.Size = new System.Drawing.Size(16, 20);
            this.txtTempNo.TabIndex = 80;
            this.txtTempNo.Tag = "nnofactura";
            this.txtTempNo.Visible = false;
            // 
            // txtTempCodFact
            // 
            this.txtTempCodFact.Location = new System.Drawing.Point(520, 12);
            this.txtTempCodFact.Name = "txtTempCodFact";
            this.txtTempCodFact.Size = new System.Drawing.Size(10, 20);
            this.txtTempCodFact.TabIndex = 79;
            this.txtTempCodFact.Tag = "ncodfactura";
            this.txtTempCodFact.Visible = false;
            // 
            // txtTransaccion
            // 
            this.txtTransaccion.Location = new System.Drawing.Point(504, 12);
            this.txtTransaccion.Name = "txtTransaccion";
            this.txtTransaccion.Size = new System.Drawing.Size(10, 20);
            this.txtTransaccion.TabIndex = 78;
            this.txtTransaccion.Tag = "ncodtipotransaccion";
            this.txtTransaccion.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(486, 12);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(12, 20);
            this.txtFecha.TabIndex = 77;
            this.txtFecha.Tag = "dfecha";
            this.txtFecha.Visible = false;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(472, 12);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(10, 20);
            this.txtCuenta.TabIndex = 76;
            this.txtCuenta.Tag = "ncodcuenta";
            this.txtCuenta.Visible = false;
            // 
            // cmbBanco
            // 
            this.cmbBanco.Enabled = false;
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(217, 13);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(100, 21);
            this.cmbBanco.TabIndex = 75;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(136, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "Cuenta Banco";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMora);
            this.panel2.Controls.Add(this.txtSaldo);
            this.panel2.Controls.Add(this.txtPago);
            this.panel2.Controls.Add(this.txtTotalCobro);
            this.panel2.Controls.Add(this.cmbTrans);
            this.panel2.Controls.Add(this.cmbCuenta);
            this.panel2.Controls.Add(this.txtTemporalCuenta);
            this.panel2.Controls.Add(this.txtTempCliente);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.txtPagado);
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtTempTotal);
            this.panel2.Controls.Add(this.cmbBanco);
            this.panel2.Controls.Add(this.txtExpira);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTempNo);
            this.panel2.Controls.Add(this.txtCuenta);
            this.panel2.Controls.Add(this.txtTempCodFact);
            this.panel2.Controls.Add(this.txtFecha);
            this.panel2.Controls.Add(this.txtTransaccion);
            this.panel2.Location = new System.Drawing.Point(13, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(652, 48);
            this.panel2.TabIndex = 4;
            // 
            // txtMora
            // 
            this.txtMora.Location = new System.Drawing.Point(107, 10);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(10, 20);
            this.txtMora.TabIndex = 92;
            this.txtMora.Tag = "nmora";
            this.txtMora.Visible = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(91, 12);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(10, 20);
            this.txtSaldo.TabIndex = 91;
            this.txtSaldo.Tag = "nsaldo";
            this.txtSaldo.Visible = false;
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(76, 12);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(10, 20);
            this.txtPago.TabIndex = 90;
            this.txtPago.Tag = "npago";
            this.txtPago.Visible = false;
            // 
            // txtTotalCobro
            // 
            this.txtTotalCobro.Location = new System.Drawing.Point(60, 12);
            this.txtTotalCobro.Name = "txtTotalCobro";
            this.txtTotalCobro.Size = new System.Drawing.Size(10, 20);
            this.txtTotalCobro.TabIndex = 89;
            this.txtTotalCobro.Tag = "dmonto";
            this.txtTotalCobro.Visible = false;
            // 
            // cmbTrans
            // 
            this.cmbTrans.FormattingEnabled = true;
            this.cmbTrans.Location = new System.Drawing.Point(44, 13);
            this.cmbTrans.Name = "cmbTrans";
            this.cmbTrans.Size = new System.Drawing.Size(10, 21);
            this.cmbTrans.TabIndex = 88;
            this.cmbTrans.Visible = false;
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(28, 13);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(10, 21);
            this.cmbCuenta.TabIndex = 87;
            this.cmbCuenta.Visible = false;
            // 
            // txtTemporalCuenta
            // 
            this.txtTemporalCuenta.Location = new System.Drawing.Point(12, 13);
            this.txtTemporalCuenta.Name = "txtTemporalCuenta";
            this.txtTemporalCuenta.Size = new System.Drawing.Size(10, 20);
            this.txtTemporalCuenta.TabIndex = 86;
            this.txtTemporalCuenta.Tag = "ncodcuenta";
            this.txtTemporalCuenta.Visible = false;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(360, 14);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Valor";
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
            this.panel3.Location = new System.Drawing.Point(12, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 8;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnirUltimo.Image")));
            this.btnirUltimo.Location = new System.Drawing.Point(597, 4);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnirUltimo.TabIndex = 16;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            this.btnirUltimo.Click += new System.EventHandler(this.btnirUltimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnsiguiente.TabIndex = 15;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(489, 4);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(48, 42);
            this.btnanterior.TabIndex = 14;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnirPrimero.Image")));
            this.btnirPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnirPrimero.TabIndex = 13;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            this.btnirPrimero.Click += new System.EventHandler(this.btnirPrimero_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(381, 4);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(48, 42);
            this.btnbuscar.TabIndex = 12;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(327, 4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(48, 42);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.Location = new System.Drawing.Point(273, 4);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnrefrescar.TabIndex = 10;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(219, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(48, 42);
            this.btncancelar.TabIndex = 9;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(165, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(48, 42);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(111, 4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(48, 42);
            this.btneliminar.TabIndex = 7;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(57, 3);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(48, 42);
            this.btneditar.TabIndex = 6;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(3, 4);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(48, 42);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnPagoCobro
            // 
            this.btnPagoCobro.Image = ((System.Drawing.Image)(resources.GetObject("btnPagoCobro.Image")));
            this.btnPagoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagoCobro.Location = new System.Drawing.Point(310, 419);
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
            this.grdDocumentos.Location = new System.Drawing.Point(16, 219);
            this.grdDocumentos.Name = "grdDocumentos";
            this.grdDocumentos.Size = new System.Drawing.Size(649, 194);
            this.grdDocumentos.TabIndex = 10;
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(42, 433);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(10, 20);
            this.txtDoc.TabIndex = 11;
            this.txtDoc.Tag = "ncoddocumento";
            this.txtDoc.Visible = false;
            // 
            // txtFacDoc
            // 
            this.txtFacDoc.Location = new System.Drawing.Point(58, 434);
            this.txtFacDoc.Name = "txtFacDoc";
            this.txtFacDoc.Size = new System.Drawing.Size(10, 20);
            this.txtFacDoc.TabIndex = 12;
            this.txtFacDoc.Tag = "ncodfactura";
            this.txtFacDoc.Visible = false;
            // 
            // cmbcodDocu
            // 
            this.cmbcodDocu.FormattingEnabled = true;
            this.cmbcodDocu.Location = new System.Drawing.Point(74, 433);
            this.cmbcodDocu.Name = "cmbcodDocu";
            this.cmbcodDocu.Size = new System.Drawing.Size(13, 21);
            this.cmbcodDocu.TabIndex = 13;
            this.cmbcodDocu.Visible = false;
            // 
            // txtFechaCobro
            // 
            this.txtFechaCobro.Location = new System.Drawing.Point(105, 435);
            this.txtFechaCobro.Name = "txtFechaCobro";
            this.txtFechaCobro.Size = new System.Drawing.Size(100, 20);
            this.txtFechaCobro.TabIndex = 14;
            this.txtFechaCobro.Tag = "dfecha";
            this.txtFechaCobro.Visible = false;
            // 
            // frmPrincipalCxC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 462);
            this.Controls.Add(this.txtFechaCobro);
            this.Controls.Add(this.cmbcodDocu);
            this.Controls.Add(this.txtFacDoc);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.grdDocumentos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPagoCobro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipalCxC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipalCxC";
            this.Load += new System.EventHandler(this.frmPrincipalCxC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDocumentos)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDocto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Button btnPagoCobro;
        private System.Windows.Forms.DataGridView grdDocumentos;
        public System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtTransaccion;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTempCodFact;
        private System.Windows.Forms.TextBox txtTempNo;
        private System.Windows.Forms.TextBox txtTempCliente;
        private System.Windows.Forms.TextBox txtPagado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTempTotal;
        private System.Windows.Forms.TextBox txtExpira;
        private System.Windows.Forms.ComboBox cmbTrans;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.TextBox txtTemporalCuenta;
        private System.Windows.Forms.TextBox txtTotalCobro;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtFacDoc;
        private System.Windows.Forms.ComboBox cmbcodDocu;
        private System.Windows.Forms.TextBox txtFechaCobro;
    }
}