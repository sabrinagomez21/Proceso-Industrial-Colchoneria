namespace Admin_User
{
    partial class frmBuscarUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarUser));
            this.dgvBusquedaUsuario = new System.Windows.Forms.DataGridView();
            this.gbUsuarioSeleccionado = new System.Windows.Forms.GroupBox();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.txtApellidoUsuario = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuario)).BeginInit();
            this.gbUsuarioSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBusquedaUsuario
            // 
            this.dgvBusquedaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBusquedaUsuario.Location = new System.Drawing.Point(12, 139);
            this.dgvBusquedaUsuario.Name = "dgvBusquedaUsuario";
            this.dgvBusquedaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBusquedaUsuario.Size = new System.Drawing.Size(644, 205);
            this.dgvBusquedaUsuario.TabIndex = 11;
            // 
            // gbUsuarioSeleccionado
            // 
            this.gbUsuarioSeleccionado.Controls.Add(this.label4);
            this.gbUsuarioSeleccionado.Controls.Add(this.lblApellidoUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtApellidoUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.btnbuscar);
            this.gbUsuarioSeleccionado.Controls.Add(this.lblNombreUsuario);
            this.gbUsuarioSeleccionado.Controls.Add(this.txtNombreUsuario);
            this.gbUsuarioSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUsuarioSeleccionado.Location = new System.Drawing.Point(12, 12);
            this.gbUsuarioSeleccionado.Name = "gbUsuarioSeleccionado";
            this.gbUsuarioSeleccionado.Size = new System.Drawing.Size(644, 110);
            this.gbUsuarioSeleccionado.TabIndex = 10;
            this.gbUsuarioSeleccionado.TabStop = false;
            this.gbUsuarioSeleccionado.Text = "Usuario Seleccionado";
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUsuario.Location = new System.Drawing.Point(436, 36);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(124, 16);
            this.lblApellidoUsuario.TabIndex = 6;
            this.lblApellidoUsuario.Text = "Apellido Usuario";
            // 
            // txtApellidoUsuario
            // 
            this.txtApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoUsuario.Location = new System.Drawing.Point(363, 55);
            this.txtApellidoUsuario.Name = "txtApellidoUsuario";
            this.txtApellidoUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtApellidoUsuario.TabIndex = 5;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::Admin_User.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(19, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(164, 32);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(121, 16);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(98, 55);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(259, 27);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Image = global::Admin_User.Properties.Resources.cancelar;
            this.btncancelar.Location = new System.Drawing.Point(356, 359);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(54, 52);
            this.btncancelar.TabIndex = 13;
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Image = global::Admin_User.Properties.Resources.aceptar;
            this.btnAceptar.Location = new System.Drawing.Point(243, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(54, 52);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 414);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Cancelar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Aceptar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Buscar";
            // 
            // frmBuscarUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvBusquedaUsuario);
            this.Controls.Add(this.gbUsuarioSeleccionado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarUser";
            this.Text = "Busqueda de Usuarios";
            this.Load += new System.EventHandler(this.frmBuscarUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBusquedaUsuario)).EndInit();
            this.gbUsuarioSeleccionado.ResumeLayout(false);
            this.gbUsuarioSeleccionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBusquedaUsuario;
        private System.Windows.Forms.GroupBox gbUsuarioSeleccionado;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.TextBox txtApellidoUsuario;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}