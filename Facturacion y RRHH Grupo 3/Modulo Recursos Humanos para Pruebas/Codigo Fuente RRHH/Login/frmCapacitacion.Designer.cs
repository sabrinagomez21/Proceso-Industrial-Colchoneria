namespace Login
{
    partial class frmCapacitacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCapacitacion));
            this.button2 = new System.Windows.Forms.Button();
            this.gbimpresion = new System.Windows.Forms.GroupBox();
            this.txtimprimir = new System.Windows.Forms.TextBox();
            this.lbimprimir = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.cbcodigo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgcapacitacion = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.gbcapcitacion = new System.Windows.Forms.GroupBox();
            this.txtnombrecapacitacion = new System.Windows.Forms.TextBox();
            this.txtresponsable = new System.Windows.Forms.TextBox();
            this.lbresponsable = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbniveles = new System.Windows.Forms.Label();
            this.gbtipocapacitacion = new System.Windows.Forms.GroupBox();
            this.txttipocapacitacion = new System.Windows.Forms.TextBox();
            this.gbperiodo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.gbparticipantes = new System.Windows.Forms.GroupBox();
            this.txtparticipantes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbobjetivos = new System.Windows.Forms.GroupBox();
            this.lbresultados = new System.Windows.Forms.Label();
            this.txtresultados = new System.Windows.Forms.TextBox();
            this.lbobjetivos = new System.Windows.Forms.Label();
            this.txtrecibeobjetivos = new System.Windows.Forms.TextBox();
            this.gbdeteccion = new System.Windows.Forms.GroupBox();
            this.lbnecesidad = new System.Windows.Forms.Label();
            this.lbdetalle = new System.Windows.Forms.Label();
            this.txtrecibenecesidad = new System.Windows.Forms.TextBox();
            this.txtrecibedetalle = new System.Windows.Forms.TextBox();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcapacitacion)).BeginInit();
            this.gbcapcitacion.SuspendLayout();
            this.gbtipocapacitacion.SuspendLayout();
            this.gbperiodo.SuspendLayout();
            this.gbparticipantes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbobjetivos.SuspendLayout();
            this.gbdeteccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1067, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 78;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbimpresion
            // 
            this.gbimpresion.Controls.Add(this.txtimprimir);
            this.gbimpresion.Controls.Add(this.lbimprimir);
            this.gbimpresion.Location = new System.Drawing.Point(181, 554);
            this.gbimpresion.Name = "gbimpresion";
            this.gbimpresion.Size = new System.Drawing.Size(272, 61);
            this.gbimpresion.TabIndex = 77;
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
            this.groupBox2.Location = new System.Drawing.Point(181, 475);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 61);
            this.groupBox2.TabIndex = 76;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgcapacitacion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(615, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 299);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Capacitacion";
            // 
            // dgcapacitacion
            // 
            this.dgcapacitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcapacitacion.Location = new System.Drawing.Point(10, 26);
            this.dgcapacitacion.Name = "dgcapacitacion";
            this.dgcapacitacion.Size = new System.Drawing.Size(578, 267);
            this.dgcapacitacion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 9;
            // 
            // gbcapcitacion
            // 
            this.gbcapcitacion.Controls.Add(this.txtnombrecapacitacion);
            this.gbcapcitacion.Controls.Add(this.txtresponsable);
            this.gbcapcitacion.Controls.Add(this.lbresponsable);
            this.gbcapcitacion.Controls.Add(this.label8);
            this.gbcapcitacion.Controls.Add(this.lbniveles);
            this.gbcapcitacion.Location = new System.Drawing.Point(615, 121);
            this.gbcapcitacion.Name = "gbcapcitacion";
            this.gbcapcitacion.Size = new System.Drawing.Size(594, 84);
            this.gbcapcitacion.TabIndex = 74;
            this.gbcapcitacion.TabStop = false;
            this.gbcapcitacion.Text = "Plan de Capacitacion";
            // 
            // txtnombrecapacitacion
            // 
            this.txtnombrecapacitacion.AcceptsTab = true;
            this.txtnombrecapacitacion.Location = new System.Drawing.Point(245, 55);
            this.txtnombrecapacitacion.Multiline = true;
            this.txtnombrecapacitacion.Name = "txtnombrecapacitacion";
            this.txtnombrecapacitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnombrecapacitacion.ShortcutsEnabled = false;
            this.txtnombrecapacitacion.Size = new System.Drawing.Size(343, 20);
            this.txtnombrecapacitacion.TabIndex = 61;
            this.txtnombrecapacitacion.Tag = "vnombrecapacitacion ";
            // 
            // txtresponsable
            // 
            this.txtresponsable.Location = new System.Drawing.Point(245, 29);
            this.txtresponsable.Name = "txtresponsable";
            this.txtresponsable.Size = new System.Drawing.Size(343, 20);
            this.txtresponsable.TabIndex = 14;
            this.txtresponsable.Tag = "vresponsable ";
            // 
            // lbresponsable
            // 
            this.lbresponsable.AutoSize = true;
            this.lbresponsable.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresponsable.Location = new System.Drawing.Point(12, 28);
            this.lbresponsable.Name = "lbresponsable";
            this.lbresponsable.Size = new System.Drawing.Size(180, 19);
            this.lbresponsable.TabIndex = 13;
            this.lbresponsable.Text = "Responsable Capacitacion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 19);
            this.label8.TabIndex = 9;
            // 
            // lbniveles
            // 
            this.lbniveles.AutoSize = true;
            this.lbniveles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbniveles.Location = new System.Drawing.Point(12, 55);
            this.lbniveles.Name = "lbniveles";
            this.lbniveles.Size = new System.Drawing.Size(148, 19);
            this.lbniveles.TabIndex = 3;
            this.lbniveles.Text = "Nombre Capacitacion";
            // 
            // gbtipocapacitacion
            // 
            this.gbtipocapacitacion.Controls.Add(this.txttipocapacitacion);
            this.gbtipocapacitacion.Location = new System.Drawing.Point(615, 216);
            this.gbtipocapacitacion.Name = "gbtipocapacitacion";
            this.gbtipocapacitacion.Size = new System.Drawing.Size(594, 84);
            this.gbtipocapacitacion.TabIndex = 73;
            this.gbtipocapacitacion.TabStop = false;
            this.gbtipocapacitacion.Text = "Tipo de capacitacion";
            // 
            // txttipocapacitacion
            // 
            this.txttipocapacitacion.AcceptsTab = true;
            this.txttipocapacitacion.Location = new System.Drawing.Point(16, 32);
            this.txttipocapacitacion.Multiline = true;
            this.txttipocapacitacion.Name = "txttipocapacitacion";
            this.txttipocapacitacion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttipocapacitacion.ShortcutsEnabled = false;
            this.txttipocapacitacion.Size = new System.Drawing.Size(572, 33);
            this.txttipocapacitacion.TabIndex = 8;
            this.txttipocapacitacion.Tag = "vtipo                   ";
            // 
            // gbperiodo
            // 
            this.gbperiodo.Controls.Add(this.label2);
            this.gbperiodo.Controls.Add(this.txttiempo);
            this.gbperiodo.Location = new System.Drawing.Point(335, 390);
            this.gbperiodo.Name = "gbperiodo";
            this.gbperiodo.Size = new System.Drawing.Size(266, 79);
            this.gbperiodo.TabIndex = 72;
            this.gbperiodo.TabStop = false;
            this.gbperiodo.Text = "Periodo de tiempo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Indicar Hrs, dias o semanas";
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(14, 42);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(241, 20);
            this.txttiempo.TabIndex = 12;
            this.txttiempo.Tag = "vtiempo                 ";
            // 
            // gbparticipantes
            // 
            this.gbparticipantes.Controls.Add(this.txtparticipantes);
            this.gbparticipantes.Controls.Add(this.label9);
            this.gbparticipantes.Location = new System.Drawing.Point(28, 390);
            this.gbparticipantes.Name = "gbparticipantes";
            this.gbparticipantes.Size = new System.Drawing.Size(276, 79);
            this.gbparticipantes.TabIndex = 71;
            this.gbparticipantes.TabStop = false;
            this.gbparticipantes.Text = "Participantes";
            // 
            // txtparticipantes
            // 
            this.txtparticipantes.Location = new System.Drawing.Point(130, 40);
            this.txtparticipantes.Name = "txtparticipantes";
            this.txtparticipantes.Size = new System.Drawing.Size(140, 20);
            this.txtparticipantes.TabIndex = 11;
            this.txtparticipantes.Tag = "iparticipantes          ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 3;
            this.label9.Text = "Min, 8     Max 15";
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
            this.panel3.Location = new System.Drawing.Point(284, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 67);
            this.panel3.TabIndex = 70;
            // 
            // gbobjetivos
            // 
            this.gbobjetivos.Controls.Add(this.lbresultados);
            this.gbobjetivos.Controls.Add(this.txtresultados);
            this.gbobjetivos.Controls.Add(this.lbobjetivos);
            this.gbobjetivos.Controls.Add(this.txtrecibeobjetivos);
            this.gbobjetivos.Location = new System.Drawing.Point(22, 242);
            this.gbobjetivos.Name = "gbobjetivos";
            this.gbobjetivos.Size = new System.Drawing.Size(579, 128);
            this.gbobjetivos.TabIndex = 69;
            this.gbobjetivos.TabStop = false;
            // 
            // lbresultados
            // 
            this.lbresultados.AutoSize = true;
            this.lbresultados.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresultados.Location = new System.Drawing.Point(6, 74);
            this.lbresultados.Name = "lbresultados";
            this.lbresultados.Size = new System.Drawing.Size(152, 19);
            this.lbresultados.TabIndex = 6;
            this.lbresultados.Text = "Resultados esperados";
            // 
            // txtresultados
            // 
            this.txtresultados.AcceptsTab = true;
            this.txtresultados.Location = new System.Drawing.Point(159, 74);
            this.txtresultados.Multiline = true;
            this.txtresultados.Name = "txtresultados";
            this.txtresultados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtresultados.ShortcutsEnabled = false;
            this.txtresultados.Size = new System.Drawing.Size(409, 32);
            this.txtresultados.TabIndex = 60;
            this.txtresultados.Tag = "vresultadosesperados    ";
            // 
            // lbobjetivos
            // 
            this.lbobjetivos.AutoSize = true;
            this.lbobjetivos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbobjetivos.Location = new System.Drawing.Point(6, 20);
            this.lbobjetivos.Name = "lbobjetivos";
            this.lbobjetivos.Size = new System.Drawing.Size(71, 19);
            this.lbobjetivos.TabIndex = 2;
            this.lbobjetivos.Text = "Objetivos";
            // 
            // txtrecibeobjetivos
            // 
            this.txtrecibeobjetivos.AcceptsTab = true;
            this.txtrecibeobjetivos.Location = new System.Drawing.Point(83, 21);
            this.txtrecibeobjetivos.Multiline = true;
            this.txtrecibeobjetivos.Name = "txtrecibeobjetivos";
            this.txtrecibeobjetivos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrecibeobjetivos.ShortcutsEnabled = false;
            this.txtrecibeobjetivos.Size = new System.Drawing.Size(485, 32);
            this.txtrecibeobjetivos.TabIndex = 59;
            this.txtrecibeobjetivos.Tag = "vobjetivo ";
            // 
            // gbdeteccion
            // 
            this.gbdeteccion.Controls.Add(this.lbnecesidad);
            this.gbdeteccion.Controls.Add(this.lbdetalle);
            this.gbdeteccion.Controls.Add(this.txtrecibenecesidad);
            this.gbdeteccion.Controls.Add(this.txtrecibedetalle);
            this.gbdeteccion.Location = new System.Drawing.Point(22, 112);
            this.gbdeteccion.Name = "gbdeteccion";
            this.gbdeteccion.Size = new System.Drawing.Size(579, 124);
            this.gbdeteccion.TabIndex = 68;
            this.gbdeteccion.TabStop = false;
            this.gbdeteccion.Text = "Deteccion de necesidades";
            // 
            // lbnecesidad
            // 
            this.lbnecesidad.AutoSize = true;
            this.lbnecesidad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnecesidad.Location = new System.Drawing.Point(6, 74);
            this.lbnecesidad.Name = "lbnecesidad";
            this.lbnecesidad.Size = new System.Drawing.Size(183, 19);
            this.lbnecesidad.TabIndex = 4;
            this.lbnecesidad.Text = "Necesidad de capacitacion";
            // 
            // lbdetalle
            // 
            this.lbdetalle.AutoSize = true;
            this.lbdetalle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdetalle.Location = new System.Drawing.Point(6, 20);
            this.lbdetalle.Name = "lbdetalle";
            this.lbdetalle.Size = new System.Drawing.Size(56, 19);
            this.lbdetalle.TabIndex = 2;
            this.lbdetalle.Text = "Detalle";
            // 
            // txtrecibenecesidad
            // 
            this.txtrecibenecesidad.AcceptsTab = true;
            this.txtrecibenecesidad.Location = new System.Drawing.Point(198, 75);
            this.txtrecibenecesidad.Multiline = true;
            this.txtrecibenecesidad.Name = "txtrecibenecesidad";
            this.txtrecibenecesidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrecibenecesidad.ShortcutsEnabled = false;
            this.txtrecibenecesidad.Size = new System.Drawing.Size(370, 33);
            this.txtrecibenecesidad.TabIndex = 7;
            this.txtrecibenecesidad.Tag = " vnecesidad              ";
            // 
            // txtrecibedetalle
            // 
            this.txtrecibedetalle.AcceptsTab = true;
            this.txtrecibedetalle.Location = new System.Drawing.Point(82, 21);
            this.txtrecibedetalle.Multiline = true;
            this.txtrecibedetalle.Name = "txtrecibedetalle";
            this.txtrecibedetalle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtrecibedetalle.ShortcutsEnabled = false;
            this.txtrecibedetalle.Size = new System.Drawing.Size(486, 33);
            this.txtrecibedetalle.TabIndex = 6;
            this.txtrecibedetalle.Tag = "vdetalle";
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
            // frmCapacitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 643);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbimpresion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbcapcitacion);
            this.Controls.Add(this.gbtipocapacitacion);
            this.Controls.Add(this.gbperiodo);
            this.Controls.Add(this.gbparticipantes);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.gbobjetivos);
            this.Controls.Add(this.gbdeteccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCapacitacion";
            this.Text = "Capacitacion";
            this.gbimpresion.ResumeLayout(false);
            this.gbimpresion.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcapacitacion)).EndInit();
            this.gbcapcitacion.ResumeLayout(false);
            this.gbcapcitacion.PerformLayout();
            this.gbtipocapacitacion.ResumeLayout(false);
            this.gbtipocapacitacion.PerformLayout();
            this.gbperiodo.ResumeLayout(false);
            this.gbperiodo.PerformLayout();
            this.gbparticipantes.ResumeLayout(false);
            this.gbparticipantes.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbobjetivos.ResumeLayout(false);
            this.gbobjetivos.PerformLayout();
            this.gbdeteccion.ResumeLayout(false);
            this.gbdeteccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbimpresion;
        private System.Windows.Forms.TextBox txtimprimir;
        private System.Windows.Forms.Label lbimprimir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.ComboBox cbcodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgcapacitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbcapcitacion;
        private System.Windows.Forms.TextBox txtnombrecapacitacion;
        private System.Windows.Forms.TextBox txtresponsable;
        private System.Windows.Forms.Label lbresponsable;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbniveles;
        private System.Windows.Forms.GroupBox gbtipocapacitacion;
        private System.Windows.Forms.TextBox txttipocapacitacion;
        private System.Windows.Forms.GroupBox gbperiodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.GroupBox gbparticipantes;
        private System.Windows.Forms.TextBox txtparticipantes;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.GroupBox gbobjetivos;
        private System.Windows.Forms.Label lbresultados;
        private System.Windows.Forms.TextBox txtresultados;
        private System.Windows.Forms.Label lbobjetivos;
        private System.Windows.Forms.TextBox txtrecibeobjetivos;
        private System.Windows.Forms.GroupBox gbdeteccion;
        private System.Windows.Forms.Label lbnecesidad;
        private System.Windows.Forms.Label lbdetalle;
        private System.Windows.Forms.TextBox txtrecibenecesidad;
        private System.Windows.Forms.TextBox txtrecibedetalle;
    }
}