namespace WindowsFormsApp1
{
    partial class UpdateElection
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
            this.label5 = new System.Windows.Forms.Label();
            this.update_election_bttn = new System.Windows.Forms.Button();
            this.departments_combo = new System.Windows.Forms.ComboBox();
            this.election_name_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.candidates_list = new System.Windows.Forms.ListBox();
            this.add_candidate_bttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(178, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 28);
            this.label5.TabIndex = 41;
            this.label5.Text = "UPDATE ELECTION";
            // 
            // update_election_bttn
            // 
            this.update_election_bttn.BackColor = System.Drawing.Color.Transparent;
            this.update_election_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_election_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.update_election_bttn.Location = new System.Drawing.Point(193, 599);
            this.update_election_bttn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.update_election_bttn.Name = "update_election_bttn";
            this.update_election_bttn.Size = new System.Drawing.Size(179, 52);
            this.update_election_bttn.TabIndex = 40;
            this.update_election_bttn.Text = "ADD ELECTION";
            this.update_election_bttn.UseVisualStyleBackColor = false;
            this.update_election_bttn.Click += new System.EventHandler(this.update_election_bttn_Click);
            // 
            // departments_combo
            // 
            this.departments_combo.BackColor = System.Drawing.Color.White;
            this.departments_combo.FormattingEnabled = true;
            this.departments_combo.Location = new System.Drawing.Point(54, 303);
            this.departments_combo.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.departments_combo.Name = "departments_combo";
            this.departments_combo.Size = new System.Drawing.Size(472, 21);
            this.departments_combo.TabIndex = 39;
            // 
            // election_name_box
            // 
            this.election_name_box.BackColor = System.Drawing.Color.White;
            this.election_name_box.Location = new System.Drawing.Point(54, 108);
            this.election_name_box.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.election_name_box.Name = "election_name_box";
            this.election_name_box.Size = new System.Drawing.Size(472, 20);
            this.election_name_box.TabIndex = 38;
            // 
            // description_box
            // 
            this.description_box.BackColor = System.Drawing.Color.White;
            this.description_box.Location = new System.Drawing.Point(54, 180);
            this.description_box.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(472, 72);
            this.description_box.TabIndex = 37;
            // 
            // candidates_list
            // 
            this.candidates_list.BackColor = System.Drawing.Color.White;
            this.candidates_list.FormattingEnabled = true;
            this.candidates_list.Location = new System.Drawing.Point(54, 417);
            this.candidates_list.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.candidates_list.Name = "candidates_list";
            this.candidates_list.Size = new System.Drawing.Size(472, 160);
            this.candidates_list.TabIndex = 36;
            this.candidates_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.candidates_list_KeyDown);
            // 
            // add_candidate_bttn
            // 
            this.add_candidate_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_candidate_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.add_candidate_bttn.Location = new System.Drawing.Point(53, 355);
            this.add_candidate_bttn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.add_candidate_bttn.Name = "add_candidate_bttn";
            this.add_candidate_bttn.Size = new System.Drawing.Size(179, 52);
            this.add_candidate_bttn.TabIndex = 35;
            this.add_candidate_bttn.Text = "ADD CANDIDATE";
            this.add_candidate_bttn.UseVisualStyleBackColor = false;
            this.add_candidate_bttn.Click += new System.EventHandler(this.add_candidate_bttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Description";
            // 
            // UpdateElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 685);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update_election_bttn);
            this.Controls.Add(this.departments_combo);
            this.Controls.Add(this.election_name_box);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.candidates_list);
            this.Controls.Add(this.add_candidate_bttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UpdateElection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateElection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button update_election_bttn;
        private System.Windows.Forms.ComboBox departments_combo;
        private System.Windows.Forms.TextBox election_name_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.ListBox candidates_list;
        private System.Windows.Forms.Button add_candidate_bttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}