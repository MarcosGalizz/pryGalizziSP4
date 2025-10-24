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
            this.chtCamiones.Location = new System.Drawing.Point(271, 82);
            this.chtCamiones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chtCamiones.Name = "chtCamiones";
            this.chtCamiones.Size = new System.Drawing.Size(824, 369);
            this.chtCamiones.TabIndex = 0;
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConexion});
            this.statusStripConexion.Location = new System.Drawing.Point(0, 528);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStripConexion.Size = new System.Drawing.Size(1139, 26);
            this.statusStripConexion.TabIndex = 1;
            this.statusStripConexion.Text = "statusStripConexion";
            // 
            // toolStripStatusLabelConexion
            // 
            this.toolStripStatusLabelConexion.Name = "toolStripStatusLabelConexion";
            this.toolStripStatusLabelConexion.Size = new System.Drawing.Size(15, 20);
            this.toolStripStatusLabelConexion.Text = "-";
            // 
            // btnKmCamion
            // 
            this.btnKmCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKmCamion.Location = new System.Drawing.Point(16, 122);
            this.btnKmCamion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKmCamion.Name = "btnKmCamion";
            this.btnKmCamion.Size = new System.Drawing.Size(180, 55);
            this.btnKmCamion.TabIndex = 4;
            this.btnKmCamion.Text = "Kilometros por Camión";
            this.btnKmCamion.UseVisualStyleBackColor = true;
            this.btnKmCamion.Click += new System.EventHandler(this.btnKmCamion_Click);
            // 
            // btnGastosCamion
            // 
            this.btnGastosCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGastosCamion.Location = new System.Drawing.Point(16, 201);
            this.btnGastosCamion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGastosCamion.Name = "btnGastosCamion";
            this.btnGastosCamion.Size = new System.Drawing.Size(180, 55);
            this.btnGastosCamion.TabIndex = 5;
            this.btnGastosCamion.Text = "Gastos por Camión";
            this.btnGastosCamion.UseVisualStyleBackColor = true;
            this.btnGastosCamion.Click += new System.EventHandler(this.btnGastosCamion_Click);
            // 
            // btnKgCamion
            // 
            this.btnKgCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKgCamion.Location = new System.Drawing.Point(16, 289);
            this.btnKgCamion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKgCamion.Name = "btnKgCamion";
            this.btnKgCamion.Size = new System.Drawing.Size(180, 55);
            this.btnKgCamion.TabIndex = 6;
            this.btnKgCamion.Text = "Kilogramos por Camión";
            this.btnKgCamion.UseVisualStyleBackColor = true;
            this.btnKgCamion.Click += new System.EventHandler(this.btnKgCamion_Click);
            // 
            // btnGasViaCamion
            // 
            this.btnGasViaCamion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGasViaCamion.Location = new System.Drawing.Point(16, 370);
            this.btnGasViaCamion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGasViaCamion.Name = "btnGasViaCamion";
            this.btnGasViaCamion.Size = new System.Drawing.Size(180, 55);
            this.btnGasViaCamion.TabIndex = 7;
            this.btnGasViaCamion.Text = "Gastos/Viaticos por Camión";
            this.btnGasViaCamion.UseVisualStyleBackColor = true;
            this.btnGasViaCamion.Click += new System.EventHandler(this.btnGasViaCamion_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(1139, 554);
            this.Controls.Add(this.btnGasViaCamion);
            this.Controls.Add(this.btnKgCamion);
            this.Controls.Add(this.btnGastosCamion);
            this.Controls.Add(this.btnKmCamion);
            this.Controls.Add(this.statusStripConexion);
            this.Controls.Add(this.chtCamiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnKmCamion;
        private System.Windows.Forms.Button btnGastosCamion;
        private System.Windows.Forms.Button btnKgCamion;
        private System.Windows.Forms.Button btnGasViaCamion;
    }
}