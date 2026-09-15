namespace CapaPresentacion.Stats
{
    partial class frmDiagnosticos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiagnosticos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label46 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.PanelCabecera = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaPacientes = new System.Windows.Forms.DataGridView();
            this.chartPeso = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.PanelCabecera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(535, 81);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Diagnosticos";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(370, 356);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(602, 43);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(238, 24);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Diagnósticos registrados";
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
            this.label46.Size = new System.Drawing.Size(172, 19);
            this.label46.TabIndex = 8;
            this.label46.Text = "Estadísticas Diagnóstico";
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
            this.btnCerrar.Location = new System.Drawing.Point(885, 0);
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
            this.PanelCabecera.Size = new System.Drawing.Size(927, 40);
            this.PanelCabecera.TabIndex = 33;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PanelCabecera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Curva de Peso x Mes (Kg)";
            // 
            // dgvListaPacientes
            // 
            this.dgvListaPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacientes.Location = new System.Drawing.Point(29, 27);
            this.dgvListaPacientes.Name = "dgvListaPacientes";
            this.dgvListaPacientes.Size = new System.Drawing.Size(392, 115);
            this.dgvListaPacientes.TabIndex = 35;
            this.dgvListaPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPacientes_CellClick);
            // 
            // chartPeso
            // 
            this.chartPeso.BorderlineColor = System.Drawing.Color.Black;
            this.chartPeso.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chartPeso.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPeso.Legends.Add(legend2);
            this.chartPeso.Location = new System.Drawing.Point(29, 165);
            this.chartPeso.Name = "chartPeso";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.CustomProperties = "IsXAxisQuantitative=True";
            series2.IsValueShownAsLabel = true;
            series2.LabelToolTip = "#VALX";
            series2.Legend = "Legend1";
            series2.Name = "Peso";
            this.chartPeso.Series.Add(series2);
            this.chartPeso.Size = new System.Drawing.Size(392, 241);
            this.chartPeso.TabIndex = 37;
            this.chartPeso.Text = "Peso Kilográmos";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvListaPacientes);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.chartPeso);
            this.panel1.Location = new System.Drawing.Point(51, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 409);
            this.panel1.TabIndex = 38;
            // 
            // frmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelCabecera);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDiagnosticos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas Diagnóstico";
            this.Load += new System.EventHandler(this.frmDiagnosticos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.PanelCabecera.ResumeLayout(false);
            this.PanelCabecera.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPeso)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbltitulo;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        internal System.Windows.Forms.Panel PanelCabecera;
        private System.Windows.Forms.Label label46;
        internal System.Windows.Forms.Button btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaPacientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPeso;
    }
}