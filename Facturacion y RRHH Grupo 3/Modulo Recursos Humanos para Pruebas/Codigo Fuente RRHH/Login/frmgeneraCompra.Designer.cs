namespace Login
{
    partial class frmgeneraCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgeneraCompra));
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstatusOrden = new System.Windows.Forms.TextBox();
            this.lblorden = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidadProducto = new System.Windows.Forms.Label();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.lblOrdenesCompra = new System.Windows.Forms.Label();
            this.cmbidProveedor = new System.Windows.Forms.ComboBox();
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
            this.cmbStatusNuevo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecibestatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(217, 286);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 49);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Codigo Articulo:";
            // 
            // txtEstatusOrden
            // 
            this.txtEstatusOrden.Enabled = false;
            this.txtEstatusOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstatusOrden.Location = new System.Drawing.Point(520, 208);
            this.txtEstatusOrden.Name = "txtEstatusOrden";
            this.txtEstatusOrden.Size = new System.Drawing.Size(146, 22);
            this.txtEstatusOrden.TabIndex = 45;
            // 
            // lblorden
            // 
            this.lblorden.AutoSize = true;
            this.lblorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblorden.Location = new System.Drawing.Point(407, 241);
            this.lblorden.Name = "lblorden";
            this.lblorden.Size = new System.Drawing.Size(109, 16);
            this.lblorden.TabIndex = 44;
            this.lblorden.Text = "Estatus Orden:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(417, 289);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(95, 16);
            this.lblDescripcion.TabIndex = 43;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblCantidadProducto
            // 
            this.lblCantidadProducto.AutoSize = true;
            this.lblCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProducto.Location = new System.Drawing.Point(11, 245);
            this.lblCantidadProducto.Name = "lblCantidadProducto";
            this.lblCantidadProducto.Size = new System.Drawing.Size(214, 16);
            this.lblCantidadProducto.TabIndex = 42;
            this.lblCantidadProducto.Text = "Cantidad Producto Solicitado:";
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.Enabled = false;
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArticulo.Location = new System.Drawing.Point(227, 201);
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(148, 22);
            this.txtCodigoArticulo.TabIndex = 41;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(518, 286);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(148, 89);
            this.txtDescripcion.TabIndex = 40;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Enabled = false;
            this.txtCantidadProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadProducto.Location = new System.Drawing.Point(227, 239);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(148, 22);
            this.txtCantidadProducto.TabIndex = 39;
            // 
            // lblOrdenesCompra
            // 
            this.lblOrdenesCompra.AutoSize = true;
            this.lblOrdenesCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdenesCompra.Location = new System.Drawing.Point(258, 118);
            this.lblOrdenesCompra.Name = "lblOrdenesCompra";
            this.lblOrdenesCompra.Size = new System.Drawing.Size(221, 16);
            this.lblOrdenesCompra.TabIndex = 38;
            this.lblOrdenesCompra.Text = "Ordenes de Compra Pendiente";
            // 
            // cmbidProveedor
            // 
            this.cmbidProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidProveedor.FormattingEnabled = true;
            this.cmbidProveedor.Location = new System.Drawing.Point(272, 146);
            this.cmbidProveedor.Name = "cmbidProveedor";
            this.cmbidProveedor.Size = new System.Drawing.Size(188, 24);
            this.cmbidProveedor.TabIndex = 37;
            this.cmbidProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbidProveedor_SelectedIndexChanged);
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(610, 22);
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
            this.btnsiguiente.Location = new System.Drawing.Point(558, 22);
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
            this.btnanterior.Location = new System.Drawing.Point(506, 22);
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
            this.btnirPrimero.Location = new System.Drawing.Point(454, 22);
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
            this.btnbuscar.Location = new System.Drawing.Point(402, 22);
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
            this.btnimprimir.Location = new System.Drawing.Point(350, 22);
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
            this.btnrefrescar.Location = new System.Drawing.Point(298, 22);
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
            this.btncancelar.Location = new System.Drawing.Point(246, 22);
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
            this.btnguardar.Location = new System.Drawing.Point(194, 22);
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
            this.btneliminar.Location = new System.Drawing.Point(142, 22);
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
            this.btneditar.Location = new System.Drawing.Point(90, 22);
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
            this.btnnuevo.Location = new System.Drawing.Point(38, 22);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 64;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // cmbStatusNuevo
            // 
            this.cmbStatusNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusNuevo.FormattingEnabled = true;
            this.cmbStatusNuevo.Items.AddRange(new object[] {
            "inicial",
            "parcial",
            "terminada"});
            this.cmbStatusNuevo.Location = new System.Drawing.Point(520, 242);
            this.cmbStatusNuevo.Name = "cmbStatusNuevo";
            this.cmbStatusNuevo.Size = new System.Drawing.Size(145, 21);
            this.cmbStatusNuevo.TabIndex = 76;
            this.cmbStatusNuevo.SelectedIndexChanged += new System.EventHandler(this.cmbstatus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Estatus Orden:";
            // 
            // txtrecibestatus
            // 
            this.txtrecibestatus.Enabled = false;
            this.txtrecibestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecibestatus.Location = new System.Drawing.Point(517, 146);
            this.txtrecibestatus.Name = "txtrecibestatus";
            this.txtrecibestatus.Size = new System.Drawing.Size(148, 22);
            this.txtrecibestatus.TabIndex = 78;
            this.txtrecibestatus.Tag = "vstatusorden";
            this.txtrecibestatus.Visible = false;
            // 
            // frmgeneraCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 440);
            this.Controls.Add(this.txtrecibestatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatusNuevo);
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
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEstatusOrden);
            this.Controls.Add(this.lblorden);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCantidadProducto);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.lblOrdenesCompra);
            this.Controls.Add(this.cmbidProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmgeneraCompra";
            this.Text = "frmgeneraCompra";
            this.Load += new System.EventHandler(this.frmgeneraCompra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblorden;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidadProducto;
        private System.Windows.Forms.Label lblOrdenesCompra;
        private System.Windows.Forms.ComboBox cmbidProveedor;
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
        public System.Windows.Forms.TextBox txtEstatusOrden;
        public System.Windows.Forms.TextBox txtCodigoArticulo;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.ComboBox cmbStatusNuevo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtrecibestatus;
    }
}