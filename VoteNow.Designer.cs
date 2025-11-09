namespace WindowsFormsApp1
{
    partial class VoteNow
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
            this.vote_candidates_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.vote_candidate_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vote_candidates_flow
            // 
            this.vote_candidates_flow.AutoScroll = true;
            this.vote_candidates_flow.BackColor = System.Drawing.Color.Transparent;
            this.vote_candidates_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vote_candidates_flow.Location = new System.Drawing.Point(37, 91);
            this.vote_candidates_flow.Name = "vote_candidates_flow";
            this.vote_candidates_flow.Size = new System.Drawing.Size(1103, 533);
            this.vote_candidates_flow.TabIndex = 0;
            this.vote_candidates_flow.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(426, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "CHOOSE YOUR CANDIDATES";
            // 
            // vote_candidate_bttn
            // 
            this.vote_candidate_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(57)))), ((int)(((byte)(21)))));
            this.vote_candidate_bttn.Cursor = System.Windows.Forms.Cursors.Default;
            this.vote_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_candidate_bttn.ForeColor = System.Drawing.Color.White;
            this.vote_candidate_bttn.Location = new System.Drawing.Point(924, 649);
            this.vote_candidate_bttn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.vote_candidate_bttn.Name = "vote_candidate_bttn";
            this.vote_candidate_bttn.Size = new System.Drawing.Size(216, 46);
            this.vote_candidate_bttn.TabIndex = 33;
            this.vote_candidate_bttn.Text = "CONFIRM";
            this.vote_candidate_bttn.UseVisualStyleBackColor = false;
            this.vote_candidate_bttn.Click += new System.EventHandler(this.vote_candidate_bttn_Click);
            // 
            // VoteNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1180, 728);
            this.Controls.Add(this.vote_candidate_bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vote_candidates_flow);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoteNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoteNow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vote_candidates_flow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vote_candidate_bttn;
    }
}