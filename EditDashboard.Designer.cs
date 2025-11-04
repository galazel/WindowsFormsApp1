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
            this.add_box.Location = new System.Drawing.Point(27, 51);
            this.add_box.Name = "add_box";
            this.add_box.Size = new System.Drawing.Size(198, 20);
            this.add_box.TabIndex = 30;
            // 
            // edit
            // 
            this.edit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.edit.IconColor = System.Drawing.Color.Black;
            this.edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit.Location = new System.Drawing.Point(76, 86);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(96, 23);
            this.edit.TabIndex = 29;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(73, 22);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(108, 13);
            this.label_add.TabIndex = 28;
            this.label_add.Text = "ADD DEPARTMENT";
            // 
            // EditDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 130);
            this.Controls.Add(this.add_box);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.label_add);
            this.Name = "EditDashboard";
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