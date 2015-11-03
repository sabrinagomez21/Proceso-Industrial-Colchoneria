namespace RRHH
{
    partial class frmPRINCIPAL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPRINCIPAL));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dETALLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTRATACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELECCIONDEPERSONALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTRATADOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELACIONESLABORALESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLANILLAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.griDatos = new System.Windows.Forms.DataGridView();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dETALLEToolStripMenuItem,
            this.cONTRATACIONESToolStripMenuItem,
            this.cONTRATADOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(742, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dETALLEToolStripMenuItem
            // 
            this.dETALLEToolStripMenuItem.Name = "dETALLEToolStripMenuItem";
            this.dETALLEToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.dETALLEToolStripMenuItem.Text = "DETALLE";
            this.dETALLEToolStripMenuItem.Click += new System.EventHandler(this.dETALLEToolStripMenuItem_Click);
            // 
            // cONTRATACIONESToolStripMenuItem
            // 
            this.cONTRATACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem,
            this.sELECCIONDEPERSONALToolStripMenuItem});
            this.cONTRATACIONESToolStripMenuItem.Name = "cONTRATACIONESToolStripMenuItem";
            this.cONTRATACIONESToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.cONTRATACIONESToolStripMenuItem.Text = "CONTRATACIONES";
            this.cONTRATACIONESToolStripMenuItem.Click += new System.EventHandler(this.cONTRATACIONESToolStripMenuItem_Click);
            // 
            // rECLUTAMIENTODEPERSONALToolStripMenuItem
            // 
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem.Name = "rECLUTAMIENTODEPERSONALToolStripMenuItem";
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem.Text = "RECLUTAMIENTO DE PERSONAL";
            this.rECLUTAMIENTODEPERSONALToolStripMenuItem.Click += new System.EventHandler(this.rECLUTAMIENTODEPERSONALToolStripMenuItem_Click);
            // 
            // sELECCIONDEPERSONALToolStripMenuItem
            // 
            this.sELECCIONDEPERSONALToolStripMenuItem.Name = "sELECCIONDEPERSONALToolStripMenuItem";
            this.sELECCIONDEPERSONALToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.sELECCIONDEPERSONALToolStripMenuItem.Text = "DETALLE CONTRATO";
            this.sELECCIONDEPERSONALToolStripMenuItem.Click += new System.EventHandler(this.sELECCIONDEPERSONALToolStripMenuItem_Click);
            // 
            // cONTRATADOSToolStripMenuItem
            // 
            this.cONTRATADOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem,
            this.rELACIONESLABORALESToolStripMenuItem,
            this.pLANILLAToolStripMenuItem});
            this.cONTRATADOSToolStripMenuItem.Name = "cONTRATADOSToolStripMenuItem";
            this.cONTRATADOSToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.cONTRATADOSToolStripMenuItem.Text = "CONTRATADOS";
            // 
            // cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem
            // 
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem.Name = "cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem";
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem.Text = "CAPACITACION Y DESARROLLO DE PERSONAL";
            this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem.Click += new System.EventHandler(this.cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem_Click_1);
            // 
            // rELACIONESLABORALESToolStripMenuItem
            // 
            this.rELACIONESLABORALESToolStripMenuItem.Name = "rELACIONESLABORALESToolStripMenuItem";
            this.rELACIONESLABORALESToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.rELACIONESLABORALESToolStripMenuItem.Text = "RELACIONES LABORALES";
            this.rELACIONESLABORALESToolStripMenuItem.Click += new System.EventHandler(this.rELACIONESLABORALESToolStripMenuItem_Click_1);
            // 
            // pLANILLAToolStripMenuItem
            // 
            this.pLANILLAToolStripMenuItem.Name = "pLANILLAToolStripMenuItem";
            this.pLANILLAToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.pLANILLAToolStripMenuItem.Text = "PLANILLA";
            this.pLANILLAToolStripMenuItem.Click += new System.EventHandler(this.pLANILLAToolStripMenuItem_Click_1);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(295, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 48);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // griDatos
            // 
            this.griDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griDatos.Location = new System.Drawing.Point(25, 109);
            this.griDatos.Name = "griDatos";
            this.griDatos.Size = new System.Drawing.Size(195, 150);
            this.griDatos.TabIndex = 3;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(25, 265);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(192, 192);
            this.axAcroPDF1.TabIndex = 4;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 56);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmPRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.griDatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPRINCIPAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recursos Humanos";
            this.Load += new System.EventHandler(this.frmPRINCIPAL_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dETALLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTRATACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rECLUTAMIENTODEPERSONALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELECCIONDEPERSONALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONTRATADOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAPACITACIONYDESARROLLODEPERSONALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELACIONESLABORALESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLANILLAToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView griDatos;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
    }
}