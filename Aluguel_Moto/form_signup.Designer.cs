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
            imgDL = new PictureBox();
            label7 = new Label();
            btnImage = new Button();
            ((System.ComponentModel.ISupportInitialize)imgDL).BeginInit();
            SuspendLayout();
            // 
            // txtCNPJ
            // 
            txtCNPJ.Font = new Font("Arial", 12F);
            txtCNPJ.Location = new Point(89, 39);
            txtCNPJ.Name = "txtCNPJ";
            txtCNPJ.Size = new Size(225, 26);
            txtCNPJ.TabIndex = 2;
            txtCNPJ.Enter += txtCNPJ_Enter;
            txtCNPJ.Leave += txtCNPJ_Leave;
            // 
            // txtName
            // 
            txtName.Font = new Font("Arial", 12F);
            txtName.Location = new Point(89, 98);
            txtName.Name = "txtName";
            txtName.Size = new Size(225, 26);
            txtName.TabIndex = 3;
            // 
            // dtBirth
            // 
            dtBirth.Font = new Font("Arial", 12F);
            dtBirth.Format = DateTimePickerFormat.Short;
            dtBirth.Location = new Point(184, 132);
            dtBirth.Name = "dtBirth";
            dtBirth.Size = new Size(130, 26);
            dtBirth.TabIndex = 4;
            // 
            // numDL
            // 
            numDL.Font = new Font("Arial", 12F);
            numDL.Location = new Point(91, 222);
            numDL.MaxLength = 12;
            numDL.Name = "numDL";
            numDL.Size = new Size(223, 26);
            numDL.TabIndex = 5;
            numDL.KeyPress += numDL_KeyPress;
            // 
            // txtDL
            // 
            txtDL.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtDL.Font = new Font("Arial", 12F);
            txtDL.FormattingEnabled = true;
            txtDL.Items.AddRange(new object[] { "A", "A + B", "B" });
            txtDL.Location = new Point(232, 168);
            txtDL.Name = "txtDL";
            txtDL.Size = new Size(82, 26);
            txtDL.Sorted = true;
            txtDL.TabIndex = 6;
            // 
            // btnSignUp
            // 
            btnSignUp.AutoSize = true;
            btnSignUp.BackColor = SystemColors.Control;
            btnSignUp.FlatAppearance.BorderColor = Color.Black;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Arial", 12F);
            btnSignUp.Location = new Point(212, 320);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(102, 32);
            btnSignUp.TabIndex = 7;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F);
            label1.Location = new Point(89, 19);
            label1.Name = "label1";
            label1.Size = new Size(46, 17);
            label1.TabIndex = 8;
            label1.Text = "CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F);
            label2.Location = new Point(89, 78);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F);
            label3.Location = new Point(89, 136);
            label3.Name = "label3";
            label3.Size = new Size(89, 17);
            label3.TabIndex = 10;
            label3.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F);
            label4.Location = new Point(89, 202);
            label4.Name = "label4";
            label4.Size = new Size(169, 17);
            label4.TabIndex = 11;
            label4.Text = "Driver's License Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F);
            label5.Location = new Point(89, 170);
            label5.Name = "label5";
            label5.Size = new Size(137, 17);
            label5.TabIndex = 12;
            label5.Text = "Driver's L. Category";
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Arial", 12F);
            btnLogin.Location = new Point(91, 320);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(98, 32);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Back";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F);
            label6.Location = new Point(89, 256);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // txtPsw
            // 
            txtPsw.Font = new Font("Arial", 12F);
            txtPsw.Location = new Point(91, 276);
            txtPsw.Name = "txtPsw";
            txtPsw.PasswordChar = '*';
            txtPsw.Size = new Size(223, 26);
            txtPsw.TabIndex = 15;
            // 
            // imgDL
            // 
            imgDL.BorderStyle = BorderStyle.FixedSingle;
            imgDL.Image = Properties.Resources.Image_not_available;
            imgDL.InitialImage = null;
            imgDL.Location = new Point(331, 39);
            imgDL.Name = "imgDL";
            imgDL.Size = new Size(200, 122);
            imgDL.SizeMode = PictureBoxSizeMode.StretchImage;
            imgDL.TabIndex = 17;
            imgDL.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F);
            label7.Location = new Point(352, 19);
            label7.Name = "label7";
            label7.Size = new Size(161, 17);
            label7.TabIndex = 18;
            label7.Text = "Driver's License Image ";
            // 
            // btnImage
            // 
            btnImage.AutoSize = true;
            btnImage.BackColor = SystemColors.Control;
            btnImage.FlatAppearance.BorderColor = Color.Black;
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnImage.Location = new Point(374, 167);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(129, 30);
            btnImage.TabIndex = 19;
            btnImage.Text = "Load Image";
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;
            // 
            // form_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 389);
            Controls.Add(btnImage);
            Controls.Add(label7);
            Controls.Add(imgDL);
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
            MaximizeBox = false;
            Name = "form_signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)imgDL).EndInit();
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
        private PictureBox imgDL;
        private Label label7;
        private Button btnImage;
    }
}