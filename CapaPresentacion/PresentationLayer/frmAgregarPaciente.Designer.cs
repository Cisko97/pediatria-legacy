namespace CapaPresentacion.PresentationLayer
{
    partial class frmAgregarPaciente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPaciente));
            this.errorValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelCabecera = new System.Windows.Forms.Panel();
            this.label46 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOrigen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReligion = new System.Windows.Forms.ComboBox();
            this.txtCedulaPadre = new System.Windows.Forms.MaskedTextBox();
            this.txtCedulaMadre = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCedulaPadre = new System.Windows.Forms.Label();
            this.lblCedulaMadre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtNombreMadre = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtNombrePadre = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblNombreMadre = new System.Windows.Forms.Label();
            this.cmbGrupoSangre = new System.Windows.Forms.ComboBox();
            this.lblNombrePadre = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.chbSi = new System.Windows.Forms.CheckBox();
            this.lblBoolean = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblCiudadNac = new System.Windows.Forms.Label();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.txtCiudadNacimiento = new System.Windows.Forms.TextBox();
            this.lblLugarNac = new System.Windows.Forms.Label();
            this.lblApellido2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).BeginInit();
            this.PanelCabecera.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorValidacion
            // 
            this.errorValidacion.ContainerControl = this;
            // 
            // PanelCabecera
            // 
            this.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.PanelCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecera.Controls.Add(this.label46);
            this.PanelCabecera.Controls.Add(this.btnCerrar);
            this.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCabecera.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecera.Name = "PanelCabecera";
            this.PanelCabecera.Size = new System.Drawing.Size(651, 40);
            this.PanelCabecera.TabIndex = 15;
            this.PanelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCabecera_MouseDown);
            this.PanelCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecera_MouseMove);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.label46.Location = new System.Drawing.Point(20, 11);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(184, 21);
            this.label46.TabIndex = 10;
            this.label46.Text = "Crear Paciente Nuevo";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(609, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.cmbOrigen);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbReligion);
            this.panel1.Controls.Add(this.txtCedulaPadre);
            this.panel1.Controls.Add(this.txtCedulaMadre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblCedulaPadre);
            this.panel1.Controls.Add(this.lblCedulaMadre);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cmbSexo);
            this.panel1.Controls.Add(this.txtNombreMadre);
            this.panel1.Controls.Add(this.txtObservaciones);
            this.panel1.Controls.Add(this.txtNombrePadre);
            this.panel1.Controls.Add(this.lblSexo);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.txtNombre2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNombre1);
            this.panel1.Controls.Add(this.lblObservaciones);
            this.panel1.Controls.Add(this.lblNombreMadre);
            this.panel1.Controls.Add(this.cmbGrupoSangre);
            this.panel1.Controls.Add(this.lblNombrePadre);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lblApellido2);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.lblApellido1);
            this.panel1.Controls.Add(this.lblNombre1);
            this.panel1.Controls.Add(this.lblNombre2);
            this.panel1.Location = new System.Drawing.Point(25, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 525);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // cmbOrigen
            // 
            this.cmbOrigen.FormattingEnabled = true;
            this.cmbOrigen.Items.AddRange(new object[] {
            "Urbano",
            "Rural"});
            this.cmbOrigen.Location = new System.Drawing.Point(413, 215);
            this.cmbOrigen.Name = "cmbOrigen";
            this.cmbOrigen.Size = new System.Drawing.Size(134, 21);
            this.cmbOrigen.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Origen:";
            // 
            // cmbReligion
            // 
            this.cmbReligion.FormattingEnabled = true;
            this.cmbReligion.Items.AddRange(new object[] {
            "No Aplica",
            "Católica",
            "Evangélica",
            "Testigo de Jehová"});
            this.cmbReligion.Location = new System.Drawing.Point(413, 176);
            this.cmbReligion.Name = "cmbReligion";
            this.cmbReligion.Size = new System.Drawing.Size(134, 21);
            this.cmbReligion.TabIndex = 35;
            // 
            // txtCedulaPadre
            // 
            this.txtCedulaPadre.Location = new System.Drawing.Point(149, 135);
            this.txtCedulaPadre.Mask = "000-000000-0000?";
            this.txtCedulaPadre.Name = "txtCedulaPadre";
            this.txtCedulaPadre.Size = new System.Drawing.Size(121, 20);
            this.txtCedulaPadre.TabIndex = 34;
            // 
            // txtCedulaMadre
            // 
            this.txtCedulaMadre.Location = new System.Drawing.Point(413, 135);
            this.txtCedulaMadre.Mask = "000-000000-0000?";
            this.txtCedulaMadre.Name = "txtCedulaMadre";
            this.txtCedulaMadre.Size = new System.Drawing.Size(134, 20);
            this.txtCedulaMadre.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Religión:";
            // 
            // lblCedulaPadre
            // 
            this.lblCedulaPadre.AutoSize = true;
            this.lblCedulaPadre.Location = new System.Drawing.Point(50, 138);
            this.lblCedulaPadre.Name = "lblCedulaPadre";
            this.lblCedulaPadre.Size = new System.Drawing.Size(90, 13);
            this.lblCedulaPadre.TabIndex = 29;
            this.lblCedulaPadre.Text = "Cédula del padre:";
            // 
            // lblCedulaMadre
            // 
            this.lblCedulaMadre.AutoSize = true;
            this.lblCedulaMadre.Location = new System.Drawing.Point(299, 138);
            this.lblCedulaMadre.Name = "lblCedulaMadre";
            this.lblCedulaMadre.Size = new System.Drawing.Size(101, 13);
            this.lblCedulaMadre.TabIndex = 27;
            this.lblCedulaMadre.Text = "Cédula de la madre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(220, 468);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(173, 37);
            this.btnGuardar.TabIndex = 26;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(149, 214);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 21;
            // 
            // txtNombreMadre
            // 
            this.txtNombreMadre.Location = new System.Drawing.Point(413, 94);
            this.txtNombreMadre.Name = "txtNombreMadre";
            this.txtNombreMadre.Size = new System.Drawing.Size(134, 20);
            this.txtNombreMadre.TabIndex = 15;
            this.txtNombreMadre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombreMadre_Validating);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(413, 258);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(134, 70);
            this.txtObservaciones.TabIndex = 25;
            // 
            // txtNombrePadre
            // 
            this.txtNombrePadre.Location = new System.Drawing.Point(149, 94);
            this.txtNombrePadre.Name = "txtNombrePadre";
            this.txtNombrePadre.Size = new System.Drawing.Size(121, 20);
            this.txtNombrePadre.TabIndex = 14;
            this.txtNombrePadre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombrePadre_Validating);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(48, 218);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 20;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(413, 58);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(134, 20);
            this.txtApellido2.TabIndex = 13;
            this.txtApellido2.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellido2_Validating);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(48, 261);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 22;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(149, 58);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(121, 20);
            this.txtApellido1.TabIndex = 12;
            this.txtApellido1.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellido1_Validating);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(413, 24);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(134, 20);
            this.txtNombre2.TabIndex = 11;
            this.txtNombre2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Grupo Sanguíneo:";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(149, 21);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(121, 20);
            this.txtNombre1.TabIndex = 10;
            this.txtNombre1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre1_Validating);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(301, 258);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 24;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // lblNombreMadre
            // 
            this.lblNombreMadre.AutoSize = true;
            this.lblNombreMadre.Location = new System.Drawing.Point(300, 97);
            this.lblNombreMadre.Name = "lblNombreMadre";
            this.lblNombreMadre.Size = new System.Drawing.Size(106, 13);
            this.lblNombreMadre.TabIndex = 8;
            this.lblNombreMadre.Text = "Nombre de la Madre:";
            // 
            // cmbGrupoSangre
            // 
            this.cmbGrupoSangre.FormattingEnabled = true;
            this.cmbGrupoSangre.Location = new System.Drawing.Point(149, 174);
            this.cmbGrupoSangre.Name = "cmbGrupoSangre";
            this.cmbGrupoSangre.Size = new System.Drawing.Size(121, 21);
            this.cmbGrupoSangre.TabIndex = 18;
            // 
            // lblNombrePadre
            // 
            this.lblNombrePadre.AutoSize = true;
            this.lblNombrePadre.Location = new System.Drawing.Point(45, 97);
            this.lblNombrePadre.Name = "lblNombrePadre";
            this.lblNombrePadre.Size = new System.Drawing.Size(95, 13);
            this.lblNombrePadre.TabIndex = 7;
            this.lblNombrePadre.Text = "Nombre del Padre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLugarNacimiento);
            this.groupBox2.Controls.Add(this.chbSi);
            this.groupBox2.Controls.Add(this.lblBoolean);
            this.groupBox2.Controls.Add(this.dtpFechaNac);
            this.groupBox2.Controls.Add(this.lblCiudadNac);
            this.groupBox2.Controls.Add(this.lblFechaNac);
            this.groupBox2.Controls.Add(this.txtCiudadNacimiento);
            this.groupBox2.Controls.Add(this.lblLugarNac);
            this.groupBox2.Location = new System.Drawing.Point(42, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 109);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nacimiento";
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Location = new System.Drawing.Point(260, 62);
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(128, 20);
            this.txtLugarNacimiento.TabIndex = 23;
            // 
            // chbSi
            // 
            this.chbSi.AutoSize = true;
            this.chbSi.Location = new System.Drawing.Point(129, 64);
            this.chbSi.Name = "chbSi";
            this.chbSi.Size = new System.Drawing.Size(40, 17);
            this.chbSi.TabIndex = 21;
            this.chbSi.Text = "Sí.";
            this.chbSi.UseVisualStyleBackColor = true;
            // 
            // lblBoolean
            // 
            this.lblBoolean.AutoSize = true;
            this.lblBoolean.Location = new System.Drawing.Point(8, 64);
            this.lblBoolean.Name = "lblBoolean";
            this.lblBoolean.Size = new System.Drawing.Size(115, 13);
            this.lblBoolean.TabIndex = 18;
            this.lblBoolean.Text = "Nació en un Hospital?:";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(125, 22);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(128, 20);
            this.dtpFechaNac.TabIndex = 17;
            // 
            // lblCiudadNac
            // 
            this.lblCiudadNac.AutoSize = true;
            this.lblCiudadNac.Location = new System.Drawing.Point(267, 26);
            this.lblCiudadNac.Name = "lblCiudadNac";
            this.lblCiudadNac.Size = new System.Drawing.Size(114, 13);
            this.lblCiudadNac.TabIndex = 5;
            this.lblCiudadNac.Text = "Ciudad de Nacimiento:";
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Location = new System.Drawing.Point(8, 28);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNac.TabIndex = 4;
            this.lblFechaNac.Text = "Fecha de Nacimiento:";
            // 
            // txtCiudadNacimiento
            // 
            this.txtCiudadNacimiento.Location = new System.Drawing.Point(387, 21);
            this.txtCiudadNacimiento.Name = "txtCiudadNacimiento";
            this.txtCiudadNacimiento.Size = new System.Drawing.Size(128, 20);
            this.txtCiudadNacimiento.TabIndex = 16;
            // 
            // lblLugarNac
            // 
            this.lblLugarNac.AutoSize = true;
            this.lblLugarNac.Location = new System.Drawing.Point(175, 65);
            this.lblLugarNac.Name = "lblLugarNac";
            this.lblLugarNac.Size = new System.Drawing.Size(79, 13);
            this.lblLugarNac.TabIndex = 6;
            this.lblLugarNac.Text = "Dónde Nació?:";
            // 
            // lblApellido2
            // 
            this.lblApellido2.AutoSize = true;
            this.lblApellido2.Location = new System.Drawing.Point(300, 61);
            this.lblApellido2.Name = "lblApellido2";
            this.lblApellido2.Size = new System.Drawing.Size(93, 13);
            this.lblApellido2.TabIndex = 3;
            this.lblApellido2.Text = "Segundo Apellido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(149, 258);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 63);
            this.txtDireccion.TabIndex = 23;
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Location = new System.Drawing.Point(44, 61);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(79, 13);
            this.lblApellido1.TabIndex = 2;
            this.lblApellido1.Text = "Primer Apellido:";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(44, 24);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(79, 13);
            this.lblNombre1.TabIndex = 0;
            this.lblNombre1.Text = "Primer Nombre:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(301, 24);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(93, 13);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Segundo Nombre:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelCabecera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(651, 617);
            this.Controls.Add(this.PanelCabecera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmAgregarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Paciente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAgregarPaciente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAgregarPaciente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorValidacion)).EndInit();
            this.PanelCabecera.ResumeLayout(false);
            this.PanelCabecera.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorValidacion;
        internal System.Windows.Forms.Panel PanelCabecera;
        internal System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtNombreMadre;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtNombrePadre;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblNombreMadre;
        private System.Windows.Forms.ComboBox cmbGrupoSangre;
        private System.Windows.Forms.Label lblNombrePadre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLugarNacimiento;
        private System.Windows.Forms.CheckBox chbSi;
        private System.Windows.Forms.Label lblBoolean;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Label lblCiudadNac;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.TextBox txtCiudadNacimiento;
        private System.Windows.Forms.Label lblLugarNac;
        private System.Windows.Forms.Label lblApellido2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblCedulaPadre;
        private System.Windows.Forms.Label lblCedulaMadre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCedulaPadre;
        private System.Windows.Forms.MaskedTextBox txtCedulaMadre;
        private System.Windows.Forms.ComboBox cmbOrigen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbReligion;
        private System.Windows.Forms.Label label46;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

