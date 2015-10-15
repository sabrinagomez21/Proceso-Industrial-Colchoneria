namespace ManejoAsignacionAplicacion
{
    partial class frmEditar
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
            this.lbxEditaAppAsig = new System.Windows.Forms.ListBox();
            this.cbInsertar = new System.Windows.Forms.CheckBox();
            this.cbEliminar = new System.Windows.Forms.CheckBox();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.txtNameUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBEditar = new System.Windows.Forms.CheckBox();
            this.cBBuscar = new System.Windows.Forms.CheckBox();
            this.cBCancelar = new System.Windows.Forms.CheckBox();
            this.btnEditaGuarda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxEditaAppAsig
            // 
            this.lbxEditaAppAsig.FormattingEnabled = true;
            this.lbxEditaAppAsig.Location = new System.Drawing.Point(31, 87);
            this.lbxEditaAppAsig.Name = "lbxEditaAppAsig";
            this.lbxEditaAppAsig.Size = new System.Drawing.Size(120, 186);
            this.lbxEditaAppAsig.TabIndex = 0;
            this.lbxEditaAppAsig.SelectedIndexChanged += new System.EventHandler(this.lbxEditaAppAsig_SelectedIndexChanged);
            // 
            // cbInsertar
            // 
            this.cbInsertar.AutoSize = true;
            this.cbInsertar.Location = new System.Drawing.Point(215, 87);
            this.cbInsertar.Name = "cbInsertar";
            this.cbInsertar.Size = new System.Drawing.Size(61, 17);
            this.cbInsertar.TabIndex = 1;
            this.cbInsertar.Text = "Insertar";
            this.cbInsertar.UseVisualStyleBackColor = true;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Location = new System.Drawing.Point(215, 129);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(62, 17);
            this.cbEliminar.TabIndex = 2;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.UseVisualStyleBackColor = true;
            // 
            // txtIdUser
            // 
            this.txtIdUser.Enabled = false;
            this.txtIdUser.Location = new System.Drawing.Point(101, 24);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(100, 20);
            this.txtIdUser.TabIndex = 3;
            // 
            // txtNameUser
            // 
            this.txtNameUser.Enabled = false;
            this.txtNameUser.Location = new System.Drawing.Point(304, 24);
            this.txtNameUser.Name = "txtNameUser";
            this.txtNameUser.Size = new System.Drawing.Size(100, 20);
            this.txtNameUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre Usuario:";
            // 
            // cBEditar
            // 
            this.cBEditar.AutoSize = true;
            this.cBEditar.Location = new System.Drawing.Point(215, 167);
            this.cBEditar.Name = "cBEditar";
            this.cBEditar.Size = new System.Drawing.Size(53, 17);
            this.cBEditar.TabIndex = 7;
            this.cBEditar.Text = "Editar";
            this.cBEditar.UseVisualStyleBackColor = true;
            // 
            // cBBuscar
            // 
            this.cBBuscar.AutoSize = true;
            this.cBBuscar.Location = new System.Drawing.Point(215, 210);
            this.cBBuscar.Name = "cBBuscar";
            this.cBBuscar.Size = new System.Drawing.Size(59, 17);
            this.cBBuscar.TabIndex = 8;
            this.cBBuscar.Text = "Buscar";
            this.cBBuscar.UseVisualStyleBackColor = true;
            // 
            // cBCancelar
            // 
            this.cBCancelar.AutoSize = true;
            this.cBCancelar.Location = new System.Drawing.Point(215, 255);
            this.cBCancelar.Name = "cBCancelar";
            this.cBCancelar.Size = new System.Drawing.Size(68, 17);
            this.cBCancelar.TabIndex = 9;
            this.cBCancelar.Text = "Cancelar";
            this.cBCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditaGuarda
            // 
            this.btnEditaGuarda.Image = global::ManejoAsignacionAplicacion.Properties.Resources.guardar;
            this.btnEditaGuarda.Location = new System.Drawing.Point(346, 158);
            this.btnEditaGuarda.Name = "btnEditaGuarda";
            this.btnEditaGuarda.Size = new System.Drawing.Size(75, 69);
            this.btnEditaGuarda.TabIndex = 10;
            this.btnEditaGuarda.Text = "Guardar";
            this.btnEditaGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditaGuarda.UseVisualStyleBackColor = true;
            this.btnEditaGuarda.Click += new System.EventHandler(this.btnEditaGuarda_Click);
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 318);
            this.Controls.Add(this.btnEditaGuarda);
            this.Controls.Add(this.cBCancelar);
            this.Controls.Add(this.cBBuscar);
            this.Controls.Add(this.cBEditar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameUser);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.cbEliminar);
            this.Controls.Add(this.cbInsertar);
            this.Controls.Add(this.lbxEditaAppAsig);
            this.Name = "frmEditar";
            this.Text = "frmEditar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxEditaAppAsig;
        private System.Windows.Forms.CheckBox cbInsertar;
        private System.Windows.Forms.CheckBox cbEliminar;
        public System.Windows.Forms.TextBox txtNameUser;
        public System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBEditar;
        private System.Windows.Forms.CheckBox cBBuscar;
        private System.Windows.Forms.CheckBox cBCancelar;
        private System.Windows.Forms.Button btnEditaGuarda;
    }
}