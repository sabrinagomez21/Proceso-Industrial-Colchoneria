namespace Login
{
    partial class frmordecompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 53;
            this.label2.Text = "Estatus Compra:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Location = new System.Drawing.Point(337, 159);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(240, 22);
            this.dtpFecha.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 240);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 24);
            this.comboBox1.TabIndex = 51;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(421, 277);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 22);
            this.txtPrecio.TabIndex = 50;
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(361, 277);
            this.lPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(57, 16);
            this.lPrecio.TabIndex = 49;
            this.lPrecio.Text = "Precio:";
            // 
            // dgvDetalle
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalle.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDetalle.Location = new System.Drawing.Point(42, 342);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(768, 226);
            this.dgvDetalle.TabIndex = 48;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(642, 278);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 22);
            this.txtCantidad.TabIndex = 47;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.Location = new System.Drawing.Point(564, 278);
            this.lCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(74, 16);
            this.lCantidad.TabIndex = 46;
            this.lCantidad.Text = "Cantidad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(137, 279);
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
            this.lDescripcion.Location = new System.Drawing.Point(41, 279);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(95, 16);
            this.lDescripcion.TabIndex = 44;
            this.lDescripcion.Text = "Descripción:";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(137, 239);
            this.cmbArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(192, 24);
            this.cmbArticulo.TabIndex = 43;
            // 
            // lArticulo
            // 
            this.lArticulo.AutoSize = true;
            this.lArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArticulo.Location = new System.Drawing.Point(61, 243);
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
            this.cmbProveedor.Location = new System.Drawing.Point(137, 199);
            this.cmbProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(192, 24);
            this.cmbProveedor.TabIndex = 41;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProveedor.Location = new System.Drawing.Point(41, 202);
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
            this.cmbCondicionPago.Location = new System.Drawing.Point(499, 202);
            this.cmbCondicionPago.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(166, 24);
            this.cmbCondicionPago.TabIndex = 39;
            // 
            // lCondicionPago
            // 
            this.lCondicionPago.AutoSize = true;
            this.lCondicionPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCondicionPago.Location = new System.Drawing.Point(351, 207);
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
            this.lFechaCompra.Location = new System.Drawing.Point(199, 164);
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
            this.txtNoDocumento.Location = new System.Drawing.Point(671, 136);
            this.txtNoDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(121, 22);
            this.txtNoDocumento.TabIndex = 36;
            // 
            // lNoDocumento
            // 
            this.lNoDocumento.AutoSize = true;
            this.lNoDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoDocumento.Location = new System.Drawing.Point(675, 108);
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
            // frmordecompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 587);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.cmbArticulo);
            this.Controls.Add(this.lArticulo);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lProveedor);
            this.Controls.Add(this.cmbCondicionPago);
            this.Controls.Add(this.lCondicionPago);
            this.Controls.Add(this.lFechaCompra);
            this.Controls.Add(this.txtNoDocumento);
            this.Controls.Add(this.lNoDocumento);
            this.Name = "frmordecompra";
            this.Text = "frmordecompra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.ComboBox cmbArticulo;
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
    }
}