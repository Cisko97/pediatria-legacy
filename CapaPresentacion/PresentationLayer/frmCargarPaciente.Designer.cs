namespace CapaPresentacion.PresentationLayer
{
    partial class frmCargarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarPaciente));
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbxSegundoApellido = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxSegundoNombre = new System.Windows.Forms.TextBox();
            this.tbxNombrePaciente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Apellido1 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.tbxTexto = new System.Windows.Forms.TextBox();
            this.btnBuscarTexto = new System.Windows.Forms.Button();
            this.btnRecargarDGV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRestaurarPaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEliminarPaciente = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCargar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelCabecera = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.PanelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.AllowUserToAddRows = false;
            this.dgvListaPacientes.AllowUserToDeleteRows = false;
            this.dgvListaPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(20, 214);
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.ReadOnly = true;
            this.dgvListaPacientes.Size = new System.Drawing.Size(755, 233);
            this.dgvListaPacientes.TabIndex = 0;
            this.dgvListaPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPacientes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.tbxSegundoApellido);
            this.groupBox2.Controls.Add(this.tbxApellido);
            this.groupBox2.Controls.Add(this.tbxSegundoNombre);
            this.groupBox2.Controls.Add(this.tbxNombrePaciente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Apellido1);
            this.groupBox2.Controls.Add(this.lblNombre2);
            this.groupBox2.Controls.Add(this.lblNombre1);
            this.groupBox2.Location = new System.Drawing.Point(115, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 136);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscador:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(456, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tbxSegundoApellido
            // 
            this.tbxSegundoApellido.Location = new System.Drawing.Point(332, 79);
            this.tbxSegundoApellido.Name = "tbxSegundoApellido";
            this.tbxSegundoApellido.Size = new System.Drawing.Size(100, 20);
            this.tbxSegundoApellido.TabIndex = 7;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(125, 76);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(100, 20);
            this.tbxApellido.TabIndex = 6;
            // 
            // tbxSegundoNombre
            // 
            this.tbxSegundoNombre.Location = new System.Drawing.Point(332, 28);
            this.tbxSegundoNombre.Name = "tbxSegundoNombre";
            this.tbxSegundoNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxSegundoNombre.TabIndex = 5;
            // 
            // tbxNombrePaciente
            // 
            this.tbxNombrePaciente.Location = new System.Drawing.Point(125, 28);
            this.tbxNombrePaciente.Name = "tbxNombrePaciente";
            this.tbxNombrePaciente.Size = new System.Drawing.Size(100, 20);
            this.tbxNombrePaciente.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido:";
            // 
            // Apellido1
            // 
            this.Apellido1.AutoSize = true;
            this.Apellido1.Location = new System.Drawing.Point(40, 79);
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Size = new System.Drawing.Size(79, 13);
            this.Apellido1.TabIndex = 2;
            this.Apellido1.Text = "Primer Apellido:";
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Location = new System.Drawing.Point(234, 31);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(93, 13);
            this.lblNombre2.TabIndex = 1;
            this.lblNombre2.Text = "Segundo Nombre:";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(40, 31);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(79, 13);
            this.lblNombre1.TabIndex = 0;
            this.lblNombre1.Text = "Primer Nombre:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Location = new System.Drawing.Point(117, 173);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(58, 13);
            this.lblBuscarPor.TabIndex = 10;
            this.lblBuscarPor.Text = "Buscar por";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DisplayMember = "1";
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Primer Nombre",
            "Segundo Nombre",
            "Primer Apellido",
            "Segundo Apellido",
            "Búsqueda por todo"});
            this.cmbCategoria.Location = new System.Drawing.Point(181, 170);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 11;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(312, 173);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 12;
            this.lblTexto.Text = "Texto";
            // 
            // tbxTexto
            // 
            this.tbxTexto.Location = new System.Drawing.Point(352, 170);
            this.tbxTexto.Name = "tbxTexto";
            this.tbxTexto.Size = new System.Drawing.Size(113, 20);
            this.tbxTexto.TabIndex = 13;
            // 
            // btnBuscarTexto
            // 
            this.btnBuscarTexto.Location = new System.Drawing.Point(493, 168);
            this.btnBuscarTexto.Name = "btnBuscarTexto";
            this.btnBuscarTexto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTexto.TabIndex = 14;
            this.btnBuscarTexto.Text = "Buscar";
            this.btnBuscarTexto.UseVisualStyleBackColor = true;
            this.btnBuscarTexto.Click += new System.EventHandler(this.btnBuscarTexto_Click);
            // 
            // btnRecargarDGV
            // 
            this.btnRecargarDGV.Location = new System.Drawing.Point(583, 168);
            this.btnRecargarDGV.Name = "btnRecargarDGV";
            this.btnRecargarDGV.Size = new System.Drawing.Size(75, 23);
            this.btnRecargarDGV.TabIndex = 15;
            this.btnRecargarDGV.Text = "Recargar";
            this.btnRecargarDGV.UseVisualStyleBackColor = true;
            this.btnRecargarDGV.Click += new System.EventHandler(this.btnRecargarDGV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnRestaurarPaciente);
            this.panel1.Controls.Add(this.btnEliminarPaciente);
            this.panel1.Controls.Add(this.btnCargar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lblBuscarPor);
            this.panel1.Controls.Add(this.cmbCategoria);
            this.panel1.Controls.Add(this.lblTexto);
            this.panel1.Controls.Add(this.btnRecargarDGV);
            this.panel1.Controls.Add(this.tbxTexto);
            this.panel1.Controls.Add(this.btnBuscarTexto);
            this.panel1.Controls.Add(this.dgvListaPacientes);
            this.panel1.Location = new System.Drawing.Point(17, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 524);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btnRestaurarPaciente
            // 
            this.btnRestaurarPaciente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.btnRestaurarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.btnRestaurarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestaurarPaciente.BorderRadius = 0;
            this.btnRestaurarPaciente.ButtonText = "Restaurar Paciente";
            this.btnRestaurarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarPaciente.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestaurarPaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRestaurarPaciente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestaurarPaciente.Iconimage")));
            this.btnRestaurarPaciente.Iconimage_right = null;
            this.btnRestaurarPaciente.Iconimage_right_Selected = null;
            this.btnRestaurarPaciente.Iconimage_Selected = null;
            this.btnRestaurarPaciente.IconMarginLeft = 0;
            this.btnRestaurarPaciente.IconMarginRight = 0;
            this.btnRestaurarPaciente.IconRightVisible = true;
            this.btnRestaurarPaciente.IconRightZoom = 0D;
            this.btnRestaurarPaciente.IconVisible = true;
            this.btnRestaurarPaciente.IconZoom = 70D;
            this.btnRestaurarPaciente.IsTab = false;
            this.btnRestaurarPaciente.Location = new System.Drawing.Point(496, 464);
            this.btnRestaurarPaciente.Name = "btnRestaurarPaciente";
            this.btnRestaurarPaciente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.btnRestaurarPaciente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnRestaurarPaciente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRestaurarPaciente.selected = false;
            this.btnRestaurarPaciente.Size = new System.Drawing.Size(162, 39);
            this.btnRestaurarPaciente.TabIndex = 20;
            this.btnRestaurarPaciente.Text = "Restaurar Paciente";
            this.btnRestaurarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestaurarPaciente.Textcolor = System.Drawing.Color.White;
            this.btnRestaurarPaciente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarPaciente.Click += new System.EventHandler(this.btnRestaurarPaciente_Click_1);
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnEliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnEliminarPaciente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarPaciente.BorderRadius = 0;
            this.btnEliminarPaciente.ButtonText = "Eliminar Paciente";
            this.btnEliminarPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPaciente.DisabledColor = System.Drawing.Color.Gray;
            this.btnEliminarPaciente.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEliminarPaciente.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPaciente.Iconimage")));
            this.btnEliminarPaciente.Iconimage_right = null;
            this.btnEliminarPaciente.Iconimage_right_Selected = null;
            this.btnEliminarPaciente.Iconimage_Selected = null;
            this.btnEliminarPaciente.IconMarginLeft = 0;
            this.btnEliminarPaciente.IconMarginRight = 0;
            this.btnEliminarPaciente.IconRightVisible = true;
            this.btnEliminarPaciente.IconRightZoom = 0D;
            this.btnEliminarPaciente.IconVisible = true;
            this.btnEliminarPaciente.IconZoom = 70D;
            this.btnEliminarPaciente.IsTab = false;
            this.btnEliminarPaciente.Location = new System.Drawing.Point(315, 464);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.btnEliminarPaciente.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnEliminarPaciente.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEliminarPaciente.selected = false;
            this.btnEliminarPaciente.Size = new System.Drawing.Size(162, 39);
            this.btnEliminarPaciente.TabIndex = 19;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPaciente.Textcolor = System.Drawing.Color.White;
            this.btnEliminarPaciente.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPaciente.Click += new System.EventHandler(this.btnEliminarPaciente_Click_1);
            // 
            // btnCargar
            // 
            this.btnCargar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.BorderRadius = 0;
            this.btnCargar.ButtonText = "Atender Paciente";
            this.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargar.DisabledColor = System.Drawing.Color.Gray;
            this.btnCargar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCargar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCargar.Iconimage")));
            this.btnCargar.Iconimage_right = null;
            this.btnCargar.Iconimage_right_Selected = null;
            this.btnCargar.Iconimage_Selected = null;
            this.btnCargar.IconMarginLeft = 0;
            this.btnCargar.IconMarginRight = 0;
            this.btnCargar.IconRightVisible = true;
            this.btnCargar.IconRightZoom = 0D;
            this.btnCargar.IconVisible = true;
            this.btnCargar.IconZoom = 90D;
            this.btnCargar.IsTab = false;
            this.btnCargar.Location = new System.Drawing.Point(129, 464);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.btnCargar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnCargar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCargar.selected = false;
            this.btnCargar.Size = new System.Drawing.Size(162, 39);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Atender Paciente";
            this.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Textcolor = System.Drawing.Color.White;
            this.btnCargar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // PanelCabecera
            // 
            this.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.PanelCabecera.Controls.Add(this.btnRestaurar);
            this.PanelCabecera.Controls.Add(this.btnMinimizar);
            this.PanelCabecera.Controls.Add(this.btnMaximizar);
            this.PanelCabecera.Controls.Add(this.btnCerrar);
            this.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCabecera.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecera.Name = "PanelCabecera";
            this.PanelCabecera.Size = new System.Drawing.Size(826, 40);
            this.PanelCabecera.TabIndex = 19;
            this.PanelCabecera.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCabecera_Paint);
            this.PanelCabecera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelCabecera_MouseDown);
            this.PanelCabecera.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelCabecera_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.FlatAppearance.BorderSize = 0;
            this.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(743, 0);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(40, 40);
            this.btnRestaurar.TabIndex = 7;
            this.btnRestaurar.Text = "";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Visible = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(700, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(40, 40);
            this.btnMinimizar.TabIndex = 6;
            this.btnMinimizar.Text = "";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizar.ForeColor = System.Drawing.Color.White;
            this.btnMaximizar.Location = new System.Drawing.Point(743, 0);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(40, 40);
            this.btnMaximizar.TabIndex = 5;
            this.btnMaximizar.UseVisualStyleBackColor = true;
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
            this.btnCerrar.Location = new System.Drawing.Point(786, 0);
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
            // frmCargarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 601);
            this.Controls.Add(this.PanelCabecera);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCargarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCargarPaciente";
            this.Load += new System.EventHandler(this.frmCargarPaciente_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCargarPaciente_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCargarPaciente_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelCabecera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Apellido1;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbxSegundoApellido;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxSegundoNombre;
        private System.Windows.Forms.TextBox tbxNombrePaciente;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox tbxTexto;
        private System.Windows.Forms.Button btnBuscarTexto;
        private System.Windows.Forms.Button btnRecargarDGV;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel PanelCabecera;
        internal System.Windows.Forms.Button btnRestaurar;
        internal System.Windows.Forms.Button btnMinimizar;
        internal System.Windows.Forms.Button btnMaximizar;
        internal System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCargar;
        private Bunifu.Framework.UI.BunifuFlatButton btnEliminarPaciente;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestaurarPaciente;
    }
}