namespace Login
{
    partial class frmReqPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReqPuesto));
            this.gbimpresion = new System.Windows.Forms.GroupBox();
            this.txtimprimir = new System.Windows.Forms.TextBox();
            this.lbimprimir = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.cbcodigo = new System.Windows.Forms.ComboBox();
            this.dgempleado = new System.Windows.Forms.DataGridView();
            this.gbdatosgenerales = new System.Windows.Forms.GroupBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbescolaridad = new System.Windows.Forms.Label();
            this.txtescolaridad = new System.Windows.Forms.TextBox();
            this.lbdpi = new System.Windows.Forms.Label();
            this.lbpuesto = new System.Windows.Forms.Label();
            this.txtdpi = new System.Windows.Forms.TextBox();
            this.txtinvisible = new System.Windows.Forms.TextBox();
            this.gbdatospersonales = new System.Windows.Forms.GroupBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.lbgenero = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.lbestadocivil = new System.Windows.Forms.Label();
            this.txtestadocivil = new System.Windows.Forms.TextBox();
            this.lbapellido = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbsalario = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.txtsalario = new System.Windows.Forms.TextBox();
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
            this.gbimpresion.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).BeginInit();
            this.gbdatosgenerales.SuspendLayout();
            this.gbdatospersonales.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbsalario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbimpresion
            // 
            this.gbimpresion.Controls.Add(this.txtimprimir);
            this.gbimpresion.Controls.Add(this.lbimprimir);
            this.gbimpresion.Location = new System.Drawing.Point(789, 368);
            this.gbimpresion.Name = "gbimpresion";
            this.gbimpresion.Size = new System.Drawing.Size(272, 61);
            this.gbimpresion.TabIndex = 74;
            this.gbimpresion.TabStop = false;
            this.gbimpresion.Text = "Impresion";
            // 
            // txtimprimir
            // 
            this.txtimprimir.Location = new System.Drawing.Point(75, 22);
            this.txtimprimir.Name = "txtimprimir";
            this.txtimprimir.Size = new System.Drawing.Size(191, 20);
            this.txtimprimir.TabIndex = 66;
            this.txtimprimir.Tag = "iparticipantes          ";
            // 
            // lbimprimir
            // 
            this.lbimprimir.AutoSize = true;
            this.lbimprimir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbimprimir.Location = new System.Drawing.Point(6, 21);
            this.lbimprimir.Name = "lbimprimir";
            this.lbimprimir.Size = new System.Drawing.Size(39, 19);
            this.lbimprimir.TabIndex = 65;
            this.lbimprimir.Text = "Ruta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbcodigo);
            this.groupBox2.Controls.Add(this.cbcodigo);
            this.groupBox2.Location = new System.Drawing.Point(789, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 61);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            // 
            // lbcodigo
            // 
            this.lbcodigo.AutoSize = true;
            this.lbcodigo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcodigo.Location = new System.Drawing.Point(6, 21);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(54, 19);
            this.lbcodigo.TabIndex = 65;
            this.lbcodigo.Text = "Codigo";
            // 
            // cbcodigo
            // 
            this.cbcodigo.FormattingEnabled = true;
            this.cbcodigo.Location = new System.Drawing.Point(72, 22);
            this.cbcodigo.Name = "cbcodigo";
            this.cbcodigo.Size = new System.Drawing.Size(194, 21);
            this.cbcodigo.TabIndex = 64;
            // 
            // dgempleado
            // 
            this.dgempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgempleado.Location = new System.Drawing.Point(21, 301);
            this.dgempleado.Name = "dgempleado";
            this.dgempleado.Size = new System.Drawing.Size(736, 246);
            this.dgempleado.TabIndex = 72;
            // 
            // gbdatosgenerales
            // 
            this.gbdatosgenerales.Controls.Add(this.txttelefono);
            this.gbdatosgenerales.Controls.Add(this.lbtelefono);
            this.gbdatosgenerales.Controls.Add(this.lbescolaridad);
            this.gbdatosgenerales.Controls.Add(this.txtescolaridad);
            this.gbdatosgenerales.Controls.Add(this.lbdpi);
            this.gbdatosgenerales.Controls.Add(this.lbpuesto);
            this.gbdatosgenerales.Controls.Add(this.txtdpi);
            this.gbdatosgenerales.Controls.Add(this.txtinvisible);
            this.gbdatosgenerales.Location = new System.Drawing.Point(21, 188);
            this.gbdatosgenerales.Name = "gbdatosgenerales";
            this.gbdatosgenerales.Size = new System.Drawing.Size(736, 96);
            this.gbdatosgenerales.TabIndex = 71;
            this.gbdatosgenerales.TabStop = false;
            this.gbdatosgenerales.Text = "Datos generales";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(462, 60);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(259, 20);
            this.txttelefono.TabIndex = 11;
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtelefono.Location = new System.Drawing.Point(391, 60);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(65, 19);
            this.lbtelefono.TabIndex = 8;
            this.lbtelefono.Text = "Telefono";
            // 
            // lbescolaridad
            // 
            this.lbescolaridad.AutoSize = true;
            this.lbescolaridad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbescolaridad.Location = new System.Drawing.Point(16, 50);
            this.lbescolaridad.Name = "lbescolaridad";
            this.lbescolaridad.Size = new System.Drawing.Size(84, 19);
            this.lbescolaridad.TabIndex = 6;
            this.lbescolaridad.Text = "Escolaridad";
            // 
            // txtescolaridad
            // 
            this.txtescolaridad.Location = new System.Drawing.Point(127, 51);
            this.txtescolaridad.Name = "txtescolaridad";
            this.txtescolaridad.Size = new System.Drawing.Size(239, 20);
            this.txtescolaridad.TabIndex = 5;
            // 
            // lbdpi
            // 
            this.lbdpi.AutoSize = true;
            this.lbdpi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdpi.Location = new System.Drawing.Point(391, 15);
            this.lbdpi.Name = "lbdpi";
            this.lbdpi.Size = new System.Drawing.Size(31, 19);
            this.lbdpi.TabIndex = 4;
            this.lbdpi.Text = "DPI";
            // 
            // lbpuesto
            // 
            this.lbpuesto.AutoSize = true;
            this.lbpuesto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuesto.Location = new System.Drawing.Point(16, 18);
            this.lbpuesto.Name = "lbpuesto";
            this.lbpuesto.Size = new System.Drawing.Size(105, 19);
            this.lbpuesto.TabIndex = 3;
            this.lbpuesto.Text = "Tipo de puesto";
            // 
            // txtdpi
            // 
            this.txtdpi.Location = new System.Drawing.Point(462, 15);
            this.txtdpi.Name = "txtdpi";
            this.txtdpi.Size = new System.Drawing.Size(259, 20);
            this.txtdpi.TabIndex = 1;
            // 
            // txtinvisible
            // 
            this.txtinvisible.Location = new System.Drawing.Point(127, 17);
            this.txtinvisible.Name = "txtinvisible";
            this.txtinvisible.Size = new System.Drawing.Size(240, 20);
            this.txtinvisible.TabIndex = 0;
            this.txtinvisible.Visible = false;
            // 
            // gbdatospersonales
            // 
            this.gbdatospersonales.Controls.Add(this.txtgenero);
            this.gbdatospersonales.Controls.Add(this.lbgenero);
            this.gbdatospersonales.Controls.Add(this.lbedad);
            this.gbdatospersonales.Controls.Add(this.txtedad);
            this.gbdatospersonales.Controls.Add(this.lbestadocivil);
            this.gbdatospersonales.Controls.Add(this.txtestadocivil);
            this.gbdatospersonales.Controls.Add(this.lbapellido);
            this.gbdatospersonales.Controls.Add(this.lbnombre);
            this.gbdatospersonales.Controls.Add(this.txtapellido);
            this.gbdatospersonales.Controls.Add(this.txtnombre);
            this.gbdatospersonales.Location = new System.Drawing.Point(21, 101);
            this.gbdatospersonales.Name = "gbdatospersonales";
            this.gbdatospersonales.Size = new System.Drawing.Size(736, 81);
            this.gbdatospersonales.TabIndex = 70;
            this.gbdatospersonales.TabStop = false;
            this.gbdatospersonales.Text = "Datos personales";
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(466, 50);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(56, 20);
            this.txtgenero.TabIndex = 10;
            this.txtgenero.Tag = "vgenero";
            // 
            // lbgenero
            // 
            this.lbgenero.AutoSize = true;
            this.lbgenero.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgenero.Location = new System.Drawing.Point(391, 50);
            this.lbgenero.Name = "lbgenero";
            this.lbgenero.Size = new System.Drawing.Size(56, 19);
            this.lbgenero.TabIndex = 9;
            this.lbgenero.Text = "Genero";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbedad.Location = new System.Drawing.Point(618, 51);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(41, 19);
            this.lbedad.TabIndex = 8;
            this.lbedad.Text = "Edad";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(665, 51);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(56, 20);
            this.txtedad.TabIndex = 7;
            // 
            // lbestadocivil
            // 
            this.lbestadocivil.AutoSize = true;
            this.lbestadocivil.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbestadocivil.Location = new System.Drawing.Point(16, 50);
            this.lbestadocivil.Name = "lbestadocivil";
            this.lbestadocivil.Size = new System.Drawing.Size(85, 19);
            this.lbestadocivil.TabIndex = 6;
            this.lbestadocivil.Text = "Estado Civil";
            // 
            // txtestadocivil
            // 
            this.txtestadocivil.Location = new System.Drawing.Point(107, 51);
            this.txtestadocivil.Name = "txtestadocivil";
            this.txtestadocivil.Size = new System.Drawing.Size(259, 20);
            this.txtestadocivil.TabIndex = 5;
            this.txtestadocivil.Tag = "vestadocivil";
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellido.Location = new System.Drawing.Point(391, 16);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(69, 19);
            this.lbapellido.TabIndex = 4;
            this.lbapellido.Text = "Apellidos";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(16, 18);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(67, 19);
            this.lbnombre.TabIndex = 3;
            this.lbnombre.Text = "Nombres";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(466, 15);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(259, 20);
            this.txtapellido.TabIndex = 1;
            this.txtapellido.Tag = "vapeempleado";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(108, 19);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(259, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.Tag = "vnomempleado";
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
            this.panel3.Location = new System.Drawing.Point(170, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 67);
            this.panel3.TabIndex = 69;
            // 
            // gbsalario
            // 
            this.gbsalario.Controls.Add(this.label9);
            this.gbsalario.Controls.Add(this.label10);
            this.gbsalario.Controls.Add(this.label12);
            this.gbsalario.Controls.Add(this.textBox11);
            this.gbsalario.Controls.Add(this.txtsalario);
            this.gbsalario.Location = new System.Drawing.Point(864, 169);
            this.gbsalario.Name = "gbsalario";
            this.gbsalario.Size = new System.Drawing.Size(126, 71);
            this.gbsalario.TabIndex = 75;
            this.gbsalario.TabStop = false;
            this.gbsalario.Text = "Salario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(824, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Escolaridad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(748, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "Edad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(391, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "Apellidos";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(466, 15);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(259, 20);
            this.textBox11.TabIndex = 1;
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(15, 25);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 0;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnimprimir.Image")));
            this.btnimprimir.Location = new System.Drawing.Point(329, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(47, 50);
            this.btnimprimir.TabIndex = 11;
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(11, 8);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(47, 50);
            this.btnnuevo.TabIndex = 10;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnirultimo
            // 
            this.btnirultimo.Image = ((System.Drawing.Image)(resources.GetObject("btnirultimo.Image")));
            this.btnirultimo.Location = new System.Drawing.Point(592, 8);
            this.btnirultimo.Name = "btnirultimo";
            this.btnirultimo.Size = new System.Drawing.Size(47, 50);
            this.btnirultimo.TabIndex = 9;
            this.btnirultimo.UseVisualStyleBackColor = true;
            this.btnirultimo.Click += new System.EventHandler(this.btnirultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnsiguiente.Image")));
            this.btnsiguiente.Location = new System.Drawing.Point(539, 8);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(47, 50);
            this.btnsiguiente.TabIndex = 8;
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Image = ((System.Drawing.Image)(resources.GetObject("btnanterior.Image")));
            this.btnanterior.Location = new System.Drawing.Point(486, 8);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(47, 50);
            this.btnanterior.TabIndex = 7;
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnirprimero
            // 
            this.btnirprimero.Image = ((System.Drawing.Image)(resources.GetObject("btnirprimero.Image")));
            this.btnirprimero.Location = new System.Drawing.Point(433, 8);
            this.btnirprimero.Name = "btnirprimero";
            this.btnirprimero.Size = new System.Drawing.Size(47, 50);
            this.btnirprimero.TabIndex = 6;
            this.btnirprimero.UseVisualStyleBackColor = true;
            this.btnirprimero.Click += new System.EventHandler(this.btnirprimero_Click);
            // 
            // btneditar
            // 
            this.btneditar.Image = ((System.Drawing.Image)(resources.GetObject("btneditar.Image")));
            this.btneditar.Location = new System.Drawing.Point(64, 8);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(47, 50);
            this.btneditar.TabIndex = 5;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(223, 8);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(47, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnrefrescar
            // 
            this.btnrefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnrefrescar.Image")));
            this.btnrefrescar.Location = new System.Drawing.Point(276, 8);
            this.btnrefrescar.Name = "btnrefrescar";
            this.btnrefrescar.Size = new System.Drawing.Size(47, 50);
            this.btnrefrescar.TabIndex = 3;
            this.btnrefrescar.UseVisualStyleBackColor = true;
            this.btnrefrescar.Click += new System.EventHandler(this.btnrefrescar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(380, 8);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(117, 8);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(47, 50);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(170, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(47, 50);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // frmReqPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 588);
            this.Controls.Add(this.gbsalario);
            this.Controls.Add(this.gbimpresion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgempleado);
            this.Controls.Add(this.gbdatosgenerales);
            this.Controls.Add(this.gbdatospersonales);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReqPuesto";
            this.Text = "Ficha Empleado";
            this.gbimpresion.ResumeLayout(false);
            this.gbimpresion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgempleado)).EndInit();
            this.gbdatosgenerales.ResumeLayout(false);
            this.gbdatosgenerales.PerformLayout();
            this.gbdatospersonales.ResumeLayout(false);
            this.gbdatospersonales.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbsalario.ResumeLayout(false);
            this.gbsalario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbimpresion;
        private System.Windows.Forms.TextBox txtimprimir;
        private System.Windows.Forms.Label lbimprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.ComboBox cbcodigo;
        private System.Windows.Forms.DataGridView dgempleado;
        private System.Windows.Forms.GroupBox gbdatosgenerales;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbescolaridad;
        private System.Windows.Forms.TextBox txtescolaridad;
        private System.Windows.Forms.Label lbdpi;
        private System.Windows.Forms.Label lbpuesto;
        private System.Windows.Forms.TextBox txtdpi;
        private System.Windows.Forms.TextBox txtinvisible;
        private System.Windows.Forms.GroupBox gbdatospersonales;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.Label lbgenero;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label lbestadocivil;
        private System.Windows.Forms.TextBox txtestadocivil;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
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
        private System.Windows.Forms.GroupBox gbsalario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox txtsalario;
    }
}