namespace Aluguel_Moto
{
    partial class form_signup
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
            txtCNPJ = new MaskedTextBox();
            txtName = new TextBox();
            dtBirth = new DateTimePicker();
            numDL = new TextBox();
            txtDL = new ComboBox();
            btnSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnLogin = new Button();
            label6 = new Label();
            txtPsw = new TextBox();
            SuspendLayout();
            // 
            // txtCNPJ
            // 
            txtCNPJ.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCNPJ.Location = new Point(89, 27);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(187, 29);
            txtCNPJ.TabIndex = 2;
            txtCNPJ.Enter += txtCNPJ_Enter;
            txtCNPJ.Leave += txtCNPJ_Leave;
            // 
            // txtName
            // 
            txtName.Location = new Point(89, 86);
            txtName.Name = "txtName";
            txtName.Size = new Size(187, 23);
            txtName.TabIndex = 3;
            // 
            // dtBirth
            // 
            dtBirth.Format = DateTimePickerFormat.Short;
            dtBirth.Location = new Point(168, 123);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(108, 23);
            dtBirth.TabIndex = 4;
            // 
            // numDL
            // 
            numDL.Location = new Point(91, 200);
            numDL.MaxLength = 12;
            numDL.Name = "numDL";
            numDL.Size = new Size(187, 23);
            numDL.TabIndex = 5;
            numDL.KeyPress += numDL_KeyPress;
            // 
            // txtDL
            // 
            txtDL.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDL.FormattingEnabled = true;
            txtDL.Items.AddRange(new object[] { "A", "A + B", "B" });
            txtDL.Location = new Point(210, 152);
            txtDL.Name = "txtDL";
            txtDL.Size = new Size(66, 23);
            txtDL.Sorted = true;
            txtDL.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(203, 301);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 9);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 8;
            label1.Text = "CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 68);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 129);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 182);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 11;
            label4.Text = "Driver's License Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 155);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 12;
            label5.Text = "Driver's License Type";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(89, 301);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Back";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 237);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // txtPsw
            // 
            txtPsw.Location = new Point(89, 255);
            txtPsw.MaxLength = 12;
            txtPsw.Name = "txtPsw";
            txtPsw.Size = new Size(187, 23);
            txtPsw.TabIndex = 15;
            // 
            // form_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 373);
            Controls.Add(txtPsw);
            Controls.Add(label6);
            Controls.Add(btnLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(txtDL);
            Controls.Add(numDL);
            Controls.Add(dtBirth);
            Controls.Add(txtName);
            Controls.Add(txtCNPJ);
            Name = "form_signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtCNPJ;
        private TextBox txtName;
        private DateTimePicker dtBirth;
        private TextBox numDL;
        private ComboBox txtDL;
        private Button btnSignUp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnLogin;
        private Label label6;
        private TextBox txtPsw;
    }
}