namespace aplicaciones
{
    partial class frmaplicacionNueva
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaplicacionNueva));
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.txtNombreFormulario = new System.Windows.Forms.TextBox();
            this.txtNombreaplicacion = new System.Windows.Forms.TextBox();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.label1);
            this.gbRegistro.Controls.Add(this.label2);
            this.gbRegistro.Controls.Add(this.btnbuscar);
            this.gbRegistro.Controls.Add(this.txtNombreFormulario);
            this.gbRegistro.Controls.Add(this.btnRegistrar);
            this.gbRegistro.Controls.Add(this.txtNombreaplicacion);
            this.gbRegistro.Controls.Add(this.lblApellidoUsuario);
            this.gbRegistro.Controls.Add(this.lblNombreUsuario);
            this.gbRegistro.Location = new System.Drawing.Point(6, 66);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(504, 179);
            this.gbRegistro.TabIndex = 9;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Enter += new System.EventHandler(this.gbRegistro_Enter);
            // 
            // txtNombreFormulario
            // 
            this.txtNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFormulario.Location = new System.Drawing.Point(200, 64);
            this.txtNombreFormulario.Name = "txtNombreFormulario";
            this.txtNombreFormulario.Size = new System.Drawing.Size(243, 26);
            this.txtNombreFormulario.TabIndex = 21;
            // 
            // txtNombreaplicacion
            // 
            this.txtNombreaplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreaplicacion.Location = new System.Drawing.Point(200, 28);
            this.txtNombreaplicacion.Name = "txtNombreaplicacion";
            this.txtNombreaplicacion.Size = new System.Drawing.Size(243, 26);
            this.txtNombreaplicacion.TabIndex = 20;
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuario.Location = new System.Drawing.Point(50, 70);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(145, 16);
            this.lblApellidoUsuario.TabIndex = 16;
            this.lblApellidoUsuario.Text = "Nombre Formulario:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(53, 34);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(144, 16);
            this.lblNombreUsuario.TabIndex = 15;
            this.lblNombreUsuario.Text = "Nombre Aplicacion:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(109, 19);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(323, 25);
            this.lblRegistro.TabIndex = 8;
            this.lblRegistro.Text = "Registro de Aplicacion Nueva";
            this.lblRegistro.Click += new System.EventHandler(this.lblRegistro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buscar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Guardar";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::aplicaciones.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(307, 113);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 22;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::aplicaciones.Properties.Resources.guardar;
            this.btnRegistrar.Location = new System.Drawing.Point(181, 113);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(47, 50);
            this.btnRegistrar.TabIndex = 14;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // frmaplicacionNueva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 289);
            this.Controls.Add(this.gbRegistro);
            this.Controls.Add(this.lblRegistro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmaplicacionNueva";
            this.Text = "Registro de Aplicaciones";
            this.gbRegistro.ResumeLayout(false);
            this.gbRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.TextBox txtNombreFormulario;
        private System.Windows.Forms.TextBox txtNombreaplicacion;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

