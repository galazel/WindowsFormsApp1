namespace WindowsFormsApp1
{
    partial class OngoingPanel
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
            this.department_label = new System.Windows.Forms.Label();
            this.election_name_label = new System.Windows.Forms.Label();
            this.view_details_bttn = new System.Windows.Forms.Button();
            this.end_bttn = new System.Windows.Forms.Button();
            this.ongoing_results_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_label.Location = new System.Drawing.Point(22, 42);
            this.department_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(145, 19);
            this.department_label.TabIndex = 50;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(22, 16);
            this.election_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(141, 19);
            this.election_name_label.TabIndex = 49;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // view_details_bttn
            // 
            this.view_details_bttn.BackColor = System.Drawing.Color.White;
            this.view_details_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_details_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_details_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.view_details_bttn.Location = new System.Drawing.Point(804, 16);
            this.view_details_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(76, 35);
            this.view_details_bttn.TabIndex = 51;
            this.view_details_bttn.Text = "VIEW";
            this.view_details_bttn.UseVisualStyleBackColor = false;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click);
            // 
            // end_bttn
            // 
            this.end_bttn.BackColor = System.Drawing.Color.White;
            this.end_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.end_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.end_bttn.Location = new System.Drawing.Point(888, 16);
            this.end_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.end_bttn.Name = "end_bttn";
            this.end_bttn.Size = new System.Drawing.Size(76, 35);
            this.end_bttn.TabIndex = 52;
            this.end_bttn.Text = "END";
            this.end_bttn.UseVisualStyleBackColor = false;
            this.end_bttn.Click += new System.EventHandler(this.end_bttn_Click);
            // 
            // ongoing_results_flow
            // 
            this.ongoing_results_flow.AutoScroll = true;
            this.ongoing_results_flow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.ongoing_results_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ongoing_results_flow.Location = new System.Drawing.Point(26, 75);
            this.ongoing_results_flow.Name = "ongoing_results_flow";
            this.ongoing_results_flow.Size = new System.Drawing.Size(966, 367);
            this.ongoing_results_flow.TabIndex = 53;
            // 
            // OngoingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.ongoing_results_flow);
            this.Controls.Add(this.end_bttn);
            this.Controls.Add(this.view_details_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OngoingPanel";
            this.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Size = new System.Drawing.Size(1016, 467);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Button view_details_bttn;
        private System.Windows.Forms.Button end_bttn;
        private System.Windows.Forms.FlowLayoutPanel ongoing_results_flow;
    }
}
