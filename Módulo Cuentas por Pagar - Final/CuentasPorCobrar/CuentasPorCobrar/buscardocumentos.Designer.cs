﻿namespace Navegador
{
    partial class buscardocumentos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbentre = new System.Windows.Forms.RadioButton();
            this.rbigual = new System.Windows.Forms.RadioButton();
            this.rbmenor = new System.Windows.Forms.RadioButton();
            this.rbmayor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.griddatosBusqueda = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddatosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbentre);
            this.groupBox1.Controls.Add(this.rbigual);
            this.groupBox1.Controls.Add(this.rbmenor);
            this.groupBox1.Controls.Add(this.rbmayor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 105);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // rbentre
            // 
            this.rbentre.AutoSize = true;
            this.rbentre.Location = new System.Drawing.Point(104, 74);
            this.rbentre.Name = "rbentre";
            this.rbentre.Size = new System.Drawing.Size(50, 17);
            this.rbentre.TabIndex = 21;
            this.rbentre.TabStop = true;
            this.rbentre.Text = "Entre";
            this.rbentre.UseVisualStyleBackColor = true;
            this.rbentre.CheckedChanged += new System.EventHandler(this.rbentre_CheckedChanged);
            // 
            // rbigual
            // 
            this.rbigual.AutoSize = true;
            this.rbigual.Location = new System.Drawing.Point(104, 51);
            this.rbigual.Name = "rbigual";
            this.rbigual.Size = new System.Drawing.Size(48, 17);
            this.rbigual.TabIndex = 20;
            this.rbigual.TabStop = true;
            this.rbigual.Text = "Igual";
            this.rbigual.UseVisualStyleBackColor = true;
            this.rbigual.CheckedChanged += new System.EventHandler(this.rbigual_CheckedChanged);
            // 
            // rbmenor
            // 
            this.rbmenor.AutoSize = true;
            this.rbmenor.Location = new System.Drawing.Point(7, 72);
            this.rbmenor.Name = "rbmenor";
            this.rbmenor.Size = new System.Drawing.Size(55, 17);
            this.rbmenor.TabIndex = 19;
            this.rbmenor.TabStop = true;
            this.rbmenor.Text = "Menor";
            this.rbmenor.UseVisualStyleBackColor = true;
            this.rbmenor.CheckedChanged += new System.EventHandler(this.rbmenor_CheckedChanged);
            // 
            // rbmayor
            // 
            this.rbmayor.AutoSize = true;
            this.rbmayor.Location = new System.Drawing.Point(7, 49);
            this.rbmayor.Name = "rbmayor";
            this.rbmayor.Size = new System.Drawing.Size(54, 17);
            this.rbmayor.TabIndex = 18;
            this.rbmayor.TabStop = true;
            this.rbmayor.Text = "Mayor";
            this.rbmayor.UseVisualStyleBackColor = true;
            this.rbmayor.CheckedChanged += new System.EventHandler(this.rbmayor_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Condición:";
            // 
            // griddatosBusqueda
            // 
            this.griddatosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddatosBusqueda.Location = new System.Drawing.Point(81, 214);
            this.griddatosBusqueda.Name = "griddatosBusqueda";
            this.griddatosBusqueda.Size = new System.Drawing.Size(408, 150);
            this.griddatosBusqueda.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(194, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Campo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 14;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buscardocumentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 379);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.griddatosBusqueda);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "buscardocumentos";
            this.Text = "buscardocumentos";
            this.Load += new System.EventHandler(this.buscardocumentos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.griddatosBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbentre;
        private System.Windows.Forms.RadioButton rbigual;
        private System.Windows.Forms.RadioButton rbmenor;
        private System.Windows.Forms.RadioButton rbmayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView griddatosBusqueda;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}