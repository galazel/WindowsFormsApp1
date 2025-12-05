namespace WindowsFormsApp1
{
    partial class AdminEndedPanel
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
            this.ended_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.clear_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 32);
            this.label1.TabIndex = 27;
            this.label1.Text = "OFFICIAL RESULTS";
            // 
            // ended_flow
            // 
            this.ended_flow.AutoScroll = true;
            this.ended_flow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ended_flow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ended_flow.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ended_flow.Location = new System.Drawing.Point(57, 93);
            this.ended_flow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ended_flow.Name = "ended_flow";
            this.ended_flow.Size = new System.Drawing.Size(927, 583);
            this.ended_flow.TabIndex = 28;
            this.ended_flow.WrapContents = false;
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.White;
            this.clear_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.clear_button.Location = new System.Drawing.Point(908, 44);
            this.clear_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(76, 35);
            this.clear_button.TabIndex = 53;
            this.clear_button.Text = "CLEAR ";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // AdminEndedPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.ended_flow);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AdminEndedPanel";
            this.Size = new System.Drawing.Size(1139, 801);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel ended_flow;
        private System.Windows.Forms.Button clear_button;
    }
}
