namespace WindowsFormsApp1
{
    partial class SummaryPanel
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
            this.position_label = new System.Windows.Forms.Label();
            this.candidate_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_label.Location = new System.Drawing.Point(6, 6);
            this.position_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(72, 16);
            this.position_label.TabIndex = 50;
            this.position_label.Text = "PRESIDENT";
            // 
            // candidate_label
            // 
            this.candidate_label.AutoSize = true;
            this.candidate_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_label.Location = new System.Drawing.Point(6, 22);
            this.candidate_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.candidate_label.Name = "candidate_label";
            this.candidate_label.Size = new System.Drawing.Size(159, 23);
            this.candidate_label.TabIndex = 51;
            this.candidate_label.Text = "CANDIDATE NAE";
            // 
            // SummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.candidate_label);
            this.Controls.Add(this.position_label);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SummaryPanel";
            this.Size = new System.Drawing.Size(193, 58);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_label;
        private System.Windows.Forms.Label candidate_label;
    }
}
