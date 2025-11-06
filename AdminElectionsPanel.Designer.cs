namespace WindowsFormsApp1
{
    partial class AdminElectionsPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.create_election_bttn = new System.Windows.Forms.Button();
            this.elections_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "ELECTIONS";
            // 
            // create_election_bttn
            // 
            this.create_election_bttn.BackColor = System.Drawing.Color.White;
            this.create_election_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_election_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_election_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.create_election_bttn.Location = new System.Drawing.Point(719, 42);
            this.create_election_bttn.Name = "create_election_bttn";
            this.create_election_bttn.Size = new System.Drawing.Size(129, 37);
            this.create_election_bttn.TabIndex = 20;
            this.create_election_bttn.Text = "CREATE";
            this.create_election_bttn.UseVisualStyleBackColor = false;
            this.create_election_bttn.Click += new System.EventHandler(this.create_election_bttn_Click);
            // 
            // elections_flow
            // 
            this.elections_flow.AutoScroll = true;
            this.elections_flow.AutoSize = true;
            this.elections_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elections_flow.Location = new System.Drawing.Point(68, 93);
            this.elections_flow.Name = "elections_flow";
            this.elections_flow.Size = new System.Drawing.Size(779, 397);
            this.elections_flow.TabIndex = 25;
            this.elections_flow.WrapContents = false;
            // 
            // AdminElectionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.elections_flow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_election_bttn);
            this.Name = "AdminElectionsPanel";
            this.Size = new System.Drawing.Size(1037, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_election_bttn;
        private System.Windows.Forms.FlowLayoutPanel elections_flow;
    }
}
