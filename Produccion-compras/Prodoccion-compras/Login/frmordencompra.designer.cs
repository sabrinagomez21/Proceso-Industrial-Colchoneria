namespace Login
{
    partial class frmordencompra
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
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbstatusnuevo = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lArticulo = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lProveedor = new System.Windows.Forms.Label();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.lCondicionPago = new System.Windows.Forms.Label();
            this.lFechaCompra = new System.Windows.Forms.Label();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.lNoDocumento = new System.Windows.Forms.Label();
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtSaldoPendiente = new System.Windows.Forms.TextBox();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtSaldoPagar = new System.Windows.Forms.TextBox();
            this.lTotalPagar = new System.Windows.Forms.Label();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.txtstatusactual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.txtcondicionpago = new System.Windows.Forms.TextBox();
            this.txtstatusnuevo = new System.Windows.Forms.TextBox();
            this.txtfecha = new System.Windows.Forms.TextBox();
            this.cmbordenes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtorden = new System.Windows.Forms.TextBox();
            this.txttotalpagar1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 308);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Estatus Actual:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(143, 99);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 22);
            this.dtpFecha.TabIndex = 52;
            // 
            // cmbstatusnuevo
            // 
            this.cmbstatusnuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbstatusnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatusnuevo.FormattingEnabled = true;
            this.cmbstatusnuevo.Items.AddRange(new object[] {
            "inicial",
            "parcial",
            "terminada"});
            this.cmbstatusnuevo.Location = new System.Drawing.Point(505, 368);
            this.cmbstatusnuevo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbstatusnuevo.Name = "cmbstatusnuevo";
            this.cmbstatusnuevo.Size = new System.Drawing.Size(166, 24);
            this.cmbstatusnuevo.TabIndex = 51;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(447, 420);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 50;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(387, 420);
            this.lPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(57, 16);
            this.lPrecio.TabIndex = 49;
            this.lPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(668, 421);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 22);
            this.txtCantidad.TabIndex = 47;
            this.txtCantidad.Tag = "ncantidadProducto";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.Location = new System.Drawing.Point(590, 421);
            this.lCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(74, 16);
            this.lCantidad.TabIndex = 46;
            this.lCantidad.Text = "Cantidad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(143, 376);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(192, 49);
            this.txtDescripcion.TabIndex = 45;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(47, 376);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(95, 16);
            this.lDescripcion.TabIndex = 44;
            this.lDescripcion.Text = "Descripción:";
            // 
            // lArticulo
            // 
            this.lArticulo.AutoSize = true;
            this.lArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArticulo.Location = new System.Drawing.Point(67, 308);
            this.lArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lArticulo.Name = "lArticulo";
            this.lArticulo.Size = new System.Drawing.Size(64, 16);
            this.lArticulo.TabIndex = 42;
            this.lArticulo.Text = "Artículo:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(143, 246);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(192, 24);
            this.cmbProveedor.TabIndex = 41;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProveedor.Location = new System.Drawing.Point(47, 249);
            this.lProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(85, 16);
            this.lProveedor.TabIndex = 40;
            this.lProveedor.Text = "Proveedor:";
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCondicionPago.FormattingEnabled = true;
            this.cmbCondicionPago.Items.AddRange(new object[] {
            "Crédito",
            "Contado"});
            this.cmbCondicionPago.Location = new System.Drawing.Point(505, 249);
            this.cmbCondicionPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(166, 24);
            this.cmbCondicionPago.TabIndex = 39;
            // 
            // lCondicionPago
            // 
            this.lCondicionPago.AutoSize = true;
            this.lCondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCondicionPago.Location = new System.Drawing.Point(357, 254);
            this.lCondicionPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCondicionPago.Name = "lCondicionPago";
            this.lCondicionPago.Size = new System.Drawing.Size(144, 16);
            this.lCondicionPago.TabIndex = 38;
            this.lCondicionPago.Text = "Condición de Pago:";
            // 
            // lFechaCompra
            // 
            this.lFechaCompra.AutoSize = true;
            this.lFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaCompra.Location = new System.Drawing.Point(5, 104);
            this.lFechaCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lFechaCompra.Name = "lFechaCompra";
            this.lFechaCompra.Size = new System.Drawing.Size(135, 16);
            this.lFechaCompra.TabIndex = 37;
            this.lFechaCompra.Text = "Fecha de Compra:";
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Enabled = false;
            this.txtNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoDocumento.Location = new System.Drawing.Point(668, 117);
            this.txtNoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(121, 22);
            this.txtNoDocumento.TabIndex = 36;
            this.txtNoDocumento.Tag = "ncodorden";
            this.txtNoDocumento.TextChanged += new System.EventHandler(this.txtNoDocumento_TextChanged);
            // 
            // lNoDocumento
            // 
            this.lNoDocumento.AutoSize = true;
            this.lNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoDocumento.Location = new System.Drawing.Point(665, 99);
            this.lNoDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lNoDocumento.Name = "lNoDocumento";
            this.lNoDocumento.Size = new System.Drawing.Size(114, 16);
            this.lNoDocumento.TabIndex = 35;
            this.lNoDocumento.Text = "No. Documento";
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(668, 25);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(46, 43);
            this.btnirUltimo.TabIndex = 75;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.Location = new System.Drawing.Point(616, 25);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(46, 43);
            this.btnsiguiente.TabIndex = 74;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(564, 25);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 43);
            this.btnanterior.TabIndex = 73;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Enabled = false;
            this.btnirPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(512, 25);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(46, 43);
            this.btnirPrimero.TabIndex = 72;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(460, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(46, 43);
            this.btnbuscar.TabIndex = 71;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(408, 25);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 43);
            this.btnimprimir.TabIndex = 70;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Enabled = false;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(356, 25);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(46, 43);
            this.btnrefrescar.TabIndex = 69;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::Login.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(304, 25);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 43);
            this.btncancelar.TabIndex = 68;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::Login.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(252, 25);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 43);
            this.btnguardar.TabIndex = 67;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(200, 25);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 43);
            this.btneliminar.TabIndex = 66;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btneditar
            // 
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(148, 25);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(46, 43);
            this.btneditar.TabIndex = 65;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(96, 25);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 64;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Login.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(70, 493);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 49);
            this.btnSalir.TabIndex = 82;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtSaldoPendiente
            // 
            this.txtSaldoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoPendiente.Location = new System.Drawing.Point(647, 580);
            this.txtSaldoPendiente.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoPendiente.Name = "txtSaldoPendiente";
            this.txtSaldoPendiente.Size = new System.Drawing.Size(132, 22);
            this.txtSaldoPendiente.TabIndex = 81;
            this.txtSaldoPendiente.Tag = "nsaldoapagar";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaldo.Location = new System.Drawing.Point(516, 586);
            this.lblsaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(127, 16);
            this.lblsaldo.TabIndex = 80;
            this.lblsaldo.Text = "Saldo Pendiente:";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.Location = new System.Drawing.Point(646, 538);
            this.txtTotalPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(132, 22);
            this.txtTotalPagar.TabIndex = 79;
            this.txtTotalPagar.Tag = "ntotalapagar";
            this.txtTotalPagar.TextChanged += new System.EventHandler(this.txtSaldoPagar_TextChanged);
            // 
            // txtSaldoPagar
            // 
            this.txtSaldoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldoPagar.Location = new System.Drawing.Point(646, 492);
            this.txtSaldoPagar.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoPagar.Name = "txtSaldoPagar";
            this.txtSaldoPagar.Size = new System.Drawing.Size(132, 22);
            this.txtSaldoPagar.TabIndex = 78;
            this.txtSaldoPagar.Tag = "ntotalpagado";
            this.txtSaldoPagar.TextChanged += new System.EventHandler(this.txtSaldoPagar_TextChanged);
            // 
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPagar.Location = new System.Drawing.Point(535, 540);
            this.lTotalPagar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(107, 16);
            this.lTotalPagar.TabIndex = 77;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // lSubtotal
            // 
            this.lSubtotal.AutoSize = true;
            this.lSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.Location = new System.Drawing.Point(510, 495);
            this.lSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(133, 16);
            this.lSubtotal.TabIndex = 76;
            this.lSubtotal.Text = "Cantidad a Pagar:";
            // 
            // txtarticulo
            // 
            this.txtarticulo.Enabled = false;
            this.txtarticulo.Location = new System.Drawing.Point(143, 309);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(192, 20);
            this.txtarticulo.TabIndex = 84;
            this.txtarticulo.Tag = "ncodarticulo";
            // 
            // txtstatusactual
            // 
            this.txtstatusactual.Enabled = false;
            this.txtstatusactual.Location = new System.Drawing.Point(505, 304);
            this.txtstatusactual.Name = "txtstatusactual";
            this.txtstatusactual.Size = new System.Drawing.Size(166, 20);
            this.txtstatusactual.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 372);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 86;
            this.label1.Text = "Estatus Nuevo:";
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(38, 226);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(100, 20);
            this.txtproveedor.TabIndex = 87;
            this.txtproveedor.Tag = "ncodproveedor";
            this.txtproveedor.Visible = false;
            // 
            // txtcondicionpago
            // 
            this.txtcondicionpago.Location = new System.Drawing.Point(687, 250);
            this.txtcondicionpago.Name = "txtcondicionpago";
            this.txtcondicionpago.Size = new System.Drawing.Size(100, 20);
            this.txtcondicionpago.TabIndex = 88;
            this.txtcondicionpago.Tag = "vtipopago";
            this.txtcondicionpago.Visible = false;
            // 
            // txtstatusnuevo
            // 
            this.txtstatusnuevo.Location = new System.Drawing.Point(688, 347);
            this.txtstatusnuevo.Name = "txtstatusnuevo";
            this.txtstatusnuevo.Size = new System.Drawing.Size(100, 20);
            this.txtstatusnuevo.TabIndex = 89;
            this.txtstatusnuevo.Visible = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Location = new System.Drawing.Point(20, 81);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(100, 20);
            this.txtfecha.TabIndex = 90;
            this.txtfecha.Visible = false;
            // 
            // cmbordenes
            // 
            this.cmbordenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbordenes.FormattingEnabled = true;
            this.cmbordenes.Location = new System.Drawing.Point(356, 166);
            this.cmbordenes.Name = "cmbordenes";
            this.cmbordenes.Size = new System.Drawing.Size(156, 21);
            this.cmbordenes.TabIndex = 91;
            this.cmbordenes.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(365, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 16);
            this.label3.TabIndex = 92;
            this.label3.Text = "Ordenes a Comprar:";
            // 
            // txtorden
            // 
            this.txtorden.Location = new System.Drawing.Point(519, 166);
            this.txtorden.Name = "txtorden";
            this.txtorden.Size = new System.Drawing.Size(100, 20);
            this.txtorden.TabIndex = 93;
            this.txtorden.Tag = "ncodorden";
            this.txtorden.Visible = false;
            // 
            // txttotalpagar1
            // 
            this.txttotalpagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalpagar1.Location = new System.Drawing.Point(384, 538);
            this.txttotalpagar1.Margin = new System.Windows.Forms.Padding(2);
            this.txttotalpagar1.Name = "txttotalpagar1";
            this.txttotalpagar1.Size = new System.Drawing.Size(132, 22);
            this.txttotalpagar1.TabIndex = 98;
            this.txttotalpagar1.Tag = "ncostototal";
            this.txttotalpagar1.Visible = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Login.Properties.Resources.nuevo;
            this.button1.Location = new System.Drawing.Point(722, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 43);
            this.button1.TabIndex = 99;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmordecompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttotalpagar1);
            this.Controls.Add(this.txtorden);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbordenes);
            this.Controls.Add(this.txtfecha);
            this.Controls.Add(this.txtstatusnuevo);
            this.Controls.Add(this.txtcondicionpago);
            this.Controls.Add(this.txtproveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstatusactual);
            this.Controls.Add(this.txtarticulo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtSaldoPendiente);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.txtSaldoPagar);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.lSubtotal);
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.cmbstatusnuevo);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.lArticulo);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lProveedor);
            this.Controls.Add(this.cmbCondicionPago);
            this.Controls.Add(this.lCondicionPago);
            this.Controls.Add(this.lFechaCompra);
            this.Controls.Add(this.txtNoDocumento);
            this.Controls.Add(this.lNoDocumento);
            this.Name = "frmordecompra";
            this.Text = "Orden a Comprar";
            this.Load += new System.EventHandler(this.frmordecompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbstatusnuevo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lArticulo;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label lCondicionPago;
        private System.Windows.Forms.Label lFechaCompra;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.Label lNoDocumento;
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
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSaldoPendiente;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtSaldoPagar;
        private System.Windows.Forms.Label lTotalPagar;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.TextBox txtstatusactual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtcondicionpago;
        private System.Windows.Forms.TextBox txtstatusnuevo;
        private System.Windows.Forms.TextBox txtfecha;
        private System.Windows.Forms.ComboBox cmbordenes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtorden;
        private System.Windows.Forms.TextBox txttotalpagar1;
        private System.Windows.Forms.Button button1;
    }
}