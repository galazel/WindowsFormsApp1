namespace WindowsFormsApp1
{
    partial class LiveResults
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.result_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.position_name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.result_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // result_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.result_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.result_chart.Legends.Add(legend2);
            this.result_chart.Location = new System.Drawing.Point(15, 43);
            this.result_chart.Margin = new System.Windows.Forms.Padding(4);
            this.result_chart.Name = "result_chart";
            this.result_chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.result_chart.Size = new System.Drawing.Size(993, 271);
            this.result_chart.TabIndex = 0;
            this.result_chart.Text = "chart1";
            // 
            // position_name_label
            // 
            this.position_name_label.AutoSize = true;
            this.position_name_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_name_label.ForeColor = System.Drawing.Color.Black;
            this.position_name_label.Location = new System.Drawing.Point(9, 7);
            this.position_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position_name_label.Name = "position_name_label";
            this.position_name_label.Size = new System.Drawing.Size(222, 32);
            this.position_name_label.TabIndex = 13;
            this.position_name_label.Text = "POSITION NAME";
            // 
            // LiveResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.position_name_label);
            this.Controls.Add(this.result_chart);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LiveResults";
            this.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Size = new System.Drawing.Size(1031, 344);
            ((System.ComponentModel.ISupportInitialize)(this.result_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart result_chart;
        private System.Windows.Forms.Label position_name_label;
    }
}
