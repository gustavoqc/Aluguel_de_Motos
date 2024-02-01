namespace Aluguel_Moto
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
            button2 = new Button();
            txtUser = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(203, 122);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.Size = new Size(187, 26);
            txtPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(203, 183);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 30);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.Location = new Point(315, 183);
            button2.Name = "button2";
            button2.Size = new Size(75, 30);
            button2.TabIndex = 3;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtUser
            // 
            txtUser.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUser.Location = new Point(203, 54);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(187, 29);
            txtUser.TabIndex = 1;
            txtUser.Enter += txtUser_Enter;
            txtUser.KeyPress += txtUser_KeyPress;
            txtUser.Leave += txtUser_Leave;
            // 
            // form_login
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 384);
            Controls.Add(txtUser);
            Controls.Add(button2);
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
        private Button button2;
        private MaskedTextBox txtUser;
    }
}
