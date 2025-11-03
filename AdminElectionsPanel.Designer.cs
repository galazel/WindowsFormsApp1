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
            this.label2 = new System.Windows.Forms.Label();
            this.create_election_bttn = new System.Windows.Forms.Button();
            this.elections_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "ELECTIONS";
            // 
            // create_election_bttn
            // 
            this.create_election_bttn.Location = new System.Drawing.Point(732, 51);
            this.create_election_bttn.Name = "create_election_bttn";
            this.create_election_bttn.Size = new System.Drawing.Size(139, 23);
            this.create_election_bttn.TabIndex = 20;
            this.create_election_bttn.Text = "CREATE";
            this.create_election_bttn.UseVisualStyleBackColor = true;
            this.create_election_bttn.Click += new System.EventHandler(this.create_election_bttn_Click);
            // 
            // elections_flow
            // 
            this.elections_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.elections_flow.Location = new System.Drawing.Point(114, 93);
            this.elections_flow.Name = "elections_flow";
            this.elections_flow.Size = new System.Drawing.Size(757, 362);
            this.elections_flow.TabIndex = 21;
            this.elections_flow.WrapContents = false;
            // 
            // AdminElectionsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.elections_flow);
            this.Controls.Add(this.create_election_bttn);
            this.Controls.Add(this.label2);
            this.Name = "AdminElectionsPanel";
            this.Size = new System.Drawing.Size(1037, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button create_election_bttn;
        private System.Windows.Forms.FlowLayoutPanel elections_flow;
    }
}
