namespace WindowsFormsApp1
{
    partial class EditDashboard
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
            this.add_box = new System.Windows.Forms.TextBox();
            this.edit = new FontAwesome.Sharp.IconButton();
            this.label_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_box
            // 
            this.add_box.Location = new System.Drawing.Point(31, 67);
            this.add_box.Margin = new System.Windows.Forms.Padding(4);
            this.add_box.Name = "add_box";
            this.add_box.Size = new System.Drawing.Size(230, 22);
            this.add_box.TabIndex = 30;
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.Color.Transparent;
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.edit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.edit.IconColor = System.Drawing.Color.Black;
            this.edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit.Location = new System.Drawing.Point(89, 112);
            this.edit.Margin = new System.Windows.Forms.Padding(4);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(112, 30);
            this.edit.TabIndex = 29;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(12)))), ((int)(((byte)(1)))));
            this.label_add.Location = new System.Drawing.Point(85, 29);
            this.label_add.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(112, 17);
            this.label_add.TabIndex = 28;
            this.label_add.Text = "ADD DEPARTMENT";
            // 
            // EditDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(294, 170);
            this.Controls.Add(this.add_box);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label_add);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox add_box;
        private FontAwesome.Sharp.IconButton edit;
        private System.Windows.Forms.Label label_add;
    }
}