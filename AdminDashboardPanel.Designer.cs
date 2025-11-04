namespace WindowsFormsApp1
{
    partial class AdminDashboardPanel
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.positions_grid = new System.Windows.Forms.DataGridView();
            this.departments_grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.total_voted = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.total_candidates = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.total_elections = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.total_voters = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.positions_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_grid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "MANAGE";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(108, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Positions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(108, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Departments";
            // 
            // positions_grid
            // 
            this.positions_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positions_grid.Location = new System.Drawing.Point(111, 456);
            this.positions_grid.Name = "positions_grid";
            this.positions_grid.Size = new System.Drawing.Size(707, 130);
            this.positions_grid.TabIndex = 20;
            // 
            // departments_grid
            // 
            this.departments_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_grid.Location = new System.Drawing.Point(111, 290);
            this.departments_grid.Name = "departments_grid";
            this.departments_grid.Size = new System.Drawing.Size(707, 130);
            this.departments_grid.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "HELLO, ADMIN!";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.total_voted);
            this.panel4.Location = new System.Drawing.Point(747, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 122);
            this.panel4.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(71, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Voted";
            // 
            // total_voted
            // 
            this.total_voted.AutoSize = true;
            this.total_voted.Location = new System.Drawing.Point(83, 40);
            this.total_voted.Name = "total_voted";
            this.total_voted.Size = new System.Drawing.Size(13, 13);
            this.total_voted.TabIndex = 11;
            this.total_voted.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.total_candidates);
            this.panel3.Location = new System.Drawing.Point(536, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 122);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Candidates";
            // 
            // total_candidates
            // 
            this.total_candidates.AutoSize = true;
            this.total_candidates.Location = new System.Drawing.Point(83, 40);
            this.total_candidates.Name = "total_candidates";
            this.total_candidates.Size = new System.Drawing.Size(13, 13);
            this.total_candidates.TabIndex = 11;
            this.total_candidates.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.total_elections);
            this.panel2.Location = new System.Drawing.Point(325, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(178, 122);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Elections";
            // 
            // total_elections
            // 
            this.total_elections.AutoSize = true;
            this.total_elections.Location = new System.Drawing.Point(83, 40);
            this.total_elections.Name = "total_elections";
            this.total_elections.Size = new System.Drawing.Size(13, 13);
            this.total_elections.TabIndex = 11;
            this.total_elections.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.total_voters);
            this.panel1.Location = new System.Drawing.Point(111, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(178, 122);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Voters";
            // 
            // total_voters
            // 
            this.total_voters.AutoSize = true;
            this.total_voters.Location = new System.Drawing.Point(82, 40);
            this.total_voters.Name = "total_voters";
            this.total_voters.Size = new System.Drawing.Size(13, 13);
            this.total_voters.TabIndex = 9;
            this.total_voters.Text = "0";
            // 
            // AdminDashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.positions_grid);
            this.Controls.Add(this.departments_grid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminDashboardPanel";
            this.Size = new System.Drawing.Size(1037, 736);
            ((System.ComponentModel.ISupportInitialize)(this.positions_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_grid)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView positions_grid;
        private System.Windows.Forms.DataGridView departments_grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label total_voted;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label total_candidates;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total_elections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label total_voters;
    }
}
