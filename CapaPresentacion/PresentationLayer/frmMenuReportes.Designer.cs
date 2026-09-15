namespace CapaPresentacion.PresentationLayer
{
    partial class frmMenuReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuReportes));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rbPacientes = new System.Windows.Forms.RadioButton();
            this.rbConsultas = new System.Windows.Forms.RadioButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label46 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PanelCabecera = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PanelCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnGenerar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(9)))), ((int)(((byte)(75)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerar.Location = new System.Drawing.Point(105, 171);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(96, 37);
            this.btnGenerar.TabIndex = 27;
            this.btnGenerar.Text = "Ir a reporte";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rbPacientes
            // 
            this.rbPacientes.AutoSize = true;
            this.rbPacientes.Location = new System.Drawing.Point(89, 81);
            this.rbPacientes.Name = "rbPacientes";
            this.rbPacientes.Size = new System.Drawing.Size(112, 17);
            this.rbPacientes.TabIndex = 28;
            this.rbPacientes.TabStop = true;
            this.rbPacientes.Text = "Lista de Pacientes";
            this.rbPacientes.UseVisualStyleBackColor = true;
            this.rbPacientes.Click += new System.EventHandler(this.rbPacientes_Click);
            // 
            // rbConsultas
            // 
            this.rbConsultas.AutoSize = true;
            this.rbConsultas.Location = new System.Drawing.Point(89, 117);
            this.rbConsultas.Name = "rbConsultas";
            this.rbConsultas.Size = new System.Drawing.Size(133, 17);
            this.rbConsultas.TabIndex = 30;
            this.rbConsultas.TabStop = true;
            this.rbConsultas.Text = "Consultas por paciente";
            this.rbConsultas.UseVisualStyleBackColor = true;
            this.rbConsultas.CheckedChanged += new System.EventHandler(this.rbConsultas_CheckedChanged);
            this.rbConsultas.Click += new System.EventHandler(this.rbConsultas_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.label46.Location = new System.Drawing.Point(9, 8);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(121, 19);
            this.label46.TabIndex = 8;
            this.label46.Text = "Cargar Reportes";
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
            this.btnCerrar.Location = new System.Drawing.Point(263, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(40, 40);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // PanelCabecera
            // 
            this.PanelCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(139)))), ((int)(((byte)(211)))));
            this.PanelCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelCabecera.Controls.Add(this.label46);
            this.PanelCabecera.Controls.Add(this.btnCerrar);
            this.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelCabecera.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PanelCabecera.Location = new System.Drawing.Point(0, 0);
            this.PanelCabecera.Name = "PanelCabecera";
            this.PanelCabecera.Size = new System.Drawing.Size(305, 40);
            this.PanelCabecera.TabIndex = 32;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelCabecera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frmMenuReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(305, 277);
            this.Controls.Add(this.PanelCabecera);
            this.Controls.Add(this.rbConsultas);
            this.Controls.Add(this.rbPacientes);
            this.Controls.Add(this.btnGenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Reportes";
            this.PanelCabecera.ResumeLayout(false);
            this.PanelCabecera.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RadioButton rbPacientes;
        private System.Windows.Forms.RadioButton rbConsultas;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Panel PanelCabecera;
        private System.Windows.Forms.Label label46;
        internal System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}