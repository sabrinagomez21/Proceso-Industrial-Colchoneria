namespace Graficador
{
    partial class frmGrafica
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
            this.zgc = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // zgc
            // 
            this.zgc.Location = new System.Drawing.Point(-3, 1);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0D;
            this.zgc.ScrollMaxX = 0D;
            this.zgc.ScrollMaxY = 0D;
            this.zgc.ScrollMaxY2 = 0D;
            this.zgc.ScrollMinX = 0D;
            this.zgc.ScrollMinY = 0D;
            this.zgc.ScrollMinY2 = 0D;
            this.zgc.Size = new System.Drawing.Size(489, 334);
            this.zgc.TabIndex = 1;
            // 
            // frmGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 337);
            this.Controls.Add(this.zgc);
            this.Name = "frmGrafica";
            this.Text = "frmGrafica";
            this.ResumeLayout(false);

        }

        #endregion

        private ZedGraph.ZedGraphControl zgc;
    }
}