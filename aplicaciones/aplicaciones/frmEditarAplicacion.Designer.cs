namespace aplicaciones
{
    partial class frmEditarAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarAplicacion));
            this.lblModificacionUser = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreFormulario = new System.Windows.Forms.TextBox();
            this.txtNombreAplicacion = new System.Windows.Forms.TextBox();
            this.txtIdAplicacion = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificacionUser
            // 
            this.lblModificacionUser.AutoSize = true;
            this.lblModificacionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificacionUser.Location = new System.Drawing.Point(144, 19);
            this.lblModificacionUser.Name = "lblModificacionUser";
            this.lblModificacionUser.Size = new System.Drawing.Size(271, 25);
            this.lblModificacionUser.TabIndex = 11;
            this.lblModificacionUser.Text = "Modificar una Aplicacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnRegresar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.txtNombreFormulario);
            this.groupBox1.Controls.Add(this.txtNombreAplicacion);
            this.groupBox1.Controls.Add(this.txtIdAplicacion);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblApellidoUsuario);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Location = new System.Drawing.Point(14, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(336, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Otra Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(246, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Cancelar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Editar";
            // 
            // txtNombreFormulario
            // 
            this.txtNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreFormulario.Location = new System.Drawing.Point(191, 100);
            this.txtNombreFormulario.Name = "txtNombreFormulario";
            this.txtNombreFormulario.Size = new System.Drawing.Size(243, 26);
            this.txtNombreFormulario.TabIndex = 11;
            // 
            // txtNombreAplicacion
            // 
            this.txtNombreAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreAplicacion.Location = new System.Drawing.Point(191, 61);
            this.txtNombreAplicacion.Name = "txtNombreAplicacion";
            this.txtNombreAplicacion.Size = new System.Drawing.Size(243, 26);
            this.txtNombreAplicacion.TabIndex = 10;
            // 
            // txtIdAplicacion
            // 
            this.txtIdAplicacion.Enabled = false;
            this.txtIdAplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdAplicacion.Location = new System.Drawing.Point(191, 25);
            this.txtIdAplicacion.Name = "txtIdAplicacion";
            this.txtIdAplicacion.Size = new System.Drawing.Size(243, 26);
            this.txtIdAplicacion.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(21, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(145, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Nombre Formulario:";
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuario.Location = new System.Drawing.Point(21, 67);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(144, 16);
            this.lblApellidoUsuario.TabIndex = 5;
            this.lblApellidoUsuario.Text = "Nombre Aplicacion:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(41, 25);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(124, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Id de Aplicacion:";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(257, 166);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(45, 20);
            this.txtid.TabIndex = 16;
            this.txtid.Visible = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Image = global::aplicaciones.Properties.Resources.regresar;
            this.btnRegresar.Location = new System.Drawing.Point(365, 150);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(47, 50);
            this.btnRegresar.TabIndex = 16;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = global::aplicaciones.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(257, 151);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(47, 50);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::aplicaciones.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(179, 151);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(47, 50);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::aplicaciones.Properties.Resources.editar;
            this.btnEditar.Location = new System.Drawing.Point(107, 151);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 50);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frmEditarAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 309);
            this.Controls.Add(this.lblModificacionUser);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarAplicacion";
            this.Text = "Editar Aplicaciones";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificacionUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnRegresar;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox txtNombreFormulario;
        public System.Windows.Forms.TextBox txtNombreAplicacion;
        public System.Windows.Forms.TextBox txtIdAplicacion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        public System.Windows.Forms.TextBox txtid;
    }
}