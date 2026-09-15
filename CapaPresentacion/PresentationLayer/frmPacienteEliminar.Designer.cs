namespace CapaPresentacion.PresentationLayer
{
    partial class frmPacienteEliminar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPacientesEliminados = new System.Windows.Forms.DataGridView();
            this.btnEliminarPaciente = new System.Windows.Forms.Button();
            this.btnRestaurarPaciente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPacientesEliminados);
            this.groupBox1.Location = new System.Drawing.Point(34, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 321);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacientes Eliminados";
            // 
            // dgvPacientesEliminados
            // 
            this.dgvPacientesEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientesEliminados.Location = new System.Drawing.Point(7, 20);
            this.dgvPacientesEliminados.Name = "dgvPacientesEliminados";
            this.dgvPacientesEliminados.Size = new System.Drawing.Size(812, 295);
            this.dgvPacientesEliminados.TabIndex = 0;
            // 
            // btnEliminarPaciente
            // 
            this.btnEliminarPaciente.Location = new System.Drawing.Point(178, 367);
            this.btnEliminarPaciente.Name = "btnEliminarPaciente";
            this.btnEliminarPaciente.Size = new System.Drawing.Size(82, 44);
            this.btnEliminarPaciente.TabIndex = 3;
            this.btnEliminarPaciente.Text = "Eliminar Paciente";
            this.btnEliminarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnRestaurarPaciente
            // 
            this.btnRestaurarPaciente.Location = new System.Drawing.Point(41, 367);
            this.btnRestaurarPaciente.Name = "btnRestaurarPaciente";
            this.btnRestaurarPaciente.Size = new System.Drawing.Size(82, 44);
            this.btnRestaurarPaciente.TabIndex = 4;
            this.btnRestaurarPaciente.Text = "Restaurar Paciente";
            this.btnRestaurarPaciente.UseVisualStyleBackColor = true;
            // 
            // frmPacienteEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarPaciente);
            this.Controls.Add(this.btnRestaurarPaciente);
            this.Name = "frmPacienteEliminar";
            this.Text = "Eliminar paciente";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientesEliminados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPacientesEliminados;
        private System.Windows.Forms.Button btnEliminarPaciente;
        private System.Windows.Forms.Button btnRestaurarPaciente;
    }
}