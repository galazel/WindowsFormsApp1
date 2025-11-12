namespace WindowsFormsApp1
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.admin_panel = new System.Windows.Forms.Panel();
            this.ongoing_icon = new FontAwesome.Sharp.IconButton();
            this.elections_icon = new FontAwesome.Sharp.IconButton();
            this.results_icon = new FontAwesome.Sharp.IconButton();
            this.dashboard_icon = new FontAwesome.Sharp.IconButton();
            this.logout_icon = new FontAwesome.Sharp.IconButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.voter_image = new System.Windows.Forms.PictureBox();
            this.name_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).BeginInit();
            this.SuspendLayout();
            // 
            // admin_panel
            // 
            this.admin_panel.AutoSize = true;
            this.admin_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.admin_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_panel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_panel.Margin = new System.Windows.Forms.Padding(0);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(1256, 941);
            this.admin_panel.TabIndex = 0;
            // 
            // ongoing_icon
            // 
            this.ongoing_icon.BackColor = System.Drawing.Color.Transparent;
            this.ongoing_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ongoing_icon.ForeColor = System.Drawing.Color.White;
            this.ongoing_icon.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.ongoing_icon.IconColor = System.Drawing.Color.White;
            this.ongoing_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ongoing_icon.IconSize = 80;
            this.ongoing_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ongoing_icon.Location = new System.Drawing.Point(26, 565);
            this.ongoing_icon.Margin = new System.Windows.Forms.Padding(5);
            this.ongoing_icon.Name = "ongoing_icon";
            this.ongoing_icon.Size = new System.Drawing.Size(277, 76);
            this.ongoing_icon.TabIndex = 2;
            this.ongoing_icon.Text = "Ongoing Elections";
            this.ongoing_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ongoing_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ongoing_icon.UseVisualStyleBackColor = false;
            this.ongoing_icon.Click += new System.EventHandler(this.ongoing_icon_Click);
            // 
            // elections_icon
            // 
            this.elections_icon.BackColor = System.Drawing.Color.Transparent;
            this.elections_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elections_icon.ForeColor = System.Drawing.Color.White;
            this.elections_icon.IconChar = FontAwesome.Sharp.IconChar.Bullhorn;
            this.elections_icon.IconColor = System.Drawing.Color.White;
            this.elections_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.elections_icon.IconSize = 80;
            this.elections_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.elections_icon.Location = new System.Drawing.Point(26, 464);
            this.elections_icon.Margin = new System.Windows.Forms.Padding(5);
            this.elections_icon.Name = "elections_icon";
            this.elections_icon.Size = new System.Drawing.Size(277, 76);
            this.elections_icon.TabIndex = 1;
            this.elections_icon.Text = "Elections";
            this.elections_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.elections_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.elections_icon.UseVisualStyleBackColor = false;
            this.elections_icon.Click += new System.EventHandler(this.elections_icon_Click);
            // 
            // results_icon
            // 
            this.results_icon.BackColor = System.Drawing.Color.Transparent;
            this.results_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.results_icon.ForeColor = System.Drawing.Color.White;
            this.results_icon.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.results_icon.IconColor = System.Drawing.Color.White;
            this.results_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.results_icon.IconSize = 80;
            this.results_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.results_icon.Location = new System.Drawing.Point(26, 670);
            this.results_icon.Margin = new System.Windows.Forms.Padding(5);
            this.results_icon.Name = "results_icon";
            this.results_icon.Size = new System.Drawing.Size(277, 76);
            this.results_icon.TabIndex = 3;
            this.results_icon.Text = "Results";
            this.results_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.results_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.results_icon.UseVisualStyleBackColor = false;
            this.results_icon.Click += new System.EventHandler(this.results_icon_Click);
            // 
            // dashboard_icon
            // 
            this.dashboard_icon.BackColor = System.Drawing.Color.Transparent;
            this.dashboard_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_icon.ForeColor = System.Drawing.Color.White;
            this.dashboard_icon.IconChar = FontAwesome.Sharp.IconChar.TachometerAltFast;
            this.dashboard_icon.IconColor = System.Drawing.Color.White;
            this.dashboard_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboard_icon.IconSize = 80;
            this.dashboard_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dashboard_icon.Location = new System.Drawing.Point(26, 362);
            this.dashboard_icon.Margin = new System.Windows.Forms.Padding(5);
            this.dashboard_icon.Name = "dashboard_icon";
            this.dashboard_icon.Size = new System.Drawing.Size(277, 76);
            this.dashboard_icon.TabIndex = 0;
            this.dashboard_icon.Text = "Dashboard";
            this.dashboard_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard_icon.UseVisualStyleBackColor = false;
            this.dashboard_icon.Click += new System.EventHandler(this.dashboard_icon_Click);
            // 
            // logout_icon
            // 
            this.logout_icon.BackColor = System.Drawing.Color.Transparent;
            this.logout_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_icon.ForeColor = System.Drawing.Color.White;
            this.logout_icon.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.logout_icon.IconColor = System.Drawing.Color.White;
            this.logout_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout_icon.IconSize = 80;
            this.logout_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logout_icon.Location = new System.Drawing.Point(26, 773);
            this.logout_icon.Margin = new System.Windows.Forms.Padding(5);
            this.logout_icon.Name = "logout_icon";
            this.logout_icon.Size = new System.Drawing.Size(277, 76);
            this.logout_icon.TabIndex = 4;
            this.logout_icon.Text = "Logout";
            this.logout_icon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_icon.UseVisualStyleBackColor = false;
            this.logout_icon.Click += new System.EventHandler(this.logout_icon_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.splitContainer1.Panel1.Controls.Add(this.logout_icon);
            this.splitContainer1.Panel1.Controls.Add(this.voter_image);
            this.splitContainer1.Panel1.Controls.Add(this.results_icon);
            this.splitContainer1.Panel1.Controls.Add(this.elections_icon);
            this.splitContainer1.Panel1.Controls.Add(this.dashboard_icon);
            this.splitContainer1.Panel1.Controls.Add(this.ongoing_icon);
            this.splitContainer1.Panel1.Controls.Add(this.name_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.admin_panel);
            this.splitContainer1.Size = new System.Drawing.Size(1597, 943);
            this.splitContainer1.SplitterDistance = 337;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 0;
            // 
            // voter_image
            // 
            this.voter_image.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.voter_image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voter_image.BackgroundImage")));
            this.voter_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voter_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voter_image.Cursor = System.Windows.Forms.Cursors.Default;
            this.voter_image.Location = new System.Drawing.Point(26, 34);
            this.voter_image.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.voter_image.Name = "voter_image";
            this.voter_image.Size = new System.Drawing.Size(277, 225);
            this.voter_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.voter_image.TabIndex = 13;
            this.voter_image.TabStop = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.ForeColor = System.Drawing.Color.White;
            this.name_label.Location = new System.Drawing.Point(92, 277);
            this.name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(143, 21);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "ADMINISTRATOR";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 943);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voter_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel admin_panel;
        private FontAwesome.Sharp.IconButton logout_icon;
        private FontAwesome.Sharp.IconButton dashboard_icon;
        private FontAwesome.Sharp.IconButton results_icon;
        private FontAwesome.Sharp.IconButton elections_icon;
        private FontAwesome.Sharp.IconButton ongoing_icon;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.PictureBox voter_image;
    }
}