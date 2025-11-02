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
            this.username.Location = new System.Drawing.Point(74, 197);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(74, 250);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(77, 214);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(282, 20);
            this.username_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(77, 266);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(282, 20);
            this.password_box.TabIndex = 3;
            // 
            // login_bttn
            // 
            this.login_bttn.Location = new System.Drawing.Point(180, 305);
            this.login_bttn.Name = "login_bttn";
            this.login_bttn.Size = new System.Drawing.Size(75, 23);
            this.login_bttn.TabIndex = 4;
            this.login_bttn.Text = "LOGIN";
            this.login_bttn.UseVisualStyleBackColor = true;
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Location = new System.Drawing.Point(74, 390);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(188, 13);
            this.register_label.TabIndex = 5;
            this.register_label.Text = "Don\'t have an account? Register here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "eBoto";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_label);
            this.Controls.Add(this.login_bttn);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Login";
            this.Text = "Form1";
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

