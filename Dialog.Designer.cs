namespace WindowsFormsApp1
{
    partial class Dialog
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
            this.add_position = new FontAwesome.Sharp.IconButton();
            this.add_box = new System.Windows.Forms.TextBox();
            this.label_add = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_position
            // 
            this.add_position.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.add_position.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_position.ForeColor = System.Drawing.Color.White;
            this.add_position.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_position.IconColor = System.Drawing.Color.Black;
            this.add_position.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_position.Location = new System.Drawing.Point(78, 115);
            this.add_position.Margin = new System.Windows.Forms.Padding(4);
            this.add_position.Name = "add_position";
            this.add_position.Size = new System.Drawing.Size(138, 42);
            this.add_position.TabIndex = 26;
            this.add_position.Text = "ADD";
            this.add_position.UseVisualStyleBackColor = false;
            this.add_position.Click += new System.EventHandler(this.add_position_Click);
            // 
            // add_box
            // 
            this.add_box.Location = new System.Drawing.Point(33, 78);
            this.add_box.Margin = new System.Windows.Forms.Padding(4);
            this.add_box.Name = "add_box";
            this.add_box.Size = new System.Drawing.Size(230, 22);
            this.add_box.TabIndex = 27;
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_add.ForeColor = System.Drawing.Color.Black;
            this.label_add.Location = new System.Drawing.Point(63, 28);
            this.label_add.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(171, 23);
            this.label_add.TabIndex = 30;
            this.label_add.Text = "ADD DEPARTMENT";
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(294, 170);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.add_box);
            this.Controls.Add(this.add_position);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton add_position;
        private System.Windows.Forms.TextBox add_box;
        private System.Windows.Forms.Label label_add;
    }
}