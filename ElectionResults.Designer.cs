namespace WindowsFormsApp1
{
    partial class ElectionResults
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.position_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position_name_label
            // 
            this.position_name_label.AutoSize = true;
            this.position_name_label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_name_label.ForeColor = System.Drawing.Color.Black;
            this.position_name_label.Location = new System.Drawing.Point(440, 32);
            this.position_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position_name_label.Name = "position_name_label";
            this.position_name_label.Size = new System.Drawing.Size(130, 32);
            this.position_name_label.TabIndex = 14;
            this.position_name_label.Text = "WINNERS";
            // 
            // ElectionResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 672);
            this.Controls.Add(this.position_name_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ElectionResults";
            this.Text = "ElectionResults";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_name_label;
    }
}