namespace Inventario
{
    partial class Frm_OrdenDeCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenDeCompra));
            this.DGV_OrdenCompra = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIrUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnIrPrimero = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cmb_Statusorden = new System.Windows.Forms.ComboBox();
            this.Cmb_ncodarticulo = new System.Windows.Forms.ComboBox();
            this.Cmb_ncodproveedor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_ncostototal = new System.Windows.Forms.TextBox();
            this.Txt_ncantidad = new System.Windows.Forms.TextBox();
            this.Txt_vdescripcioncompra = new System.Windows.Forms.TextBox();
            this.Txt_ncodordencompra = new System.Windows.Forms.TextBox();
            this.Txt_vstatus = new System.Windows.Forms.TextBox();
            this.Txt_vstatusorden = new System.Windows.Forms.TextBox();
            this.Txt_ncodarticulo = new System.Windows.Forms.TextBox();
            this.Txt_ncodproveedor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrdenCompra)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_OrdenCompra
            // 
            this.DGV_OrdenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_OrdenCompra.Location = new System.Drawing.Point(36, 243);
            this.DGV_OrdenCompra.Name = "DGV_OrdenCompra";
            this.DGV_OrdenCompra.ReadOnly = true;
            this.DGV_OrdenCompra.Size = new System.Drawing.Size(653, 183);
            this.DGV_OrdenCompra.TabIndex = 0;
            this.DGV_OrdenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_OrdenCompra_CellClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnIrUltimo);
            this.panel3.Controls.Add(this.btnSiguiente);
            this.panel3.Controls.Add(this.btnAnterior);
            this.panel3.Controls.Add(this.btnIrPrimero);
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.btnRefrescar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnNuevo);
            this.panel3.Location = new System.Drawing.Point(36, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(653, 51);
            this.panel3.TabIndex = 10;
            // 
            // btnIrUltimo
            // 
            this.btnIrUltimo.Enabled = false;
            this.btnIrUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnIrUltimo.Image")));
            this.btnIrUltimo.Location = new System.Drawing.Point(597, 4);
            this.btnIrUltimo.Name = "btnIrUltimo";
            this.btnIrUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnIrUltimo.TabIndex = 16;
            this.btnIrUltimo.UseVisualStyleBackColor = true;
            this.btnIrUltimo.Click += new System.EventHandler(this.btnIrUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(543, 4);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnSiguiente.TabIndex = 15;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.Location = new System.Drawing.Point(489, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(48, 42);
            this.btnAnterior.TabIndex = 14;
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnIrPrimero
            // 
            this.btnIrPrimero.Enabled = false;
            this.btnIrPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnIrPrimero.Image")));
            this.btnIrPrimero.Location = new System.Drawing.Point(435, 3);
            this.btnIrPrimero.Name = "btnIrPrimero";
            this.btnIrPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnIrPrimero.TabIndex = 13;
            this.btnIrPrimero.UseVisualStyleBackColor = true;
            this.btnIrPrimero.Click += new System.EventHandler(this.btnIrPrimero_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(381, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 42);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(327, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(48, 42);
            this.btnImprimir.TabIndex = 11;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(273, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(219, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(165, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(111, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(57, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(3, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cmb_Statusorden);
            this.panel1.Controls.Add(this.Cmb_ncodarticulo);
            this.panel1.Controls.Add(this.Cmb_ncodproveedor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Txt_ncostototal);
            this.panel1.Controls.Add(this.Txt_ncantidad);
            this.panel1.Controls.Add(this.Txt_vdescripcioncompra);
            this.panel1.Controls.Add(this.Txt_ncodordencompra);
            this.panel1.Location = new System.Drawing.Point(36, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 155);
            this.panel1.TabIndex = 11;
            // 
            // Cmb_Statusorden
            // 
            this.Cmb_Statusorden.Enabled = false;
            this.Cmb_Statusorden.FormattingEnabled = true;
            this.Cmb_Statusorden.Items.AddRange(new object[] {
            "inicial",
            "terminada"});
            this.Cmb_Statusorden.Location = new System.Drawing.Point(336, 94);
            this.Cmb_Statusorden.Name = "Cmb_Statusorden";
            this.Cmb_Statusorden.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Statusorden.TabIndex = 16;
            this.Cmb_Statusorden.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Cmb_ncodarticulo
            // 
            this.Cmb_ncodarticulo.Enabled = false;
            this.Cmb_ncodarticulo.FormattingEnabled = true;
            this.Cmb_ncodarticulo.Location = new System.Drawing.Point(35, 94);
            this.Cmb_ncodarticulo.Name = "Cmb_ncodarticulo";
            this.Cmb_ncodarticulo.Size = new System.Drawing.Size(121, 21);
            this.Cmb_ncodarticulo.TabIndex = 15;
            this.Cmb_ncodarticulo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Cmb_ncodproveedor
            // 
            this.Cmb_ncodproveedor.Enabled = false;
            this.Cmb_ncodproveedor.FormattingEnabled = true;
            this.Cmb_ncodproveedor.Location = new System.Drawing.Point(184, 94);
            this.Cmb_ncodproveedor.Name = "Cmb_ncodproveedor";
            this.Cmb_ncodproveedor.Size = new System.Drawing.Size(121, 21);
            this.Cmb_ncodproveedor.TabIndex = 14;
            this.Cmb_ncodproveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estatus de Orden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Articulo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Costo Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(212, 81);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(56, 13);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orden de Compra";
            // 
            // Txt_ncostototal
            // 
            this.Txt_ncostototal.Enabled = false;
            this.Txt_ncostototal.Location = new System.Drawing.Point(184, 33);
            this.Txt_ncostototal.Name = "Txt_ncostototal";
            this.Txt_ncostototal.Size = new System.Drawing.Size(121, 20);
            this.Txt_ncostototal.TabIndex = 4;
            this.Txt_ncostototal.Tag = "ncostototal";
            this.Txt_ncostototal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ncostototal_KeyPress);
            // 
            // Txt_ncantidad
            // 
            this.Txt_ncantidad.Enabled = false;
            this.Txt_ncantidad.Location = new System.Drawing.Point(336, 34);
            this.Txt_ncantidad.Name = "Txt_ncantidad";
            this.Txt_ncantidad.Size = new System.Drawing.Size(121, 20);
            this.Txt_ncantidad.TabIndex = 3;
            this.Txt_ncantidad.Tag = "ncantidad";
            this.Txt_ncantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ncantidad_KeyPress);
            // 
            // Txt_vdescripcioncompra
            // 
            this.Txt_vdescripcioncompra.Enabled = false;
            this.Txt_vdescripcioncompra.Location = new System.Drawing.Point(477, 33);
            this.Txt_vdescripcioncompra.Multiline = true;
            this.Txt_vdescripcioncompra.Name = "Txt_vdescripcioncompra";
            this.Txt_vdescripcioncompra.Size = new System.Drawing.Size(139, 82);
            this.Txt_vdescripcioncompra.TabIndex = 2;
            this.Txt_vdescripcioncompra.Tag = "vdescripcioncompra";
            this.Txt_vdescripcioncompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_vdescripcioncompra_KeyPress);
            // 
            // Txt_ncodordencompra
            // 
            this.Txt_ncodordencompra.Enabled = false;
            this.Txt_ncodordencompra.Location = new System.Drawing.Point(35, 33);
            this.Txt_ncodordencompra.Name = "Txt_ncodordencompra";
            this.Txt_ncodordencompra.Size = new System.Drawing.Size(121, 20);
            this.Txt_ncodordencompra.TabIndex = 0;
            this.Txt_ncodordencompra.Tag = "ncodordencompra";
            this.Txt_ncodordencompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_ncodordencompra_KeyPress);
            // 
            // Txt_vstatus
            // 
            this.Txt_vstatus.Location = new System.Drawing.Point(676, 208);
            this.Txt_vstatus.Name = "Txt_vstatus";
            this.Txt_vstatus.Size = new System.Drawing.Size(100, 20);
            this.Txt_vstatus.TabIndex = 20;
            this.Txt_vstatus.Tag = "vstatus";
            this.Txt_vstatus.Visible = false;
            // 
            // Txt_vstatusorden
            // 
            this.Txt_vstatusorden.Enabled = false;
            this.Txt_vstatusorden.Location = new System.Drawing.Point(676, 182);
            this.Txt_vstatusorden.Name = "Txt_vstatusorden";
            this.Txt_vstatusorden.Size = new System.Drawing.Size(100, 20);
            this.Txt_vstatusorden.TabIndex = 19;
            this.Txt_vstatusorden.Tag = "vstatusorden";
            this.Txt_vstatusorden.Visible = false;
            // 
            // Txt_ncodarticulo
            // 
            this.Txt_ncodarticulo.Enabled = false;
            this.Txt_ncodarticulo.Location = new System.Drawing.Point(676, 130);
            this.Txt_ncodarticulo.Name = "Txt_ncodarticulo";
            this.Txt_ncodarticulo.Size = new System.Drawing.Size(100, 20);
            this.Txt_ncodarticulo.TabIndex = 18;
            this.Txt_ncodarticulo.Tag = "ncodarticulo";
            this.Txt_ncodarticulo.Visible = false;
            // 
            // Txt_ncodproveedor
            // 
            this.Txt_ncodproveedor.Enabled = false;
            this.Txt_ncodproveedor.Location = new System.Drawing.Point(676, 156);
            this.Txt_ncodproveedor.Name = "Txt_ncodproveedor";
            this.Txt_ncodproveedor.Size = new System.Drawing.Size(100, 20);
            this.Txt_ncodproveedor.TabIndex = 17;
            this.Txt_ncodproveedor.Tag = "ncodproveedor";
            this.Txt_ncodproveedor.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Salir";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(341, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 50);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_OrdenDeCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 529);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Txt_vstatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_vstatusorden);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DGV_OrdenCompra);
            this.Controls.Add(this.Txt_ncodarticulo);
            this.Controls.Add(this.Txt_ncodproveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_OrdenDeCompra";
            this.Text = "Frm_OrdenDeCompra";
            this.Load += new System.EventHandler(this.Frm_OrdenDeCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_OrdenCompra)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_OrdenCompra;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIrUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnIrPrimero;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Txt_ncodordencompra;
        private System.Windows.Forms.ComboBox Cmb_ncodproveedor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_ncostototal;
        private System.Windows.Forms.TextBox Txt_ncantidad;
        private System.Windows.Forms.TextBox Txt_vdescripcioncompra;
        private System.Windows.Forms.ComboBox Cmb_ncodarticulo;
        private System.Windows.Forms.ComboBox Cmb_Statusorden;
        private System.Windows.Forms.TextBox Txt_vstatusorden;
        private System.Windows.Forms.TextBox Txt_ncodarticulo;
        private System.Windows.Forms.TextBox Txt_ncodproveedor;
        private System.Windows.Forms.TextBox Txt_vstatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}