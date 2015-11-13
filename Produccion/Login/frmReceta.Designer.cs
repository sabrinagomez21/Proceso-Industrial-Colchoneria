namespace Login
{
    partial class frmReceta
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
            this.lblNombreReceta = new System.Windows.Forms.Label();
            this.txbNombreReceta = new System.Windows.Forms.TextBox();
            this.txbHoraHombre = new System.Windows.Forms.TextBox();
            this.lblhhombre = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.txbCantidad = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreReceta
            // 
            this.lblNombreReceta.AutoSize = true;
            this.lblNombreReceta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreReceta.Location = new System.Drawing.Point(31, 117);
            this.lblNombreReceta.Name = "lblNombreReceta";
            this.lblNombreReceta.Size = new System.Drawing.Size(113, 19);
            this.lblNombreReceta.TabIndex = 67;
            this.lblNombreReceta.Text = "Nombre Receta:";
            // 
            // txbNombreReceta
            // 
            this.txbNombreReceta.Location = new System.Drawing.Point(150, 118);
            this.txbNombreReceta.Name = "txbNombreReceta";
            this.txbNombreReceta.Size = new System.Drawing.Size(100, 20);
            this.txbNombreReceta.TabIndex = 68;
            this.txbNombreReceta.Tag = "vnombrereceta";
            // 
            // txbHoraHombre
            // 
            this.txbHoraHombre.Location = new System.Drawing.Point(435, 117);
            this.txbHoraHombre.Name = "txbHoraHombre";
            this.txbHoraHombre.Size = new System.Drawing.Size(100, 20);
            this.txbHoraHombre.TabIndex = 69;
            this.txbHoraHombre.Tag = "nhorahombre";
            // 
            // lblhhombre
            // 
            this.lblhhombre.AutoSize = true;
            this.lblhhombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhhombre.Location = new System.Drawing.Point(305, 117);
            this.lblhhombre.Name = "lblhhombre";
            this.lblhhombre.Size = new System.Drawing.Size(99, 19);
            this.lblhhombre.TabIndex = 70;
            this.lblhhombre.Text = "Hora Hombre:";
            // 
            // btnirUltimo
            // 
            this.btnirUltimo.Enabled = false;
            this.btnirUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirUltimo.Image = global::Login.Properties.Resources.go_to_last;
            this.btnirUltimo.Location = new System.Drawing.Point(603, 22);
            this.btnirUltimo.Name = "btnirUltimo";
            this.btnirUltimo.Size = new System.Drawing.Size(46, 43);
            this.btnirUltimo.TabIndex = 66;
            this.btnirUltimo.UseVisualStyleBackColor = true;
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Enabled = false;
            this.btnsiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsiguiente.Image = global::Login.Properties.Resources.go_next;
            this.btnsiguiente.Location = new System.Drawing.Point(551, 22);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(46, 43);
            this.btnsiguiente.TabIndex = 65;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            // 
            // btnanterior
            // 
            this.btnanterior.Enabled = false;
            this.btnanterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnanterior.Image = global::Login.Properties.Resources.anterior;
            this.btnanterior.Location = new System.Drawing.Point(499, 22);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(46, 43);
            this.btnanterior.TabIndex = 64;
            this.btnanterior.UseVisualStyleBackColor = true;
            // 
            // btnirPrimero
            // 
            this.btnirPrimero.Enabled = false;
            this.btnirPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnirPrimero.Image = global::Login.Properties.Resources.go_to_first;
            this.btnirPrimero.Location = new System.Drawing.Point(447, 22);
            this.btnirPrimero.Name = "btnirPrimero";
            this.btnirPrimero.Size = new System.Drawing.Size(46, 43);
            this.btnirPrimero.TabIndex = 63;
            this.btnirPrimero.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Enabled = false;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Image = global::Login.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(395, 22);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(46, 43);
            this.btnbuscar.TabIndex = 62;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Image = global::Login.Properties.Resources.IMPRIMIR;
            this.btnimprimir.Location = new System.Drawing.Point(343, 22);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(46, 43);
            this.btnimprimir.TabIndex = 61;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Enabled = false;
            this.btnrefrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrefrescar.Image = global::Login.Properties.Resources.refresh;
            this.btnrefrescar.Location = new System.Drawing.Point(291, 22);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(46, 43);
            this.btnrefrescar.TabIndex = 60;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Image = global::Login.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(239, 22);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(46, 43);
            this.btncancelar.TabIndex = 59;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Image = global::Login.Properties.Resources.guardar;
            this.btnguardar.Location = new System.Drawing.Point(187, 22);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(46, 43);
            this.btnguardar.TabIndex = 58;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Image = global::Login.Properties.Resources.eliminar;
            this.btneliminar.Location = new System.Drawing.Point(135, 22);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 43);
            this.btneliminar.TabIndex = 57;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btneditar
            // 
            this.btneditar.Enabled = false;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.Image = global::Login.Properties.Resources.editar;
            this.btneditar.Location = new System.Drawing.Point(83, 22);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(46, 43);
            this.btneditar.TabIndex = 56;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Enabled = false;
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnuevo.Image = global::Login.Properties.Resources.nuevo;
            this.btnnuevo.Location = new System.Drawing.Point(31, 22);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(46, 43);
            this.btnnuevo.TabIndex = 55;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 71;
            this.label1.Text = "Detalle Receta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Material";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "Cantidad:";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(150, 236);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 21);
            this.cmbMaterial.TabIndex = 74;
            this.cmbMaterial.Tag = "";
            // 
            // txbCantidad
            // 
            this.txbCantidad.Location = new System.Drawing.Point(435, 233);
            this.txbCantidad.Name = "txbCantidad";
            this.txbCantidad.Size = new System.Drawing.Size(100, 20);
            this.txbCantidad.TabIndex = 75;
            this.txbCantidad.Tag = "ncantidad";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(574, 230);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 76;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // frmReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 420);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.txbCantidad);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblhhombre);
            this.Controls.Add(this.txbHoraHombre);
            this.Controls.Add(this.txbNombreReceta);
            this.Controls.Add(this.lblNombreReceta);
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
            this.Name = "frmReceta";
            this.Text = "frmReceta";
            this.Load += new System.EventHandler(this.frmReceta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblNombreReceta;
        private System.Windows.Forms.TextBox txbNombreReceta;
        private System.Windows.Forms.TextBox txbHoraHombre;
        private System.Windows.Forms.Label lblhhombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.TextBox txbCantidad;
        private System.Windows.Forms.Button btnAñadir;
    }
}