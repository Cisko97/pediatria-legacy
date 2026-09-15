namespace CapaPresentacion.PresentationLayer
{
    partial class frmRestaurarDosisVacunas
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
            this.btnRestaurarDosis = new System.Windows.Forms.Button();
            this.btnEliminarDosis = new System.Windows.Forms.Button();
            this.dgvDosisEliminadas = new System.Windows.Forms.DataGridView();
            this.gbDosisVacunas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosisEliminadas)).BeginInit();
            this.gbDosisVacunas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRestaurarDosis
            // 
            this.btnRestaurarDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarDosis.Location = new System.Drawing.Point(51, 229);
            this.btnRestaurarDosis.Name = "btnRestaurarDosis";
            this.btnRestaurarDosis.Size = new System.Drawing.Size(109, 45);
            this.btnRestaurarDosis.TabIndex = 5;
            this.btnRestaurarDosis.Text = "Restaurar";
            this.btnRestaurarDosis.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDosis
            // 
            this.btnEliminarDosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDosis.Location = new System.Drawing.Point(350, 229);
            this.btnEliminarDosis.Name = "btnEliminarDosis";
            this.btnEliminarDosis.Size = new System.Drawing.Size(109, 45);
            this.btnEliminarDosis.TabIndex = 4;
            this.btnEliminarDosis.Text = "Eliminar por completo";
            this.btnEliminarDosis.UseVisualStyleBackColor = true;
            // 
            // dgvDosisEliminadas
            // 
            this.dgvDosisEliminadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDosisEliminadas.Location = new System.Drawing.Point(27, 19);
            this.dgvDosisEliminadas.Name = "dgvDosisEliminadas";
            this.dgvDosisEliminadas.Size = new System.Drawing.Size(408, 163);
            this.dgvDosisEliminadas.TabIndex = 2;
            // 
            // gbDosisVacunas
            // 
            this.gbDosisVacunas.Controls.Add(this.dgvDosisEliminadas);
            this.gbDosisVacunas.Location = new System.Drawing.Point(24, 27);
            this.gbDosisVacunas.Name = "gbDosisVacunas";
            this.gbDosisVacunas.Size = new System.Drawing.Size(465, 196);
            this.gbDosisVacunas.TabIndex = 6;
            this.gbDosisVacunas.TabStop = false;
            this.gbDosisVacunas.Text = "Dosis Eliminadas";
            // 
            // frmRestaurarDosisVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.btnRestaurarDosis);
            this.Controls.Add(this.btnEliminarDosis);
            this.Controls.Add(this.gbDosisVacunas);
            this.Name = "frmRestaurarDosisVacunas";
            this.Text = "frmRestaurarDosisVacunas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDosisEliminadas)).EndInit();
            this.gbDosisVacunas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestaurarDosis;
        private System.Windows.Forms.Button btnEliminarDosis;
        private System.Windows.Forms.DataGridView dgvDosisEliminadas;
        private System.Windows.Forms.GroupBox gbDosisVacunas;
    }
}