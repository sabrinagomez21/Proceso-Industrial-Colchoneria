namespace Login
{
    partial class frmRplanilla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRplanilla));
            this.txtHorasEx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSueldoN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsueldoxhe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSueldoB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSueldoxh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.grdRplanilla = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnirultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnirprimero = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdRplanilla)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHorasEx
            // 
            this.txtHorasEx.Location = new System.Drawing.Point(455, 136);
            this.txtHorasEx.Name = "txtHorasEx";
            this.txtHorasEx.Size = new System.Drawing.Size(100, 20);
            this.txtHorasEx.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Hora Extra";
            // 
            // txtSueldoN
            // 
            this.txtSueldoN.Location = new System.Drawing.Point(455, 167);
            this.txtSueldoN.Name = "txtSueldoN";
            this.txtSueldoN.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoN.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Sueldo Neto";
            // 
            // txtsueldoxhe
            // 
            this.txtsueldoxhe.Location = new System.Drawing.Point(265, 136);
            this.txtsueldoxhe.Name = "txtsueldoxhe";
            this.txtsueldoxhe.Size = new System.Drawing.Size(100, 20);
            this.txtsueldoxhe.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Sueldo x Hora Extra";
            // 
            // txtSueldoB
            // 
            this.txtSueldoB.Location = new System.Drawing.Point(455, 109);
            this.txtSueldoB.Name = "txtSueldoB";
            this.txtSueldoB.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoB.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Sueldo Bruto";
            // 
            // txtSueldoxh
            // 
            this.txtSueldoxh.Location = new System.Drawing.Point(266, 109);
            this.txtSueldoxh.Name = "txtSueldoxh";
            this.txtSueldoxh.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoxh.TabIndex = 23;
            this.txtSueldoxh.TextChanged += new System.EventHandler(this.txtSueldoxh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Sueldo x Hora";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Sueldo";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(71, 109);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 20);
            this.txtSueldo.TabIndex = 20;
            this.txtSueldo.TextChanged += new System.EventHandler(this.txtSueldo_TextChanged_1);
            // 
            // grdRplanilla
            // 
            this.grdRplanilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRplanilla.Location = new System.Drawing.Point(28, 210);
            this.grdRplanilla.Name = "grdRplanilla";
            this.grdRplanilla.Size = new System.Drawing.Size(672, 183);
            this.grdRplanilla.TabIndex = 19;
            this.grdRplanilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRplanilla_CellClick);
            this.grdRplanilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRplanilla_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnimprimir);
            this.panel3.Controls.Add(this.btnnuevo);
            this.panel3.Controls.Add(this.btnirultimo);
            this.panel3.Controls.Add(this.btnsiguiente);
            this.panel3.Controls.Add(this.btnanterior);
            this.panel3.Controls.Add(this.btnirprimero);
            this.panel3.Controls.Add(this.btneditar);
            this.panel3.Controls.Add(this.btncancelar);
            this.panel3.Controls.Add(this.btnrefrescar);
            this.panel3.Controls.Add(this.btnbuscar);
            this.panel3.Controls.Add(this.btneliminar);
            this.panel3.Controls.Add(this.btnguardar);
            this.panel3.Location = new System.Drawing.Point(50, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 67);
            this.panel3.TabIndex = 71;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(329, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(47, 50);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(11, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 50);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnirultimo
            // 
            this.btnirultimo.Image = ((System.Drawing.Image)(resources.GetObject("btnirultimo.Image")));
            this.btnirultimo.Location = new System.Drawing.Point(592, 8);
            this.btnirultimo.Name = "btnirultimo";
            this.btnirultimo.Size = new System.Drawing.Size(47, 50);
            this.btnirultimo.TabIndex = 9;
            this.btnirultimo.UseVisualStyleBackColor = true;
            this.btnirultimo.Click += new System.EventHandler(this.btnirultimo_Click_1);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(539, 8);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(47, 50);
            this.btnsiguiente.TabIndex = 8;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click_1);
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(486, 8);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(47, 50);
            this.btnanterior.TabIndex = 7;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click_1);
            // 
            // btnirprimero
            // 
            this.btnirprimero.Image = ((System.Drawing.Image)(resources.GetObject("btnirprimero.Image")));
            this.btnirprimero.Location = new System.Drawing.Point(433, 8);
            this.btnirprimero.Name = "btnirprimero";
            this.btnirprimero.Size = new System.Drawing.Size(47, 50);
            this.btnirprimero.TabIndex = 6;
            this.btnirprimero.UseVisualStyleBackColor = true;
            this.btnirprimero.Click += new System.EventHandler(this.btnirprimero_Click_1);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(64, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(47, 50);
            this.btneditar.TabIndex = 5;
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(223, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(47, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.Location = new System.Drawing.Point(276, 8);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(47, 50);
            this.btnrefrescar.TabIndex = 3;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click_1);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(380, 8);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(117, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 50);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(170, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(47, 50);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // frmRplanilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 426);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtHorasEx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSueldoN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsueldoxhe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSueldoB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSueldoxh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.grdRplanilla);
            this.Name = "frmRplanilla";
            this.Text = "frmRplanilla";
            this.Load += new System.EventHandler(this.frmRplanilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdRplanilla)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHorasEx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSueldoN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsueldoxhe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSueldoB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSueldoxh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.DataGridView grdRplanilla;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnirultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnirprimero;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnguardar;

    }
}