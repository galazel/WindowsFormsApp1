namespace WindowsFormsApp1
{
    partial class ElectionPanel
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
            this.election_name_label = new System.Windows.Forms.Label();
            this.department_label = new System.Windows.Forms.Label();
            this.start = new FontAwesome.Sharp.IconButton();
            this.view_details = new FontAwesome.Sharp.IconButton();
            this.delete = new FontAwesome.Sharp.IconButton();
            this.edit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(8, 16);
            this.election_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(141, 19);
            this.election_name_label.TabIndex = 23;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_label.Location = new System.Drawing.Point(8, 35);
            this.department_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(145, 19);
            this.department_label.TabIndex = 24;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.ForeColor = System.Drawing.Color.Gainsboro;
            this.start.IconChar = FontAwesome.Sharp.IconChar.CirclePlay;
            this.start.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.start.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.start.IconSize = 40;
            this.start.Location = new System.Drawing.Point(925, 17);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(43, 42);
            this.start.TabIndex = 48;
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // view_details
            // 
            this.view_details.BackColor = System.Drawing.Color.Transparent;
            this.view_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_details.ForeColor = System.Drawing.Color.Gainsboro;
            this.view_details.IconChar = FontAwesome.Sharp.IconChar.Pager;
            this.view_details.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.view_details.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_details.IconSize = 40;
            this.view_details.Location = new System.Drawing.Point(778, 16);
            this.view_details.Name = "view_details";
            this.view_details.Size = new System.Drawing.Size(43, 42);
            this.view_details.TabIndex = 49;
            this.view_details.UseVisualStyleBackColor = false;
            this.view_details.Click += new System.EventHandler(this.view_details_bttn_Click_1);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.ForeColor = System.Drawing.Color.Gainsboro;
            this.delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete.IconSize = 40;
            this.delete.Location = new System.Drawing.Point(876, 16);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(43, 42);
            this.delete.TabIndex = 50;
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.Gainsboro;
            this.edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.edit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit.IconSize = 40;
            this.edit.Location = new System.Drawing.Point(827, 15);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(43, 42);
            this.edit.TabIndex = 51;
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // ElectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.edit);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.view_details);
            this.Controls.Add(this.start);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ElectionPanel";
            this.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Size = new System.Drawing.Size(993, 81);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Label department_label;
        private FontAwesome.Sharp.IconButton start;
        private FontAwesome.Sharp.IconButton view_details;
        private FontAwesome.Sharp.IconButton delete;
        private FontAwesome.Sharp.IconButton edit;
    }
}
