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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_candidate_bttn = new System.Windows.Forms.Button();
            this.candidates_list = new System.Windows.Forms.ListBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.election_name_box = new System.Windows.Forms.TextBox();
            this.departments_combo = new System.Windows.Forms.ComboBox();
            this.add_election_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "CREATE ELECTION";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Department";
            // 
            // add_candidate_bttn
            // 
            this.add_candidate_bttn.Location = new System.Drawing.Point(50, 254);
            this.add_candidate_bttn.Name = "add_candidate_bttn";
            this.add_candidate_bttn.Size = new System.Drawing.Size(139, 23);
            this.add_candidate_bttn.TabIndex = 24;
            this.add_candidate_bttn.Text = "ADD CANDIDATE";
            this.add_candidate_bttn.UseVisualStyleBackColor = true;
            this.add_candidate_bttn.Click += new System.EventHandler(this.add_candidate_bttn_Click);
            // 
            // candidates_list
            // 
            this.candidates_list.FormattingEnabled = true;
            this.candidates_list.Location = new System.Drawing.Point(50, 302);
            this.candidates_list.Name = "candidates_list";
            this.candidates_list.Size = new System.Drawing.Size(423, 134);
            this.candidates_list.TabIndex = 25;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(50, 139);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(423, 59);
            this.description_box.TabIndex = 27;
            // 
            // election_name_box
            // 
            this.election_name_box.Location = new System.Drawing.Point(50, 95);
            this.election_name_box.Name = "election_name_box";
            this.election_name_box.Size = new System.Drawing.Size(423, 20);
            this.election_name_box.TabIndex = 28;
            // 
            // departments_combo
            // 
            this.departments_combo.FormattingEnabled = true;
            this.departments_combo.Location = new System.Drawing.Point(50, 227);
            this.departments_combo.Name = "departments_combo";
            this.departments_combo.Size = new System.Drawing.Size(423, 21);
            this.departments_combo.TabIndex = 29;
            // 
            // add_election_bttn
            // 
            this.add_election_bttn.Location = new System.Drawing.Point(196, 454);
            this.add_election_bttn.Name = "add_election_bttn";
            this.add_election_bttn.Size = new System.Drawing.Size(139, 23);
            this.add_election_bttn.TabIndex = 30;
            this.add_election_bttn.Text = "ADD ELECTION";
            this.add_election_bttn.UseVisualStyleBackColor = true;
            this.add_election_bttn.Click += new System.EventHandler(this.add_election_bttn_Click);
            // 
            // CreateElection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 527);
            this.Controls.Add(this.add_election_bttn);
            this.Controls.Add(this.departments_combo);
            this.Controls.Add(this.election_name_box);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.candidates_list);
            this.Controls.Add(this.add_candidate_bttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "CreateElection";
            this.Text = "CreateElection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_candidate_bttn;
        private System.Windows.Forms.ListBox candidates_list;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.TextBox election_name_box;
        private System.Windows.Forms.ComboBox departments_combo;
        private System.Windows.Forms.Button add_election_bttn;
    }
}