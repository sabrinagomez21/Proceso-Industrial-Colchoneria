namespace Errores
{
    partial class frmBuscarUsuari
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
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaccept = new System.Windows.Forms.Button();
            this.dvgbuscar = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgbuscar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncancel
            // 
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.Image = global::Errores.Properties.Resources.cancelar;
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(273, 332);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(89, 39);
            this.btncancel.TabIndex = 11;
            this.btncancel.Text = "Cancelar";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnaccept
            // 
            this.btnaccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaccept.Enabled = false;
            this.btnaccept.Image = global::Errores.Properties.Resources.aceptar;
            this.btnaccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaccept.Location = new System.Drawing.Point(163, 332);
            this.btnaccept.Name = "btnaccept";
            this.btnaccept.Size = new System.Drawing.Size(84, 39);
            this.btnaccept.TabIndex = 10;
            this.btnaccept.Text = "Aceptar";
            this.btnaccept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnaccept.UseVisualStyleBackColor = true;
            this.btnaccept.Click += new System.EventHandler(this.btnaccept_Click);
            // 
            // dvgbuscar
            // 
            this.dvgbuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgbuscar.Location = new System.Drawing.Point(27, 106);
            this.dvgbuscar.Name = "dvgbuscar";
            this.dvgbuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgbuscar.Size = new System.Drawing.Size(581, 220);
            this.dvgbuscar.TabIndex = 9;
            this.dvgbuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgbuscar_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(75, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::Errores.Properties.Resources.buscar;
            this.btnsearch.Location = new System.Drawing.Point(401, 22);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(46, 42);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.Location = new System.Drawing.Point(190, 51);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(190, 26);
            this.txtlastname.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(190, 12);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(190, 26);
            this.txtname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnsalir
            // 
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.Image = global::Errores.Properties.Resources.salir;
            this.btnsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsalir.Location = new System.Drawing.Point(387, 332);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(89, 39);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(639, 372);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnaccept);
            this.Controls.Add(this.dvgbuscar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBuscarUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.dvgbuscar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaccept;
        private System.Windows.Forms.DataGridView dvgbuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalir;
    }
}