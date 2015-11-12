namespace Bancos
{
    partial class frmConciliacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConciliacion));
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.cmbcuenta = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblfeha = new System.Windows.Forms.Label();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtCodDoc = new System.Windows.Forms.TextBox();
            this.Verificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.txtCodigo);
            this.pnlInformacion.Controls.Add(this.cmbCodigo);
            this.pnlInformacion.Controls.Add(this.txtcuenta);
            this.pnlInformacion.Controls.Add(this.cmbcuenta);
            this.pnlInformacion.Controls.Add(this.txtEstado);
            this.pnlInformacion.Controls.Add(this.txtFecha);
            this.pnlInformacion.Controls.Add(this.lblfeha);
            this.pnlInformacion.Controls.Add(this.cmbMes);
            this.pnlInformacion.Controls.Add(this.btnGenerar);
            this.pnlInformacion.Controls.Add(this.lblMes);
            this.pnlInformacion.Controls.Add(this.lblEncargado);
            this.pnlInformacion.Controls.Add(this.txtEncargado);
            this.pnlInformacion.Controls.Add(this.lblFecha);
            this.pnlInformacion.Controls.Add(this.lblCuenta);
            this.pnlInformacion.Location = new System.Drawing.Point(57, 65);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(847, 100);
            this.pnlInformacion.TabIndex = 12;
            this.pnlInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInformacion_Paint);
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(392, 55);
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(24, 20);
            this.txtcuenta.TabIndex = 28;
            this.txtcuenta.Tag = "ncodcuenta";
            this.txtcuenta.Visible = false;
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.Enabled = false;
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.Location = new System.Drawing.Point(149, 55);
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbcuenta.TabIndex = 27;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(776, 62);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(24, 20);
            this.txtEstado.TabIndex = 26;
            this.txtEstado.Tag = "cestado";
            this.txtEstado.Text = "activo";
            this.txtEstado.Visible = false;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(776, 24);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(24, 20);
            this.txtFecha.TabIndex = 25;
            this.txtFecha.Tag = "dfecha";
            this.txtFecha.Visible = false;
            // 
            // lblfeha
            // 
            this.lblfeha.AutoSize = true;
            this.lblfeha.Location = new System.Drawing.Point(705, 27);
            this.lblfeha.Name = "lblfeha";
            this.lblfeha.Size = new System.Drawing.Size(0, 13);
            this.lblfeha.TabIndex = 24;
            // 
            // cmbMes
            // 
            this.cmbMes.Enabled = false;
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(468, 24);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(131, 21);
            this.cmbMes.TabIndex = 23;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(468, 51);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(131, 26);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(429, 27);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(33, 13);
            this.lblMes.TabIndex = 14;
            this.lblMes.Text = "Mes: ";
            // 
            // lblEncargado
            // 
            this.lblEncargado.AutoSize = true;
            this.lblEncargado.Location = new System.Drawing.Point(63, 27);
            this.lblEncargado.Name = "lblEncargado";
            this.lblEncargado.Size = new System.Drawing.Size(62, 13);
            this.lblEncargado.TabIndex = 11;
            this.lblEncargado.Text = "Encargado:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.Enabled = false;
            this.txtEncargado.Location = new System.Drawing.Point(149, 24);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(257, 20);
            this.txtEncargado.TabIndex = 12;
            this.txtEncargado.Tag = "cencargado";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(647, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(66, 58);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(64, 13);
            this.lblCuenta.TabIndex = 16;
            this.lblCuenta.Text = "No. Cuenta:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Verificacion});
            this.dataGridView1.Location = new System.Drawing.Point(57, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 261);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.panel3.Location = new System.Drawing.Point(152, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 15;
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
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(327, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 42);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Enabled = false;
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
            this.btnCancelar.Enabled = false;
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
            this.btnGuardar.Enabled = false;
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
            this.btnEditar.Enabled = false;
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
            // cmbCodigo
            // 
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(22, 74);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(24, 21);
            this.cmbCodigo.TabIndex = 29;
            this.cmbCodigo.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(52, 74);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(24, 20);
            this.txtCodigo.TabIndex = 30;
            this.txtCodigo.Tag = "ncodconcilicacion";
            this.txtCodigo.Visible = false;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(12, 167);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(29, 20);
            this.txtComentario.TabIndex = 16;
            this.txtComentario.Tag = "cdescripcion";
            this.txtComentario.Visible = false;
            // 
            // txtCodDoc
            // 
            this.txtCodDoc.Location = new System.Drawing.Point(12, 193);
            this.txtCodDoc.Name = "txtCodDoc";
            this.txtCodDoc.Size = new System.Drawing.Size(29, 20);
            this.txtCodDoc.TabIndex = 17;
            this.txtCodDoc.Tag = "ncoddocumento";
            this.txtCodDoc.Visible = false;
            // 
            // Verificacion
            // 
            this.Verificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Verificacion.HeaderText = "Verificacion";
            this.Verificacion.Name = "Verificacion";
            this.Verificacion.Width = 68;
            // 
            // frmConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(976, 497);
            this.Controls.Add(this.txtCodDoc);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConciliacion";
            this.Text = "frmConciliacion";
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblfeha;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.ComboBox cmbcuenta;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtCodDoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Verificacion;

    }
}