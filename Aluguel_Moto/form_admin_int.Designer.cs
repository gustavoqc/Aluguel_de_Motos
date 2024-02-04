namespace Aluguel_Moto
{
    partial class form_admin_int
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnNewVh = new Button();
            btnCheckVh = new Button();
            pnlNewVh = new Panel();
            pnlCheckVh = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            dtgListVh = new DataGridView();
            label4 = new Label();
            txtSearchPlate = new TextBox();
            btnCancelUpdate = new Button();
            txtYear = new TextBox();
            txtPlate = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtModel = new TextBox();
            label1 = new Label();
            btnRegVh = new Button();
            pnlNewVh.SuspendLayout();
            pnlCheckVh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListVh).BeginInit();
            SuspendLayout();
            // 
            // btnNewVh
            // 
            btnNewVh.AutoSize = true;
            btnNewVh.BackColor = Color.Transparent;
            btnNewVh.FlatAppearance.BorderColor = SystemColors.Control;
            btnNewVh.FlatAppearance.BorderSize = 0;
            btnNewVh.FlatStyle = FlatStyle.Flat;
            btnNewVh.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewVh.Location = new Point(-3, 75);
            btnNewVh.Name = "btnNewVh";
            btnNewVh.Size = new Size(152, 29);
            btnNewVh.TabIndex = 2;
            btnNewVh.Text = "New Vehicle";
            btnNewVh.UseVisualStyleBackColor = false;
            btnNewVh.Click += btnNewVh_Click;
            // 
            // btnCheckVh
            // 
            btnCheckVh.AutoSize = true;
            btnCheckVh.BackColor = Color.LightGray;
            btnCheckVh.FlatAppearance.BorderColor = SystemColors.Control;
            btnCheckVh.FlatAppearance.BorderSize = 0;
            btnCheckVh.FlatStyle = FlatStyle.Flat;
            btnCheckVh.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckVh.ForeColor = Color.Black;
            btnCheckVh.Location = new Point(-3, 40);
            btnCheckVh.Name = "btnCheckVh";
            btnCheckVh.Size = new Size(152, 29);
            btnCheckVh.TabIndex = 3;
            btnCheckVh.Text = "Check Vehicles";
            btnCheckVh.UseVisualStyleBackColor = false;
            btnCheckVh.Click += btnCheckVh_Click;
            // 
            // pnlNewVh
            // 
            pnlNewVh.BorderStyle = BorderStyle.FixedSingle;
            pnlNewVh.Controls.Add(btnCancelUpdate);
            pnlNewVh.Controls.Add(txtPlate);
            pnlNewVh.Controls.Add(label3);
            pnlNewVh.Controls.Add(txtYear);
            pnlNewVh.Controls.Add(label2);
            pnlNewVh.Controls.Add(txtModel);
            pnlNewVh.Controls.Add(label1);
            pnlNewVh.Controls.Add(btnRegVh);
            pnlNewVh.Location = new Point(149, -7);
            pnlNewVh.Name = "pnlNewVh";
            pnlNewVh.Size = new Size(560, 390);
            pnlNewVh.TabIndex = 4;
            // 
            // pnlCheckVh
            // 
            pnlCheckVh.BackColor = SystemColors.Control;
            pnlCheckVh.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckVh.Controls.Add(btnDelete);
            pnlCheckVh.Controls.Add(btnEdit);
            pnlCheckVh.Controls.Add(dtgListVh);
            pnlCheckVh.Controls.Add(label4);
            pnlCheckVh.Controls.Add(txtSearchPlate);
            pnlCheckVh.Location = new Point(149, -6);
            pnlCheckVh.Name = "pnlCheckVh";
            pnlCheckVh.Size = new Size(560, 390);
            pnlCheckVh.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.LightGray;
            btnDelete.BackgroundImage = Properties.Resources.delete_Icon;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.Enabled = false;
            btnDelete.FlatAppearance.BorderColor = Color.Black;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(503, 21);
            btnDelete.Name = "btnDelete";
            btnDelete.RightToLeft = RightToLeft.No;
            btnDelete.Size = new Size(30, 30);
            btnDelete.TabIndex = 4;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.EnabledChanged += btnDelete_EnabledChanged;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.LightGray;
            btnEdit.BackgroundImage = Properties.Resources.update;
            btnEdit.BackgroundImageLayout = ImageLayout.Zoom;
            btnEdit.Enabled = false;
            btnEdit.FlatAppearance.BorderColor = Color.Black;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Location = new Point(467, 20);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(30, 30);
            btnEdit.TabIndex = 3;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.EnabledChanged += btnEdit_EnabledChanged;
            btnEdit.Click += btnEdit_Click;
            // 
            // dtgListVh
            // 
            dtgListVh.AllowUserToAddRows = false;
            dtgListVh.AllowUserToResizeColumns = false;
            dtgListVh.AllowUserToResizeRows = false;
            dtgListVh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListVh.BackgroundColor = SystemColors.Control;
            dtgListVh.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dtgListVh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgListVh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgListVh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgListVh.DefaultCellStyle = dataGridViewCellStyle4;
            dtgListVh.EnableHeadersVisualStyles = false;
            dtgListVh.Location = new Point(19, 62);
            dtgListVh.MultiSelect = false;
            dtgListVh.Name = "dtgListVh";
            dtgListVh.RightToLeft = RightToLeft.No;
            dtgListVh.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgListVh.RowHeadersVisible = false;
            dtgListVh.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgListVh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgListVh.Size = new Size(524, 310);
            dtgListVh.TabIndex = 2;
            dtgListVh.CellClick += dtgListVh_CellClick;
            dtgListVh.DataBindingComplete += dtgListVh_DataBindingComplete;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 27);
            label4.Name = "label4";
            label4.Size = new Size(107, 18);
            label4.TabIndex = 1;
            label4.Text = "License Plate:";
            // 
            // txtSearchPlate
            // 
            txtSearchPlate.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchPlate.Location = new Point(132, 21);
            txtSearchPlate.MaxLength = 7;
            txtSearchPlate.Name = "txtSearchPlate";
            txtSearchPlate.Size = new Size(159, 29);
            txtSearchPlate.TabIndex = 0;
            txtSearchPlate.KeyUp += txtSearchPlate_KeyUp;
            // 
            // btnCancelUpdate
            // 
            btnCancelUpdate.AutoSize = true;
            btnCancelUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelUpdate.Location = new Point(148, 215);
            btnCancelUpdate.Name = "btnCancelUpdate";
            btnCancelUpdate.Size = new Size(233, 31);
            btnCancelUpdate.TabIndex = 9;
            btnCancelUpdate.Text = "Cancel Update";
            btnCancelUpdate.UseVisualStyleBackColor = true;
            btnCancelUpdate.Visible = false;
            btnCancelUpdate.Click += btnCancelUpdate_Click;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Arial", 12F);
            txtYear.Location = new Point(148, 128);
            txtYear.MaxLength = 4;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(94, 26);
            txtYear.TabIndex = 2;
            txtYear.KeyPress += txtYear_KeyPress;
            // 
            // txtPlate
            // 
            txtPlate.Font = new Font("Arial", 12F);
            txtPlate.Location = new Point(248, 128);
            txtPlate.MaxLength = 7;
            txtPlate.Name = "txtPlate";
            txtPlate.Size = new Size(133, 26);
            txtPlate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(261, 107);
            label3.Name = "label3";
            label3.Size = new Size(103, 18);
            label3.TabIndex = 5;
            label3.Text = "License Plate";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(148, 107);
            label2.Name = "label2";
            label2.Size = new Size(94, 18);
            label2.TabIndex = 4;
            label2.Text = "Vehicle Year";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Arial", 12F);
            txtModel.Location = new Point(148, 69);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(233, 26);
            txtModel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(148, 48);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 1;
            label1.Text = "Vehicle Model";
            // 
            // btnRegVh
            // 
            btnRegVh.AutoSize = true;
            btnRegVh.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegVh.Location = new Point(148, 169);
            btnRegVh.Name = "btnRegVh";
            btnRegVh.Size = new Size(233, 31);
            btnRegVh.TabIndex = 4;
            btnRegVh.Text = "Registrate Motorcycle";
            btnRegVh.UseVisualStyleBackColor = true;
            btnRegVh.Click += btnRegVh_Click;
            // 
            // form_admin_int
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 381);
            Controls.Add(btnCheckVh);
            Controls.Add(btnNewVh);
            Controls.Add(pnlCheckVh);
            Controls.Add(pnlNewVh);
            Name = "form_admin_int";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            pnlNewVh.ResumeLayout(false);
            pnlNewVh.PerformLayout();
            pnlCheckVh.ResumeLayout(false);
            pnlCheckVh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListVh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNewVh;
        private Button btnCheckVh;
        private Panel pnlNewVh;
        private Label label1;
        private Button btnRegVh;
        private TextBox txtModel;
        private TextBox txtPlate;
        private Label label3;
        private Label label2;
        private TextBox txtYear;
        private Panel pnlCheckVh;
        private DataGridView dtgListVh;
        private Label label4;
        private TextBox txtSearchPlate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCancelUpdate;
    }
}