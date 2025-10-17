namespace pryGalizziSP4
{
    partial class frmInicio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.chtCamiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStripConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.CboTipoGrafico = new System.Windows.Forms.ComboBox();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            this.btnKmCamion = new System.Windows.Forms.Button();
            this.btnGastosCamion = new System.Windows.Forms.Button();
            this.btnKgCamion = new System.Windows.Forms.Button();
            this.btnGasViaCamion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).BeginInit();
            this.statusStripConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtCamiones
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.ScaleView.Size = 5D;
            chartArea1.AxisX.Title = "Camiones";
            chartArea1.Name = "ChartArea1";
            this.chtCamiones.ChartAreas.Add(chartArea1);
            this.chtCamiones.Location = new System.Drawing.Point(203, 67);
            this.chtCamiones.Name = "chtCamiones";
            this.chtCamiones.Size = new System.Drawing.Size(618, 300);
            this.chtCamiones.TabIndex = 0;
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConexion});
            this.statusStripConexion.Location = new System.Drawing.Point(0, 428);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.Size = new System.Drawing.Size(854, 22);
            this.statusStripConexion.TabIndex = 1;
            this.statusStripConexion.Text = "statusStripConexion";
            // 
            // toolStripStatusLabelConexion
            // 
            this.toolStripStatusLabelConexion.Name = "toolStripStatusLabelConexion";
            this.toolStripStatusLabelConexion.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabelConexion.Text = "-";
            // 
            // CboTipoGrafico
            // 
            this.CboTipoGrafico.FormattingEnabled = true;
            this.CboTipoGrafico.Location = new System.Drawing.Point(12, 46);
            this.CboTipoGrafico.Name = "CboTipoGrafico";
            this.CboTipoGrafico.Size = new System.Drawing.Size(159, 21);
            this.CboTipoGrafico.TabIndex = 2;
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Location = new System.Drawing.Point(12, 20);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(80, 13);
            this.lblTipoGrafico.TabIndex = 3;
            this.lblTipoGrafico.Text = "Tipo de Gráfico";
            // 
            // btnKmCamion
            // 
            this.btnKmCamion.Location = new System.Drawing.Point(12, 99);
            this.btnKmCamion.Name = "btnKmCamion";
            this.btnKmCamion.Size = new System.Drawing.Size(135, 45);
            this.btnKmCamion.TabIndex = 4;
            this.btnKmCamion.Text = "Kilometros por Camión";
            this.btnKmCamion.UseVisualStyleBackColor = true;
            this.btnKmCamion.Click += new System.EventHandler(this.btnKmCamion_Click);
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Location = new System.Drawing.Point(12, 163);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(135, 45);
            this.btnGastosCamion.TabIndex = 5;
            this.btnGastosCamion.Text = "Gastos por Camión";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            this.btnGastosCamion.Click += new System.EventHandler(this.btnGastosCamion_Click);
            // 
            // btnKgCamion
            // 
            this.btnKgCamion.Location = new System.Drawing.Point(12, 235);
            this.btnKgCamion.Name = "btnKgCamion";
            this.btnKgCamion.Size = new System.Drawing.Size(135, 45);
            this.btnKgCamion.TabIndex = 6;
            this.btnKgCamion.Text = "Kilogramos por Camión";
            this.btnKgCamion.UseVisualStyleBackColor = true;
            this.btnKgCamion.Click += new System.EventHandler(this.btnKgCamion_Click);
            // 
            // btnGasViaCamion
            // 
            this.btnGasViaCamion.Location = new System.Drawing.Point(12, 301);
            this.btnGasViaCamion.Name = "btnGasViaCamion";
            this.btnGasViaCamion.Size = new System.Drawing.Size(135, 45);
            this.btnGasViaCamion.TabIndex = 7;
            this.btnGasViaCamion.Text = "Gastos/Viaticos por Camión";
            this.btnGasViaCamion.UseVisualStyleBackColor = true;
            this.btnGasViaCamion.Click += new System.EventHandler(this.btnGasViaCamion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btnGasViaCamion);
            this.Controls.Add(this.btnKgCamion);
            this.Controls.Add(this.btnGastosCamion);
            this.Controls.Add(this.btnKmCamion);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.CboTipoGrafico);
            this.Controls.Add(this.statusStripConexion);
            this.Controls.Add(this.chtCamiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de Consumo/Kilogramos/Gastos Por Camión";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).EndInit();
            this.statusStripConexion.ResumeLayout(false);
            this.statusStripConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtCamiones;
        private System.Windows.Forms.StatusStrip statusStripConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConexion;
        private System.Windows.Forms.ComboBox CboTipoGrafico;
        private System.Windows.Forms.Label lblTipoGrafico;
        private System.Windows.Forms.Button btnKmCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button btnKgCamion;
        private System.Windows.Forms.Button btnGasViaCamion;
    }
}