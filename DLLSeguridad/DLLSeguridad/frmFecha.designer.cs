namespace DLLSeguridad
{
    partial class frmFecha
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
            this.mcFecha1 = new System.Windows.Forms.MonthCalendar();
            this.rbfecha1 = new System.Windows.Forms.RadioButton();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaccept = new System.Windows.Forms.Button();
            this.rbDesactivado = new System.Windows.Forms.RadioButton();
            this.rbfecha2 = new System.Windows.Forms.RadioButton();
            this.mcFecha2 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // mcFecha1
            // 
            this.mcFecha1.Location = new System.Drawing.Point(18, 18);
            this.mcFecha1.MaxSelectionCount = 1;
            this.mcFecha1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.mcFecha1.Name = "mcFecha1";
            this.mcFecha1.TabIndex = 0;
            this.mcFecha1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFecha1_DateChanged);
            // 
            // rbfecha1
            // 
            this.rbfecha1.AutoSize = true;
            this.rbfecha1.Location = new System.Drawing.Point(335, 53);
            this.rbfecha1.Name = "rbfecha1";
            this.rbfecha1.Size = new System.Drawing.Size(78, 17);
            this.rbfecha1.TabIndex = 1;
            this.rbfecha1.TabStop = true;
            this.rbfecha1.Text = "Una Fecha";
            this.rbfecha1.UseVisualStyleBackColor = true;
            this.rbfecha1.Click += new System.EventHandler(this.rbfecha1_CheckedChanged);
            // 
            // btncancel
            // 
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Image = global::DLLSeguridad.Properties.Resources.cancelar;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(400, 132);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(89, 39);
            this.btncancel.TabIndex = 9;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnaccept
            // 
            this.btnaccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaccept.Enabled = false;
            this.btnaccept.Image = global::DLLSeguridad.Properties.Resources.aceptar;
            this.btnaccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccept.Location = new System.Drawing.Point(290, 132);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(84, 39);
            this.btnaccept.TabIndex = 8;
            this.btnaccept.Text = "Aceptar";
            this.btnaccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // rbDesactivado
            // 
            this.rbDesactivado.AutoSize = true;
            this.rbDesactivado.Location = new System.Drawing.Point(335, 32);
            this.rbDesactivado.Name = "rbDesactivado";
            this.rbDesactivado.Size = new System.Drawing.Size(85, 17);
            this.rbDesactivado.TabIndex = 3;
            this.rbDesactivado.TabStop = true;
            this.rbDesactivado.Text = "Desactivado";
            this.rbDesactivado.UseVisualStyleBackColor = true;
            this.rbDesactivado.Click += new System.EventHandler(this.rbDesactivado_CheckedChanged);
            // 
            // rbfecha2
            // 
            this.rbfecha2.AutoSize = true;
            this.rbfecha2.Location = new System.Drawing.Point(335, 76);
            this.rbfecha2.Name = "rbfecha2";
            this.rbfecha2.Size = new System.Drawing.Size(97, 17);
            this.rbfecha2.TabIndex = 2;
            this.rbfecha2.TabStop = true;
            this.rbfecha2.Text = "Entre 2 Fechas";
            this.rbfecha2.UseVisualStyleBackColor = true;
            this.rbfecha2.Click += new System.EventHandler(this.rbfecha2_CheckedChanged);
            // 
            // mcFecha2
            // 
            this.mcFecha2.Location = new System.Drawing.Point(512, 18);
            this.mcFecha2.MaxSelectionCount = 1;
            this.mcFecha2.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.mcFecha2.Name = "mcFecha2";
            this.mcFecha2.TabIndex = 10;
            this.mcFecha2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFecha2_DateChanged);
            // 
            // frmFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 192);
            this.ControlBox = false;
            this.Controls.Add(this.mcFecha2);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.rbDesactivado);
            this.Controls.Add(this.rbfecha2);
            this.Controls.Add(this.rbfecha1);
            this.Controls.Add(this.mcFecha1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFecha";
            this.Text = "Fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcFecha1;
        private System.Windows.Forms.RadioButton rbfecha1;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.RadioButton rbDesactivado;
        private System.Windows.Forms.RadioButton rbfecha2;
        private System.Windows.Forms.MonthCalendar mcFecha2;
    }
}