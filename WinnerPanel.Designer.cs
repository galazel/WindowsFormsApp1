namespace WindowsFormsApp1
{
    partial class WinnerPanel
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
            this.party = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.candidate_image = new System.Windows.Forms.PictureBox();
            this.votes = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidate_image)).BeginInit();
            this.SuspendLayout();
            // 
            // party
            // 
            this.party.AutoSize = true;
            this.party.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.party.ForeColor = System.Drawing.Color.Black;
            this.party.Location = new System.Drawing.Point(18, 184);
            this.party.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.party.Name = "party";
            this.party.Size = new System.Drawing.Size(44, 17);
            this.party.TabIndex = 35;
            this.party.Text = "Party:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(18, 150);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(169, 16);
            this.name.TabIndex = 34;
            this.name.Text = "Name: GLYZEL GALAGAR";
            // 
            // candidate_image
            // 
            this.candidate_image.BackColor = System.Drawing.Color.Black;
            this.candidate_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.candidate_image.Location = new System.Drawing.Point(21, 15);
            this.candidate_image.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_image.Name = "candidate_image";
            this.candidate_image.Size = new System.Drawing.Size(190, 128);
            this.candidate_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.candidate_image.TabIndex = 33;
            this.candidate_image.TabStop = false;
            // 
            // votes
            // 
            this.votes.AutoSize = true;
            this.votes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votes.ForeColor = System.Drawing.Color.Black;
            this.votes.Location = new System.Drawing.Point(18, 201);
            this.votes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.votes.Name = "votes";
            this.votes.Size = new System.Drawing.Size(48, 17);
            this.votes.TabIndex = 37;
            this.votes.Text = "Votes:";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.ForeColor = System.Drawing.Color.Black;
            this.position.Location = new System.Drawing.Point(18, 167);
            this.position.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(44, 17);
            this.position.TabIndex = 38;
            this.position.Text = "Party:";
            // 
            // WinnerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.position);
            this.Controls.Add(this.votes);
            this.Controls.Add(this.party);
            this.Controls.Add(this.name);
            this.Controls.Add(this.candidate_image);
            this.Name = "WinnerPanel";
            this.Size = new System.Drawing.Size(227, 230);
            ((System.ComponentModel.ISupportInitialize)(this.candidate_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label party;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox candidate_image;
        private System.Windows.Forms.Label votes;
        private System.Windows.Forms.Label position;
    }
}
