namespace WindowsFormsApp1
{
    partial class ResultLabelcs
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
            this.position_name_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // position_name_label
            // 
            this.position_name_label.AutoSize = true;
            this.position_name_label.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position_name_label.ForeColor = System.Drawing.Color.Black;
            this.position_name_label.Location = new System.Drawing.Point(14, 21);
            this.position_name_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.position_name_label.Name = "position_name_label";
            this.position_name_label.Size = new System.Drawing.Size(762, 41);
            this.position_name_label.TabIndex = 14;
            this.position_name_label.Text = "YOU NEED TO VOTE FIRST TO VIEW THE RESULT";
            // 
            // ResultLabelcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.position_name_label);
            this.Name = "ResultLabelcs";
            this.Size = new System.Drawing.Size(800, 80);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label position_name_label;
    }
}
