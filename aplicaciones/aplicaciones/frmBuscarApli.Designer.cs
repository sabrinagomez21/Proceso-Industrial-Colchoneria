namespace aplicaciones
{
    partial class frmBuscarApli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarApli));
            this.dgvBusquedaAplicacion = new System.Windows.Forms.DataGridView();
            this.gbUsuarioSeleccionado = new System.Windows.Forms.GroupBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreAplicacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaAplicacion)).BeginInit();
            this.gbUsuarioSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusquedaAplicacion
            // 
            this.dgvBusquedaAplicacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaAplicacion.Location = new System.Drawing.Point(12, 163);
            this.dgvBusquedaAplicacion.Name = "dgvBusquedaAplicacion";
            this.dgvBusquedaAplicacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaAplicacion.Size = new System.Drawing.Size(396, 205);
            this.dgvBusquedaAplicacion.TabIndex = 15;
            // 
            // gbUsuarioSeleccionado
            // 
            this.gbUsuarioSeleccionado.Controls.Add(this.label4);
            this.gbUsuarioSeleccionado.Controls.Add(this.btnbuscar);
            this.gbUsuarioSeleccionado.Controls.Add(this.lblNombreUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtNombreAplicacion);
            this.gbUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarioSeleccionado.Location = new System.Drawing.Point(12, 36);
            this.gbUsuarioSeleccionado.Name = "gbUsuarioSeleccionado";
            this.gbUsuarioSeleccionado.Size = new System.Drawing.Size(396, 110);
            this.gbUsuarioSeleccionado.TabIndex = 14;
            this.gbUsuarioSeleccionado.TabStop = false;
            this.gbUsuarioSeleccionado.Text = "Buscar Aplicaciones";
            this.gbUsuarioSeleccionado.Enter += new System.EventHandler(this.gbUsuarioSeleccionado_Enter);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(164, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(140, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Aplicacion";
            // 
            // txtNombreAplicacion
            // 
            this.txtNombreAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAplicacion.Location = new System.Drawing.Point(98, 55);
            this.txtNombreAplicacion.Name = "txtNombreAplicacion";
            this.txtNombreAplicacion.Size = new System.Drawing.Size(259, 27);
            this.txtNombreAplicacion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Editar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Buscar";
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Image = global::aplicaciones.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(217, 393);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(58, 51);
            this.btncancelar.TabIndex = 17;
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::aplicaciones.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(99, 393);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(54, 51);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Image = global::aplicaciones.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(22, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(51, 59);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmBuscarApli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvBusquedaAplicacion);
            this.Controls.Add(this.gbUsuarioSeleccionado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarApli";
            this.Text = "Buscar Aplicacion";
            this.Load += new System.EventHandler(this.frmBuscarApli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaAplicacion)).EndInit();
            this.gbUsuarioSeleccionado.ResumeLayout(false);
            this.gbUsuarioSeleccionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvBusquedaAplicacion;
        private System.Windows.Forms.GroupBox gbUsuarioSeleccionado;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreAplicacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}