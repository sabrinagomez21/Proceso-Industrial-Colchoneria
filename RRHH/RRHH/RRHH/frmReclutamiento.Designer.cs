namespace RRHH
{
    partial class frmReclutamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReclutamiento));
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnrefrescar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnirprimero = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnirultimo = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.cmbCodEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.txtSueldoMax = new System.Windows.Forms.TextBox();
            this.lblSueldoMax = new System.Windows.Forms.Label();
            this.txtSueldoMin = new System.Windows.Forms.TextBox();
            this.lblmin = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.grdReclutamiento = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtImprimir = new System.Windows.Forms.TextBox();
            this.txtCodigoSeleccionado = new System.Windows.Forms.TextBox();
            this.cmbCodigoSeleccionado = new System.Windows.Forms.ComboBox();
            this.lblCodigoPlaza = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.lblCausaSolicitud = new System.Windows.Forms.Label();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblCapacidades = new System.Windows.Forms.Label();
            this.txtCapacidades = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReclutamiento)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.panel3.Location = new System.Drawing.Point(147, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 67);
            this.panel3.TabIndex = 58;
            // 
            // groupBox1
            // 
            this.groupBox1.CausesValidation = false;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtCapacidades);
            this.groupBox1.Controls.Add(this.lblCapacidades);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.txtCodigoEmpresa);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.cmbCodEmpresa);
            this.groupBox1.Controls.Add(this.lblDescripcion);
            this.groupBox1.Controls.Add(this.lblEmpresa);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.txtSueldoMax);
            this.groupBox1.Controls.Add(this.lblSueldoMax);
            this.groupBox1.Controls.Add(this.txtSueldoMin);
            this.groupBox1.Controls.Add(this.lblmin);
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.lblEmpleado);
            this.groupBox1.Controls.Add(this.txtCausa);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.lblCausaSolicitud);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(this.lblDepartamento);
            this.groupBox1.Controls.Add(this.lblHorario);
            this.groupBox1.Controls.Add(this.txtHorario);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 238);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Plaza";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cmbEstado.Location = new System.Drawing.Point(424, 112);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(100, 21);
            this.cmbEstado.TabIndex = 18;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(840, 125);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(17, 20);
            this.txtCodigoEmpresa.TabIndex = 16;
            this.txtCodigoEmpresa.Tag = "ncodempresa";
            this.txtCodigoEmpresa.Visible = false;
            // 
            // cmbCodEmpresa
            // 
            this.cmbCodEmpresa.FormattingEnabled = true;
            this.cmbCodEmpresa.Location = new System.Drawing.Point(736, 98);
            this.cmbCodEmpresa.Name = "cmbCodEmpresa";
            this.cmbCodEmpresa.Size = new System.Drawing.Size(121, 21);
            this.cmbCodEmpresa.TabIndex = 13;
            this.cmbCodEmpresa.SelectedIndexChanged += new System.EventHandler(this.cmbCodEmpresa_SelectedIndexChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(621, 97);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEmpresa.Size = new System.Drawing.Size(114, 19);
            this.lblEmpresa.TabIndex = 12;
            this.lblEmpresa.Text = "Codigo Empresa";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(424, 78);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 11;
            this.txtHorario.Tag = "vhorario";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.Location = new System.Drawing.Point(240, 77);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(57, 19);
            this.lblHorario.TabIndex = 10;
            this.lblHorario.Text = "Horario";
            // 
            // txtSueldoMax
            // 
            this.txtSueldoMax.Location = new System.Drawing.Point(741, 54);
            this.txtSueldoMax.Name = "txtSueldoMax";
            this.txtSueldoMax.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoMax.TabIndex = 9;
            this.txtSueldoMax.Tag = "dsueldomax";
            // 
            // lblSueldoMax
            // 
            this.lblSueldoMax.AutoSize = true;
            this.lblSueldoMax.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldoMax.Location = new System.Drawing.Point(630, 53);
            this.lblSueldoMax.Name = "lblSueldoMax";
            this.lblSueldoMax.Size = new System.Drawing.Size(108, 19);
            this.lblSueldoMax.TabIndex = 8;
            this.lblSueldoMax.Text = "Sueldo Maximo";
            // 
            // txtSueldoMin
            // 
            this.txtSueldoMin.Location = new System.Drawing.Point(741, 15);
            this.txtSueldoMin.Name = "txtSueldoMin";
            this.txtSueldoMin.Size = new System.Drawing.Size(100, 20);
            this.txtSueldoMin.TabIndex = 7;
            this.txtSueldoMin.Tag = "dsueldomin";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(630, 15);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(105, 19);
            this.lblmin.TabIndex = 6;
            this.lblmin.Text = "Sueldo Minimo";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(424, 148);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(181, 66);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.Tag = "vdescripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(240, 147);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(123, 19);
            this.lblDescripcion.TabIndex = 4;
            this.lblDescripcion.Text = "Descripcion Plaza";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.Location = new System.Drawing.Point(240, 114);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(53, 19);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Estado";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(530, 115);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(34, 20);
            this.txtTipo.TabIndex = 3;
            this.txtTipo.Tag = "vtipo";
            this.txtTipo.Visible = false;
            // 
            // grdReclutamiento
            // 
            this.grdReclutamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReclutamiento.Location = new System.Drawing.Point(6, 19);
            this.grdReclutamiento.Name = "grdReclutamiento";
            this.grdReclutamiento.Size = new System.Drawing.Size(882, 194);
            this.grdReclutamiento.TabIndex = 60;
            this.grdReclutamiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdReclutamiento_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdReclutamiento);
            this.groupBox2.Location = new System.Drawing.Point(12, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 219);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Plazas Disponibles";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtImprimir);
            this.groupBox3.Controls.Add(this.txtCodigoSeleccionado);
            this.groupBox3.Controls.Add(this.cmbCodigoSeleccionado);
            this.groupBox3.Controls.Add(this.lblCodigoPlaza);
            this.groupBox3.Location = new System.Drawing.Point(661, 125);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 99);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar, Modificar";
            // 
            // txtImprimir
            // 
            this.txtImprimir.Location = new System.Drawing.Point(15, 68);
            this.txtImprimir.Name = "txtImprimir";
            this.txtImprimir.Size = new System.Drawing.Size(121, 20);
            this.txtImprimir.TabIndex = 3;
            this.txtImprimir.Visible = false;
            // 
            // txtCodigoSeleccionado
            // 
            this.txtCodigoSeleccionado.Location = new System.Drawing.Point(142, 41);
            this.txtCodigoSeleccionado.Name = "txtCodigoSeleccionado";
            this.txtCodigoSeleccionado.Size = new System.Drawing.Size(20, 20);
            this.txtCodigoSeleccionado.TabIndex = 2;
            this.txtCodigoSeleccionado.Tag = "vtipo";
            this.txtCodigoSeleccionado.Visible = false;
            // 
            // cmbCodigoSeleccionado
            // 
            this.cmbCodigoSeleccionado.FormattingEnabled = true;
            this.cmbCodigoSeleccionado.Location = new System.Drawing.Point(15, 41);
            this.cmbCodigoSeleccionado.Name = "cmbCodigoSeleccionado";
            this.cmbCodigoSeleccionado.Size = new System.Drawing.Size(121, 21);
            this.cmbCodigoSeleccionado.TabIndex = 1;
            this.cmbCodigoSeleccionado.SelectedIndexChanged += new System.EventHandler(this.cmbCodigoSeleccionado_SelectedIndexChanged);
            // 
            // lblCodigoPlaza
            // 
            this.lblCodigoPlaza.AutoSize = true;
            this.lblCodigoPlaza.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPlaza.Location = new System.Drawing.Point(17, 24);
            this.lblCodigoPlaza.Name = "lblCodigoPlaza";
            this.lblCodigoPlaza.Size = new System.Drawing.Size(78, 15);
            this.lblCodigoPlaza.TabIndex = 0;
            this.lblCodigoPlaza.Text = "Codigo Plaza";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(10, 21);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(102, 19);
            this.lblDepartamento.TabIndex = 19;
            this.lblDepartamento.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(118, 20);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtDepartamento.TabIndex = 20;
            this.txtDepartamento.Tag = "vdepartamento";
            // 
            // lblCausaSolicitud
            // 
            this.lblCausaSolicitud.AutoSize = true;
            this.lblCausaSolicitud.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCausaSolicitud.Location = new System.Drawing.Point(10, 60);
            this.lblCausaSolicitud.Name = "lblCausaSolicitud";
            this.lblCausaSolicitud.Size = new System.Drawing.Size(108, 19);
            this.lblCausaSolicitud.TabIndex = 21;
            this.lblCausaSolicitud.Text = "Causa Solicitud";
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(18, 82);
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(200, 51);
            this.txtCausa.TabIndex = 22;
            this.txtCausa.Tag = "vcausasolicitud";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(14, 145);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(73, 19);
            this.lblEmpleado.TabIndex = 23;
            this.lblEmpleado.Text = "Empleado";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(125, 146);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 24;
            this.txtEmpleado.Tag = "vtipoempleado";
            // 
            // lblCapacidades
            // 
            this.lblCapacidades.AutoSize = true;
            this.lblCapacidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacidades.Location = new System.Drawing.Point(240, 20);
            this.lblCapacidades.Name = "lblCapacidades";
            this.lblCapacidades.Size = new System.Drawing.Size(169, 19);
            this.lblCapacidades.TabIndex = 25;
            this.lblCapacidades.Text = "Capacidades Requeridas";
            // 
            // txtCapacidades
            // 
            this.txtCapacidades.Location = new System.Drawing.Point(424, 15);
            this.txtCapacidades.Multiline = true;
            this.txtCapacidades.Name = "txtCapacidades";
            this.txtCapacidades.Size = new System.Drawing.Size(200, 57);
            this.txtCapacidades.TabIndex = 26;
            this.txtCapacidades.Tag = "vcapacidadesrequeridas";
            // 
            // frmReclutamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(922, 591);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReclutamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reclutamiento";
            this.Load += new System.EventHandler(this.frmReclutamiento_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdReclutamiento)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnrefrescar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnirprimero;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnirultimo;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grdReclutamiento;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox cmbCodEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.TextBox txtSueldoMax;
        private System.Windows.Forms.Label lblSueldoMax;
        private System.Windows.Forms.TextBox txtSueldoMin;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtImprimir;
        private System.Windows.Forms.TextBox txtCodigoSeleccionado;
        private System.Windows.Forms.ComboBox cmbCodigoSeleccionado;
        private System.Windows.Forms.Label lblCodigoPlaza;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txtCapacidades;
        private System.Windows.Forms.Label lblCapacidades;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Label lblCausaSolicitud;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label lblDepartamento;



    }
}