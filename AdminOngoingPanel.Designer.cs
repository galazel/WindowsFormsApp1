namespace WindowsFormsApp1
{
    partial class AdminOngoingPanel
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
            this.ongoing_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ongoing_flow
            // 
            this.ongoing_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ongoing_flow.Location = new System.Drawing.Point(87, 93);
            this.ongoing_flow.Name = "ongoing_flow";
            this.ongoing_flow.Size = new System.Drawing.Size(779, 397);
            this.ongoing_flow.TabIndex = 24;
            this.ongoing_flow.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "ONGOING ELECTION";
            // 
            // AdminOngoingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.ongoing_flow);
            this.Controls.Add(this.label2);
            this.Name = "AdminOngoingPanel";
            this.Size = new System.Drawing.Size(1037, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ongoing_flow;
        private System.Windows.Forms.Label label2;
    }
}
