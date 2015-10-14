namespace Errores
{
    partial class frmErrores
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
            this.components = new System.ComponentModel.Container();
            this.dgvErroresSistema = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblSalir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErroresSistema
            // 
            this.dgvErroresSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErroresSistema.Location = new System.Drawing.Point(28, 76);
            this.dgvErroresSistema.Name = "dgvErroresSistema";
            this.dgvErroresSistema.Size = new System.Drawing.Size(865, 443);
            this.dgvErroresSistema.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(47, 57);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(51, 15);
            this.lblbuscar.TabIndex = 48;
            this.lblbuscar.Text = "Buscar";
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::Errores.Properties.Resources.buscar;
            this.btnsearch.Location = new System.Drawing.Point(50, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 42);
            this.btnsearch.TabIndex = 47;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Errores.Properties.Resources.salir;
            this.btnSalir.Location = new System.Drawing.Point(837, 560);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 42);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblSalir
            // 
            this.lblSalir.AutoSize = true;
            this.lblSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalir.Location = new System.Drawing.Point(844, 605);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(37, 15);
            this.lblSalir.TabIndex = 50;
            this.lblSalir.Text = "Salir";
            // 
            // frmErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 629);
            this.Controls.Add(this.lblSalir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgvErroresSistema);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmErrores";
            this.Text = "Errores del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErroresSistema;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblSalir;
    }
}