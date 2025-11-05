namespace WindowsFormsApp1
{
    partial class Login
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
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_bttn = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.username.Location = new System.Drawing.Point(70, 224);
            this.username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(88, 21);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.password.Location = new System.Drawing.Point(70, 298);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(82, 21);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // username_box
            // 
            this.username_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.username_box.Location = new System.Drawing.Point(74, 246);
            this.username_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(367, 27);
            this.username_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.password_box.Location = new System.Drawing.Point(74, 323);
            this.password_box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_box.Name = "password_box";
            this.password_box.PasswordChar = '*';
            this.password_box.Size = new System.Drawing.Size(367, 27);
            this.password_box.TabIndex = 3;
            this.password_box.UseSystemPasswordChar = true;
            // 
            // login_bttn
            // 
            this.login_bttn.BackColor = System.Drawing.Color.White;
            this.login_bttn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_bttn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_bttn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_bttn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.login_bttn.Location = new System.Drawing.Point(188, 427);
            this.login_bttn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(137, 37);
            this.login_bttn.TabIndex = 4;
            this.login_bttn.Text = "LOGIN";
            this.login_bttn.UseVisualStyleBackColor = false;
            this.login_bttn.Click += new System.EventHandler(this.login_bttn_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register_label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.register_label.Location = new System.Drawing.Point(104, 560);
            this.register_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(308, 21);
            this.register_label.TabIndex = 5;
            this.register_label.Text = "Don\'t have an account? Register here";
            this.register_label.Click += new System.EventHandler(this.register_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(178, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "eBoto";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(531, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.login_bttn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button login_bttn;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Label label1;
    }
}

