namespace WindowsFormsApp1
{
    partial class ResultsPanel
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
            this.view_results_bttn = new System.Windows.Forms.Button();
            this.department_label = new System.Windows.Forms.Label();
            this.election_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // view_results_bttn
            // 
            this.view_results_bttn.Location = new System.Drawing.Point(635, 25);
            this.view_results_bttn.Name = "view_results_bttn";
            this.view_results_bttn.Size = new System.Drawing.Size(96, 23);
            this.view_results_bttn.TabIndex = 42;
            this.view_results_bttn.Text = "VIEW RESULTS";
            this.view_results_bttn.UseVisualStyleBackColor = true;
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(26, 47);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(113, 13);
            this.department_label.TabIndex = 41;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Location = new System.Drawing.Point(26, 25);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(113, 13);
            this.election_name_label.TabIndex = 40;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // ResultsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.view_results_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Name = "ResultsPanel";
            this.Size = new System.Drawing.Size(757, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button view_results_bttn;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label election_name_label;
    }
}
