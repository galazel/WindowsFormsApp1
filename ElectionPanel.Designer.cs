namespace WindowsFormsApp1
{
    partial class ElectionPanel
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
            this.election_name_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.view_details_bttn = new System.Windows.Forms.Button();
            this.start_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Location = new System.Drawing.Point(27, 23);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(113, 13);
            this.election_name_label.TabIndex = 23;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(27, 45);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(113, 13);
            this.department_label.TabIndex = 24;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // view_details_bttn
            // 
            this.view_details_bttn.Location = new System.Drawing.Point(636, 23);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(96, 23);
            this.view_details_bttn.TabIndex = 38;
            this.view_details_bttn.Text = "VIEW DETAILS";
            this.view_details_bttn.UseVisualStyleBackColor = true;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click);
            // 
            // start_bttn
            // 
            this.start_bttn.Location = new System.Drawing.Point(578, 23);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(52, 23);
            this.start_bttn.TabIndex = 39;
            this.start_bttn.Text = "START";
            this.start_bttn.UseVisualStyleBackColor = true;
            // 
            // ElectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.start_bttn);
            this.Controls.Add(this.view_details_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Name = "ElectionPanel";
            this.Size = new System.Drawing.Size(757, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Button view_details_bttn;
        private System.Windows.Forms.Button start_bttn;
    }
}
