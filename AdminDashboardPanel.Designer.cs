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
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.positions_grid = new System.Windows.Forms.DataGridView();
            this.departments_grid = new System.Windows.Forms.DataGridView();
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
            this.add_position = new FontAwesome.Sharp.IconButton();
            this.add_department = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.voters_view = new System.Windows.Forms.DataGridView();
            this.clearAll = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.positions_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departments_grid)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voters_view)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(563, 615);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Positions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(35, 615);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Departments";
            // 
            // positions_grid
            // 
            this.positions_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.positions_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positions_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.positions_grid.Location = new System.Drawing.Point(566, 636);
            this.positions_grid.Margin = new System.Windows.Forms.Padding(4);
            this.positions_grid.Name = "positions_grid";
            this.positions_grid.Size = new System.Drawing.Size(442, 170);
            this.positions_grid.TabIndex = 20;
            this.positions_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.positions_grid_CellClick);
            this.positions_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.positions_grid_CellMouseClick);
            // 
            // departments_grid
            // 
            this.departments_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.departments_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departments_grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.departments_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.departments_grid.Location = new System.Drawing.Point(38, 636);
            this.departments_grid.Margin = new System.Windows.Forms.Padding(4);
            this.departments_grid.Name = "departments_grid";
            this.departments_grid.Size = new System.Drawing.Size(481, 170);
            this.departments_grid.TabIndex = 19;
            this.departments_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.departments_grid_CellClick);
        
            this.departments_grid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.departments_grid_CellMouseClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.total_voted);
            this.panel4.Location = new System.Drawing.Point(780, 80);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 189);
            this.panel4.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(74, 137);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "No. of Voted";
            // 
            // total_voted
            // 
            this.total_voted.AutoSize = true;
            this.total_voted.Font = new System.Drawing.Font("Century Gothic", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_voted.Location = new System.Drawing.Point(73, 25);
            this.total_voted.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_voted.Name = "total_voted";
            this.total_voted.Size = new System.Drawing.Size(106, 117);
            this.total_voted.TabIndex = 11;
            this.total_voted.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.total_candidates);
            this.panel3.Location = new System.Drawing.Point(534, 80);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 189);
            this.panel3.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 137);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "No. of Candidates";
            // 
            // total_candidates
            // 
            this.total_candidates.AutoSize = true;
            this.total_candidates.Font = new System.Drawing.Font("Century Gothic", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_candidates.Location = new System.Drawing.Point(65, 25);
            this.total_candidates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_candidates.Name = "total_candidates";
            this.total_candidates.Size = new System.Drawing.Size(106, 117);
            this.total_candidates.TabIndex = 11;
            this.total_candidates.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.total_elections);
            this.panel2.Location = new System.Drawing.Point(287, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 189);
            this.panel2.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "No. of Elections";
            // 
            // total_elections
            // 
            this.total_elections.AutoSize = true;
            this.total_elections.Font = new System.Drawing.Font("Century Gothic", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_elections.Location = new System.Drawing.Point(59, 25);
            this.total_elections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_elections.Name = "total_elections";
            this.total_elections.Size = new System.Drawing.Size(106, 117);
            this.total_elections.TabIndex = 11;
            this.total_elections.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.total_voters);
            this.panel1.Location = new System.Drawing.Point(38, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 189);
            this.panel1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(66, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "No. of Voters";
            // 
            // total_voters
            // 
            this.total_voters.AutoSize = true;
            this.total_voters.Font = new System.Drawing.Font("Century Gothic", 75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_voters.Location = new System.Drawing.Point(64, 25);
            this.total_voters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.total_voters.Name = "total_voters";
            this.total_voters.Size = new System.Drawing.Size(106, 117);
            this.total_voters.TabIndex = 9;
            this.total_voters.Text = "0";
            // 
            // add_position
            // 
            this.add_position.BackColor = System.Drawing.Color.Transparent;
            this.add_position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_position.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.add_position.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_position.IconColor = System.Drawing.Color.Black;
            this.add_position.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_position.Location = new System.Drawing.Point(873, 814);
            this.add_position.Margin = new System.Windows.Forms.Padding(4);
            this.add_position.Name = "add_position";
            this.add_position.Size = new System.Drawing.Size(135, 30);
            this.add_position.TabIndex = 25;
            this.add_position.Text = "ADD POSITION";
            this.add_position.UseVisualStyleBackColor = false;
            this.add_position.Click += new System.EventHandler(this.add_position_Click);
            // 
            // add_department
            // 
            this.add_department.BackColor = System.Drawing.Color.Transparent;
            this.add_department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.add_department.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_department.IconColor = System.Drawing.Color.Black;
            this.add_department.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_department.Location = new System.Drawing.Point(384, 814);
            this.add_department.Margin = new System.Windows.Forms.Padding(4);
            this.add_department.Name = "add_department";
            this.add_department.Size = new System.Drawing.Size(135, 30);
            this.add_department.TabIndex = 26;
            this.add_department.Text = "ADD DEPARTMENT";
            this.add_department.UseVisualStyleBackColor = false;
            this.add_department.Click += new System.EventHandler(this.add_department_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 32);
            this.label1.TabIndex = 29;
            this.label1.Text = "DASHBOARD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label3.Location = new System.Drawing.Point(27, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 30;
            this.label3.Text = "MANAGE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 340);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Voters";
            // 
            // voters_view
            // 
            this.voters_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(214)))), ((int)(((byte)(249)))));
            this.voters_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voters_view.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.voters_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.voters_view.Location = new System.Drawing.Point(38, 365);
            this.voters_view.Margin = new System.Windows.Forms.Padding(4);
            this.voters_view.Name = "voters_view";
            this.voters_view.Size = new System.Drawing.Size(973, 235);
            this.voters_view.TabIndex = 32;
            // 
            // clearAll
            // 
            this.clearAll.BackColor = System.Drawing.Color.Transparent;
            this.clearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.clearAll.IconChar = FontAwesome.Sharp.IconChar.None;
            this.clearAll.IconColor = System.Drawing.Color.Black;
            this.clearAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearAll.Location = new System.Drawing.Point(876, 299);
            this.clearAll.Margin = new System.Windows.Forms.Padding(4);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(135, 30);
            this.clearAll.TabIndex = 33;
            this.clearAll.Text = "CLEAR ALL";
            this.clearAll.UseVisualStyleBackColor = false;
            this.clearAll.Click += new System.EventHandler(this.clearAll_Click);
            // 
            // AdminDashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.voters_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_department);
            this.Controls.Add(this.add_position);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.positions_grid);
            this.Controls.Add(this.departments_grid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminDashboardPanel";
            this.Size = new System.Drawing.Size(1068, 874);
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
            ((System.ComponentModel.ISupportInitialize)(this.voters_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView positions_grid;
        private System.Windows.Forms.DataGridView departments_grid;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton add_position;
        private FontAwesome.Sharp.IconButton add_department;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label total_voted;
        private System.Windows.Forms.Label total_candidates;
        private System.Windows.Forms.Label total_elections;
        private System.Windows.Forms.Label total_voters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView voters_view;
        private FontAwesome.Sharp.IconButton clearAll;
    }
}
