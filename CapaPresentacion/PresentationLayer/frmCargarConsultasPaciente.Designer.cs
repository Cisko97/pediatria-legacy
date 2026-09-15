namespace CapaPresentacion.PresentationLayer
{
    partial class frmCargarConsultasPaciente
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
            this.components = new System.ComponentModel.Container();
            this.dgvConsultaPaciente = new System.Windows.Forms.DataGridView();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtObservacionesGenerales = new System.Windows.Forms.TextBox();
            this.lblObservacionesGenerales = new System.Windows.Forms.Label();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.btnRestaurarConsultas = new System.Windows.Forms.Button();
            this.btnEliminarConsultas = new System.Windows.Forms.Button();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHEA = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.tbxSintomas = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblSintomas = new System.Windows.Forms.Label();
            this.dpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorEnValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPresionDiastolica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacionesSG = new System.Windows.Forms.RichTextBox();
            this.lblObservacionesSG = new System.Windows.Forms.Label();
            this.txtFR = new System.Windows.Forms.TextBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPresionSistolica = new System.Windows.Forms.TextBox();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.gbSomatometria = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtPT = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtPA = new System.Windows.Forms.TextBox();
            this.lblPA = new System.Windows.Forms.Label();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtHallazgo = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblEdadConsulta = new System.Windows.Forms.Label();
            this.lblCentimetros = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblExitoConsulta = new System.Windows.Forms.Label();
            this.txtObservacionesaAntro = new System.Windows.Forms.TextBox();
            this.txtEstatura = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblEstatura = new System.Windows.Forms.Label();
            this.lblImc = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblEdadActual2 = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtSistemas = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txtTratamiento = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPaciente)).BeginInit();
            this.gbResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEnValidacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gbSomatometria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsultaPaciente
            // 
            this.dgvConsultaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaPaciente.Location = new System.Drawing.Point(15, 68);
            this.dgvConsultaPaciente.Name = "dgvConsultaPaciente";
            this.dgvConsultaPaciente.Size = new System.Drawing.Size(464, 118);
            this.dgvConsultaPaciente.TabIndex = 0;
            this.dgvConsultaPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultaPaciente_CellClick);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 29);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(61, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Buscar por:";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(79, 25);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 2;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(208, 30);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(37, 13);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(251, 26);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(100, 20);
            this.txtTexto.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(370, 24);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Buscar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // txtObservacionesGenerales
            // 
            this.txtObservacionesGenerales.Location = new System.Drawing.Point(200, 376);
            this.txtObservacionesGenerales.Multiline = true;
            this.txtObservacionesGenerales.Name = "txtObservacionesGenerales";
            this.txtObservacionesGenerales.Size = new System.Drawing.Size(175, 71);
            this.txtObservacionesGenerales.TabIndex = 57;
            // 
            // lblObservacionesGenerales
            // 
            this.lblObservacionesGenerales.AutoSize = true;
            this.lblObservacionesGenerales.Location = new System.Drawing.Point(201, 363);
            this.lblObservacionesGenerales.Name = "lblObservacionesGenerales";
            this.lblObservacionesGenerales.Size = new System.Drawing.Size(132, 13);
            this.lblObservacionesGenerales.TabIndex = 56;
            this.lblObservacionesGenerales.Text = "Observaciones Generales:";
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.btnRestaurarConsultas);
            this.gbResultados.Controls.Add(this.btnEliminarConsultas);
            this.gbResultados.Controls.Add(this.btnGuardarCambios);
            this.gbResultados.Controls.Add(this.dgvConsultaPaciente);
            this.gbResultados.Controls.Add(this.cmbCategoria);
            this.gbResultados.Controls.Add(this.txtTexto);
            this.gbResultados.Controls.Add(this.lblCategoria);
            this.gbResultados.Controls.Add(this.lblTexto);
            this.gbResultados.Controls.Add(this.btnFiltrar);
            this.gbResultados.Location = new System.Drawing.Point(15, 462);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(619, 191);
            this.gbResultados.TabIndex = 55;
            this.gbResultados.TabStop = false;
            this.gbResultados.Text = "Opciones de Consulta";
            // 
            // btnRestaurarConsultas
            // 
            this.btnRestaurarConsultas.Location = new System.Drawing.Point(497, 153);
            this.btnRestaurarConsultas.Name = "btnRestaurarConsultas";
            this.btnRestaurarConsultas.Size = new System.Drawing.Size(112, 23);
            this.btnRestaurarConsultas.TabIndex = 8;
            this.btnRestaurarConsultas.Text = "Restaurar Consulta";
            this.btnRestaurarConsultas.UseVisualStyleBackColor = true;
            this.btnRestaurarConsultas.Click += new System.EventHandler(this.btnRestaurarConsultas_Click);
            // 
            // btnEliminarConsultas
            // 
            this.btnEliminarConsultas.Location = new System.Drawing.Point(497, 107);
            this.btnEliminarConsultas.Name = "btnEliminarConsultas";
            this.btnEliminarConsultas.Size = new System.Drawing.Size(112, 23);
            this.btnEliminarConsultas.TabIndex = 7;
            this.btnEliminarConsultas.Text = "Eliminar Consulta";
            this.btnEliminarConsultas.UseVisualStyleBackColor = true;
            this.btnEliminarConsultas.Click += new System.EventHandler(this.btnEliminarConsultas_Click);
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.Location = new System.Drawing.Point(497, 68);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(112, 23);
            this.btnGuardarCambios.TabIndex = 6;
            this.btnGuardarCambios.Text = "Guardar Cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = true;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Historia de la Enfermedad Actual:";
            // 
            // txtHEA
            // 
            this.txtHEA.Location = new System.Drawing.Point(15, 143);
            this.txtHEA.Multiline = true;
            this.txtHEA.Name = "txtHEA";
            this.txtHEA.Size = new System.Drawing.Size(179, 76);
            this.txtHEA.TabIndex = 31;
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(204, 256);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(171, 92);
            this.txtDiagnostico.TabIndex = 53;
            // 
            // tbxSintomas
            // 
            this.tbxSintomas.Location = new System.Drawing.Point(210, 143);
            this.tbxSintomas.Multiline = true;
            this.tbxSintomas.Name = "tbxSintomas";
            this.tbxSintomas.Size = new System.Drawing.Size(165, 76);
            this.tbxSintomas.TabIndex = 51;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(90, 33);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.ReadOnly = true;
            this.txtPaciente.Size = new System.Drawing.Size(165, 20);
            this.txtPaciente.TabIndex = 47;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(204, 238);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 52;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // lblSintomas
            // 
            this.lblSintomas.AutoSize = true;
            this.lblSintomas.Location = new System.Drawing.Point(210, 119);
            this.lblSintomas.Name = "lblSintomas";
            this.lblSintomas.Size = new System.Drawing.Size(81, 13);
            this.lblSintomas.TabIndex = 50;
            this.lblSintomas.Text = "Sintomatología:";
            // 
            // dpFechaConsulta
            // 
            this.dpFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFechaConsulta.Location = new System.Drawing.Point(90, 69);
            this.dpFechaConsulta.Name = "dpFechaConsulta";
            this.dpFechaConsulta.Size = new System.Drawing.Size(104, 20);
            this.dpFechaConsulta.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "Fecha:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 45;
            // 
            // errorEnValidacion
            // 
            this.errorEnValidacion.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPresionDiastolica);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtObservacionesSG);
            this.groupBox1.Controls.Add(this.lblObservacionesSG);
            this.groupBox1.Controls.Add(this.txtFR);
            this.groupBox1.Controls.Add(this.txtFC);
            this.groupBox1.Controls.Add(this.lblTemperatura);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPresionSistolica);
            this.groupBox1.Controls.Add(this.txtTemperatura);
            this.groupBox1.Location = new System.Drawing.Point(381, 286);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 161);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Signos vitales";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(176, 49);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(39, 13);
            this.label34.TabIndex = 58;
            this.label34.Text = "mmHG";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(213, 136);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(35, 13);
            this.label33.TabIndex = 57;
            this.label33.Text = "x Min.";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(213, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "x Min.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(170, 20);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(39, 13);
            this.label32.TabIndex = 55;
            this.label32.Text = "mmHG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Presión Diastólica:";
            // 
            // txtPresionDiastolica
            // 
            this.txtPresionDiastolica.Location = new System.Drawing.Point(118, 46);
            this.txtPresionDiastolica.MaxLength = 10;
            this.txtPresionDiastolica.Name = "txtPresionDiastolica";
            this.txtPresionDiastolica.ReadOnly = true;
            this.txtPresionDiastolica.Size = new System.Drawing.Size(52, 20);
            this.txtPresionDiastolica.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Presión Sistólica:";
            // 
            // txtObservacionesSG
            // 
            this.txtObservacionesSG.Location = new System.Drawing.Point(259, 46);
            this.txtObservacionesSG.Name = "txtObservacionesSG";
            this.txtObservacionesSG.Size = new System.Drawing.Size(209, 98);
            this.txtObservacionesSG.TabIndex = 45;
            this.txtObservacionesSG.Text = "";
            // 
            // lblObservacionesSG
            // 
            this.lblObservacionesSG.AutoSize = true;
            this.lblObservacionesSG.Location = new System.Drawing.Point(258, 23);
            this.lblObservacionesSG.Name = "lblObservacionesSG";
            this.lblObservacionesSG.Size = new System.Drawing.Size(149, 13);
            this.lblObservacionesSG.TabIndex = 44;
            this.lblObservacionesSG.Text = "Observaciones Signos vitales:";
            // 
            // txtFR
            // 
            this.txtFR.Location = new System.Drawing.Point(143, 133);
            this.txtFR.Name = "txtFR";
            this.txtFR.ReadOnly = true;
            this.txtFR.Size = new System.Drawing.Size(66, 20);
            this.txtFR.TabIndex = 42;
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(143, 105);
            this.txtFC.Name = "txtFC";
            this.txtFC.ReadOnly = true;
            this.txtFC.Size = new System.Drawing.Size(66, 20);
            this.txtFC.TabIndex = 41;
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(15, 77);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(90, 13);
            this.lblTemperatura.TabIndex = 29;
            this.lblTemperatura.Text = "Temperatura (C°):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Frecuencia Respiratoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Frecuencia Cardiaca:";
            // 
            // txtPresionSistolica
            // 
            this.txtPresionSistolica.Location = new System.Drawing.Point(111, 17);
            this.txtPresionSistolica.MaxLength = 10;
            this.txtPresionSistolica.Name = "txtPresionSistolica";
            this.txtPresionSistolica.ReadOnly = true;
            this.txtPresionSistolica.Size = new System.Drawing.Size(52, 20);
            this.txtPresionSistolica.TabIndex = 28;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(104, 74);
            this.txtTemperatura.MaxLength = 10;
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.ReadOnly = true;
            this.txtTemperatura.Size = new System.Drawing.Size(52, 20);
            this.txtTemperatura.TabIndex = 30;
            // 
            // gbSomatometria
            // 
            this.gbSomatometria.BackColor = System.Drawing.Color.Transparent;
            this.gbSomatometria.Controls.Add(this.label21);
            this.gbSomatometria.Controls.Add(this.label20);
            this.gbSomatometria.Controls.Add(this.label19);
            this.gbSomatometria.Controls.Add(this.txtPT);
            this.gbSomatometria.Controls.Add(this.label18);
            this.gbSomatometria.Controls.Add(this.txtPA);
            this.gbSomatometria.Controls.Add(this.lblPA);
            this.gbSomatometria.Controls.Add(this.txtPC);
            this.gbSomatometria.Controls.Add(this.label17);
            this.gbSomatometria.Controls.Add(this.txtHallazgo);
            this.gbSomatometria.Controls.Add(this.label16);
            this.gbSomatometria.Controls.Add(this.lblEdadConsulta);
            this.gbSomatometria.Controls.Add(this.lblCentimetros);
            this.gbSomatometria.Controls.Add(this.label12);
            this.gbSomatometria.Controls.Add(this.lblExitoConsulta);
            this.gbSomatometria.Controls.Add(this.txtObservacionesaAntro);
            this.gbSomatometria.Controls.Add(this.txtEstatura);
            this.gbSomatometria.Controls.Add(this.txtImc);
            this.gbSomatometria.Controls.Add(this.txtPeso);
            this.gbSomatometria.Controls.Add(this.lblEstatura);
            this.gbSomatometria.Controls.Add(this.lblImc);
            this.gbSomatometria.Controls.Add(this.lblObservaciones);
            this.gbSomatometria.Controls.Add(this.lblEdadActual2);
            this.gbSomatometria.Controls.Add(this.lblPeso);
            this.gbSomatometria.Location = new System.Drawing.Point(381, 11);
            this.gbSomatometria.Name = "gbSomatometria";
            this.gbSomatometria.Size = new System.Drawing.Size(479, 269);
            this.gbSomatometria.TabIndex = 59;
            this.gbSomatometria.TabStop = false;
            this.gbSomatometria.Text = "Antropometría";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(415, 94);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "cm.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(415, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "cm.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(417, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "cm.";
            // 
            // txtPT
            // 
            this.txtPT.Location = new System.Drawing.Point(370, 87);
            this.txtPT.Name = "txtPT";
            this.txtPT.ReadOnly = true;
            this.txtPT.Size = new System.Drawing.Size(41, 20);
            this.txtPT.TabIndex = 45;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(256, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 13);
            this.label18.TabIndex = 44;
            this.label18.Text = "Perímetro Torácico:";
            // 
            // txtPA
            // 
            this.txtPA.Location = new System.Drawing.Point(370, 56);
            this.txtPA.Name = "txtPA";
            this.txtPA.ReadOnly = true;
            this.txtPA.Size = new System.Drawing.Size(41, 20);
            this.txtPA.TabIndex = 43;
            // 
            // lblPA
            // 
            this.lblPA.AutoSize = true;
            this.lblPA.Location = new System.Drawing.Point(256, 60);
            this.lblPA.Name = "lblPA";
            this.lblPA.Size = new System.Drawing.Size(108, 13);
            this.lblPA.TabIndex = 42;
            this.lblPA.Text = "Perímetro Abodminal:";
            // 
            // txtPC
            // 
            this.txtPC.Location = new System.Drawing.Point(370, 26);
            this.txtPC.Name = "txtPC";
            this.txtPC.ReadOnly = true;
            this.txtPC.Size = new System.Drawing.Size(39, 20);
            this.txtPC.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(256, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Perímetro Cefálico:";
            // 
            // txtHallazgo
            // 
            this.txtHallazgo.Location = new System.Drawing.Point(262, 154);
            this.txtHallazgo.Name = "txtHallazgo";
            this.txtHallazgo.Size = new System.Drawing.Size(209, 96);
            this.txtHallazgo.TabIndex = 39;
            this.txtHallazgo.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Hallazgos exploratorios:";
            // 
            // lblEdadConsulta
            // 
            this.lblEdadConsulta.AutoSize = true;
            this.lblEdadConsulta.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEdadConsulta.Location = new System.Drawing.Point(101, 26);
            this.lblEdadConsulta.Name = "lblEdadConsulta";
            this.lblEdadConsulta.Size = new System.Drawing.Size(0, 13);
            this.lblEdadConsulta.TabIndex = 37;
            // 
            // lblCentimetros
            // 
            this.lblCentimetros.AutoSize = true;
            this.lblCentimetros.Location = new System.Drawing.Point(149, 86);
            this.lblCentimetros.Name = "lblCentimetros";
            this.lblCentimetros.Size = new System.Drawing.Size(24, 13);
            this.lblCentimetros.TabIndex = 36;
            this.lblCentimetros.Text = "cm.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(149, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Kg.";
            // 
            // lblExitoConsulta
            // 
            this.lblExitoConsulta.AutoSize = true;
            this.lblExitoConsulta.Location = new System.Drawing.Point(115, 303);
            this.lblExitoConsulta.Name = "lblExitoConsulta";
            this.lblExitoConsulta.Size = new System.Drawing.Size(0, 13);
            this.lblExitoConsulta.TabIndex = 34;
            // 
            // txtObservacionesaAntro
            // 
            this.txtObservacionesaAntro.Location = new System.Drawing.Point(18, 155);
            this.txtObservacionesaAntro.Multiline = true;
            this.txtObservacionesaAntro.Name = "txtObservacionesaAntro";
            this.txtObservacionesaAntro.Size = new System.Drawing.Size(177, 95);
            this.txtObservacionesaAntro.TabIndex = 26;
            // 
            // txtEstatura
            // 
            this.txtEstatura.Location = new System.Drawing.Point(91, 83);
            this.txtEstatura.MaxLength = 3;
            this.txtEstatura.Name = "txtEstatura";
            this.txtEstatura.ReadOnly = true;
            this.txtEstatura.Size = new System.Drawing.Size(52, 20);
            this.txtEstatura.TabIndex = 13;
            // 
            // txtImc
            // 
            this.txtImc.Enabled = false;
            this.txtImc.Location = new System.Drawing.Point(90, 114);
            this.txtImc.Name = "txtImc";
            this.txtImc.ReadOnly = true;
            this.txtImc.Size = new System.Drawing.Size(53, 20);
            this.txtImc.TabIndex = 12;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(91, 53);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.ReadOnly = true;
            this.txtPeso.Size = new System.Drawing.Size(52, 20);
            this.txtPeso.TabIndex = 8;
            // 
            // lblEstatura
            // 
            this.lblEstatura.AutoSize = true;
            this.lblEstatura.Location = new System.Drawing.Point(18, 86);
            this.lblEstatura.Name = "lblEstatura";
            this.lblEstatura.Size = new System.Drawing.Size(49, 13);
            this.lblEstatura.TabIndex = 6;
            this.lblEstatura.Text = "Estatura:";
            // 
            // lblImc
            // 
            this.lblImc.AutoSize = true;
            this.lblImc.Location = new System.Drawing.Point(18, 117);
            this.lblImc.Name = "lblImc";
            this.lblImc.Size = new System.Drawing.Size(29, 13);
            this.lblImc.TabIndex = 5;
            this.lblImc.Text = "IMC:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(18, 139);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(166, 13);
            this.lblObservaciones.TabIndex = 2;
            this.lblObservaciones.Text = "Observaciones de Antropometría:";
            // 
            // lblEdadActual2
            // 
            this.lblEdadActual2.AutoSize = true;
            this.lblEdadActual2.Location = new System.Drawing.Point(18, 26);
            this.lblEdadActual2.Name = "lblEdadActual2";
            this.lblEdadActual2.Size = new System.Drawing.Size(35, 13);
            this.lblEdadActual2.TabIndex = 1;
            this.lblEdadActual2.Text = "Edad:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(18, 56);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(67, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso Actual:";
            // 
            // txtSistemas
            // 
            this.txtSistemas.Location = new System.Drawing.Point(15, 256);
            this.txtSistemas.Multiline = true;
            this.txtSistemas.Name = "txtSistemas";
            this.txtSistemas.Size = new System.Drawing.Size(179, 92);
            this.txtSistemas.TabIndex = 63;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(12, 236);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(112, 13);
            this.label44.TabIndex = 62;
            this.label44.Text = "Revisión por sistemas:";
            // 
            // txtTratamiento
            // 
            this.txtTratamiento.Location = new System.Drawing.Point(15, 376);
            this.txtTratamiento.Multiline = true;
            this.txtTratamiento.Name = "txtTratamiento";
            this.txtTratamiento.Size = new System.Drawing.Size(179, 71);
            this.txtTratamiento.TabIndex = 61;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(12, 360);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(66, 13);
            this.label43.TabIndex = 60;
            this.label43.Text = "Tratamiento:";
            // 
            // frmCargarConsultasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 665);
            this.Controls.Add(this.txtSistemas);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.txtTratamiento);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.gbSomatometria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtObservacionesGenerales);
            this.Controls.Add(this.lblObservacionesGenerales);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.txtHEA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.tbxSintomas);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.lblSintomas);
            this.Controls.Add(this.dpFechaConsulta);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Name = "frmCargarConsultasPaciente";
            this.Text = "Cargar Consultas Registradas";
            this.Load += new System.EventHandler(this.frmCargarConsultasPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaPaciente)).EndInit();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorEnValidacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSomatometria.ResumeLayout(false);
            this.gbSomatometria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaPaciente;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtObservacionesGenerales;
        private System.Windows.Forms.Label lblObservacionesGenerales;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHEA;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox tbxSintomas;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblSintomas;
        private System.Windows.Forms.DateTimePicker dpFechaConsulta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRestaurarConsultas;
        private System.Windows.Forms.Button btnEliminarConsultas;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ErrorProvider errorEnValidacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtObservacionesSG;
        private System.Windows.Forms.Label lblObservacionesSG;
        private System.Windows.Forms.TextBox txtFR;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPresionSistolica;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.GroupBox gbSomatometria;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtPT;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtPA;
        private System.Windows.Forms.Label lblPA;
        private System.Windows.Forms.TextBox txtPC;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox txtHallazgo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblEdadConsulta;
        private System.Windows.Forms.Label lblCentimetros;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblExitoConsulta;
        private System.Windows.Forms.TextBox txtObservacionesaAntro;
        private System.Windows.Forms.TextBox txtEstatura;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblEstatura;
        private System.Windows.Forms.Label lblImc;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.Label lblEdadActual2;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPresionDiastolica;
        private System.Windows.Forms.TextBox txtSistemas;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtTratamiento;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label32;
    }
}
