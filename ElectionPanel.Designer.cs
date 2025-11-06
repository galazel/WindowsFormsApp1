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
            this.delete_bttn = new FontAwesome.Sharp.IconButton();
            this.start_bttn = new FontAwesome.Sharp.IconButton();
            this.view_details_bttn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(58, 37);
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
            this.department_label.Location = new System.Drawing.Point(58, 73);
            this.department_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(145, 19);
            this.department_label.TabIndex = 24;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.White;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.delete_bttn.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.delete_bttn.IconColor = System.Drawing.Color.Red;
            this.delete_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.delete_bttn.IconSize = 30;
            this.delete_bttn.Location = new System.Drawing.Point(975, 37);
            this.delete_bttn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(51, 45);
            this.delete_bttn.TabIndex = 40;
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // start_bttn
            // 
            this.start_bttn.BackColor = System.Drawing.Color.White;
            this.start_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.start_bttn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.start_bttn.IconColor = System.Drawing.Color.Green;
            this.start_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.start_bttn.IconSize = 30;
            this.start_bttn.Location = new System.Drawing.Point(914, 37);
            this.start_bttn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(51, 45);
            this.start_bttn.TabIndex = 41;
            this.start_bttn.UseVisualStyleBackColor = false;
            this.start_bttn.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // view_details_bttn
            // 
            this.view_details_bttn.BackColor = System.Drawing.Color.White;
            this.view_details_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_details_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.view_details_bttn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.view_details_bttn.IconColor = System.Drawing.Color.Purple;
            this.view_details_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_details_bttn.IconSize = 30;
            this.view_details_bttn.Location = new System.Drawing.Point(853, 37);
            this.view_details_bttn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(51, 45);
            this.view_details_bttn.TabIndex = 42;
            this.view_details_bttn.UseVisualStyleBackColor = false;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click_1);
            // 
            // ElectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(188)))), ((int)(((byte)(65)))));
            this.Controls.Add(this.view_details_bttn);
            this.Controls.Add(this.start_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ElectionPanel";
            this.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Size = new System.Drawing.Size(1083, 123);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Label department_label;
        private FontAwesome.Sharp.IconButton delete_bttn;
        private FontAwesome.Sharp.IconButton start_bttn;
        private FontAwesome.Sharp.IconButton view_details_bttn;
    }
}
