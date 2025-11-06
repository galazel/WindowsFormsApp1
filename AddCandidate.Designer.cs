namespace WindowsFormsApp1
{
    partial class s
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
            this.label2 = new System.Windows.Forms.Label();
            this.candidate_name_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.candidate_partylist_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.candidate_positions_combo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_candidate_bttn = new System.Windows.Forms.Button();
            this.candidate_photo_picture = new FontAwesome.Sharp.IconPictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.motto_box = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.candidate_photo_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "ADD CANDIDATE";
            // 
            // candidate_name_box
            // 
            this.candidate_name_box.Location = new System.Drawing.Point(55, 120);
            this.candidate_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_name_box.Name = "candidate_name_box";
            this.candidate_name_box.Size = new System.Drawing.Size(392, 22);
            this.candidate_name_box.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name";
            // 
            // candidate_partylist_box
            // 
            this.candidate_partylist_box.Location = new System.Drawing.Point(55, 256);
            this.candidate_partylist_box.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_partylist_box.Name = "candidate_partylist_box";
            this.candidate_partylist_box.Size = new System.Drawing.Size(392, 22);
            this.candidate_partylist_box.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Position";
            // 
            // candidate_positions_combo
            // 
            this.candidate_positions_combo.FormattingEnabled = true;
            this.candidate_positions_combo.Location = new System.Drawing.Point(55, 183);
            this.candidate_positions_combo.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_positions_combo.Name = "candidate_positions_combo";
            this.candidate_positions_combo.Size = new System.Drawing.Size(392, 25);
            this.candidate_positions_combo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Partylist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 378);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "Photo";
            // 
            // add_candidate_bttn
            // 
            this.add_candidate_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_candidate_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.add_candidate_bttn.Location = new System.Drawing.Point(184, 570);
            this.add_candidate_bttn.Margin = new System.Windows.Forms.Padding(4);
            this.add_candidate_bttn.Name = "add_candidate_bttn";
            this.add_candidate_bttn.Size = new System.Drawing.Size(162, 30);
            this.add_candidate_bttn.TabIndex = 37;
            this.add_candidate_bttn.Text = "ADD CANDIDATE";
            this.add_candidate_bttn.UseVisualStyleBackColor = false;
            this.add_candidate_bttn.Click += new System.EventHandler(this.add_candidate_bttn_Click);
            // 
            // candidate_photo_picture
            // 
            this.candidate_photo_picture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.candidate_photo_picture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.candidate_photo_picture.IconChar = FontAwesome.Sharp.IconChar.None;
            this.candidate_photo_picture.IconColor = System.Drawing.SystemColors.ControlText;
            this.candidate_photo_picture.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.candidate_photo_picture.IconSize = 131;
            this.candidate_photo_picture.Location = new System.Drawing.Point(55, 399);
            this.candidate_photo_picture.Margin = new System.Windows.Forms.Padding(4);
            this.candidate_photo_picture.Name = "candidate_photo_picture";
            this.candidate_photo_picture.Size = new System.Drawing.Size(393, 131);
            this.candidate_photo_picture.TabIndex = 38;
            this.candidate_photo_picture.TabStop = false;
            this.candidate_photo_picture.Click += new System.EventHandler(this.candidate_photo_picture_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 301);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Motto";
            // 
            // motto_box
            // 
            this.motto_box.Location = new System.Drawing.Point(55, 322);
            this.motto_box.Margin = new System.Windows.Forms.Padding(4);
            this.motto_box.Name = "motto_box";
            this.motto_box.Size = new System.Drawing.Size(392, 22);
            this.motto_box.TabIndex = 40;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(537, 641);
            this.Controls.Add(this.motto_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.candidate_photo_picture);
            this.Controls.Add(this.add_candidate_bttn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.candidate_positions_combo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.candidate_partylist_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.candidate_name_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPosition";
            ((System.ComponentModel.ISupportInitialize)(this.candidate_photo_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox candidate_name_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox candidate_partylist_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox candidate_positions_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_candidate_bttn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox motto_box;
        public FontAwesome.Sharp.IconPictureBox candidate_photo_picture;
    }
}