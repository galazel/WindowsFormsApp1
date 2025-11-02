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
            this.others_icon = new FontAwesome.Sharp.IconButton();
            this.result_icons = new FontAwesome.Sharp.IconButton();
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
            this.tableLayoutPanel1.Controls.Add(this.others_icon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.result_icons, 0, 2);
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
            // others_icon
            // 
            this.others_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.others_icon.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.others_icon.IconColor = System.Drawing.Color.Black;
            this.others_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.others_icon.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.others_icon.Location = new System.Drawing.Point(5, 186);
            this.others_icon.Name = "others_icon";
            this.others_icon.Size = new System.Drawing.Size(203, 53);
            this.others_icon.TabIndex = 3;
            this.others_icon.Text = "Logout";
            this.others_icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.others_icon.UseVisualStyleBackColor = true;
            // 
            // result_icons
            // 
            this.result_icons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result_icons.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            this.result_icons.IconColor = System.Drawing.Color.Black;
            this.result_icons.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.result_icons.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.result_icons.Location = new System.Drawing.Point(5, 125);
            this.result_icons.Name = "result_icons";
            this.result_icons.Size = new System.Drawing.Size(203, 53);
            this.result_icons.TabIndex = 2;
            this.result_icons.Text = "Results";
            this.result_icons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.result_icons.UseVisualStyleBackColor = true;
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
        private FontAwesome.Sharp.IconButton others_icon;
        private FontAwesome.Sharp.IconButton result_icons;
        private FontAwesome.Sharp.IconButton elections_icon;
        private FontAwesome.Sharp.IconButton dashboard_icon;
        private System.Windows.Forms.Panel admin_panel;
    }
}