namespace WindowsFormsApp1
{
    partial class AdminResultsPanel
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
            this.results_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // results_flow
            // 
            this.results_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.results_flow.Location = new System.Drawing.Point(141, 107);
            this.results_flow.Name = "results_flow";
            this.results_flow.Size = new System.Drawing.Size(757, 362);
            this.results_flow.TabIndex = 24;
            this.results_flow.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ELECTION RESULTS";
            // 
            // AdminResultsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.results_flow);
            this.Controls.Add(this.label2);
            this.Name = "AdminResultsPanel";
            this.Size = new System.Drawing.Size(1037, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel results_flow;
        private System.Windows.Forms.Label label2;
    }
}
