namespace ManejoAsignacionAplicacion
{
    partial class frmAsignacionAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionAplicacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.lblEditar = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.lblAplicacionesDisp = new System.Windows.Forms.Label();
            this.lblAplicacionesAsign = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarPerfil = new System.Windows.Forms.Button();
            this.lbxAppAsignadas = new System.Windows.Forms.ListBox();
            this.lbxAppDisponibles = new System.Windows.Forms.ListBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnQuitarSimple = new System.Windows.Forms.Button();
            this.btnQuitarMuchas = new System.Windows.Forms.Button();
            this.btnAsignacionMuchas = new System.Windows.Forms.Button();
            this.btnAsignacionSimple = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtCodigoPerfil);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblNombrePerfil);
            this.groupBox1.Controls.Add(this.txtNombrePerfil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil Seleccionado";
            // 
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.Enabled = false;
            this.txtCodigoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPerfil.Location = new System.Drawing.Point(115, 55);
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.Size = new System.Drawing.Size(110, 27);
            this.txtCodigoPerfil.TabIndex = 1;
            this.txtCodigoPerfil.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(122, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(98, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Codigo Perfil";
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfil.Location = new System.Drawing.Point(330, 32);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(103, 16);
            this.lblNombrePerfil.TabIndex = 4;
            this.lblNombrePerfil.Text = "Nombre Perfil";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Enabled = false;
            this.txtNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePerfil.Location = new System.Drawing.Point(270, 55);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(259, 27);
            this.txtNombrePerfil.TabIndex = 3;
            // 
            // lblEditar
            // 
            this.lblEditar.AutoSize = true;
            this.lblEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditar.Location = new System.Drawing.Point(295, 397);
            this.lblEditar.Name = "lblEditar";
            this.lblEditar.Size = new System.Drawing.Size(49, 16);
            this.lblEditar.TabIndex = 27;
            this.lblEditar.Text = "Editar";
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(294, 262);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(49, 16);
            this.lblQuitar.TabIndex = 23;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(293, 122);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(61, 16);
            this.lblAsignar.TabIndex = 20;
            this.lblAsignar.Text = "Asignar";
            // 
            // lblAplicacionesDisp
            // 
            this.lblAplicacionesDisp.AutoSize = true;
            this.lblAplicacionesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacionesDisp.Location = new System.Drawing.Point(52, 122);
            this.lblAplicacionesDisp.Name = "lblAplicacionesDisp";
            this.lblAplicacionesDisp.Size = new System.Drawing.Size(185, 16);
            this.lblAplicacionesDisp.TabIndex = 28;
            this.lblAplicacionesDisp.Text = "Aplicaciones Disponibles";
            // 
            // lblAplicacionesAsign
            // 
            this.lblAplicacionesAsign.AutoSize = true;
            this.lblAplicacionesAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacionesAsign.Location = new System.Drawing.Point(422, 122);
            this.lblAplicacionesAsign.Name = "lblAplicacionesAsign";
            this.lblAplicacionesAsign.Size = new System.Drawing.Size(176, 16);
            this.lblAplicacionesAsign.TabIndex = 29;
            this.lblAplicacionesAsign.Text = "Aplicaciones Asignadas";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(527, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 34);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPerfil
            // 
            this.btnLimpiarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPerfil.Location = new System.Drawing.Point(404, 474);
            this.btnLimpiarPerfil.Name = "btnLimpiarPerfil";
            this.btnLimpiarPerfil.Size = new System.Drawing.Size(107, 34);
            this.btnLimpiarPerfil.TabIndex = 31;
            this.btnLimpiarPerfil.Text = "Limpiar Perfiles";
            this.btnLimpiarPerfil.UseVisualStyleBackColor = true;
            this.btnLimpiarPerfil.Click += new System.EventHandler(this.btnLimpiarPerfil_Click);
            // 
            // lbxAppAsignadas
            // 
            this.lbxAppAsignadas.FormattingEnabled = true;
            this.lbxAppAsignadas.Location = new System.Drawing.Point(370, 157);
            this.lbxAppAsignadas.Name = "lbxAppAsignadas";
            this.lbxAppAsignadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAppAsignadas.Size = new System.Drawing.Size(277, 303);
            this.lbxAppAsignadas.TabIndex = 33;
            // 
            // lbxAppDisponibles
            // 
            this.lbxAppDisponibles.FormattingEnabled = true;
            this.lbxAppDisponibles.Location = new System.Drawing.Point(37, 153);
            this.lbxAppDisponibles.Name = "lbxAppDisponibles";
            this.lbxAppDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAppDisponibles.Size = new System.Drawing.Size(220, 303);
            this.lbxAppDisponibles.TabIndex = 34;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::ManejoAsignacionAplicacion.Properties.Resources.guardar;
            this.btnEditar.Location = new System.Drawing.Point(296, 416);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(47, 50);
            this.btnEditar.TabIndex = 26;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarSimple
            // 
            this.btnQuitarSimple.Image = global::ManejoAsignacionAplicacion.Properties.Resources.asignar4;
            this.btnQuitarSimple.Location = new System.Drawing.Point(296, 337);
            this.btnQuitarSimple.Name = "btnQuitarSimple";
            this.btnQuitarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarSimple.TabIndex = 25;
            this.btnQuitarSimple.UseVisualStyleBackColor = true;
            this.btnQuitarSimple.Click += new System.EventHandler(this.btnQuitarSimple_Click);
            // 
            // btnQuitarMuchas
            // 
            this.btnQuitarMuchas.Image = global::ManejoAsignacionAplicacion.Properties.Resources.asignar3;
            this.btnQuitarMuchas.Location = new System.Drawing.Point(296, 281);
            this.btnQuitarMuchas.Name = "btnQuitarMuchas";
            this.btnQuitarMuchas.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarMuchas.TabIndex = 24;
            this.btnQuitarMuchas.UseVisualStyleBackColor = true;
            this.btnQuitarMuchas.Click += new System.EventHandler(this.btnQuitarMuchas_Click);
            // 
            // btnAsignacionMuchas
            // 
            this.btnAsignacionMuchas.Image = global::ManejoAsignacionAplicacion.Properties.Resources.asignar2;
            this.btnAsignacionMuchas.Location = new System.Drawing.Point(296, 199);
            this.btnAsignacionMuchas.Name = "btnAsignacionMuchas";
            this.btnAsignacionMuchas.Size = new System.Drawing.Size(47, 50);
            this.btnAsignacionMuchas.TabIndex = 22;
            this.btnAsignacionMuchas.UseVisualStyleBackColor = true;
            this.btnAsignacionMuchas.Click += new System.EventHandler(this.btnAsignacionMuchas_Click);
            // 
            // btnAsignacionSimple
            // 
            this.btnAsignacionSimple.Image = global::ManejoAsignacionAplicacion.Properties.Resources.asginar;
            this.btnAsignacionSimple.Location = new System.Drawing.Point(296, 143);
            this.btnAsignacionSimple.Name = "btnAsignacionSimple";
            this.btnAsignacionSimple.Size = new System.Drawing.Size(47, 50);
            this.btnAsignacionSimple.TabIndex = 21;
            this.btnAsignacionSimple.UseVisualStyleBackColor = true;
            this.btnAsignacionSimple.Click += new System.EventHandler(this.btnAsignacionSimple_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::ManejoAsignacionAplicacion.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(51, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmAsignacionAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 520);
            this.Controls.Add(this.lbxAppDisponibles);
            this.Controls.Add(this.lbxAppAsignadas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarPerfil);
            this.Controls.Add(this.lblAplicacionesAsign);
            this.Controls.Add(this.lblAplicacionesDisp);
            this.Controls.Add(this.lblEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnQuitarSimple);
            this.Controls.Add(this.btnQuitarMuchas);
            this.Controls.Add(this.lblQuitar);
            this.Controls.Add(this.btnAsignacionMuchas);
            this.Controls.Add(this.btnAsignacionSimple);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignacionAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Aplicaciones a Perfiles de Usuario";
            this.Load += new System.EventHandler(this.frmAsignacionAplicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Label lblEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitarSimple;
        private System.Windows.Forms.Button btnQuitarMuchas;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Button btnAsignacionMuchas;
        private System.Windows.Forms.Button btnAsignacionSimple;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Label lblAplicacionesDisp;
        private System.Windows.Forms.Label lblAplicacionesAsign;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarPerfil;
        private System.Windows.Forms.ListBox lbxAppAsignadas;
        private System.Windows.Forms.ListBox lbxAppDisponibles;
        public System.Windows.Forms.TextBox txtCodigoPerfil;
        public System.Windows.Forms.TextBox txtNombrePerfil;
    }
}