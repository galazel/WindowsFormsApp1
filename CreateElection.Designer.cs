namespace WindowsFormsApp1
{
    partial class CreateElection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_candidate_bttn = new System.Windows.Forms.Button();
            this.candidates_list = new System.Windows.Forms.ListBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.election_name_box = new System.Windows.Forms.TextBox();
            this.departments_combo = new System.Windows.Forms.ComboBox();
            this.add_election_bttn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Department";
            // 
            // add_candidate_bttn
            // 
            this.add_candidate_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_candidate_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_candidate_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.add_candidate_bttn.Location = new System.Drawing.Point(39, 333);
            this.add_candidate_bttn.Margin = new System.Windows.Forms.Padding(4);
            this.add_candidate_bttn.Name = "add_candidate_bttn";
            this.add_candidate_bttn.Size = new System.Drawing.Size(162, 30);
            this.add_candidate_bttn.TabIndex = 24;
            this.add_candidate_bttn.Text = "ADD CANDIDATE";
            this.add_candidate_bttn.UseVisualStyleBackColor = false;
            this.add_candidate_bttn.Click += new System.EventHandler(this.add_candidate_bttn_Click);
            // 
            // candidates_list
            // 
            this.candidates_list.BackColor = System.Drawing.Color.White;
            this.candidates_list.FormattingEnabled = true;
            this.candidates_list.ItemHeight = 17;
            this.candidates_list.Location = new System.Drawing.Point(39, 396);
            this.candidates_list.Margin = new System.Windows.Forms.Padding(4);
            this.candidates_list.Name = "candidates_list";
            this.candidates_list.Size = new System.Drawing.Size(493, 174);
            this.candidates_list.TabIndex = 25;
            this.candidates_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.candidates_list_KeyDown);
            // 
            // description_box
            // 
            this.description_box.BackColor = System.Drawing.Color.White;
            this.description_box.Location = new System.Drawing.Point(39, 183);
            this.description_box.Margin = new System.Windows.Forms.Padding(4);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(493, 76);
            this.description_box.TabIndex = 27;
            // 
            // election_name_box
            // 
            this.election_name_box.BackColor = System.Drawing.Color.White;
            this.election_name_box.Location = new System.Drawing.Point(39, 125);
            this.election_name_box.Margin = new System.Windows.Forms.Padding(4);
            this.election_name_box.Name = "election_name_box";
            this.election_name_box.Size = new System.Drawing.Size(493, 22);
            this.election_name_box.TabIndex = 28;
            // 
            // departments_combo
            // 
            this.departments_combo.BackColor = System.Drawing.Color.White;
            this.departments_combo.FormattingEnabled = true;
            this.departments_combo.Location = new System.Drawing.Point(39, 298);
            this.departments_combo.Margin = new System.Windows.Forms.Padding(4);
            this.departments_combo.Name = "departments_combo";
            this.departments_combo.Size = new System.Drawing.Size(493, 25);
            this.departments_combo.TabIndex = 29;
            // 
            // add_election_bttn
            // 
            this.add_election_bttn.BackColor = System.Drawing.Color.Transparent;
            this.add_election_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_election_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.add_election_bttn.Location = new System.Drawing.Point(196, 590);
            this.add_election_bttn.Margin = new System.Windows.Forms.Padding(4);
            this.add_election_bttn.Name = "add_election_bttn";
            this.add_election_bttn.Size = new System.Drawing.Size(162, 44);
            this.add_election_bttn.TabIndex = 30;
            this.add_election_bttn.Text = "ADD ELECTION";
            this.add_election_bttn.UseVisualStyleBackColor = false;
            this.add_election_bttn.Click += new System.EventHandler(this.add_election_bttn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label5.Location = new System.Drawing.Point(189, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "CREATE ELECTION";
            // 
            // CreateElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(560, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_election_bttn);
            this.Controls.Add(this.departments_combo);
            this.Controls.Add(this.election_name_box);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.candidates_list);
            this.Controls.Add(this.add_candidate_bttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateElection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateElection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_candidate_bttn;
        private System.Windows.Forms.ListBox candidates_list;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.TextBox election_name_box;
        private System.Windows.Forms.ComboBox departments_combo;
        private System.Windows.Forms.Button add_election_bttn;
        private System.Windows.Forms.Label label5;
    }
}