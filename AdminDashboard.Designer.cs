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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.logout_icon = new FontAwesome.Sharp.IconButton();
            this.results_icons = new FontAwesome.Sharp.IconButton();
            this.elections_icon = new FontAwesome.Sharp.IconButton();
            this.dashboard_icon = new FontAwesome.Sharp.IconButton();
            this.admin_panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.admin_panel);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 688);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer2.Size = new System.Drawing.Size(215, 688);
            this.splitContainer2.SplitterDistance = 52;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "eBoto";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.logout_icon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.results_icons, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.elections_icon, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dashboard_icon, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.235669F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.55414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.55414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.55414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.10191F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(213, 633);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // logout_icon
            // 
            this.logout_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logout_icon.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.logout_icon.IconColor = System.Drawing.Color.Black;
            this.logout_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logout_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.logout_icon.Location = new System.Drawing.Point(5, 186);
            this.logout_icon.Name = "logout_icon";
            this.logout_icon.Size = new System.Drawing.Size(203, 53);
            this.logout_icon.TabIndex = 3;
            this.logout_icon.Text = "Logout";
            this.logout_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.logout_icon.UseVisualStyleBackColor = true;
            this.logout_icon.Click += new System.EventHandler(this.logout_icon_Click);
            // 
            // results_icons
            // 
            this.results_icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.results_icons.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.results_icons.IconColor = System.Drawing.Color.Black;
            this.results_icons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.results_icons.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.results_icons.Location = new System.Drawing.Point(5, 125);
            this.results_icons.Name = "results_icons";
            this.results_icons.Size = new System.Drawing.Size(203, 53);
            this.results_icons.TabIndex = 2;
            this.results_icons.Text = "Results";
            this.results_icons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.results_icons.UseVisualStyleBackColor = true;
            this.results_icons.Click += new System.EventHandler(this.results_icons_Click);
            // 
            // elections_icon
            // 
            this.elections_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elections_icon.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.elections_icon.IconColor = System.Drawing.Color.Black;
            this.elections_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.elections_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.elections_icon.Location = new System.Drawing.Point(5, 64);
            this.elections_icon.Name = "elections_icon";
            this.elections_icon.Size = new System.Drawing.Size(203, 53);
            this.elections_icon.TabIndex = 1;
            this.elections_icon.Text = "Elections";
            this.elections_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.elections_icon.UseVisualStyleBackColor = true;
            this.elections_icon.Click += new System.EventHandler(this.elections_icon_Click);
            // 
            // dashboard_icon
            // 
            this.dashboard_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboard_icon.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.dashboard_icon.IconColor = System.Drawing.Color.Black;
            this.dashboard_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dashboard_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.dashboard_icon.Location = new System.Drawing.Point(5, 5);
            this.dashboard_icon.Name = "dashboard_icon";
            this.dashboard_icon.Size = new System.Drawing.Size(203, 51);
            this.dashboard_icon.TabIndex = 0;
            this.dashboard_icon.Text = "Dashboard";
            this.dashboard_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard_icon.UseVisualStyleBackColor = true;
            this.dashboard_icon.Click += new System.EventHandler(this.dashboard_icon_Click);
            // 
            // admin_panel
            // 
            this.admin_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admin_panel.Location = new System.Drawing.Point(0, 0);
            this.admin_panel.Name = "admin_panel";
            this.admin_panel.Size = new System.Drawing.Size(1007, 686);
            this.admin_panel.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 688);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton logout_icon;
        private FontAwesome.Sharp.IconButton results_icons;
        private FontAwesome.Sharp.IconButton elections_icon;
        private FontAwesome.Sharp.IconButton dashboard_icon;
        private System.Windows.Forms.Panel admin_panel;
    }
}