namespace prueba1
{
    partial class Frm_AdminReporte
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
            this.Gv_Reporte = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AReporte = new System.Windows.Forms.Button();
            this.Btn_EReporte = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Reporte)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gv_Reporte
            // 
            this.Gv_Reporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gv_Reporte.Location = new System.Drawing.Point(271, 12);
            this.Gv_Reporte.Name = "Gv_Reporte";
            this.Gv_Reporte.Size = new System.Drawing.Size(224, 245);
            this.Gv_Reporte.TabIndex = 0;
            this.Gv_Reporte.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Reporte_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(68, 9);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(161, 20);
            this.Txt_Nombre.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_EReporte);
            this.panel1.Controls.Add(this.Btn_AReporte);
            this.panel1.Controls.Add(this.Txt_Nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 109);
            this.panel1.TabIndex = 3;
            // 
            // Btn_AReporte
            // 
            this.Btn_AReporte.Location = new System.Drawing.Point(18, 76);
            this.Btn_AReporte.Name = "Btn_AReporte";
            this.Btn_AReporte.Size = new System.Drawing.Size(98, 23);
            this.Btn_AReporte.TabIndex = 3;
            this.Btn_AReporte.Text = "Agregar Reporte";
            this.Btn_AReporte.UseVisualStyleBackColor = true;
            this.Btn_AReporte.Click += new System.EventHandler(this.Btn_AReporte_Click);
            // 
            // Btn_EReporte
            // 
            this.Btn_EReporte.Location = new System.Drawing.Point(131, 76);
            this.Btn_EReporte.Name = "Btn_EReporte";
            this.Btn_EReporte.Size = new System.Drawing.Size(98, 23);
            this.Btn_EReporte.TabIndex = 4;
            this.Btn_EReporte.Text = "Eliminar Reporte";
            this.Btn_EReporte.UseVisualStyleBackColor = true;
            this.Btn_EReporte.Click += new System.EventHandler(this.Btn_EReporte_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 260);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(100, 221);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_AdminReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 282);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gv_Reporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AdminReporte";
            this.Text = "Frm_AdminReporte";
            this.Load += new System.EventHandler(this.Frm_AdminReporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gv_Reporte)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gv_Reporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_EReporte;
        private System.Windows.Forms.Button Btn_AReporte;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
    }
}