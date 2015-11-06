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
            this.pnlInformacion = new System.Windows.Forms.Panel();
            this.lblConciliacion = new System.Windows.Forms.Label();
            this.lblEncargado = new System.Windows.Forms.Label();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtConciliacion = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.Verificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Moneda = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInformacion
            // 
            this.pnlInformacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformacion.Controls.Add(this.btnGenerar);
            this.pnlInformacion.Controls.Add(this.lblConciliacion);
            this.pnlInformacion.Controls.Add(this.lblEncargado);
            this.pnlInformacion.Controls.Add(this.txtEncargado);
            this.pnlInformacion.Controls.Add(this.cmbBanco);
            this.pnlInformacion.Controls.Add(this.lblFecha);
            this.pnlInformacion.Controls.Add(this.lblBanco);
            this.pnlInformacion.Controls.Add(this.txtConciliacion);
            this.pnlInformacion.Controls.Add(this.txtCuenta);
            this.pnlInformacion.Controls.Add(this.lblCuenta);
            this.pnlInformacion.Location = new System.Drawing.Point(57, 56);
            this.pnlInformacion.Name = "pnlInformacion";
            this.pnlInformacion.Size = new System.Drawing.Size(847, 100);
            this.pnlInformacion.TabIndex = 12;
            // 
            // lblConciliacion
            // 
            this.lblConciliacion.AutoSize = true;
            this.lblConciliacion.Location = new System.Drawing.Point(429, 27);
            this.lblConciliacion.Name = "lblConciliacion";
            this.lblConciliacion.Size = new System.Drawing.Size(90, 13);
            this.lblConciliacion.TabIndex = 14;
            this.lblConciliacion.Text = "No. Conciliacion: ";
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
            this.txtEncargado.Location = new System.Drawing.Point(149, 24);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(257, 20);
            this.txtEncargado.TabIndex = 12;
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(382, 55);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(187, 21);
            this.cmbBanco.TabIndex = 19;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(672, 27);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 13);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Location = new System.Drawing.Point(329, 58);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(41, 13);
            this.lblBanco.TabIndex = 18;
            this.lblBanco.Text = "Banco:";
            // 
            // txtConciliacion
            // 
            this.txtConciliacion.Location = new System.Drawing.Point(520, 24);
            this.txtConciliacion.Name = "txtConciliacion";
            this.txtConciliacion.Size = new System.Drawing.Size(126, 20);
            this.txtConciliacion.TabIndex = 15;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(149, 55);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(163, 20);
            this.txtCuenta.TabIndex = 17;
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
            this.Verificacion,
            this.NoDocumento,
            this.Fecha,
            this.TipoDocumento,
            this.Moneda,
            this.Monto,
            this.Comentario});
            this.dataGridView1.Location = new System.Drawing.Point(57, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 261);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(629, 458);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(83, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total Conciliado";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(650, 58);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(97, 26);
            this.btnGenerar.TabIndex = 22;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // Verificacion
            // 
            this.Verificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Verificacion.HeaderText = "Verificacion";
            this.Verificacion.Name = "Verificacion";
            this.Verificacion.Width = 68;
            // 
            // NoDocumento
            // 
            this.NoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoDocumento.HeaderText = "No.Documento";
            this.NoDocumento.Name = "NoDocumento";
            this.NoDocumento.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha Documento";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            // 
            // Moneda
            // 
            this.Moneda.HeaderText = "Moneda";
            this.Moneda.Items.AddRange(new object[] {
            "Quetzales ",
            "Dolares",
            "Euros",
            "Libras",
            "Yenes"});
            this.Moneda.Name = "Moneda";
            // 
            // Monto
            // 
            this.Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Comentario
            // 
            this.Comentario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Comentario.FillWeight = 200F;
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            // 
            // frmConciliacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(976, 497);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnlInformacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmConciliacion";
            this.Text = "frmConciliacion";
            this.pnlInformacion.ResumeLayout(false);
            this.pnlInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformacion;
        private System.Windows.Forms.Label lblConciliacion;
        private System.Windows.Forms.Label lblEncargado;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtConciliacion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Verificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewComboBoxColumn Moneda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private System.Windows.Forms.Label lblTotal;

    }
}