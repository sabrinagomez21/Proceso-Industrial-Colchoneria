namespace Login
{
    partial class frmBodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBodega));
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.lblSalir = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblcod = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnnavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            this.SuspendLayout();
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
            this.pnnavegador.Location = new System.Drawing.Point(12, 12);
            this.pnnavegador.Name = "pnnavegador";
            this.pnnavegador.Size = new System.Drawing.Size(650, 67);
            this.pnnavegador.TabIndex = 5;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(327, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(47, 50);
            this.btnimprimir.TabIndex = 7;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(11, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 50);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last1;
            this.btnirUltimo.Location = new System.Drawing.Point(592, 8);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(47, 50);
            this.btnirUltimo.TabIndex = 12;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next1;
            this.btnsiguiente.Location = new System.Drawing.Point(539, 8);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(47, 50);
            this.btnsiguiente.TabIndex = 11;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(486, 8);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(47, 50);
            this.btnanterior.TabIndex = 10;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(433, 8);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(47, 50);
            this.btnirPrimero.TabIndex = 9;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(64, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(47, 50);
            this.btneditar.TabIndex = 2;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::Login.Properties.Resources.delete;
            this.btncancelar.Location = new System.Drawing.Point(223, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(47, 50);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(276, 8);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(47, 50);
            this.btnrefrescar.TabIndex = 6;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(380, 8);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 8;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(117, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 50);
            this.btneliminar.TabIndex = 3;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(170, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(47, 50);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(100, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            this.txtNombre.Tag = "vnombre";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(97, 182);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 14;
            this.txtCantidad.Tag = "ncantidad";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(379, 182);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 15;
            this.txtEstado.Tag = "vestatus";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Estado:";
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMaterial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvMaterial.Location = new System.Drawing.Point(24, 227);
            this.dgvMaterial.MultiSelect = false;
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMaterial.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterial.Size = new System.Drawing.Size(616, 123);
            this.dgvMaterial.TabIndex = 12;
            this.dgvMaterial.DoubleClick += new System.EventHandler(this.dgvMaterial_DoubleClick);
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSalir.Location = new System.Drawing.Point(601, 401);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 56;
            this.lblSalir.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Login.Properties.Resources.salir;
            this.btnSalir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSalir.Location = new System.Drawing.Point(594, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 42);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(602, 102);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(0, 13);
            this.lblcod.TabIndex = 57;
            this.lblcod.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(316, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 58;
            this.label4.Text = "Precio:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(379, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.Tag = "vestatus";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // frmBodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 438);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pnnavegador);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBodega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bodega Produccion";
            this.Load += new System.EventHandler(this.frmBodega_Load);
            this.pnnavegador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}