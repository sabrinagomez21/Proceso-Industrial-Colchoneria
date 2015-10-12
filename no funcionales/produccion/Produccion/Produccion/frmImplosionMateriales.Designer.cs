namespace Produccion
{
    partial class frmImplosionMateriales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImplosionMateriales));
            this.lProductoTerminado = new System.Windows.Forms.Label();
            this.lMaximoAFabricar = new System.Windows.Forms.Label();
            this.txtProductoTerminado = new System.Windows.Forms.TextBox();
            this.txtMaximoAFarbicar = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lProductoTerminado
            // 
            this.lProductoTerminado.AutoSize = true;
            this.lProductoTerminado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductoTerminado.Location = new System.Drawing.Point(11, 18);
            this.lProductoTerminado.Name = "lProductoTerminado";
            this.lProductoTerminado.Size = new System.Drawing.Size(142, 19);
            this.lProductoTerminado.TabIndex = 0;
            this.lProductoTerminado.Text = "Producto Terminado:";
            // 
            // lMaximoAFabricar
            // 
            this.lMaximoAFabricar.AutoSize = true;
            this.lMaximoAFabricar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMaximoAFabricar.Location = new System.Drawing.Point(11, 58);
            this.lMaximoAFabricar.Name = "lMaximoAFabricar";
            this.lMaximoAFabricar.Size = new System.Drawing.Size(133, 19);
            this.lMaximoAFabricar.TabIndex = 1;
            this.lMaximoAFabricar.Text = "Máximo a Fabricar:";
            // 
            // txtProductoTerminado
            // 
            this.txtProductoTerminado.Location = new System.Drawing.Point(159, 18);
            this.txtProductoTerminado.Name = "txtProductoTerminado";
            this.txtProductoTerminado.Size = new System.Drawing.Size(172, 20);
            this.txtProductoTerminado.TabIndex = 2;
            // 
            // txtMaximoAFarbicar
            // 
            this.txtMaximoAFarbicar.Location = new System.Drawing.Point(159, 58);
            this.txtMaximoAFarbicar.Name = "txtMaximoAFarbicar";
            this.txtMaximoAFarbicar.Size = new System.Drawing.Size(172, 20);
            this.txtMaximoAFarbicar.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(350, 18);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 4;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(12, 99);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(512, 374);
            this.dgvDetalle.TabIndex = 5;
            // 
            // frmImplosionMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 485);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtMaximoAFarbicar);
            this.Controls.Add(this.txtProductoTerminado);
            this.Controls.Add(this.lMaximoAFabricar);
            this.Controls.Add(this.lProductoTerminado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmImplosionMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Implosión de Materiales";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductoTerminado;
        private System.Windows.Forms.Label lMaximoAFabricar;
        private System.Windows.Forms.TextBox txtProductoTerminado;
        private System.Windows.Forms.TextBox txtMaximoAFarbicar;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}