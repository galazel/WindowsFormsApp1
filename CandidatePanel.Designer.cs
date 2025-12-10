namespace WindowsFormsApp1
{
    partial class CandidatePanel
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
            this.candidate_image = new System.Windows.Forms.PictureBox();
            this.candidate_name_label = new System.Windows.Forms.Label();
            this.candidate_party_label = new System.Windows.Forms.Label();
            this.vote_candidate_bttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidate_image)).BeginInit();
            this.SuspendLayout();
            // 
            // candidate_image
            // 
            this.candidate_image.BackColor = System.Drawing.Color.Black;
            this.candidate_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.candidate_image.Location = new System.Drawing.Point(18, 20);
            this.candidate_image.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_image.Name = "candidate_image";
            this.candidate_image.Size = new System.Drawing.Size(191, 125);
            this.candidate_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candidate_image.TabIndex = 0;
            this.candidate_image.TabStop = false;
            // 
            // candidate_name_label
            // 
            this.candidate_name_label.AutoSize = true;
            this.candidate_name_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_name_label.ForeColor = System.Drawing.Color.Black;
            this.candidate_name_label.Location = new System.Drawing.Point(14, 160);
            this.candidate_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.candidate_name_label.Name = "candidate_name_label";
            this.candidate_name_label.Size = new System.Drawing.Size(166, 17);
            this.candidate_name_label.TabIndex = 14;
            this.candidate_name_label.Text = "Name: GLYZEL GALAGAR";
            // 
            // candidate_party_label
            // 
            this.candidate_party_label.AutoSize = true;
            this.candidate_party_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_party_label.ForeColor = System.Drawing.Color.Black;
            this.candidate_party_label.Location = new System.Drawing.Point(15, 181);
            this.candidate_party_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.candidate_party_label.Name = "candidate_party_label";
            this.candidate_party_label.Size = new System.Drawing.Size(44, 17);
            this.candidate_party_label.TabIndex = 15;
            this.candidate_party_label.Text = "Party:";
            // 
            // vote_candidate_bttn
            // 
            this.vote_candidate_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.vote_candidate_bttn.Cursor = System.Windows.Forms.Cursors.Default;
            this.vote_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_candidate_bttn.ForeColor = System.Drawing.Color.White;
            this.vote_candidate_bttn.Location = new System.Drawing.Point(18, 202);
            this.vote_candidate_bttn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.vote_candidate_bttn.Name = "vote_candidate_bttn";
            this.vote_candidate_bttn.Size = new System.Drawing.Size(191, 43);
            this.vote_candidate_bttn.TabIndex = 32;
            this.vote_candidate_bttn.Text = "VOTE";
            this.vote_candidate_bttn.UseVisualStyleBackColor = false;
            this.vote_candidate_bttn.Click += new System.EventHandler(this.vote_candidate_bttn_Click);
            // 
            // CandidatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.vote_candidate_bttn);
            this.Controls.Add(this.candidate_party_label);
            this.Controls.Add(this.candidate_name_label);
            this.Controls.Add(this.candidate_image);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CandidatePanel";
            this.Size = new System.Drawing.Size(228, 258);
            ((System.ComponentModel.ISupportInitialize)(this.candidate_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox candidate_image;
        private System.Windows.Forms.Label candidate_name_label;
        private System.Windows.Forms.Label candidate_party_label;
        private System.Windows.Forms.Button vote_candidate_bttn;
    }
}
