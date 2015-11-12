namespace Bancos
{
    partial class frmBancos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manejoDeCuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeCreditoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notaDeDebitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manejoDeCuentasToolStripMenuItem,
            this.historialDeCuentaToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manejoDeCuentasToolStripMenuItem
            // 
            this.manejoDeCuentasToolStripMenuItem.Name = "manejoDeCuentasToolStripMenuItem";
            this.manejoDeCuentasToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.manejoDeCuentasToolStripMenuItem.Text = "Manejo De Cuentas";
            // 
            // historialDeCuentaToolStripMenuItem
            // 
            this.historialDeCuentaToolStripMenuItem.Name = "historialDeCuentaToolStripMenuItem";
            this.historialDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.historialDeCuentaToolStripMenuItem.Text = "Historial De Cuenta";
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notaDeCreditoToolStripMenuItem,
            this.notaDeDebitoToolStripMenuItem,
            this.pagosToolStripMenuItem,
            this.conciliaciónToolStripMenuItem});
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // notaDeCreditoToolStripMenuItem
            // 
            this.notaDeCreditoToolStripMenuItem.Name = "notaDeCreditoToolStripMenuItem";
            this.notaDeCreditoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.notaDeCreditoToolStripMenuItem.Text = "Nota de Credito";
            // 
            // notaDeDebitoToolStripMenuItem
            // 
            this.notaDeDebitoToolStripMenuItem.Name = "notaDeDebitoToolStripMenuItem";
            this.notaDeDebitoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.notaDeDebitoToolStripMenuItem.Text = "Nota de Debito";
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // conciliaciónToolStripMenuItem
            // 
            this.conciliaciónToolStripMenuItem.Name = "conciliaciónToolStripMenuItem";
            this.conciliaciónToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.conciliaciónToolStripMenuItem.Text = "Conciliación";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Estado de Cuenta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBancos";
            this.Text = "frmBancos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manejoDeCuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeCreditoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notaDeDebitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conciliaciónToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}