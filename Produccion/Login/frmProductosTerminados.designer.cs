namespace Login
{
    partial class frmProductosTerminados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductosTerminados));
            this.lProductoTerminado = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NoOrden = new System.Windows.Forms.Label();
            this.cmbOrden = new System.Windows.Forms.ComboBox();
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
            this.btnSi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lProductoTerminado
            // 
            this.lProductoTerminado.AutoSize = true;
            this.lProductoTerminado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductoTerminado.Location = new System.Drawing.Point(12, 130);
            this.lProductoTerminado.Name = "lProductoTerminado";
            this.lProductoTerminado.Size = new System.Drawing.Size(193, 19);
            this.lProductoTerminado.TabIndex = 0;
            this.lProductoTerminado.Text = "Esta el Producto Terminado?";
            this.lProductoTerminado.Click += new System.EventHandler(this.lProductoTerminado_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(804, 297);
            this.dataGridView1.TabIndex = 24;
            // 
            // NoOrden
            // 
            this.NoOrden.AutoSize = true;
            this.NoOrden.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOrden.Location = new System.Drawing.Point(16, 99);
            this.NoOrden.Name = "NoOrden";
            this.NoOrden.Size = new System.Drawing.Size(53, 19);
            this.NoOrden.TabIndex = 65;
            this.NoOrden.Text = "Orden:";
            // 
            // cmbOrden
            // 
            this.cmbOrden.FormattingEnabled = true;
            this.cmbOrden.Location = new System.Drawing.Point(75, 100);
            this.cmbOrden.Name = "cmbOrden";
            this.cmbOrden.Size = new System.Drawing.Size(121, 21);
            this.cmbOrden.TabIndex = 66;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(588, 26);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(46, 43);
            this.btnirUltimo.TabIndex = 64;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.Location = new System.Drawing.Point(536, 26);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(46, 43);
            this.btnsiguiente.TabIndex = 63;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(484, 26);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 43);
            this.btnanterior.TabIndex = 62;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Enabled = false;
            this.btnirPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(432, 26);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(46, 43);
            this.btnirPrimero.TabIndex = 61;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(380, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(46, 43);
            this.btnbuscar.TabIndex = 60;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(328, 26);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 43);
            this.btnimprimir.TabIndex = 59;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Enabled = false;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(276, 26);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(46, 43);
            this.btnrefrescar.TabIndex = 58;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::Login.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(224, 26);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 43);
            this.btncancelar.TabIndex = 57;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::Login.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(172, 26);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 43);
            this.btnguardar.TabIndex = 56;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(120, 26);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 43);
            this.btneliminar.TabIndex = 55;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(68, 26);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(46, 43);
            this.btneditar.TabIndex = 54;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(16, 26);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 53;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnSi
            // 
            this.btnSi.Location = new System.Drawing.Point(224, 130);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 23);
            this.btnSi.TabIndex = 67;
            this.btnSi.Text = "Si";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // frmProductosTerminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 532);
            this.Controls.Add(this.btnSi);
            this.Controls.Add(this.cmbOrden);
            this.Controls.Add(this.NoOrden);
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lProductoTerminado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProductosTerminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambios al Producto Terminado";
            this.Load += new System.EventHandler(this.frmProductosTerminados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductoTerminado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnirPrimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnirUltimo;
        private System.Windows.Forms.Label NoOrden;
        private System.Windows.Forms.ComboBox cmbOrden;
        private System.Windows.Forms.Button btnSi;
    }
}