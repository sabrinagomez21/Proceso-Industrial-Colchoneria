namespace Inventario
{
    partial class Frm_Edicion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Producto = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Orden = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Egresoingreso = new System.Windows.Forms.TextBox();
            this.Btn_ingreso = new System.Windows.Forms.Button();
            this.Txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cbox_tipo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad Existente:";
            // 
            // Txt_Producto
            // 
            this.Txt_Producto.Enabled = false;
            this.Txt_Producto.Location = new System.Drawing.Point(160, 10);
            this.Txt_Producto.Name = "Txt_Producto";
            this.Txt_Producto.Size = new System.Drawing.Size(100, 20);
            this.Txt_Producto.TabIndex = 2;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Enabled = false;
            this.Txt_Cantidad.Location = new System.Drawing.Point(159, 34);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.Txt_Cantidad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "No. Orden";
            // 
            // Txt_Orden
            // 
            this.Txt_Orden.Location = new System.Drawing.Point(159, 58);
            this.Txt_Orden.Name = "Txt_Orden";
            this.Txt_Orden.Size = new System.Drawing.Size(100, 20);
            this.Txt_Orden.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad Egreso/Ingreso";
            // 
            // Txt_Egresoingreso
            // 
            this.Txt_Egresoingreso.Location = new System.Drawing.Point(159, 81);
            this.Txt_Egresoingreso.Name = "Txt_Egresoingreso";
            this.Txt_Egresoingreso.Size = new System.Drawing.Size(100, 20);
            this.Txt_Egresoingreso.TabIndex = 7;
            // 
            // Btn_ingreso
            // 
            this.Btn_ingreso.Image = global::Inventario.Properties.Resources.aceptar;
            this.Btn_ingreso.Location = new System.Drawing.Point(77, 261);
            this.Btn_ingreso.Name = "Btn_ingreso";
            this.Btn_ingreso.Size = new System.Drawing.Size(47, 50);
            this.Btn_ingreso.TabIndex = 8;
            this.Btn_ingreso.UseVisualStyleBackColor = true;
            this.Btn_ingreso.Click += new System.EventHandler(this.Btn_ingreso_Click);
            // 
            // Txt_Descripcion
            // 
            this.Txt_Descripcion.Location = new System.Drawing.Point(82, 117);
            this.Txt_Descripcion.Multiline = true;
            this.Txt_Descripcion.Name = "Txt_Descripcion";
            this.Txt_Descripcion.Size = new System.Drawing.Size(177, 64);
            this.Txt_Descripcion.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Cbox_tipo);
            this.panel1.Controls.Add(this.Txt_Descripcion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Txt_Producto);
            this.panel1.Controls.Add(this.Txt_Cantidad);
            this.panel1.Controls.Add(this.Txt_Egresoingreso);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_Orden);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 243);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de Movimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 13;
            // 
            // Cbox_tipo
            // 
            this.Cbox_tipo.FormattingEnabled = true;
            this.Cbox_tipo.Location = new System.Drawing.Point(160, 187);
            this.Cbox_tipo.Name = "Cbox_tipo";
            this.Cbox_tipo.Size = new System.Drawing.Size(99, 21);
            this.Cbox_tipo.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Image = global::Inventario.Properties.Resources.salir;
            this.button1.Location = new System.Drawing.Point(172, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Aceptar";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Salir";
            // 
            // Frm_Edicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 344);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Btn_ingreso);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Edicion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Producto;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Orden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Egresoingreso;
        private System.Windows.Forms.Button Btn_ingreso;
        private System.Windows.Forms.TextBox Txt_Descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cbox_tipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}