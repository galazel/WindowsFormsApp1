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
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.winners_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.download_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // department_name_label
            // 
            this.department_name_label.AutoSize = true;
            this.department_name_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_name_label.Location = new System.Drawing.Point(19, 10);
            this.department_name_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.department_name_label.Name = "department_name_label";
            this.department_name_label.Size = new System.Drawing.Size(191, 16);
            this.department_name_label.TabIndex = 50;
            this.department_name_label.Text = "COLLEGE OF COMPUTER STUDIES";
            // 
            // election_name_label
            // 
            this.election_name_label.AutoSize = true;
            this.election_name_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.election_name_label.Location = new System.Drawing.Point(19, 30);
            this.election_name_label.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.election_name_label.Name = "election_name_label";
            this.election_name_label.Size = new System.Drawing.Size(474, 19);
            this.election_name_label.TabIndex = 51;
            this.election_name_label.Text = "PHILIPPINE SOCIETY OF INFORMATION TECHNOLOGY STUDENTS";
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // winners_flow
            // 
            this.winners_flow.AutoScroll = true;
            this.winners_flow.BackColor = System.Drawing.Color.Transparent;
            this.winners_flow.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winners_flow.Location = new System.Drawing.Point(23, 69);
            this.winners_flow.Name = "winners_flow";
            this.winners_flow.Padding = new System.Windows.Forms.Padding(5);
            this.winners_flow.Size = new System.Drawing.Size(922, 325);
            this.winners_flow.TabIndex = 52;
            this.winners_flow.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 53;
            this.label1.Text = "WINNERS";
            // 
            // download_bttn
            // 
            this.download_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.download_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.download_bttn.ForeColor = System.Drawing.Color.White;
            this.download_bttn.Location = new System.Drawing.Point(807, 14);
            this.download_bttn.Margin = new System.Windows.Forms.Padding(4);
            this.download_bttn.Name = "download_bttn";
            this.download_bttn.Size = new System.Drawing.Size(138, 42);
            this.download_bttn.TabIndex = 29;
            this.download_bttn.Text = "DOWNLOAD";
            this.download_bttn.UseVisualStyleBackColor = false;
            this.download_bttn.Click += new System.EventHandler(this.download_bttn_Click);
            // 
            // EndedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.download_bttn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.winners_flow);
            this.Controls.Add(this.election_name_label);
            this.Controls.Add(this.department_name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "EndedPanel";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(959, 416);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label department_name_label;
        private System.Windows.Forms.Label election_name_label;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.FlowLayoutPanel winners_flow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button download_bttn;
    }
}
