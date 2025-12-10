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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoterDashboard));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.live_results_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.vote_now_bttn = new System.Windows.Forms.Button();
            this.status_election_label = new System.Windows.Forms.Label();
            this.election_department_label = new System.Windows.Forms.Label();
            this.election_name = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_label = new System.Windows.Forms.Label();
            this.status_label = new System.Windows.Forms.Label();
            this.logout_icon = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.contact_label = new System.Windows.Forms.Label();
            this.birthday_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.section_label = new System.Windows.Forms.Label();
            this.year_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.voter_image = new System.Windows.Forms.PictureBox();
            this.profile_button = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.view_ballot_icon = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.live_results_flow);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 876);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(955, 34);
            this.label2.TabIndex = 15;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "PARTIAL AND UNOFFICIAL RESULTS";
            // 
            // live_results_flow
            // 
            this.live_results_flow.AutoScroll = true;
            this.live_results_flow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.live_results_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.live_results_flow.Location = new System.Drawing.Point(20, 362);
            this.live_results_flow.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.live_results_flow.Name = "live_results_flow";
            this.live_results_flow.Padding = new System.Windows.Forms.Padding(10);
            this.live_results_flow.Size = new System.Drawing.Size(1027, 488);
            this.live_results_flow.TabIndex = 12;
            this.live_results_flow.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.vote_now_bttn);
            this.panel3.Controls.Add(this.status_election_label);
            this.panel3.Controls.Add(this.election_department_label);
            this.panel3.Controls.Add(this.election_name);
            this.panel3.Location = new System.Drawing.Point(20, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1027, 188);
            this.panel3.TabIndex = 11;
            // 
            // vote_now_bttn
            // 
            this.vote_now_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.vote_now_bttn.Cursor = System.Windows.Forms.Cursors.Default;
            this.vote_now_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vote_now_bttn.ForeColor = System.Drawing.Color.White;
            this.vote_now_bttn.Location = new System.Drawing.Point(25, 125);
            this.vote_now_bttn.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.vote_now_bttn.Name = "vote_now_bttn";
            this.vote_now_bttn.Size = new System.Drawing.Size(231, 49);
            this.vote_now_bttn.TabIndex = 31;
            this.vote_now_bttn.Text = "VOTE NOW";
            this.vote_now_bttn.UseVisualStyleBackColor = false;
            this.vote_now_bttn.Click += new System.EventHandler(this.vote_now_bttn_Click);
            // 
            // status_election_label
            // 
            this.status_election_label.AutoSize = true;
            this.status_election_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_election_label.ForeColor = System.Drawing.Color.Black;
            this.status_election_label.Location = new System.Drawing.Point(23, 90);
            this.status_election_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_election_label.Name = "status_election_label";
            this.status_election_label.Size = new System.Drawing.Size(88, 17);
            this.status_election_label.TabIndex = 11;
            this.status_election_label.Text = "Hello, Glyzel!";
            // 
            // election_department_label
            // 
            this.election_department_label.AutoSize = true;
            this.election_department_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_department_label.ForeColor = System.Drawing.Color.Black;
            this.election_department_label.Location = new System.Drawing.Point(23, 20);
            this.election_department_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.election_department_label.Name = "election_department_label";
            this.election_department_label.Size = new System.Drawing.Size(88, 17);
            this.election_department_label.TabIndex = 13;
            this.election_department_label.Text = "Hello, Glyzel!";
            // 
            // election_name
            // 
            this.election_name.AutoSize = true;
            this.election_name.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name.ForeColor = System.Drawing.Color.Black;
            this.election_name.Location = new System.Drawing.Point(19, 49);
            this.election_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.election_name.Name = "election_name";
            this.election_name.Size = new System.Drawing.Size(182, 32);
            this.election_name.TabIndex = 12;
            this.election_name.Text = "Hello, Glyzel!";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(13, 27);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(348, 38);
            this.label.TabIndex = 10;
            this.label.Text = "WELCOME TO eBOTO!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.panel1.Controls.Add(this.name_label);
            this.panel1.Controls.Add(this.status_label);
            this.panel1.Controls.Add(this.view_ballot_icon);
            this.panel1.Controls.Add(this.logout_icon);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.contact_label);
            this.panel1.Controls.Add(this.birthday_label);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.section_label);
            this.panel1.Controls.Add(this.year_label);
            this.panel1.Controls.Add(this.department_label);
            this.panel1.Controls.Add(this.voter_image);
            this.panel1.Controls.Add(this.profile_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 876);
            this.panel1.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(13, 265);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(118, 17);
            this.name_label.TabIndex = 10;
            this.name_label.Text = "GLYZEL GALAGAR";
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_label.ForeColor = System.Drawing.Color.White;
            this.status_label.Location = new System.Drawing.Point(13, 282);
            this.status_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(47, 17);
            this.status_label.TabIndex = 11;
            this.status_label.Text = "STATUS";
            // 
            // logout_icon
            // 
            this.logout_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.logout_icon.Cursor = System.Windows.Forms.Cursors.Default;
            this.logout_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_icon.ForeColor = System.Drawing.Color.Transparent;
            this.logout_icon.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logout_icon.IconColor = System.Drawing.Color.White;
            this.logout_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout_icon.IconSize = 50;
            this.logout_icon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_icon.Location = new System.Drawing.Point(15, 775);
            this.logout_icon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.logout_icon.Name = "logout_icon";
            this.logout_icon.Size = new System.Drawing.Size(272, 49);
            this.logout_icon.TabIndex = 43;
            this.logout_icon.Text = "Logout";
            this.logout_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_icon.UseVisualStyleBackColor = false;
            this.logout_icon.Click += new System.EventHandler(this.logout_icon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 312);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(238, 23);
            this.label10.TabIndex = 42;
            this.label10.Text = "PERSONAL INFORMATION";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(13, 370);
            this.email_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(44, 17);
            this.email_label.TabIndex = 41;
            this.email_label.Text = "EMAIL";
            // 
            // contact_label
            // 
            this.contact_label.AutoSize = true;
            this.contact_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_label.ForeColor = System.Drawing.Color.White;
            this.contact_label.Location = new System.Drawing.Point(11, 353);
            this.contact_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.contact_label.Name = "contact_label";
            this.contact_label.Size = new System.Drawing.Size(70, 17);
            this.contact_label.TabIndex = 40;
            this.contact_label.Text = "CONTACT";
            // 
            // birthday_label
            // 
            this.birthday_label.AutoSize = true;
            this.birthday_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday_label.ForeColor = System.Drawing.Color.White;
            this.birthday_label.Location = new System.Drawing.Point(11, 336);
            this.birthday_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.birthday_label.Name = "birthday_label";
            this.birthday_label.Size = new System.Drawing.Size(66, 17);
            this.birthday_label.TabIndex = 39;
            this.birthday_label.Text = "BIRTHDAY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 23);
            this.label9.TabIndex = 38;
            this.label9.Text = "SCHOOL INFORMATION";
            // 
            // section_label
            // 
            this.section_label.AutoSize = true;
            this.section_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_label.ForeColor = System.Drawing.Color.White;
            this.section_label.Location = new System.Drawing.Point(13, 457);
            this.section_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.section_label.Name = "section_label";
            this.section_label.Size = new System.Drawing.Size(61, 17);
            this.section_label.TabIndex = 37;
            this.section_label.Text = "SECTION";
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_label.ForeColor = System.Drawing.Color.White;
            this.year_label.Location = new System.Drawing.Point(11, 440);
            this.year_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(39, 17);
            this.year_label.TabIndex = 36;
            this.year_label.Text = "YEAR";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_label.ForeColor = System.Drawing.Color.White;
            this.department_label.Location = new System.Drawing.Point(11, 423);
            this.department_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(88, 17);
            this.department_label.TabIndex = 35;
            this.department_label.Text = "DEPARTMENT";
            // 
            // voter_image
            // 
            this.voter_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.voter_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.voter_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voter_image.Cursor = System.Windows.Forms.Cursors.Default;
            this.voter_image.Location = new System.Drawing.Point(16, 28);
            this.voter_image.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.voter_image.Name = "voter_image";
            this.voter_image.Size = new System.Drawing.Size(270, 231);
            this.voter_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.profile_button.Location = new System.Drawing.Point(1204, 15);
            this.profile_button.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(58, 56);
            this.profile_button.TabIndex = 3;
            this.profile_button.UseVisualStyleBackColor = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1375, 876);
            this.splitContainer1.SplitterDistance = 303;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // view_ballot_icon
            // 
            this.view_ballot_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.view_ballot_icon.Cursor = System.Windows.Forms.Cursors.Default;
            this.view_ballot_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_ballot_icon.ForeColor = System.Drawing.Color.Transparent;
            this.view_ballot_icon.IconChar = FontAwesome.Sharp.IconChar.VoteYea;
            this.view_ballot_icon.IconColor = System.Drawing.Color.White;
            this.view_ballot_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_ballot_icon.IconSize = 50;
            this.view_ballot_icon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.view_ballot_icon.Location = new System.Drawing.Point(14, 718);
            this.view_ballot_icon.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.view_ballot_icon.Name = "view_ballot_icon";
            this.view_ballot_icon.Size = new System.Drawing.Size(272, 49);
            this.view_ballot_icon.TabIndex = 44;
            this.view_ballot_icon.Text = "Download eBallot";
            this.view_ballot_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.view_ballot_icon.UseVisualStyleBackColor = false;
            this.view_ballot_icon.Click += new System.EventHandler(this.view_ballot_icon_Click);
            // 
            // VoterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1375, 876);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "VoterDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VoterDashboard";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel live_results_flow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button vote_now_bttn;
        private System.Windows.Forms.Label status_election_label;
        private System.Windows.Forms.Label election_department_label;
        private System.Windows.Forms.Label election_name;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton logout_icon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label contact_label;
        private System.Windows.Forms.Label birthday_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label section_label;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox voter_image;
        private FontAwesome.Sharp.IconButton profile_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton view_ballot_icon;
    }
}