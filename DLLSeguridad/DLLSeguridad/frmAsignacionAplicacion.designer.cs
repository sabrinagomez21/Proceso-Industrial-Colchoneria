namespace DLLSeguridad
{
    partial class frmAsignacionAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionAplicacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoPerfil = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblNombrePerfil = new System.Windows.Forms.Label();
            this.txtNombrePerfil = new System.Windows.Forms.TextBox();
            this.lblQuitar = new System.Windows.Forms.Label();
            this.lblAsignar = new System.Windows.Forms.Label();
            this.lblAplicacionesDisp = new System.Windows.Forms.Label();
            this.lblAplicacionesAsign = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarPerfil = new System.Windows.Forms.Button();
            this.lbxAppAsignadas = new System.Windows.Forms.ListBox();
            this.lbxAppDisponibles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxPermisoAsig = new System.Windows.Forms.ListBox();
            this.PermisoAsignado = new System.Windows.Forms.Label();
            this.cBNuevo = new System.Windows.Forms.CheckBox();
            this.cBUltRegis = new System.Windows.Forms.CheckBox();
            this.cBSigRegis = new System.Windows.Forms.CheckBox();
            this.cBAntRegis = new System.Windows.Forms.CheckBox();
            this.cBPrimRegis = new System.Windows.Forms.CheckBox();
            this.cBImprimir = new System.Windows.Forms.CheckBox();
            this.cBActualizar = new System.Windows.Forms.CheckBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cBCancelar = new System.Windows.Forms.CheckBox();
            this.cBBuscar = new System.Windows.Forms.CheckBox();
            this.cBEditar = new System.Windows.Forms.CheckBox();
            this.cBEliminar = new System.Windows.Forms.CheckBox();
            this.cBInserta = new System.Windows.Forms.CheckBox();
            this.btnQuitarSimple = new System.Windows.Forms.Button();
            this.btnQuitarMuchas = new System.Windows.Forms.Button();
            this.btnAsignacionMuchas = new System.Windows.Forms.Button();
            this.btnAsignacionSimple = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtCodigoPerfil);
            this.groupBox1.Controls.Add(this.lblusuario);
            this.groupBox1.Controls.Add(this.lblNombrePerfil);
            this.groupBox1.Controls.Add(this.txtNombrePerfil);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perfil Seleccionado";
            // 
            // txtCodigoPerfil
            // 
            this.txtCodigoPerfil.Enabled = false;
            this.txtCodigoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPerfil.Location = new System.Drawing.Point(115, 55);
            this.txtCodigoPerfil.Name = "txtCodigoPerfil";
            this.txtCodigoPerfil.Size = new System.Drawing.Size(110, 27);
            this.txtCodigoPerfil.TabIndex = 1;
            this.txtCodigoPerfil.TabStop = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(122, 32);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(98, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Codigo Perfil";
            // 
            // lblNombrePerfil
            // 
            this.lblNombrePerfil.AutoSize = true;
            this.lblNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombrePerfil.Location = new System.Drawing.Point(330, 36);
            this.lblNombrePerfil.Name = "lblNombrePerfil";
            this.lblNombrePerfil.Size = new System.Drawing.Size(103, 16);
            this.lblNombrePerfil.TabIndex = 4;
            this.lblNombrePerfil.Text = "Nombre Perfil";
            // 
            // txtNombrePerfil
            // 
            this.txtNombrePerfil.Enabled = false;
            this.txtNombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombrePerfil.Location = new System.Drawing.Point(261, 55);
            this.txtNombrePerfil.Name = "txtNombrePerfil";
            this.txtNombrePerfil.Size = new System.Drawing.Size(259, 27);
            this.txtNombrePerfil.TabIndex = 3;
            // 
            // lblQuitar
            // 
            this.lblQuitar.AutoSize = true;
            this.lblQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuitar.Location = new System.Drawing.Point(519, 248);
            this.lblQuitar.Name = "lblQuitar";
            this.lblQuitar.Size = new System.Drawing.Size(49, 16);
            this.lblQuitar.TabIndex = 23;
            this.lblQuitar.Text = "Quitar";
            // 
            // lblAsignar
            // 
            this.lblAsignar.AutoSize = true;
            this.lblAsignar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsignar.Location = new System.Drawing.Point(518, 122);
            this.lblAsignar.Name = "lblAsignar";
            this.lblAsignar.Size = new System.Drawing.Size(61, 16);
            this.lblAsignar.TabIndex = 20;
            this.lblAsignar.Text = "Asignar";
            // 
            // lblAplicacionesDisp
            // 
            this.lblAplicacionesDisp.AutoSize = true;
            this.lblAplicacionesDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacionesDisp.Location = new System.Drawing.Point(52, 122);
            this.lblAplicacionesDisp.Name = "lblAplicacionesDisp";
            this.lblAplicacionesDisp.Size = new System.Drawing.Size(185, 16);
            this.lblAplicacionesDisp.TabIndex = 28;
            this.lblAplicacionesDisp.Text = "Aplicaciones Disponibles";
            // 
            // lblAplicacionesAsign
            // 
            this.lblAplicacionesAsign.AutoSize = true;
            this.lblAplicacionesAsign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAplicacionesAsign.Location = new System.Drawing.Point(598, 122);
            this.lblAplicacionesAsign.Name = "lblAplicacionesAsign";
            this.lblAplicacionesAsign.Size = new System.Drawing.Size(176, 16);
            this.lblAplicacionesAsign.TabIndex = 29;
            this.lblAplicacionesAsign.Text = "Aplicaciones Asignadas";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(842, 474);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(60, 34);
            this.btnSalir.TabIndex = 32;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarPerfil
            // 
            this.btnLimpiarPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarPerfil.Location = new System.Drawing.Point(601, 474);
            this.btnLimpiarPerfil.Name = "btnLimpiarPerfil";
            this.btnLimpiarPerfil.Size = new System.Drawing.Size(107, 34);
            this.btnLimpiarPerfil.TabIndex = 31;
            this.btnLimpiarPerfil.Text = "Limpiar Perfiles";
            this.btnLimpiarPerfil.UseVisualStyleBackColor = true;
            this.btnLimpiarPerfil.Click += new System.EventHandler(this.btnLimpiarPerfil_Click);
            // 
            // lbxAppAsignadas
            // 
            this.lbxAppAsignadas.FormattingEnabled = true;
            this.lbxAppAsignadas.Location = new System.Drawing.Point(601, 143);
            this.lbxAppAsignadas.Name = "lbxAppAsignadas";
            this.lbxAppAsignadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAppAsignadas.Size = new System.Drawing.Size(203, 303);
            this.lbxAppAsignadas.TabIndex = 33;
            this.lbxAppAsignadas.SelectedIndexChanged += new System.EventHandler(this.lbxAppAsignadas_SelectedIndexChanged);
            // 
            // lbxAppDisponibles
            // 
            this.lbxAppDisponibles.FormattingEnabled = true;
            this.lbxAppDisponibles.Location = new System.Drawing.Point(42, 143);
            this.lbxAppDisponibles.Name = "lbxAppDisponibles";
            this.lbxAppDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbxAppDisponibles.Size = new System.Drawing.Size(185, 303);
            this.lbxAppDisponibles.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(519, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "Editar";
            // 
            // lbxPermisoAsig
            // 
            this.lbxPermisoAsig.FormattingEnabled = true;
            this.lbxPermisoAsig.Location = new System.Drawing.Point(842, 143);
            this.lbxPermisoAsig.Name = "lbxPermisoAsig";
            this.lbxPermisoAsig.Size = new System.Drawing.Size(123, 160);
            this.lbxPermisoAsig.TabIndex = 43;
            // 
            // PermisoAsignado
            // 
            this.PermisoAsignado.AutoSize = true;
            this.PermisoAsignado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PermisoAsignado.Location = new System.Drawing.Point(822, 124);
            this.PermisoAsignado.Name = "PermisoAsignado";
            this.PermisoAsignado.Size = new System.Drawing.Size(151, 16);
            this.PermisoAsignado.TabIndex = 44;
            this.PermisoAsignado.Text = "Permisos Asignados";
            // 
            // cBNuevo
            // 
            this.cBNuevo.AutoSize = true;
            this.cBNuevo.Image = global::DLLSeguridad.Properties.Resources.nuevo;
            this.cBNuevo.Location = new System.Drawing.Point(241, 141);
            this.cBNuevo.Name = "cBNuevo";
            this.cBNuevo.Size = new System.Drawing.Size(90, 32);
            this.cBNuevo.TabIndex = 52;
            this.cBNuevo.Text = "Nuevo";
            this.cBNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBNuevo.UseVisualStyleBackColor = true;
            // 
            // cBUltRegis
            // 
            this.cBUltRegis.AutoSize = true;
            this.cBUltRegis.Image = global::DLLSeguridad.Properties.Resources.go_to_last;
            this.cBUltRegis.Location = new System.Drawing.Point(368, 404);
            this.cBUltRegis.Name = "cBUltRegis";
            this.cBUltRegis.Size = new System.Drawing.Size(129, 32);
            this.cBUltRegis.TabIndex = 51;
            this.cBUltRegis.Text = "Ultimo Registro";
            this.cBUltRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBUltRegis.UseVisualStyleBackColor = true;
            // 
            // cBSigRegis
            // 
            this.cBSigRegis.Image = global::DLLSeguridad.Properties.Resources.go_next;
            this.cBSigRegis.Location = new System.Drawing.Point(361, 343);
            this.cBSigRegis.Name = "cBSigRegis";
            this.cBSigRegis.Size = new System.Drawing.Size(154, 32);
            this.cBSigRegis.TabIndex = 49;
            this.cBSigRegis.Text = "Siguiente Registro";
            this.cBSigRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBSigRegis.UseVisualStyleBackColor = true;
            // 
            // cBAntRegis
            // 
            this.cBAntRegis.AutoSize = true;
            this.cBAntRegis.Image = global::DLLSeguridad.Properties.Resources.anterior;
            this.cBAntRegis.Location = new System.Drawing.Point(361, 280);
            this.cBAntRegis.Name = "cBAntRegis";
            this.cBAntRegis.Size = new System.Drawing.Size(136, 32);
            this.cBAntRegis.TabIndex = 48;
            this.cBAntRegis.Text = "Anterior Registro";
            this.cBAntRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBAntRegis.UseVisualStyleBackColor = true;
            // 
            // cBPrimRegis
            // 
            this.cBPrimRegis.AutoSize = true;
            this.cBPrimRegis.Image = global::DLLSeguridad.Properties.Resources.go_to_first;
            this.cBPrimRegis.Location = new System.Drawing.Point(361, 230);
            this.cBPrimRegis.Name = "cBPrimRegis";
            this.cBPrimRegis.Size = new System.Drawing.Size(124, 32);
            this.cBPrimRegis.TabIndex = 47;
            this.cBPrimRegis.Text = "Primer registro";
            this.cBPrimRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBPrimRegis.UseVisualStyleBackColor = true;
            // 
            // cBImprimir
            // 
            this.cBImprimir.AutoSize = true;
            this.cBImprimir.Image = global::DLLSeguridad.Properties.Resources.imprimir;
            this.cBImprimir.Location = new System.Drawing.Point(361, 179);
            this.cBImprimir.Name = "cBImprimir";
            this.cBImprimir.Size = new System.Drawing.Size(93, 32);
            this.cBImprimir.TabIndex = 46;
            this.cBImprimir.Text = "Imprimir";
            this.cBImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBImprimir.UseVisualStyleBackColor = true;
            // 
            // cBActualizar
            // 
            this.cBActualizar.AutoSize = true;
            this.cBActualizar.Image = global::DLLSeguridad.Properties.Resources.refresh;
            this.cBActualizar.Location = new System.Drawing.Point(366, 126);
            this.cBActualizar.Name = "cBActualizar";
            this.cBActualizar.Size = new System.Drawing.Size(104, 32);
            this.cBActualizar.TabIndex = 45;
            this.cBActualizar.Text = "Actualizar";
            this.cBActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::DLLSeguridad.Properties.Resources.buscar1;
            this.btnEditar.Location = new System.Drawing.Point(522, 404);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 42);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cBCancelar
            // 
            this.cBCancelar.Image = global::DLLSeguridad.Properties.Resources.cancelar;
            this.cBCancelar.Location = new System.Drawing.Point(241, 395);
            this.cBCancelar.Name = "cBCancelar";
            this.cBCancelar.Size = new System.Drawing.Size(112, 41);
            this.cBCancelar.TabIndex = 39;
            this.cBCancelar.Text = "Cancelar";
            this.cBCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBCancelar.UseVisualStyleBackColor = true;
            // 
            // cBBuscar
            // 
            this.cBBuscar.Image = global::DLLSeguridad.Properties.Resources.buscar1;
            this.cBBuscar.Location = new System.Drawing.Point(241, 343);
            this.cBBuscar.Name = "cBBuscar";
            this.cBBuscar.Size = new System.Drawing.Size(96, 32);
            this.cBBuscar.TabIndex = 38;
            this.cBBuscar.Text = "Buscar";
            this.cBBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBBuscar.UseVisualStyleBackColor = true;
            // 
            // cBEditar
            // 
            this.cBEditar.Image = global::DLLSeguridad.Properties.Resources.editar1;
            this.cBEditar.Location = new System.Drawing.Point(241, 277);
            this.cBEditar.Name = "cBEditar";
            this.cBEditar.Size = new System.Drawing.Size(96, 43);
            this.cBEditar.TabIndex = 37;
            this.cBEditar.Text = "Editar";
            this.cBEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBEditar.UseVisualStyleBackColor = true;
            // 
            // cBEliminar
            // 
            this.cBEliminar.Image = global::DLLSeguridad.Properties.Resources.eliminar;
            this.cBEliminar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cBEliminar.Location = new System.Drawing.Point(241, 232);
            this.cBEliminar.Name = "cBEliminar";
            this.cBEliminar.Size = new System.Drawing.Size(94, 32);
            this.cBEliminar.TabIndex = 36;
            this.cBEliminar.Text = "Eliminar";
            this.cBEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cBEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cBEliminar.UseVisualStyleBackColor = true;
            // 
            // cBInserta
            // 
            this.cBInserta.Image = global::DLLSeguridad.Properties.Resources.guardar;
            this.cBInserta.Location = new System.Drawing.Point(241, 179);
            this.cBInserta.Name = "cBInserta";
            this.cBInserta.Size = new System.Drawing.Size(131, 36);
            this.cBInserta.TabIndex = 40;
            this.cBInserta.Text = "Insertar";
            this.cBInserta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBInserta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // btnQuitarSimple
            // 
            this.btnQuitarSimple.Image = global::DLLSeguridad.Properties.Resources.asignar4;
            this.btnQuitarSimple.Location = new System.Drawing.Point(521, 325);
            this.btnQuitarSimple.Name = "btnQuitarSimple";
            this.btnQuitarSimple.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarSimple.TabIndex = 25;
            this.btnQuitarSimple.UseVisualStyleBackColor = true;
            this.btnQuitarSimple.Click += new System.EventHandler(this.btnQuitarSimple_Click);
            // 
            // btnQuitarMuchas
            // 
            this.btnQuitarMuchas.Image = global::DLLSeguridad.Properties.Resources.asignar3;
            this.btnQuitarMuchas.Location = new System.Drawing.Point(521, 270);
            this.btnQuitarMuchas.Name = "btnQuitarMuchas";
            this.btnQuitarMuchas.Size = new System.Drawing.Size(47, 50);
            this.btnQuitarMuchas.TabIndex = 24;
            this.btnQuitarMuchas.UseVisualStyleBackColor = true;
            this.btnQuitarMuchas.Click += new System.EventHandler(this.btnQuitarMuchas_Click);
            // 
            // btnAsignacionMuchas
            // 
            this.btnAsignacionMuchas.Image = global::DLLSeguridad.Properties.Resources.asignar2;
            this.btnAsignacionMuchas.Location = new System.Drawing.Point(521, 195);
            this.btnAsignacionMuchas.Name = "btnAsignacionMuchas";
            this.btnAsignacionMuchas.Size = new System.Drawing.Size(47, 50);
            this.btnAsignacionMuchas.TabIndex = 22;
            this.btnAsignacionMuchas.UseVisualStyleBackColor = true;
            this.btnAsignacionMuchas.Click += new System.EventHandler(this.btnAsignacionMuchas_Click);
            // 
            // btnAsignacionSimple
            // 
            this.btnAsignacionSimple.Image = global::DLLSeguridad.Properties.Resources.asginar;
            this.btnAsignacionSimple.Location = new System.Drawing.Point(521, 141);
            this.btnAsignacionSimple.Name = "btnAsignacionSimple";
            this.btnAsignacionSimple.Size = new System.Drawing.Size(47, 50);
            this.btnAsignacionSimple.TabIndex = 21;
            this.btnAsignacionSimple.UseVisualStyleBackColor = true;
            this.btnAsignacionSimple.Click += new System.EventHandler(this.btnAsignacionSimple_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::DLLSeguridad.Properties.Resources.buscar;
            this.btnbuscar.Location = new System.Drawing.Point(51, 32);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(47, 50);
            this.btnbuscar.TabIndex = 0;
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // frmAsignacionAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 539);
            this.Controls.Add(this.cBNuevo);
            this.Controls.Add(this.cBUltRegis);
            this.Controls.Add(this.cBSigRegis);
            this.Controls.Add(this.cBAntRegis);
            this.Controls.Add(this.cBPrimRegis);
            this.Controls.Add(this.cBImprimir);
            this.Controls.Add(this.cBActualizar);
            this.Controls.Add(this.PermisoAsignado);
            this.Controls.Add(this.lbxPermisoAsig);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cBCancelar);
            this.Controls.Add(this.cBBuscar);
            this.Controls.Add(this.cBEditar);
            this.Controls.Add(this.cBEliminar);
            this.Controls.Add(this.cBInserta);
            this.Controls.Add(this.lbxAppDisponibles);
            this.Controls.Add(this.lbxAppAsignadas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarPerfil);
            this.Controls.Add(this.lblAplicacionesAsign);
            this.Controls.Add(this.lblAplicacionesDisp);
            this.Controls.Add(this.btnQuitarSimple);
            this.Controls.Add(this.btnQuitarMuchas);
            this.Controls.Add(this.lblQuitar);
            this.Controls.Add(this.btnAsignacionMuchas);
            this.Controls.Add(this.btnAsignacionSimple);
            this.Controls.Add(this.lblAsignar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAsignacionAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignacion de Aplicaciones a Perfiles de Usuario";
            this.Load += new System.EventHandler(this.frmAsignacionAplicacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lblNombrePerfil;
        private System.Windows.Forms.Button btnQuitarSimple;
        private System.Windows.Forms.Button btnQuitarMuchas;
        private System.Windows.Forms.Label lblQuitar;
        private System.Windows.Forms.Button btnAsignacionMuchas;
        private System.Windows.Forms.Button btnAsignacionSimple;
        private System.Windows.Forms.Label lblAsignar;
        private System.Windows.Forms.Label lblAplicacionesDisp;
        private System.Windows.Forms.Label lblAplicacionesAsign;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarPerfil;
        private System.Windows.Forms.ListBox lbxAppAsignadas;
        private System.Windows.Forms.ListBox lbxAppDisponibles;
        public System.Windows.Forms.TextBox txtCodigoPerfil;
        public System.Windows.Forms.TextBox txtNombrePerfil;
        private System.Windows.Forms.CheckBox cBInserta;
        private System.Windows.Forms.CheckBox cBEliminar;
        private System.Windows.Forms.CheckBox cBEditar;
        private System.Windows.Forms.CheckBox cBBuscar;
        private System.Windows.Forms.CheckBox cBCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxPermisoAsig;
        private System.Windows.Forms.Label PermisoAsignado;
        private System.Windows.Forms.CheckBox cBActualizar;
        private System.Windows.Forms.CheckBox cBImprimir;
        private System.Windows.Forms.CheckBox cBPrimRegis;
        private System.Windows.Forms.CheckBox cBAntRegis;
        private System.Windows.Forms.CheckBox cBSigRegis;
        private System.Windows.Forms.CheckBox cBUltRegis;
        private System.Windows.Forms.CheckBox cBNuevo;
    }
}