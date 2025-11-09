namespace WindowsFormsApp1
{
    partial class PositionFlowLayout
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
            this.candidates_flow = new System.Windows.Forms.FlowLayoutPanel();
            this.position_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // candidates_flow
            // 
            this.candidates_flow.AutoScroll = true;
            this.candidates_flow.BackColor = System.Drawing.Color.White;
            this.candidates_flow.Location = new System.Drawing.Point(16, 27);
            this.candidates_flow.Margin = new System.Windows.Forms.Padding(4);
            this.candidates_flow.Name = "candidates_flow";
            this.candidates_flow.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.candidates_flow.Size = new System.Drawing.Size(1016, 338);
            this.candidates_flow.TabIndex = 0;
            this.candidates_flow.WrapContents = false;
            // 
            // position_label
            // 
            this.position_label.AutoSize = true;
            this.position_label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.position_label.Location = new System.Drawing.Point(12, 0);
            this.position_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position_label.Name = "position_label";
            this.position_label.Size = new System.Drawing.Size(155, 23);
            this.position_label.TabIndex = 15;
            this.position_label.Text = "POSITION NAME";
            // 
            // PositionFlowLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.position_label);
            this.Controls.Add(this.candidates_flow);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PositionFlowLayout";
            this.Size = new System.Drawing.Size(1074, 393);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel candidates_flow;
        private System.Windows.Forms.Label position_label;
    }
}
