namespace CapaPresentacion.PresentationLayer
{
    partial class frmAgregarVacuna
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
            this.dgvVacunas = new System.Windows.Forms.DataGridView();
            this.btnEditarV = new System.Windows.Forms.Button();
            this.btnGuardarV = new System.Windows.Forms.Button();
            this.gpVacunas = new System.Windows.Forms.GroupBox();
            this.txtDescripcionVacuna = new System.Windows.Forms.TextBox();
            this.txtNombreVacuna = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblNombreVacuna = new System.Windows.Forms.Label();
            this.lblDosisNecesarias = new System.Windows.Forms.Label();
            this.cmbDosisNumero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).BeginInit();
            this.gpVacunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVacunas
            // 
            this.dgvVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVacunas.Location = new System.Drawing.Point(13, 19);
            this.dgvVacunas.Name = "dgvVacunas";
            this.dgvVacunas.Size = new System.Drawing.Size(284, 150);
            this.dgvVacunas.TabIndex = 3;
            this.dgvVacunas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVacunas_CellClick);
            // 
            // btnEditarV
            // 
            this.btnEditarV.Location = new System.Drawing.Point(322, 51);
            this.btnEditarV.Name = "btnEditarV";
            this.btnEditarV.Size = new System.Drawing.Size(75, 23);
            this.btnEditarV.TabIndex = 28;
            this.btnEditarV.Text = "Editar";
            this.btnEditarV.UseVisualStyleBackColor = true;
            this.btnEditarV.Click += new System.EventHandler(this.btnEditarV_Click);
            // 
            // btnGuardarV
            // 
            this.btnGuardarV.Location = new System.Drawing.Point(322, 15);
            this.btnGuardarV.Name = "btnGuardarV";
            this.btnGuardarV.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarV.TabIndex = 27;
            this.btnGuardarV.Text = "Guardar";
            this.btnGuardarV.UseVisualStyleBackColor = true;
            this.btnGuardarV.Click += new System.EventHandler(this.btnGuardarV_Click_1);
            // 
            // gpVacunas
            // 
            this.gpVacunas.Controls.Add(this.dgvVacunas);
            this.gpVacunas.Location = new System.Drawing.Point(24, 207);
            this.gpVacunas.Name = "gpVacunas";
            this.gpVacunas.Size = new System.Drawing.Size(317, 184);
            this.gpVacunas.TabIndex = 25;
            this.gpVacunas.TabStop = false;
            this.gpVacunas.Text = "Vacunas Registradas:";
            // 
            // txtDescripcionVacuna
            // 
            this.txtDescripcionVacuna.Location = new System.Drawing.Point(114, 50);
            this.txtDescripcionVacuna.Multiline = true;
            this.txtDescripcionVacuna.Name = "txtDescripcionVacuna";
            this.txtDescripcionVacuna.Size = new System.Drawing.Size(124, 104);
            this.txtDescripcionVacuna.TabIndex = 24;
            // 
            // txtNombreVacuna
            // 
            this.txtNombreVacuna.Location = new System.Drawing.Point(114, 17);
            this.txtNombreVacuna.Multiline = true;
            this.txtNombreVacuna.Name = "txtNombreVacuna";
            this.txtNombreVacuna.Size = new System.Drawing.Size(124, 20);
            this.txtNombreVacuna.TabIndex = 23;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(21, 53);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(66, 13);
            this.lblObservacion.TabIndex = 22;
            this.lblObservacion.Text = "Descripcion:";
            // 
            // lblNombreVacuna
            // 
            this.lblNombreVacuna.AutoSize = true;
            this.lblNombreVacuna.Location = new System.Drawing.Point(21, 20);
            this.lblNombreVacuna.Name = "lblNombreVacuna";
            this.lblNombreVacuna.Size = new System.Drawing.Size(87, 13);
            this.lblNombreVacuna.TabIndex = 21;
            this.lblNombreVacuna.Text = "Nombre Vacuna:";
            // 
            // lblDosisNecesarias
            // 
            this.lblDosisNecesarias.AutoSize = true;
            this.lblDosisNecesarias.Location = new System.Drawing.Point(21, 173);
            this.lblDosisNecesarias.Name = "lblDosisNecesarias";
            this.lblDosisNecesarias.Size = new System.Drawing.Size(92, 13);
            this.lblDosisNecesarias.TabIndex = 26;
            this.lblDosisNecesarias.Text = "Dosis Necesarias:";
            // 
            // cmbDosisNumero
            // 
            this.cmbDosisNumero.FormattingEnabled = true;
            this.cmbDosisNumero.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDosisNumero.Location = new System.Drawing.Point(119, 170);
            this.cmbDosisNumero.Name = "cmbDosisNumero";
            this.cmbDosisNumero.Size = new System.Drawing.Size(36, 21);
            this.cmbDosisNumero.TabIndex = 29;
            // 
            // frmAgregarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.cmbDosisNumero);
            this.Controls.Add(this.btnEditarV);
            this.Controls.Add(this.btnGuardarV);
            this.Controls.Add(this.lblDosisNecesarias);
            this.Controls.Add(this.gpVacunas);
            this.Controls.Add(this.txtDescripcionVacuna);
            this.Controls.Add(this.txtNombreVacuna);
            this.Controls.Add(this.lblObservacion);
            this.Controls.Add(this.lblNombreVacuna);
            this.Name = "frmAgregarVacuna";
            this.Text = "Catálogo de Vacunas";
            this.Load += new System.EventHandler(this.frmAgregarVacuna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVacunas)).EndInit();
            this.gpVacunas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvVacunas;
        private System.Windows.Forms.Button btnEditarV;
        private System.Windows.Forms.Button btnGuardarV;
        private System.Windows.Forms.GroupBox gpVacunas;
        private System.Windows.Forms.TextBox txtDescripcionVacuna;
        private System.Windows.Forms.TextBox txtNombreVacuna;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblNombreVacuna;
        private System.Windows.Forms.Label lblDosisNecesarias;
        private System.Windows.Forms.ComboBox cmbDosisNumero;
    }
}