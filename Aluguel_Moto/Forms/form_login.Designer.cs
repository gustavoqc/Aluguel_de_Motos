﻿namespace Aluguel_Moto
{
    partial class form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnSignup = new Button();
            txtUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(104, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(187, 26);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(101, 158);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnSignup
            // 
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Location = new Point(216, 158);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(75, 30);
            btnSignup.TabIndex = 4;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // txtUser
            // 
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(104, 49);
            txtUser.MaxLength = 12;
            txtUser.Name = "txtUser";
            txtUser.RightToLeft = RightToLeft.No;
            txtUser.Size = new Size(187, 26);
            txtUser.TabIndex = 1;
            txtUser.KeyPress += txtUser_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 90);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 28);
            label2.Name = "label2";
            label2.Size = new Size(179, 18);
            label2.TabIndex = 6;
            label2.Text = "Driver's License Number";
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 231);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUser);
            Controls.Add(btnSignup);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "form_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnSignup;
        private TextBox txtUser;
        private Label label1;
        private Label label2;
    }
}
