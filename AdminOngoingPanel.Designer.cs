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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ongoing_flow
            // 
            this.ongoing_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ongoing_flow.Location = new System.Drawing.Point(68, 93);
            this.ongoing_flow.Name = "ongoing_flow";
            this.ongoing_flow.Size = new System.Drawing.Size(779, 397);
            this.ongoing_flow.TabIndex = 24;
            this.ongoing_flow.WrapContents = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.label1.Location = new System.Drawing.Point(65, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "ONGOING ELECTIONS";
            // 
            // AdminOngoingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ongoing_flow);
            this.Name = "AdminOngoingPanel";
            this.Size = new System.Drawing.Size(1037, 535);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ongoing_flow;
        private System.Windows.Forms.Label label1;
    }
}
