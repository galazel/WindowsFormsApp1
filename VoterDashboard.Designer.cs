namespace WindowsFormsApp1
{
    partial class VoterDashboard
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.voter_image = new System.Windows.Forms.PictureBox();
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.live_results_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vote_now_bttn = new System.Windows.Forms.Button();
            this.status_election_label = new System.Windows.Forms.Label();
            this.election_department_label = new System.Windows.Forms.Label();
            this.election_name = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.greetings_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.section_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.edit_profile_icon = new FontAwesome.Sharp.IconButton();
            this.logout_icon = new FontAwesome.Sharp.IconButton();
            this.view_ballot_icon = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 688);
            this.splitContainer1.SplitterDistance = 249;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.view_ballot_icon);
            this.panel1.Controls.Add(this.logout_icon);
            this.panel1.Controls.Add(this.edit_profile_icon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.contact_label);
            this.panel1.Controls.Add(this.birthday_label);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.section_label);
            this.panel1.Controls.Add(this.year_label);
            this.panel1.Controls.Add(this.department_label);
            this.panel1.Controls.Add(this.status_label);
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.voter_image);
            this.panel1.Controls.Add(this.profile_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 688);
            this.panel1.TabIndex = 0;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(91, 239);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(50, 13);
            this.status_label.TabIndex = 11;
            this.status_label.Text = "STATUS";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(74, 215);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(102, 13);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "GLYZEL GALAGAR";
            // 
            // voter_image
            // 
            this.voter_image.Location = new System.Drawing.Point(23, 26);
            this.voter_image.Name = "voter_image";
            this.voter_image.Size = new System.Drawing.Size(198, 173);
            this.voter_image.TabIndex = 4;
            this.voter_image.TabStop = false;
            // 
            // profile_button
            // 
            this.profile_button.BackColor = System.Drawing.Color.Transparent;
            this.profile_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile_button.ForeColor = System.Drawing.Color.Transparent;
            this.profile_button.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.profile_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.profile_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.profile_button.Location = new System.Drawing.Point(1032, 11);
            this.profile_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(49, 43);
            this.profile_button.TabIndex = 3;
            this.profile_button.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.live_results_flow);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.greetings_label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 688);
            this.panel2.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "LIVE RESULT";
            // 
            // live_results_flow
            // 
            this.live_results_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.live_results_flow.Location = new System.Drawing.Point(47, 289);
            this.live_results_flow.Name = "live_results_flow";
            this.live_results_flow.Size = new System.Drawing.Size(887, 373);
            this.live_results_flow.TabIndex = 12;
            this.live_results_flow.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.vote_now_bttn);
            this.panel3.Controls.Add(this.status_election_label);
            this.panel3.Controls.Add(this.election_department_label);
            this.panel3.Controls.Add(this.election_name);
            this.panel3.Location = new System.Drawing.Point(47, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 144);
            this.panel3.TabIndex = 11;
            // 
            // vote_now_bttn
            // 
            this.vote_now_bttn.Location = new System.Drawing.Point(23, 90);
            this.vote_now_bttn.Name = "vote_now_bttn";
            this.vote_now_bttn.Size = new System.Drawing.Size(282, 41);
            this.vote_now_bttn.TabIndex = 31;
            this.vote_now_bttn.Text = "VOTE NOW";
            this.vote_now_bttn.UseVisualStyleBackColor = true;
            // 
            // status_election_label
            // 
            this.status_election_label.AutoSize = true;
            this.status_election_label.Location = new System.Drawing.Point(20, 13);
            this.status_election_label.Name = "status_election_label";
            this.status_election_label.Size = new System.Drawing.Size(68, 13);
            this.status_election_label.TabIndex = 11;
            this.status_election_label.Text = "Hello, Glyzel!";
            // 
            // election_department_label
            // 
            this.election_department_label.AutoSize = true;
            this.election_department_label.Location = new System.Drawing.Point(20, 62);
            this.election_department_label.Name = "election_department_label";
            this.election_department_label.Size = new System.Drawing.Size(68, 13);
            this.election_department_label.TabIndex = 13;
            this.election_department_label.Text = "Hello, Glyzel!";
            // 
            // election_name
            // 
            this.election_name.AutoSize = true;
            this.election_name.Location = new System.Drawing.Point(20, 38);
            this.election_name.Name = "election_name";
            this.election_name.Size = new System.Drawing.Size(68, 13);
            this.election_name.TabIndex = 12;
            this.election_name.Text = "Hello, Glyzel!";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 59);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(123, 13);
            this.label.TabIndex = 10;
            this.label.Text = "WELCOME TO EBOTO!";
            // 
            // greetings_label
            // 
            this.greetings_label.AutoSize = true;
            this.greetings_label.Location = new System.Drawing.Point(44, 41);
            this.greetings_label.Name = "greetings_label";
            this.greetings_label.Size = new System.Drawing.Size(68, 13);
            this.greetings_label.TabIndex = 9;
            this.greetings_label.Text = "Hello, Glyzel!";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(20, 313);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(82, 13);
            this.department_label.TabIndex = 35;
            this.department_label.Text = "DEPARTMENT";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Location = new System.Drawing.Point(20, 340);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(36, 13);
            this.year_label.TabIndex = 36;
            this.year_label.Text = "YEAR";
            // 
            // section_label
            // 
            this.section_label.AutoSize = true;
            this.section_label.Location = new System.Drawing.Point(20, 364);
            this.section_label.Name = "section_label";
            this.section_label.Size = new System.Drawing.Size(54, 13);
            this.section_label.TabIndex = 37;
            this.section_label.Text = "SECTION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "SCHOOL INFORMATION";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "PERSONAL INFORMATION";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(20, 481);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(39, 13);
            this.email_label.TabIndex = 41;
            this.email_label.Text = "EMAIL";
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Location = new System.Drawing.Point(20, 457);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(58, 13);
            this.contact_label.TabIndex = 40;
            this.contact_label.Text = "CONTACT";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Location = new System.Drawing.Point(20, 430);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(62, 13);
            this.birthday_label.TabIndex = 39;
            this.birthday_label.Text = "BIRTHDAY";
            // 
            // edit_profile_icon
            // 
            this.edit_profile_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.edit_profile_icon.IconColor = System.Drawing.Color.Black;
            this.edit_profile_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_profile_icon.Location = new System.Drawing.Point(23, 543);
            this.edit_profile_icon.Name = "edit_profile_icon";
            this.edit_profile_icon.Size = new System.Drawing.Size(198, 23);
            this.edit_profile_icon.TabIndex = 0;
            this.edit_profile_icon.Text = "EDIT PROFILE";
            this.edit_profile_icon.UseVisualStyleBackColor = true;
            // 
            // logout_icon
            // 
            this.logout_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.logout_icon.IconColor = System.Drawing.Color.Black;
            this.logout_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout_icon.Location = new System.Drawing.Point(23, 601);
            this.logout_icon.Name = "logout_icon";
            this.logout_icon.Size = new System.Drawing.Size(198, 23);
            this.logout_icon.TabIndex = 43;
            this.logout_icon.Text = "LOGOUT";
            this.logout_icon.UseVisualStyleBackColor = true;
            // 
            // view_ballot_icon
            // 
            this.view_ballot_icon.IconChar = FontAwesome.Sharp.IconChar.None;
            this.view_ballot_icon.IconColor = System.Drawing.Color.Black;
            this.view_ballot_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_ballot_icon.Location = new System.Drawing.Point(23, 572);
            this.view_ballot_icon.Name = "view_ballot_icon";
            this.view_ballot_icon.Size = new System.Drawing.Size(198, 23);
            this.view_ballot_icon.TabIndex = 44;
            this.view_ballot_icon.Text = "VIEW BALLOT";
            this.view_ballot_icon.UseVisualStyleBackColor = true;
            // 
            // VoterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "VoterDashboard";
            this.Text = "VoterDashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton profile_button;
        private System.Windows.Forms.Label greetings_label;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label election_name;
        private System.Windows.Forms.Label status_election_label;
        private System.Windows.Forms.Label election_department_label;
        private System.Windows.Forms.Button vote_now_bttn;
        private System.Windows.Forms.FlowLayoutPanel live_results_flow;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox voter_image;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label section_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label label9;
        private FontAwesome.Sharp.IconButton view_ballot_icon;
        private FontAwesome.Sharp.IconButton logout_icon;
        private FontAwesome.Sharp.IconButton edit_profile_icon;
    }
}