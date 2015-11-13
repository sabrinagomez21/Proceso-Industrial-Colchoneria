namespace Login
{
    partial class frmEstadoCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstadoCuenta));
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
            this.gbEmpleador = new System.Windows.Forms.GroupBox();
            this.txtCuentaDebitar = new System.Windows.Forms.TextBox();
            this.lblCuentaEmpleador = new System.Windows.Forms.Label();
            this.grdEstados = new System.Windows.Forms.DataGridView();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.rbMensual = new System.Windows.Forms.RadioButton();
            this.rbHistorico = new System.Windows.Forms.RadioButton();
            this.panel3.SuspendLayout();
            this.gbEmpleador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstados)).BeginInit();
            this.grbPago.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(34, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 18;
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
            this.btnbuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(327, 4);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(48, 42);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(165, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(48, 42);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.UseVisualStyleBackColor = true;
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
            // 
            // gbEmpleador
            // 
            this.gbEmpleador.Controls.Add(this.txtCuentaDebitar);
            this.gbEmpleador.Controls.Add(this.lblCuentaEmpleador);
            this.gbEmpleador.Location = new System.Drawing.Point(439, 108);
            this.gbEmpleador.Name = "gbEmpleador";
            this.gbEmpleador.Size = new System.Drawing.Size(241, 58);
            this.gbEmpleador.TabIndex = 17;
            this.gbEmpleador.TabStop = false;
            this.gbEmpleador.Text = "Buscar Cuenta";
            // 
            // txtCuentaDebitar
            // 
            this.txtCuentaDebitar.Location = new System.Drawing.Point(88, 25);
            this.txtCuentaDebitar.Name = "txtCuentaDebitar";
            this.txtCuentaDebitar.Size = new System.Drawing.Size(134, 20);
            this.txtCuentaDebitar.TabIndex = 1;
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
            // grdEstados
            // 
            this.grdEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEstados.Location = new System.Drawing.Point(34, 172);
            this.grdEstados.Name = "grdEstados";
            this.grdEstados.Size = new System.Drawing.Size(646, 203);
            this.grdEstados.TabIndex = 19;
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.dtpFecha);
            this.grbPago.Controls.Add(this.rbMensual);
            this.grbPago.Controls.Add(this.rbHistorico);
            this.grbPago.Location = new System.Drawing.Point(34, 108);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(371, 58);
            this.grbPago.TabIndex = 20;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Tipo Estado Cuenta";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(165, 26);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 3;
            // 
            // rbMensual
            // 
            this.rbMensual.AutoSize = true;
            this.rbMensual.Location = new System.Drawing.Point(94, 26);
            this.rbMensual.Name = "rbMensual";
            this.rbMensual.Size = new System.Drawing.Size(65, 17);
            this.rbMensual.TabIndex = 2;
            this.rbMensual.TabStop = true;
            this.rbMensual.Text = "Mensual";
            this.rbMensual.UseVisualStyleBackColor = true;
            // 
            // rbHistorico
            // 
            this.rbHistorico.AutoSize = true;
            this.rbHistorico.Location = new System.Drawing.Point(18, 26);
            this.rbHistorico.Name = "rbHistorico";
            this.rbHistorico.Size = new System.Drawing.Size(66, 17);
            this.rbHistorico.TabIndex = 1;
            this.rbHistorico.TabStop = true;
            this.rbHistorico.Text = "Historico";
            this.rbHistorico.UseVisualStyleBackColor = true;
            // 
            // frmEstadoCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 402);
            this.Controls.Add(this.grbPago);
            this.Controls.Add(this.grdEstados);
            this.Controls.Add(this.gbEmpleador);
            this.Controls.Add(this.panel3);
            this.Name = "frmEstadoCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado De Cuenta";
            this.Load += new System.EventHandler(this.frmEstadoCuenta_Load);
            this.panel3.ResumeLayout(false);
            this.gbEmpleador.ResumeLayout(false);
            this.gbEmpleador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEstados)).EndInit();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbEmpleador;
        private System.Windows.Forms.TextBox txtCuentaDebitar;
        private System.Windows.Forms.Label lblCuentaEmpleador;
        private System.Windows.Forms.DataGridView grdEstados;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.RadioButton rbMensual;
        private System.Windows.Forms.RadioButton rbHistorico;
    }
}