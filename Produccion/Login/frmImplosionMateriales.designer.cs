namespace Login
{
    partial class frmImplosionMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImplosionMateriales));
            this.lProductoTerminado = new System.Windows.Forms.Label();
            this.lMaximoAFabricar = new System.Windows.Forms.Label();
            this.txtMaximoAFarbicar = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.pnnavegador = new System.Windows.Forms.Panel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnirUltimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnirPrimero = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.pnnavegador.SuspendLayout();
            this.SuspendLayout();
            // 
            // lProductoTerminado
            // 
            resources.ApplyResources(this.lProductoTerminado, "lProductoTerminado");
            this.lProductoTerminado.Name = "lProductoTerminado";
            // 
            // lMaximoAFabricar
            // 
            resources.ApplyResources(this.lMaximoAFabricar, "lMaximoAFabricar");
            this.lMaximoAFabricar.Name = "lMaximoAFabricar";
            // 
            // txtMaximoAFarbicar
            // 
            resources.ApplyResources(this.txtMaximoAFarbicar, "txtMaximoAFarbicar");
            this.txtMaximoAFarbicar.Name = "txtMaximoAFarbicar";
            this.txtMaximoAFarbicar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximoAFarbicar_KeyPress);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvDetalle, "dgvDetalle");
            this.dgvDetalle.Name = "dgvDetalle";
            // 
            // pnnavegador
            // 
            this.pnnavegador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnnavegador.Controls.Add(this.btnimprimir);
            this.pnnavegador.Controls.Add(this.btnnuevo);
            this.pnnavegador.Controls.Add(this.btnirUltimo);
            this.pnnavegador.Controls.Add(this.btnsiguiente);
            this.pnnavegador.Controls.Add(this.btnanterior);
            this.pnnavegador.Controls.Add(this.btnirPrimero);
            this.pnnavegador.Controls.Add(this.btneditar);
            this.pnnavegador.Controls.Add(this.btncancelar);
            this.pnnavegador.Controls.Add(this.btnrefrescar);
            this.pnnavegador.Controls.Add(this.btnbuscar);
            this.pnnavegador.Controls.Add(this.btneliminar);
            this.pnnavegador.Controls.Add(this.btnguardar);
            resources.ApplyResources(this.pnnavegador, "pnnavegador");
            this.pnnavegador.Name = "pnnavegador";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            resources.ApplyResources(this.btnimprimir, "btnimprimir");
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            resources.ApplyResources(this.btnnuevo, "btnnuevo");
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last1;
            resources.ApplyResources(this.btnirUltimo, "btnirUltimo");
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next1;
            resources.ApplyResources(this.btnsiguiente, "btnsiguiente");
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            resources.ApplyResources(this.btnanterior, "btnanterior");
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            resources.ApplyResources(this.btnirPrimero, "btnirPrimero");
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            resources.ApplyResources(this.btneditar, "btneditar");
            this.btneditar.Name = "btneditar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Login.Properties.Resources.delete;
            resources.ApplyResources(this.btncancelar, "btncancelar");
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            resources.ApplyResources(this.btnrefrescar, "btnrefrescar");
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            resources.ApplyResources(this.btnbuscar, "btnbuscar");
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            resources.ApplyResources(this.btneliminar, "btneliminar");
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            resources.ApplyResources(this.btnguardar, "btnguardar");
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            resources.ApplyResources(this.cmbProducto, "cmbProducto");
            this.cmbProducto.Name = "cmbProducto";
            // 
            // lblSalir
            // 
            resources.ApplyResources(this.lblSalir, "lblSalir");
            this.lblSalir.Name = "lblSalir";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Login.Properties.Resources.salir;
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnCalculo
            // 
            this.btnCalculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculo.Image = global::Login.Properties.Resources.aceptar;
            resources.ApplyResources(this.btnCalculo, "btnCalculo");
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // frmImplosionMateriales
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculo);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.pnnavegador);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtMaximoAFarbicar);
            this.Controls.Add(this.lMaximoAFabricar);
            this.Controls.Add(this.lProductoTerminado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmImplosionMateriales";
            this.Load += new System.EventHandler(this.frmImplosionMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.pnnavegador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductoTerminado;
        private System.Windows.Forms.Label lMaximoAFabricar;
        private System.Windows.Forms.TextBox txtMaximoAFarbicar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Panel pnnavegador;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnirUltimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnirPrimero;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculo;
    }
}