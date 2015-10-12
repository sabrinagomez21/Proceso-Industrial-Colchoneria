namespace Produccion
{
    partial class frmOrden
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrden));
            this.lOrden = new System.Windows.Forms.Label();
            this.lProducto = new System.Windows.Forms.Label();
            this.lInicio = new System.Windows.Forms.Label();
            this.lEntrega = new System.Windows.Forms.Label();
            this.lUltMovimiento = new System.Windows.Forms.Label();
            this.txtOrden = new System.Windows.Forms.TextBox();
            this.txtUltMovimiento = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lReferencia = new System.Windows.Forms.Label();
            this.lLinea = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lFabricar = new System.Windows.Forms.Label();
            this.lTerminada = new System.Windows.Forms.Label();
            this.lFaltante = new System.Windows.Forms.Label();
            this.txtFabricar = new System.Windows.Forms.TextBox();
            this.txtTerminada = new System.Windows.Forms.TextBox();
            this.txtFaltante = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lOrden
            // 
            this.lOrden.AutoSize = true;
            this.lOrden.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrden.Location = new System.Drawing.Point(11, 18);
            this.lOrden.Name = "lOrden";
            this.lOrden.Size = new System.Drawing.Size(53, 19);
            this.lOrden.TabIndex = 0;
            this.lOrden.Text = "Orden:";
            // 
            // lProducto
            // 
            this.lProducto.AutoSize = true;
            this.lProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProducto.Location = new System.Drawing.Point(11, 58);
            this.lProducto.Name = "lProducto";
            this.lProducto.Size = new System.Drawing.Size(70, 19);
            this.lProducto.TabIndex = 1;
            this.lProducto.Text = "Producto:";
            // 
            // lInicio
            // 
            this.lInicio.AutoSize = true;
            this.lInicio.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lInicio.Location = new System.Drawing.Point(11, 98);
            this.lInicio.Name = "lInicio";
            this.lInicio.Size = new System.Drawing.Size(48, 19);
            this.lInicio.TabIndex = 2;
            this.lInicio.Text = "Inicio:";
            // 
            // lEntrega
            // 
            this.lEntrega.AutoSize = true;
            this.lEntrega.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEntrega.Location = new System.Drawing.Point(11, 138);
            this.lEntrega.Name = "lEntrega";
            this.lEntrega.Size = new System.Drawing.Size(63, 19);
            this.lEntrega.TabIndex = 3;
            this.lEntrega.Text = "Entrega:";
            // 
            // lUltMovimiento
            // 
            this.lUltMovimiento.AutoSize = true;
            this.lUltMovimiento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUltMovimiento.Location = new System.Drawing.Point(11, 178);
            this.lUltMovimiento.Name = "lUltMovimiento";
            this.lUltMovimiento.Size = new System.Drawing.Size(137, 19);
            this.lUltMovimiento.TabIndex = 4;
            this.lUltMovimiento.Text = "Ultimo Movimiento:";
            // 
            // txtOrden
            // 
            this.txtOrden.Location = new System.Drawing.Point(154, 18);
            this.txtOrden.Name = "txtOrden";
            this.txtOrden.Size = new System.Drawing.Size(161, 20);
            this.txtOrden.TabIndex = 5;
            // 
            // txtUltMovimiento
            // 
            this.txtUltMovimiento.Location = new System.Drawing.Point(154, 178);
            this.txtUltMovimiento.Name = "txtUltMovimiento";
            this.txtUltMovimiento.Size = new System.Drawing.Size(161, 20);
            this.txtUltMovimiento.TabIndex = 6;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(154, 58);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(161, 20);
            this.txtProducto.TabIndex = 7;
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(154, 98);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(161, 20);
            this.txtInicio.TabIndex = 8;
            // 
            // txtEntrega
            // 
            this.txtEntrega.Location = new System.Drawing.Point(154, 138);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(161, 20);
            this.txtEntrega.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 20);
            this.textBox1.TabIndex = 10;
            // 
            // lReferencia
            // 
            this.lReferencia.AutoSize = true;
            this.lReferencia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReferencia.Location = new System.Drawing.Point(361, 98);
            this.lReferencia.Name = "lReferencia";
            this.lReferencia.Size = new System.Drawing.Size(83, 19);
            this.lReferencia.TabIndex = 11;
            this.lReferencia.Text = "Referencia:";
            // 
            // lLinea
            // 
            this.lLinea.AutoSize = true;
            this.lLinea.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLinea.Location = new System.Drawing.Point(361, 138);
            this.lLinea.Name = "lLinea";
            this.lLinea.Size = new System.Drawing.Size(48, 19);
            this.lLinea.TabIndex = 12;
            this.lLinea.Text = "Linea:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 18);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(361, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(426, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(450, 98);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(450, 138);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            // 
            // lFabricar
            // 
            this.lFabricar.AutoSize = true;
            this.lFabricar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFabricar.Location = new System.Drawing.Point(600, 98);
            this.lFabricar.Name = "lFabricar";
            this.lFabricar.Size = new System.Drawing.Size(65, 19);
            this.lFabricar.TabIndex = 17;
            this.lFabricar.Text = "Fabricar:";
            // 
            // lTerminada
            // 
            this.lTerminada.AutoSize = true;
            this.lTerminada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTerminada.Location = new System.Drawing.Point(600, 138);
            this.lTerminada.Name = "lTerminada";
            this.lTerminada.Size = new System.Drawing.Size(81, 19);
            this.lTerminada.TabIndex = 18;
            this.lTerminada.Text = "Terminada:";
            // 
            // lFaltante
            // 
            this.lFaltante.AutoSize = true;
            this.lFaltante.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFaltante.Location = new System.Drawing.Point(600, 178);
            this.lFaltante.Name = "lFaltante";
            this.lFaltante.Size = new System.Drawing.Size(66, 19);
            this.lFaltante.TabIndex = 19;
            this.lFaltante.Text = "Faltante:";
            // 
            // txtFabricar
            // 
            this.txtFabricar.Location = new System.Drawing.Point(687, 98);
            this.txtFabricar.Name = "txtFabricar";
            this.txtFabricar.Size = new System.Drawing.Size(100, 20);
            this.txtFabricar.TabIndex = 20;
            // 
            // txtTerminada
            // 
            this.txtTerminada.Location = new System.Drawing.Point(687, 138);
            this.txtTerminada.Name = "txtTerminada";
            this.txtTerminada.Size = new System.Drawing.Size(100, 20);
            this.txtTerminada.TabIndex = 21;
            // 
            // txtFaltante
            // 
            this.txtFaltante.Location = new System.Drawing.Point(687, 178);
            this.txtFaltante.Name = "txtFaltante";
            this.txtFaltante.Size = new System.Drawing.Size(100, 20);
            this.txtFaltante.TabIndex = 22;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(628, 18);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(53, 19);
            this.lStatus.TabIndex = 23;
            this.lStatus.Text = "Status:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(687, 18);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(450, 218);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(337, 20);
            this.textBox7.TabIndex = 25;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(11, 254);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(776, 263);
            this.dgvDetalle.TabIndex = 26;
            // 
            // frmOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 529);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.txtFaltante);
            this.Controls.Add(this.txtTerminada);
            this.Controls.Add(this.txtFabricar);
            this.Controls.Add(this.lFaltante);
            this.Controls.Add(this.lTerminada);
            this.Controls.Add(this.lFabricar);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lLinea);
            this.Controls.Add(this.lReferencia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtEntrega);
            this.Controls.Add(this.txtInicio);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtUltMovimiento);
            this.Controls.Add(this.txtOrden);
            this.Controls.Add(this.lUltMovimiento);
            this.Controls.Add(this.lEntrega);
            this.Controls.Add(this.lInicio);
            this.Controls.Add(this.lProducto);
            this.Controls.Add(this.lOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Seguimiento por Orden";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lOrden;
        private System.Windows.Forms.Label lProducto;
        private System.Windows.Forms.Label lInicio;
        private System.Windows.Forms.Label lEntrega;
        private System.Windows.Forms.Label lUltMovimiento;
        private System.Windows.Forms.TextBox txtOrden;
        private System.Windows.Forms.TextBox txtUltMovimiento;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtInicio;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lReferencia;
        private System.Windows.Forms.Label lLinea;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lFabricar;
        private System.Windows.Forms.Label lTerminada;
        private System.Windows.Forms.Label lFaltante;
        private System.Windows.Forms.TextBox txtFabricar;
        private System.Windows.Forms.TextBox txtTerminada;
        private System.Windows.Forms.TextBox txtFaltante;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}

