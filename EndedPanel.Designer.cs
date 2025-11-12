namespace WindowsFormsApp1
{
    partial class EndedPanel
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
            this.department_name_label = new System.Windows.Forms.Label();
            this.election_name_label = new System.Windows.Forms.Label();
            this.view_result = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // department_name_label
            // 
            this.department_name_label.AutoSize = true;
            this.department_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_name_label.Location = new System.Drawing.Point(58, 37);
            this.department_name_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.department_name_label.Name = "department_name_label";
            this.department_name_label.Size = new System.Drawing.Size(248, 19);
            this.department_name_label.TabIndex = 50;
            this.department_name_label.Text = "COLLEGE OF COMPUTER STUDIES";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(58, 56);
            this.election_name_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(483, 19);
            this.election_name_label.TabIndex = 51;
            this.election_name_label.Text = "PHILIPPINE SOCIETY OF INFORMATION TECHNOLOGY STUDENTS";
            // 
            // view_result
            // 
            this.view_result.BackColor = System.Drawing.Color.White;
            this.view_result.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.view_result.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.view_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.view_result.Location = new System.Drawing.Point(62, 87);
            this.view_result.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.view_result.Name = "view_result";
            this.view_result.Size = new System.Drawing.Size(150, 39);
            this.view_result.TabIndex = 52;
            this.view_result.Text = "VIEW RESULT";
            this.view_result.UseVisualStyleBackColor = false;
            this.view_result.Click += new System.EventHandler(this.view_result_Click);
            // 
            // EndedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.view_result);
            this.Controls.Add(this.election_name_label);
            this.Controls.Add(this.department_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EndedPanel";
            this.Size = new System.Drawing.Size(929, 122);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label department_name_label;
        private System.Windows.Forms.Label election_name_label;
        private System.Windows.Forms.Button view_result;
    }
}
