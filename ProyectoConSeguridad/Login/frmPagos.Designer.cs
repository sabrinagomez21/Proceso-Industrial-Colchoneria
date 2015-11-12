namespace Login
{
    partial class frmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagos));
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.gpbEmpleados = new System.Windows.Forms.GroupBox();
            this.txtCuentaEmpleado = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.lblTotalPago = new System.Windows.Forms.Label();
            this.gbEmpleador = new System.Windows.Forms.GroupBox();
            this.txtCuentaDebitar = new System.Windows.Forms.TextBox();
            this.lblCuentaEmpleador = new System.Windows.Forms.Label();
            this.grdEmpleador = new System.Windows.Forms.DataGridView();
            this.gpEmpleador = new System.Windows.Forms.GroupBox();
            this.gbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.rbCheque = new System.Windows.Forms.RadioButton();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTipoTransaccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.gpbEmpleados.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEmpleador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleador)).BeginInit();
            this.gpEmpleador.SuspendLayout();
            this.gbDatosEmpleado.SuspendLayout();
            this.grbPago.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.AllowUserToDeleteRows = false;
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Location = new System.Drawing.Point(6, 19);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.ReadOnly = true;
            this.grdEmpleado.Size = new System.Drawing.Size(376, 154);
            this.grdEmpleado.TabIndex = 10;
            // 
            // gpbEmpleados
            // 
            this.gpbEmpleados.Controls.Add(this.txtCuentaEmpleado);
            this.gpbEmpleados.Controls.Add(this.lblCuenta);
            this.gpbEmpleados.Location = new System.Drawing.Point(166, 141);
            this.gpbEmpleados.Name = "gpbEmpleados";
            this.gpbEmpleados.Size = new System.Drawing.Size(510, 58);
            this.gpbEmpleados.TabIndex = 11;
            this.gpbEmpleados.TabStop = false;
            this.gpbEmpleados.Text = "Datos Empleado";
            // 
            // txtCuentaEmpleado
            // 
            this.txtCuentaEmpleado.Location = new System.Drawing.Point(88, 25);
            this.txtCuentaEmpleado.Name = "txtCuentaEmpleado";
            this.txtCuentaEmpleado.Size = new System.Drawing.Size(134, 20);
            this.txtCuentaEmpleado.TabIndex = 1;
            this.txtCuentaEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaEmpleado_KeyPress);
            this.txtCuentaEmpleado.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCuentaEmpleado_KeyUp);
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(6, 25);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(61, 13);
            this.lblCuenta.TabIndex = 0;
            this.lblCuenta.Text = "No. Cuenta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotalPago);
            this.groupBox1.Controls.Add(this.lblTotalPago);
            this.groupBox1.Location = new System.Drawing.Point(166, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 58);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Realizacion de Pago";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Pago";
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Location = new System.Drawing.Point(259, 25);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(134, 20);
            this.txtTotalPago.TabIndex = 3;
            this.txtTotalPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalPago_KeyPress);
            // 
            // lblTotalPago
            // 
            this.lblTotalPago.AutoSize = true;
            this.lblTotalPago.Location = new System.Drawing.Point(6, 32);
            this.lblTotalPago.Name = "lblTotalPago";
            this.lblTotalPago.Size = new System.Drawing.Size(59, 13);
            this.lblTotalPago.TabIndex = 2;
            this.lblTotalPago.Text = "Total Pago";
            // 
            // gbEmpleador
            // 
            this.gbEmpleador.Controls.Add(this.txtCuentaDebitar);
            this.gbEmpleador.Controls.Add(this.lblCuentaEmpleador);
            this.gbEmpleador.Location = new System.Drawing.Point(166, 77);
            this.gbEmpleador.Name = "gbEmpleador";
            this.gbEmpleador.Size = new System.Drawing.Size(241, 58);
            this.gbEmpleador.TabIndex = 13;
            this.gbEmpleador.TabStop = false;
            this.gbEmpleador.Text = "Datos Empleador";
            // 
            // txtCuentaDebitar
            // 
            this.txtCuentaDebitar.Location = new System.Drawing.Point(88, 25);
            this.txtCuentaDebitar.Name = "txtCuentaDebitar";
            this.txtCuentaDebitar.Size = new System.Drawing.Size(134, 20);
            this.txtCuentaDebitar.TabIndex = 1;
            this.txtCuentaDebitar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuentaDebitar_KeyPress);
            this.txtCuentaDebitar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCuentaDebitar_KeyUp);
            // 
            // lblCuentaEmpleador
            // 
            this.lblCuentaEmpleador.AutoSize = true;
            this.lblCuentaEmpleador.Location = new System.Drawing.Point(6, 25);
            this.lblCuentaEmpleador.Name = "lblCuentaEmpleador";
            this.lblCuentaEmpleador.Size = new System.Drawing.Size(61, 13);
            this.lblCuentaEmpleador.TabIndex = 0;
            this.lblCuentaEmpleador.Text = "No. Cuenta";
            // 
            // grdEmpleador
            // 
            this.grdEmpleador.AllowUserToDeleteRows = false;
            this.grdEmpleador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleador.Location = new System.Drawing.Point(12, 19);
            this.grdEmpleador.Name = "grdEmpleador";
            this.grdEmpleador.ReadOnly = true;
            this.grdEmpleador.Size = new System.Drawing.Size(383, 154);
            this.grdEmpleador.TabIndex = 14;
            // 
            // gpEmpleador
            // 
            this.gpEmpleador.Controls.Add(this.grdEmpleador);
            this.gpEmpleador.Location = new System.Drawing.Point(12, 269);
            this.gpEmpleador.Name = "gpEmpleador";
            this.gpEmpleador.Size = new System.Drawing.Size(401, 187);
            this.gpEmpleador.TabIndex = 15;
            this.gpEmpleador.TabStop = false;
            this.gpEmpleador.Text = "Datos Empleador";
            // 
            // gbDatosEmpleado
            // 
            this.gbDatosEmpleado.Controls.Add(this.grdEmpleado);
            this.gbDatosEmpleado.Location = new System.Drawing.Point(413, 269);
            this.gbDatosEmpleado.Name = "gbDatosEmpleado";
            this.gbDatosEmpleado.Size = new System.Drawing.Size(388, 187);
            this.gbDatosEmpleado.TabIndex = 16;
            this.gbDatosEmpleado.TabStop = false;
            this.gbDatosEmpleado.Text = "Datos Empleado";
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.rbCheque);
            this.grbPago.Location = new System.Drawing.Point(413, 77);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(103, 58);
            this.grbPago.TabIndex = 14;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Tipo de Pago";
            // 
            // rbCheque
            // 
            this.rbCheque.AutoSize = true;
            this.rbCheque.Location = new System.Drawing.Point(6, 23);
            this.rbCheque.Name = "rbCheque";
            this.rbCheque.Size = new System.Drawing.Size(62, 17);
            this.rbCheque.TabIndex = 3;
            this.rbCheque.TabStop = true;
            this.rbCheque.Text = "Cheque";
            this.rbCheque.UseVisualStyleBackColor = true;
            this.rbCheque.Click += new System.EventHandler(this.rbCheque_Click);
            this.rbCheque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rbCheque_KeyPress);
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
            this.panel3.Location = new System.Drawing.Point(75, 12);
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
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnsiguiente.TabIndex = 15;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(489, 4);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(48, 42);
            this.btnanterior.TabIndex = 14;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnirPrimero.Image")));
            this.btnirPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnirPrimero.TabIndex = 13;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
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
            this.btncancelar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnCancelar_KeyPress);
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
            this.btnguardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnGuardar_KeyPress);
            // 
            // btneliminar
            // 
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
            this.btnnuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNuevo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipoTransaccion);
            this.groupBox2.Location = new System.Drawing.Point(522, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 58);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo Tansaccion";
            // 
            // cmbTipoTransaccion
            // 
            this.cmbTipoTransaccion.FormattingEnabled = true;
            this.cmbTipoTransaccion.Location = new System.Drawing.Point(7, 23);
            this.cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            this.cmbTipoTransaccion.Size = new System.Drawing.Size(137, 21);
            this.cmbTipoTransaccion.TabIndex = 0;
            this.cmbTipoTransaccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTipoTransaccion_KeyPress);
            // 
            // frmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.gbDatosEmpleado);
            this.Controls.Add(this.gpEmpleador);
            this.Controls.Add(this.gbEmpleador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbEmpleados);
            this.Name = "frmPagos";
            this.Text = "Pago Empleado";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmPagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.gpbEmpleados.ResumeLayout(false);
            this.gpbEmpleados.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmpleador.ResumeLayout(false);
            this.gbEmpleador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleador)).EndInit();
            this.gpEmpleador.ResumeLayout(false);
            this.gbDatosEmpleado.ResumeLayout(false);
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.GroupBox gpbEmpleados;
        private System.Windows.Forms.TextBox txtCuentaEmpleado;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPago;
        private System.Windows.Forms.TextBox txtTotalPago;
        private System.Windows.Forms.GroupBox gbEmpleador;
        private System.Windows.Forms.TextBox txtCuentaDebitar;
        private System.Windows.Forms.Label lblCuentaEmpleador;
        private System.Windows.Forms.DataGridView grdEmpleador;
        private System.Windows.Forms.GroupBox gpEmpleador;
        private System.Windows.Forms.GroupBox gbDatosEmpleado;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.RadioButton rbCheque;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbTipoTransaccion;
        private System.Windows.Forms.Label label1;
    }
}