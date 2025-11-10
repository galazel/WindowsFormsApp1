namespace WindowsFormsApp1
{
    partial class OngoingPanel
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
            this.view_details_bttn = new FontAwesome.Sharp.IconButton();
            this.end_bttn = new FontAwesome.Sharp.IconButton();
            this.department_label = new System.Windows.Forms.Label();
            this.election_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // view_details_bttn
            // 
            this.view_details_bttn.BackColor = System.Drawing.Color.White;
            this.view_details_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_details_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.view_details_bttn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.view_details_bttn.IconColor = System.Drawing.Color.Black;
            this.view_details_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_details_bttn.IconSize = 30;
            this.view_details_bttn.Location = new System.Drawing.Point(975, 37);
            this.view_details_bttn.Margin = new System.Windows.Forms.Padding(5);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(51, 45);
            this.view_details_bttn.TabIndex = 47;
            this.view_details_bttn.UseVisualStyleBackColor = false;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click);
            // 
            // end_bttn
            // 
            this.end_bttn.BackColor = System.Drawing.Color.White;
            this.end_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.end_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.end_bttn.IconChar = FontAwesome.Sharp.IconChar.Stop;
            this.end_bttn.IconColor = System.Drawing.Color.Black;
            this.end_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.end_bttn.IconSize = 30;
            this.end_bttn.Location = new System.Drawing.Point(914, 37);
            this.end_bttn.Margin = new System.Windows.Forms.Padding(5);
            this.end_bttn.Name = "end_bttn";
            this.end_bttn.Size = new System.Drawing.Size(51, 45);
            this.end_bttn.TabIndex = 48;
            this.end_bttn.UseVisualStyleBackColor = false;
            this.end_bttn.Click += new System.EventHandler(this.end_bttn_Click);
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_label.Location = new System.Drawing.Point(58, 73);
            this.department_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(145, 19);
            this.department_label.TabIndex = 50;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(58, 37);
            this.election_name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(141, 19);
            this.election_name_label.TabIndex = 49;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // OngoingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Controls.Add(this.end_bttn);
            this.Controls.Add(this.view_details_bttn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OngoingPanel";
            this.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Size = new System.Drawing.Size(1083, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton view_details_bttn;
        private FontAwesome.Sharp.IconButton end_bttn;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label election_name_label;
    }
}
