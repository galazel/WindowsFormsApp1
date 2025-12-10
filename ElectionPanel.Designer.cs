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
            this.view_details_bttn = new System.Windows.Forms.Button();
            this.delete_bttn = new System.Windows.Forms.Button();
            this.start_bttn = new System.Windows.Forms.Button();
            this.update_bttn = new System.Windows.Forms.Button();
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
            // view_details_bttn
            // 
            this.view_details_bttn.BackColor = System.Drawing.Color.White;
            this.view_details_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_details_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_details_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.view_details_bttn.Location = new System.Drawing.Point(657, 16);
            this.view_details_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.view_details_bttn.Name = "view_details_bttn";
            this.view_details_bttn.Size = new System.Drawing.Size(76, 35);
            this.view_details_bttn.TabIndex = 43;
            this.view_details_bttn.Text = "VIEW";
            this.view_details_bttn.UseVisualStyleBackColor = false;
            this.view_details_bttn.Click += new System.EventHandler(this.view_details_bttn_Click_1);
            // 
            // delete_bttn
            // 
            this.delete_bttn.BackColor = System.Drawing.Color.White;
            this.delete_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.delete_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.delete_bttn.Location = new System.Drawing.Point(919, 16);
            this.delete_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete_bttn.Name = "delete_bttn";
            this.delete_bttn.Size = new System.Drawing.Size(76, 35);
            this.delete_bttn.TabIndex = 44;
            this.delete_bttn.Text = "DELETE";
            this.delete_bttn.UseVisualStyleBackColor = false;
            this.delete_bttn.Click += new System.EventHandler(this.delete_bttn_Click);
            // 
            // start_bttn
            // 
            this.start_bttn.BackColor = System.Drawing.Color.White;
            this.start_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.start_bttn.Location = new System.Drawing.Point(835, 16);
            this.start_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.start_bttn.Name = "start_bttn";
            this.start_bttn.Size = new System.Drawing.Size(76, 35);
            this.start_bttn.TabIndex = 45;
            this.start_bttn.Text = "START";
            this.start_bttn.UseVisualStyleBackColor = false;
            this.start_bttn.Click += new System.EventHandler(this.start_bttn_Click);
            // 
            // update_bttn
            // 
            this.update_bttn.BackColor = System.Drawing.Color.White;
            this.update_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.update_bttn.Location = new System.Drawing.Point(741, 16);
            this.update_bttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update_bttn.Name = "update_bttn";
            this.update_bttn.Size = new System.Drawing.Size(86, 35);
            this.update_bttn.TabIndex = 46;
            this.update_bttn.Text = "UPDATE";
            this.update_bttn.UseVisualStyleBackColor = false;
            this.update_bttn.Click += new System.EventHandler(this.update_bttn_Click);
            // 
            // ElectionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.update_bttn);
            this.Controls.Add(this.start_bttn);
            this.Controls.Add(this.delete_bttn);
            this.Controls.Add(this.view_details_bttn);
            this.Controls.Add(this.department_label);
            this.Controls.Add(this.election_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ElectionPanel";
            this.Padding = new System.Windows.Forms.Padding(17, 16, 17, 16);
            this.Size = new System.Drawing.Size(1016, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Button view_details_bttn;
        private System.Windows.Forms.Button delete_bttn;
        private System.Windows.Forms.Button start_bttn;
        private System.Windows.Forms.Button update_bttn;
    }
}
