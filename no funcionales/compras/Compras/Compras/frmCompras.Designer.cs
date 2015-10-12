namespace Compras
{
    partial class frmCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.lNoDocumento = new System.Windows.Forms.Label();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.lFechaCompra = new System.Windows.Forms.Label();
            this.txtFechaCompra = new System.Windows.Forms.TextBox();
            this.lCondicionPago = new System.Windows.Forms.Label();
            this.cmbCondicionPago = new System.Windows.Forms.ComboBox();
            this.lProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lArticulo = new System.Windows.Forms.Label();
            this.cmbArticulo = new System.Windows.Forms.ComboBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lMoneda = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lDescuento = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.lTotalPagar = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lNoDocumento
            // 
            this.lNoDocumento.AutoSize = true;
            this.lNoDocumento.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNoDocumento.Location = new System.Drawing.Point(99, 7);
            this.lNoDocumento.Name = "lNoDocumento";
            this.lNoDocumento.Size = new System.Drawing.Size(131, 23);
            this.lNoDocumento.TabIndex = 0;
            this.lNoDocumento.Text = "No. Documento";
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Location = new System.Drawing.Point(109, 33);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtNoDocumento.TabIndex = 1;
            // 
            // lFechaCompra
            // 
            this.lFechaCompra.AutoSize = true;
            this.lFechaCompra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFechaCompra.Location = new System.Drawing.Point(261, 10);
            this.lFechaCompra.Name = "lFechaCompra";
            this.lFechaCompra.Size = new System.Drawing.Size(125, 19);
            this.lFechaCompra.TabIndex = 2;
            this.lFechaCompra.Text = "Fecha de Compra:";
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.Location = new System.Drawing.Point(400, 10);
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Size = new System.Drawing.Size(121, 20);
            this.txtFechaCompra.TabIndex = 3;
            // 
            // lCondicionPago
            // 
            this.lCondicionPago.AutoSize = true;
            this.lCondicionPago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCondicionPago.Location = new System.Drawing.Point(261, 50);
            this.lCondicionPago.Name = "lCondicionPago";
            this.lCondicionPago.Size = new System.Drawing.Size(133, 19);
            this.lCondicionPago.TabIndex = 4;
            this.lCondicionPago.Text = "Condición de Pago:";
            // 
            // cmbCondicionPago
            // 
            this.cmbCondicionPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionPago.FormattingEnabled = true;
            this.cmbCondicionPago.Location = new System.Drawing.Point(400, 50);
            this.cmbCondicionPago.Name = "cmbCondicionPago";
            this.cmbCondicionPago.Size = new System.Drawing.Size(121, 21);
            this.cmbCondicionPago.TabIndex = 5;
            // 
            // lProveedor
            // 
            this.lProveedor.AutoSize = true;
            this.lProveedor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProveedor.Location = new System.Drawing.Point(11, 123);
            this.lProveedor.Name = "lProveedor";
            this.lProveedor.Size = new System.Drawing.Size(78, 19);
            this.lProveedor.TabIndex = 6;
            this.lProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(107, 123);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(192, 21);
            this.cmbProveedor.TabIndex = 7;
            // 
            // lArticulo
            // 
            this.lArticulo.AutoSize = true;
            this.lArticulo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lArticulo.Location = new System.Drawing.Point(11, 163);
            this.lArticulo.Name = "lArticulo";
            this.lArticulo.Size = new System.Drawing.Size(63, 19);
            this.lArticulo.TabIndex = 8;
            this.lArticulo.Text = "Artículo:";
            // 
            // cmbArticulo
            // 
            this.cmbArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArticulo.FormattingEnabled = true;
            this.cmbArticulo.Location = new System.Drawing.Point(107, 163);
            this.cmbArticulo.Name = "cmbArticulo";
            this.cmbArticulo.Size = new System.Drawing.Size(192, 21);
            this.cmbArticulo.TabIndex = 9;
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(11, 203);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lDescripcion.TabIndex = 10;
            this.lDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 203);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(192, 20);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lMoneda
            // 
            this.lMoneda.AutoSize = true;
            this.lMoneda.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMoneda.Location = new System.Drawing.Point(400, 163);
            this.lMoneda.Name = "lMoneda";
            this.lMoneda.Size = new System.Drawing.Size(66, 19);
            this.lMoneda.TabIndex = 12;
            this.lMoneda.Text = "Moneda:";
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(473, 163);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(121, 21);
            this.cmbMoneda.TabIndex = 13;
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCantidad.Location = new System.Drawing.Point(400, 203);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(71, 19);
            this.lCantidad.TabIndex = 14;
            this.lCantidad.Text = "Cantidad:";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(620, 203);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(53, 19);
            this.lPrecio.TabIndex = 15;
            this.lPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(478, 203);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(116, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(680, 203);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 17;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 241);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(768, 226);
            this.dgvDetalle.TabIndex = 18;
            // 
            // lDescuento
            // 
            this.lDescuento.AutoSize = true;
            this.lDescuento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescuento.Location = new System.Drawing.Point(12, 483);
            this.lDescuento.Name = "lDescuento";
            this.lDescuento.Size = new System.Drawing.Size(131, 19);
            this.lDescuento.TabIndex = 19;
            this.lDescuento.Text = "Aplicar Descuento:";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(150, 481);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(25, 20);
            this.txtDescuento.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "%";
            // 
            // lSubtotal
            // 
            this.lSubtotal.AutoSize = true;
            this.lSubtotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.Location = new System.Drawing.Point(543, 483);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(66, 19);
            this.lSubtotal.TabIndex = 22;
            this.lSubtotal.Text = "Subtotal:";
            // 
            // lTotalPagar
            // 
            this.lTotalPagar.AutoSize = true;
            this.lTotalPagar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalPagar.Location = new System.Drawing.Point(543, 563);
            this.lTotalPagar.Name = "lTotalPagar";
            this.lTotalPagar.Size = new System.Drawing.Size(98, 19);
            this.lTotalPagar.TabIndex = 23;
            this.lTotalPagar.Text = "Total a Pagar:";
            // 
            // lDesc
            // 
            this.lDesc.AutoSize = true;
            this.lDesc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDesc.Location = new System.Drawing.Point(543, 523);
            this.lDesc.Name = "lDesc";
            this.lDesc.Size = new System.Drawing.Size(82, 19);
            this.lDesc.TabIndex = 24;
            this.lDesc.Text = "Descuento:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(647, 483);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(647, 523);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(647, 563);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(133, 20);
            this.textBox3.TabIndex = 27;
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 596);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTotalPagar);
            this.Controls.Add(this.lSubtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lDescuento);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.lCantidad);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.lMoneda);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.cmbArticulo);
            this.Controls.Add(this.lArticulo);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lProveedor);
            this.Controls.Add(this.cmbCondicionPago);
            this.Controls.Add(this.lCondicionPago);
            this.Controls.Add(this.txtFechaCompra);
            this.Controls.Add(this.lFechaCompra);
            this.Controls.Add(this.txtNoDocumento);
            this.Controls.Add(this.lNoDocumento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNoDocumento;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.Label lFechaCompra;
        private System.Windows.Forms.TextBox txtFechaCompra;
        private System.Windows.Forms.Label lCondicionPago;
        private System.Windows.Forms.ComboBox cmbCondicionPago;
        private System.Windows.Forms.Label lProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lArticulo;
        private System.Windows.Forms.ComboBox cmbArticulo;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lMoneda;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lDescuento;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.Label lTotalPagar;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

