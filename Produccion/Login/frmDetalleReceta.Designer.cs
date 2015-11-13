namespace Login
{
    partial class frmDetalleReceta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMaterial = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnirPrimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnirUltimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalle Receta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material";
            // 
            // cbxMaterial
            // 
            this.cbxMaterial.FormattingEnabled = true;
            this.cbxMaterial.Location = new System.Drawing.Point(99, 145);
            this.cbxMaterial.Name = "cbxMaterial";
            this.cbxMaterial.Size = new System.Drawing.Size(121, 21);
            this.cbxMaterial.TabIndex = 2;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(342, 145);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(492, 148);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 5;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(12, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 54;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(64, 12);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(46, 43);
            this.btneditar.TabIndex = 55;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(116, 12);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 43);
            this.btneliminar.TabIndex = 56;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::Login.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(168, 12);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 43);
            this.btnguardar.TabIndex = 57;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::Login.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(220, 12);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 43);
            this.btncancelar.TabIndex = 58;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Enabled = false;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(272, 12);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(46, 43);
            this.btnrefrescar.TabIndex = 59;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(324, 12);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 43);
            this.btnimprimir.TabIndex = 60;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(376, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(46, 43);
            this.btnbuscar.TabIndex = 61;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Enabled = false;
            this.btnirPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(428, 12);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(46, 43);
            this.btnirPrimero.TabIndex = 62;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(480, 12);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 43);
            this.btnanterior.TabIndex = 63;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.Location = new System.Drawing.Point(532, 12);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(46, 43);
            this.btnsiguiente.TabIndex = 64;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(584, 12);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(46, 43);
            this.btnirUltimo.TabIndex = 65;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // frmDetalleReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 307);
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
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cbxMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDetalleReceta";
            this.Text = "frmDetalleReceta";
            this.Load += new System.EventHandler(this.frmDetalleReceta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxMaterial;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAñadir;
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
    }
}