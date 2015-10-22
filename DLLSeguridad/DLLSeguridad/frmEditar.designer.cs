namespace DLLSeguridad
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
            this.btnEditaGuarda = new System.Windows.Forms.Button();
            this.cBCancelar = new System.Windows.Forms.CheckBox();
            this.cBNuevo = new System.Windows.Forms.CheckBox();
            this.cBActualizar = new System.Windows.Forms.CheckBox();
            this.cBImprimir = new System.Windows.Forms.CheckBox();
            this.cBPrimReg = new System.Windows.Forms.CheckBox();
            this.cBAntReg = new System.Windows.Forms.CheckBox();
            this.cBSigReg = new System.Windows.Forms.CheckBox();
            this.cBUltReg = new System.Windows.Forms.CheckBox();
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
            this.cbInsertar.Image = global::DLLSeguridad.Properties.Resources.guardar;
            this.cbInsertar.Location = new System.Drawing.Point(159, 125);
            this.cbInsertar.Name = "cbInsertar";
            this.cbInsertar.Size = new System.Drawing.Size(93, 32);
            this.cbInsertar.TabIndex = 1;
            this.cbInsertar.Text = "Insertar";
            this.cbInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cbInsertar.UseVisualStyleBackColor = true;
            // 
            // cbEliminar
            // 
            this.cbEliminar.AutoSize = true;
            this.cbEliminar.Image = global::DLLSeguridad.Properties.Resources.eliminar;
            this.cbEliminar.Location = new System.Drawing.Point(159, 163);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(94, 32);
            this.cbEliminar.TabIndex = 2;
            this.cbEliminar.Text = "Eliminar";
            this.cbEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
            this.cBEditar.Image = global::DLLSeguridad.Properties.Resources.editar1;
            this.cBEditar.Location = new System.Drawing.Point(156, 201);
            this.cBEditar.Name = "cBEditar";
            this.cBEditar.Size = new System.Drawing.Size(96, 43);
            this.cBEditar.TabIndex = 7;
            this.cBEditar.Text = "Editar";
            this.cBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBEditar.UseVisualStyleBackColor = true;
            // 
            // cBBuscar
            // 
            this.cBBuscar.AutoSize = true;
            this.cBBuscar.Image = global::DLLSeguridad.Properties.Resources.buscar1;
            this.cBBuscar.Location = new System.Drawing.Point(156, 250);
            this.cBBuscar.Name = "cBBuscar";
            this.cBBuscar.Size = new System.Drawing.Size(91, 32);
            this.cBBuscar.TabIndex = 8;
            this.cBBuscar.Text = "Buscar";
            this.cBBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEditaGuarda
            // 
            this.btnEditaGuarda.Image = global::DLLSeguridad.Properties.Resources.guardar;
            this.btnEditaGuarda.Location = new System.Drawing.Point(435, 153);
            this.btnEditaGuarda.Name = "btnEditaGuarda";
            this.btnEditaGuarda.Size = new System.Drawing.Size(75, 69);
            this.btnEditaGuarda.TabIndex = 10;
            this.btnEditaGuarda.Text = "Guardar";
            this.btnEditaGuarda.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditaGuarda.UseVisualStyleBackColor = true;
            this.btnEditaGuarda.Click += new System.EventHandler(this.btnEditaGuarda_Click);
            // 
            // cBCancelar
            // 
            this.cBCancelar.Image = global::DLLSeguridad.Properties.Resources.cancelar;
            this.cBCancelar.Location = new System.Drawing.Point(156, 288);
            this.cBCancelar.Name = "cBCancelar";
            this.cBCancelar.Size = new System.Drawing.Size(100, 46);
            this.cBCancelar.TabIndex = 11;
            this.cBCancelar.Text = "Cancelar";
            this.cBCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBCancelar.UseVisualStyleBackColor = true;
            // 
            // cBNuevo
            // 
            this.cBNuevo.AutoSize = true;
            this.cBNuevo.Image = global::DLLSeguridad.Properties.Resources.nuevo;
            this.cBNuevo.Location = new System.Drawing.Point(162, 87);
            this.cBNuevo.Name = "cBNuevo";
            this.cBNuevo.Size = new System.Drawing.Size(90, 32);
            this.cBNuevo.TabIndex = 12;
            this.cBNuevo.Text = "Nuevo";
            this.cBNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBNuevo.UseVisualStyleBackColor = true;
            // 
            // cBActualizar
            // 
            this.cBActualizar.AutoSize = true;
            this.cBActualizar.Image = global::DLLSeguridad.Properties.Resources.refresh;
            this.cBActualizar.Location = new System.Drawing.Point(292, 95);
            this.cBActualizar.Name = "cBActualizar";
            this.cBActualizar.Size = new System.Drawing.Size(104, 32);
            this.cBActualizar.TabIndex = 13;
            this.cBActualizar.Text = "Actualizar";
            this.cBActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBActualizar.UseVisualStyleBackColor = true;
            // 
            // cBImprimir
            // 
            this.cBImprimir.AutoSize = true;
            this.cBImprimir.Image = global::DLLSeguridad.Properties.Resources.imprimir;
            this.cBImprimir.Location = new System.Drawing.Point(292, 133);
            this.cBImprimir.Name = "cBImprimir";
            this.cBImprimir.Size = new System.Drawing.Size(93, 32);
            this.cBImprimir.TabIndex = 14;
            this.cBImprimir.Text = "Imprimir";
            this.cBImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBImprimir.UseVisualStyleBackColor = true;
            // 
            // cBPrimReg
            // 
            this.cBPrimReg.AutoSize = true;
            this.cBPrimReg.Image = global::DLLSeguridad.Properties.Resources.go_to_first;
            this.cBPrimReg.Location = new System.Drawing.Point(292, 177);
            this.cBPrimReg.Name = "cBPrimReg";
            this.cBPrimReg.Size = new System.Drawing.Size(129, 32);
            this.cBPrimReg.TabIndex = 15;
            this.cBPrimReg.Text = "Primer Registro";
            this.cBPrimReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBPrimReg.UseVisualStyleBackColor = true;
            // 
            // cBAntReg
            // 
            this.cBAntReg.AutoSize = true;
            this.cBAntReg.Image = global::DLLSeguridad.Properties.Resources.anterior;
            this.cBAntReg.Location = new System.Drawing.Point(292, 216);
            this.cBAntReg.Name = "cBAntReg";
            this.cBAntReg.Size = new System.Drawing.Size(136, 32);
            this.cBAntReg.TabIndex = 16;
            this.cBAntReg.Text = "Anterior Registro";
            this.cBAntReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBAntReg.UseVisualStyleBackColor = true;
            // 
            // cBSigReg
            // 
            this.cBSigReg.AutoSize = true;
            this.cBSigReg.Image = global::DLLSeguridad.Properties.Resources.go_next;
            this.cBSigReg.Location = new System.Drawing.Point(292, 258);
            this.cBSigReg.Name = "cBSigReg";
            this.cBSigReg.Size = new System.Drawing.Size(144, 32);
            this.cBSigReg.TabIndex = 17;
            this.cBSigReg.Text = "Siguiente Registro";
            this.cBSigReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBSigReg.UseVisualStyleBackColor = true;
            // 
            // cBUltReg
            // 
            this.cBUltReg.AutoSize = true;
            this.cBUltReg.Image = global::DLLSeguridad.Properties.Resources.go_to_last;
            this.cBUltReg.Location = new System.Drawing.Point(292, 302);
            this.cBUltReg.Name = "cBUltReg";
            this.cBUltReg.Size = new System.Drawing.Size(129, 32);
            this.cBUltReg.TabIndex = 18;
            this.cBUltReg.Text = "Ultimo Registro";
            this.cBUltReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBUltReg.UseVisualStyleBackColor = true;
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 357);
            this.Controls.Add(this.cBUltReg);
            this.Controls.Add(this.cBSigReg);
            this.Controls.Add(this.cBAntReg);
            this.Controls.Add(this.cBPrimReg);
            this.Controls.Add(this.cBImprimir);
            this.Controls.Add(this.cBActualizar);
            this.Controls.Add(this.cBNuevo);
            this.Controls.Add(this.cBCancelar);
            this.Controls.Add(this.btnEditaGuarda);
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
        private System.Windows.Forms.Button btnEditaGuarda;
        private System.Windows.Forms.CheckBox cBCancelar;
        private System.Windows.Forms.CheckBox cBNuevo;
        private System.Windows.Forms.CheckBox cBActualizar;
        private System.Windows.Forms.CheckBox cBImprimir;
        private System.Windows.Forms.CheckBox cBPrimReg;
        private System.Windows.Forms.CheckBox cBAntReg;
        private System.Windows.Forms.CheckBox cBSigReg;
        private System.Windows.Forms.CheckBox cBUltReg;
    }
}