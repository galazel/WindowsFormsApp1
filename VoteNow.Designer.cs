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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chosen_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vote_candidates_flow
            // 
            this.vote_candidates_flow.AutoScroll = true;
            this.vote_candidates_flow.BackColor = System.Drawing.Color.Transparent;
            this.vote_candidates_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.vote_candidates_flow.Location = new System.Drawing.Point(12, 95);
            this.vote_candidates_flow.Name = "vote_candidates_flow";
            this.vote_candidates_flow.Size = new System.Drawing.Size(776, 496);
            this.vote_candidates_flow.TabIndex = 0;
            this.vote_candidates_flow.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(279, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "CHOOSE YOUR CANDIDATES";
            // 
            // vote_candidate_bttn
            // 
            this.vote_candidate_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.vote_candidate_bttn.Cursor = System.Windows.Forms.Cursors.Default;
            this.vote_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_candidate_bttn.ForeColor = System.Drawing.Color.White;
            this.vote_candidate_bttn.Location = new System.Drawing.Point(17, 431);
            this.vote_candidate_bttn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.vote_candidate_bttn.Name = "vote_candidate_bttn";
            this.vote_candidate_bttn.Size = new System.Drawing.Size(250, 46);
            this.vote_candidate_bttn.TabIndex = 33;
            this.vote_candidate_bttn.Text = "CONFIRM";
            this.vote_candidate_bttn.UseVisualStyleBackColor = false;
            this.vote_candidate_bttn.Click += new System.EventHandler(this.vote_candidate_bttn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chosen_flow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vote_candidate_bttn);
            this.panel1.Location = new System.Drawing.Point(794, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 496);
            this.panel1.TabIndex = 34;
            // 
            // chosen_flow
            // 
            this.chosen_flow.AutoScroll = true;
            this.chosen_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.chosen_flow.Location = new System.Drawing.Point(17, 40);
            this.chosen_flow.Name = "chosen_flow";
            this.chosen_flow.Padding = new System.Windows.Forms.Padding(1);
            this.chosen_flow.Size = new System.Drawing.Size(250, 384);
            this.chosen_flow.TabIndex = 36;
            this.chosen_flow.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(101, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "SUMMARY";
            // 
            // VoteNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1093, 603);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vote_candidates_flow);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VoteNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoteNow";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel vote_candidates_flow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vote_candidate_bttn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel chosen_flow;
    }
}