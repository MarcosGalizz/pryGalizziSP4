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
            this.btnKmCamion = new System.Windows.Forms.Button();
            this.btnGastosCamion = new System.Windows.Forms.Button();
            this.btnKgCamion = new System.Windows.Forms.Button();
            this.btnGasViaCamion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboTipoChart = new System.Windows.Forms.ComboBox();
            this.lblTipoChart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).BeginInit();
            this.statusStripConexion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chtCamiones
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.ScaleView.Size = 5D;
            chartArea1.AxisX.Title = "Camiones";
            chartArea1.Name = "ChartArea1";
            this.chtCamiones.ChartAreas.Add(chartArea1);
            this.chtCamiones.Location = new System.Drawing.Point(200, 31);
            this.chtCamiones.Name = "chtCamiones";
            this.chtCamiones.Size = new System.Drawing.Size(618, 353);
            this.chtCamiones.TabIndex = 0;
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConexion});
            this.statusStripConexion.Location = new System.Drawing.Point(0, 410);
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
            // btnKmCamion
            // 
            this.btnKmCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKmCamion.Location = new System.Drawing.Point(14, 22);
            this.btnKmCamion.Name = "btnKmCamion";
            this.btnKmCamion.Size = new System.Drawing.Size(135, 45);
            this.btnKmCamion.TabIndex = 4;
            this.btnKmCamion.Text = "Kilometros por Camión";
            this.btnKmCamion.UseVisualStyleBackColor = true;
            this.btnKmCamion.Click += new System.EventHandler(this.btnKmCamion_Click);
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastosCamion.Location = new System.Drawing.Point(14, 86);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(135, 45);
            this.btnGastosCamion.TabIndex = 5;
            this.btnGastosCamion.Text = "Gastos por Camión";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            this.btnGastosCamion.Click += new System.EventHandler(this.btnGastosCamion_Click);
            // 
            // btnKgCamion
            // 
            this.btnKgCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKgCamion.Location = new System.Drawing.Point(14, 158);
            this.btnKgCamion.Name = "btnKgCamion";
            this.btnKgCamion.Size = new System.Drawing.Size(135, 45);
            this.btnKgCamion.TabIndex = 6;
            this.btnKgCamion.Text = "Kilogramos por Camión";
            this.btnKgCamion.UseVisualStyleBackColor = true;
            this.btnKgCamion.Click += new System.EventHandler(this.btnKgCamion_Click);
            // 
            // btnGasViaCamion
            // 
            this.btnGasViaCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGasViaCamion.Location = new System.Drawing.Point(14, 224);
            this.btnGasViaCamion.Name = "btnGasViaCamion";
            this.btnGasViaCamion.Size = new System.Drawing.Size(135, 45);
            this.btnGasViaCamion.TabIndex = 7;
            this.btnGasViaCamion.Text = "Gastos/Viaticos por Camión";
            this.btnGasViaCamion.UseVisualStyleBackColor = true;
            this.btnGasViaCamion.Click += new System.EventHandler(this.btnGasViaCamion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnKmCamion);
            this.panel1.Controls.Add(this.btnGasViaCamion);
            this.panel1.Controls.Add(this.btnGastosCamion);
            this.panel1.Controls.Add(this.btnKgCamion);
            this.panel1.Location = new System.Drawing.Point(10, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 300);
            this.panel1.TabIndex = 8;
            // 
            // cboTipoChart
            // 
            this.cboTipoChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoChart.FormattingEnabled = true;
            this.cboTipoChart.Items.AddRange(new object[] {
            "Columna",
            "Línea",
            "Barra",
            "Burbuja"});
            this.cboTipoChart.Location = new System.Drawing.Point(10, 51);
            this.cboTipoChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoChart.Name = "cboTipoChart";
            this.cboTipoChart.Size = new System.Drawing.Size(169, 21);
            this.cboTipoChart.TabIndex = 9;
            this.cboTipoChart.SelectedIndexChanged += new System.EventHandler(this.cboTipoChart_SelectedIndexChanged);
            // 
            // lblTipoChart
            // 
            this.lblTipoChart.AutoSize = true;
            this.lblTipoChart.BackColor = System.Drawing.Color.White;
            this.lblTipoChart.Location = new System.Drawing.Point(10, 33);
            this.lblTipoChart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoChart.Name = "lblTipoChart";
            this.lblTipoChart.Size = new System.Drawing.Size(83, 13);
            this.lblTipoChart.TabIndex = 10;
            this.lblTipoChart.Text = "Tipo de Gráfico:";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(854, 432);
            this.Controls.Add(this.lblTipoChart);
            this.Controls.Add(this.cboTipoChart);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStripConexion);
            this.Controls.Add(this.chtCamiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística de Consumo/Kilogramos/Gastos Por Camión";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).EndInit();
            this.statusStripConexion.ResumeLayout(false);
            this.statusStripConexion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtCamiones;
        private System.Windows.Forms.StatusStrip statusStripConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConexion;
        private System.Windows.Forms.Button btnKmCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button btnKgCamion;
        private System.Windows.Forms.Button btnGasViaCamion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboTipoChart;
        private System.Windows.Forms.Label lblTipoChart;
    }
}