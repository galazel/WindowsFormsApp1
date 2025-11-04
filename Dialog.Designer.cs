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
            this.label_add = new System.Windows.Forms.Label();
            this.add_position = new FontAwesome.Sharp.IconButton();
            this.add_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(74, 31);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(108, 13);
            this.label_add.TabIndex = 19;
            this.label_add.Text = "ADD DEPARTMENT";
            // 
            // add_position
            // 
            this.add_position.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_position.IconColor = System.Drawing.Color.Black;
            this.add_position.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_position.Location = new System.Drawing.Point(77, 95);
            this.add_position.Name = "add_position";
            this.add_position.Size = new System.Drawing.Size(96, 23);
            this.add_position.TabIndex = 26;
            this.add_position.Text = "ADD";
            this.add_position.UseVisualStyleBackColor = true;
            this.add_position.Click += new System.EventHandler(this.add_position_Click);
            // 
            // add_box
            // 
            this.add_box.Location = new System.Drawing.Point(28, 60);
            this.add_box.Name = "add_box";
            this.add_box.Size = new System.Drawing.Size(198, 20);
            this.add_box.TabIndex = 27;
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 130);
            this.Controls.Add(this.add_box);
            this.Controls.Add(this.add_position);
            this.Controls.Add(this.label_add);
            this.Name = "Dialog";
            this.Text = "AddDepartment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private FontAwesome.Sharp.IconButton add_position;
        private System.Windows.Forms.TextBox add_box;
    }
}