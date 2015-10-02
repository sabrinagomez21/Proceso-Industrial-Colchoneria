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
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvErroresSistema
            // 
            this.dgvErroresSistema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErroresSistema.Location = new System.Drawing.Point(28, 76);
            this.dgvErroresSistema.Name = "dgvErroresSistema";
            this.dgvErroresSistema.Size = new System.Drawing.Size(863, 443);
            this.dgvErroresSistema.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmErrores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 562);
            this.Controls.Add(this.dgvErroresSistema);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmErrores";
            this.Text = "Errores del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErroresSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvErroresSistema;
        public System.Windows.Forms.Timer timer1;
    }
}