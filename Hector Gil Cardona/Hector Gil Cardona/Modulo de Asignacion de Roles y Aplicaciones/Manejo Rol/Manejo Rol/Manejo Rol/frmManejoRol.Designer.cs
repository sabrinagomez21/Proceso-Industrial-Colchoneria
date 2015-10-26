namespace Manejo_Rol
{
    partial class frmManejoRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManejoRol));
            this.lblAppAsignadas = new System.Windows.Forms.Label();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblPerfilesDispo = new System.Windows.Forms.Label();
            this.lbPerfiles = new System.Windows.Forms.ListBox();
            this.lbRolAsignado = new System.Windows.Forms.ListBox();
            this.btnQuitarSimple = new System.Windows.Forms.Button();
            this.lblQuitarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarMuchos = new System.Windows.Forms.Button();
            this.btnAsignarSimple = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAppAsignadas
            // 
            this.lblAppAsignadas.AutoSize = true;
            this.lblAppAsignadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppAsignadas.Location = new System.Drawing.Point(436, 133);
            this.lblAppAsignadas.Name = "lblAppAsignadas";
            this.lblAppAsignadas.Size = new System.Drawing.Size(139, 16);
            this.lblAppAsignadas.TabIndex = 35;
            this.lblAppAsignadas.Text = "Perfiles Asignados";
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(297, 244);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(49, 16);
            this.lblQuitar.TabIndex = 32;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(290, 125);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(61, 16);
            this.lblAsignar.TabIndex = 29;
            this.lblAsignar.Text = "Asignar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblNombreUsuario);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 100);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario Seleccionado";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Manejo_Rol.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(22, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(103, 55);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(100, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(116, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Codigo Usuario";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(330, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(270, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblPerfilesDispo
            // 
            this.lblPerfilesDispo.AutoSize = true;
            this.lblPerfilesDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilesDispo.Location = new System.Drawing.Point(68, 133);
            this.lblPerfilesDispo.Name = "lblPerfilesDispo";
            this.lblPerfilesDispo.Size = new System.Drawing.Size(148, 16);
            this.lblPerfilesDispo.TabIndex = 24;
            this.lblPerfilesDispo.Text = "Perfiles Disponibles";
            // 
            // lbPerfiles
            // 
            this.lbPerfiles.FormattingEnabled = true;
            this.lbPerfiles.Location = new System.Drawing.Point(12, 169);
            this.lbPerfiles.Name = "lbPerfiles";
            this.lbPerfiles.ScrollAlwaysVisible = true;
            this.lbPerfiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbPerfiles.Size = new System.Drawing.Size(271, 160);
            this.lbPerfiles.TabIndex = 44;
            // 
            // lbRolAsignado
            // 
            this.lbRolAsignado.FormattingEnabled = true;
            this.lbRolAsignado.Location = new System.Drawing.Point(367, 169);
            this.lbRolAsignado.Name = "lbRolAsignado";
            this.lbRolAsignado.ScrollAlwaysVisible = true;
            this.lbRolAsignado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbRolAsignado.Size = new System.Drawing.Size(271, 160);
            this.lbRolAsignado.TabIndex = 48;
            // 
            // btnQuitarSimple
            // 
            this.btnQuitarSimple.Image = global::Manejo_Rol.Properties.Resources.asignar4;
            this.btnQuitarSimple.Location = new System.Drawing.Point(299, 309);
            this.btnQuitarSimple.Name = "btnQuitarSimple";
            this.btnQuitarSimple.Size = new System.Drawing.Size(45, 40);
            this.btnQuitarSimple.TabIndex = 34;
            this.btnQuitarSimple.UseVisualStyleBackColor = true;
            this.btnQuitarSimple.Click += new System.EventHandler(this.btnQuitarSimple_Click);
            // 
            // lblQuitarMuchos
            // 
            this.lblQuitarMuchos.Image = global::Manejo_Rol.Properties.Resources.asignar3;
            this.lblQuitarMuchos.Location = new System.Drawing.Point(299, 263);
            this.lblQuitarMuchos.Name = "lblQuitarMuchos";
            this.lblQuitarMuchos.Size = new System.Drawing.Size(45, 40);
            this.lblQuitarMuchos.TabIndex = 33;
            this.lblQuitarMuchos.UseVisualStyleBackColor = true;
            this.lblQuitarMuchos.Click += new System.EventHandler(this.lblQuitarMuchos_Click);
            // 
            // btnAsignarMuchos
            // 
            this.btnAsignarMuchos.Image = global::Manejo_Rol.Properties.Resources.asignar2;
            this.btnAsignarMuchos.Location = new System.Drawing.Point(297, 190);
            this.btnAsignarMuchos.Name = "btnAsignarMuchos";
            this.btnAsignarMuchos.Size = new System.Drawing.Size(45, 40);
            this.btnAsignarMuchos.TabIndex = 31;
            this.btnAsignarMuchos.UseVisualStyleBackColor = true;
            this.btnAsignarMuchos.Click += new System.EventHandler(this.btnAsignarMuchos_Click);
            // 
            // btnAsignarSimple
            // 
            this.btnAsignarSimple.Image = global::Manejo_Rol.Properties.Resources.asginar;
            this.btnAsignarSimple.Location = new System.Drawing.Point(297, 144);
            this.btnAsignarSimple.Name = "btnAsignarSimple";
            this.btnAsignarSimple.Size = new System.Drawing.Size(45, 40);
            this.btnAsignarSimple.TabIndex = 30;
            this.btnAsignarSimple.UseVisualStyleBackColor = true;
            this.btnAsignarSimple.Click += new System.EventHandler(this.btnAsignarSimple_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(439, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 49;
            this.button1.Text = "Asignacion de Permisos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(98, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 41);
            this.button2.TabIndex = 50;
            this.button2.Text = "Crear Roles";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmManejoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 388);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbRolAsignado);
            this.Controls.Add(this.lbPerfiles);
            this.Controls.Add(this.lblAppAsignadas);
            this.Controls.Add(this.btnQuitarSimple);
            this.Controls.Add(this.lblQuitarMuchos);
            this.Controls.Add(this.lblQuitar);
            this.Controls.Add(this.btnAsignarMuchos);
            this.Controls.Add(this.btnAsignarSimple);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPerfilesDispo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManejoRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Roles";
            this.Load += new System.EventHandler(this.frmManejoRol_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAppAsignadas;
        private System.Windows.Forms.Button btnQuitarSimple;
        private System.Windows.Forms.Button lblQuitarMuchos;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Button btnAsignarMuchos;
        private System.Windows.Forms.Button btnAsignarSimple;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblPerfilesDispo;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.TextBox txtNombreUsuario;
        public System.Windows.Forms.ListBox lbPerfiles;
        public System.Windows.Forms.ListBox lbRolAsignado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

