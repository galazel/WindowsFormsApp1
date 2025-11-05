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
            this.department_label = new System.Windows.Forms.Label();
            this.election_name_label = new System.Windows.Forms.Label();
            this.end_bttn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // view_details_bttn
            // 
            this.view_details_bttn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.view_details_bttn.IconColor = System.Drawing.Color.Black;
            this.view_details_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.view_details_bttn.Location = new System.Drawing.Point(643, 25);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(75, 23);
            this.view_details_bttn.TabIndex = 47;
            this.view_details_bttn.Text = "VIEW";
            this.view_details_bttn.UseVisualStyleBackColor = true;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click);
            // 
            // department_label
            // 
            this.department_label.AutoSize = true;
            this.department_label.Location = new System.Drawing.Point(23, 47);
            this.department_label.Name = "department_label";
            this.department_label.Size = new System.Drawing.Size(113, 13);
            this.department_label.TabIndex = 44;
            this.department_label.Text = "ELECTION RESULTS";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Location = new System.Drawing.Point(23, 25);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(113, 13);
            this.election_name_label.TabIndex = 43;
            this.election_name_label.Text = "ELECTION RESULTS";
            // 
            // end_bttn
            // 
            this.end_bttn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.end_bttn.IconColor = System.Drawing.Color.Black;
            this.end_bttn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.end_bttn.Location = new System.Drawing.Point(562, 25);
            this.end_bttn.Name = "end_bttn";
            this.end_bttn.Size = new System.Drawing.Size(75, 23);
            this.end_bttn.TabIndex = 48;
            this.end_bttn.Text = "END";
            this.end_bttn.UseVisualStyleBackColor = true;
            // 
            // OngoingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.end_bttn);
            this.Controls.Add(this.view_details_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Name = "OngoingPanel";
            this.Size = new System.Drawing.Size(757, 84);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton view_details_bttn;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Label election_name_label;
        private FontAwesome.Sharp.IconButton end_bttn;
    }
}
