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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnNewVh = new Button();
            btnCheckVh = new Button();
            pnlNewVh = new Panel();
            btnCancelUpdate = new Button();
            txtPlate = new TextBox();
            label3 = new Label();
            txtYear = new TextBox();
            label2 = new Label();
            txtModel = new TextBox();
            label1 = new Label();
            btnRegVh = new Button();
            pnlCheckVh = new Panel();
            btnDelete = new Button();
            btnEdit = new Button();
            dtgListVh = new DataGridView();
            label4 = new Label();
            txtSearchPlate = new TextBox();
            btnLogOut = new Button();
            btnNewOrder = new Button();
            pnlNewOrder = new Panel();
            btnCancelOrder = new Button();
            txtDesc = new TextBox();
            label9 = new Label();
            txtLabel = new TextBox();
            label8 = new Label();
            txtOrderValue = new TextBox();
            label7 = new Label();
            label6 = new Label();
            dtCreationD = new DateTimePicker();
            label5 = new Label();
            btnCreateOrder = new Button();
            btnCheckOrder = new Button();
            pnlCheckOrder = new Panel();
            btnBackOrders = new Button();
            label10 = new Label();
            btnCheckDrivers = new Button();
            btnDeleteOrder = new Button();
            btnEditOrder = new Button();
            dtgOrders = new DataGridView();
            pnlNewVh.SuspendLayout();
            pnlCheckVh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListVh).BeginInit();
            pnlNewOrder.SuspendLayout();
            pnlCheckOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgOrders).BeginInit();
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
            btnNewVh.Location = new Point(-3, 103);
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
            pnlNewVh.Visible = false;
            // 
            // btnCancelUpdate
            // 
            btnCancelUpdate.AutoSize = true;
            btnCancelUpdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelUpdate.Location = new Point(148, 215);
            btnCancelUpdate.Name = "btnCancelUpdate";
            btnCancelUpdate.Size = new Size(233, 31);
            btnCancelUpdate.TabIndex = 9;
            btnCancelUpdate.Text = "Cancel";
            btnCancelUpdate.UseVisualStyleBackColor = true;
            btnCancelUpdate.Click += btnCancelUpdate_Click;
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
            btnEdit.Location = new Point(467, 21);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgListVh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgListVh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgListVh.DefaultCellStyle = dataGridViewCellStyle2;
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
            // btnLogOut
            // 
            btnLogOut.AutoSize = true;
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.FlatAppearance.BorderColor = SystemColors.Control;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogOut.Location = new Point(-3, 170);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(152, 29);
            btnLogOut.TabIndex = 31;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnNewOrder
            // 
            btnNewOrder.AutoSize = true;
            btnNewOrder.BackColor = Color.Transparent;
            btnNewOrder.FlatAppearance.BorderColor = SystemColors.Control;
            btnNewOrder.FlatAppearance.BorderSize = 0;
            btnNewOrder.FlatStyle = FlatStyle.Flat;
            btnNewOrder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewOrder.Location = new Point(-3, 136);
            btnNewOrder.Name = "btnNewOrder";
            btnNewOrder.Size = new Size(152, 29);
            btnNewOrder.TabIndex = 32;
            btnNewOrder.Text = "New Order";
            btnNewOrder.UseVisualStyleBackColor = false;
            btnNewOrder.Click += btnNewOrder_Click;
            // 
            // pnlNewOrder
            // 
            pnlNewOrder.BackColor = SystemColors.Control;
            pnlNewOrder.BorderStyle = BorderStyle.FixedSingle;
            pnlNewOrder.Controls.Add(btnCancelOrder);
            pnlNewOrder.Controls.Add(txtDesc);
            pnlNewOrder.Controls.Add(label9);
            pnlNewOrder.Controls.Add(txtLabel);
            pnlNewOrder.Controls.Add(label8);
            pnlNewOrder.Controls.Add(txtOrderValue);
            pnlNewOrder.Controls.Add(label7);
            pnlNewOrder.Controls.Add(label6);
            pnlNewOrder.Controls.Add(dtCreationD);
            pnlNewOrder.Controls.Add(label5);
            pnlNewOrder.Controls.Add(btnCreateOrder);
            pnlNewOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlNewOrder.Location = new Point(149, -3);
            pnlNewOrder.Name = "pnlNewOrder";
            pnlNewOrder.Size = new Size(560, 390);
            pnlNewOrder.TabIndex = 9;
            pnlNewOrder.Visible = false;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.AutoSize = true;
            btnCancelOrder.FlatStyle = FlatStyle.Flat;
            btnCancelOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelOrder.Location = new Point(201, 285);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(122, 31);
            btnCancelOrder.TabIndex = 45;
            btnCancelOrder.Text = "Cancel";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(142, 100);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(324, 96);
            txtDesc.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 103);
            label9.Name = "label9";
            label9.Size = new Size(92, 18);
            label9.TabIndex = 41;
            label9.Text = "Description:";
            // 
            // txtLabel
            // 
            txtLabel.Location = new Point(142, 65);
            txtLabel.Name = "txtLabel";
            txtLabel.Size = new Size(324, 26);
            txtLabel.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 68);
            label8.Name = "label8";
            label8.Size = new Size(89, 18);
            label8.TabIndex = 39;
            label8.Text = "Order label:";
            // 
            // txtOrderValue
            // 
            txtOrderValue.Location = new Point(142, 221);
            txtOrderValue.Name = "txtOrderValue";
            txtOrderValue.Size = new Size(149, 26);
            txtOrderValue.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 224);
            label7.Name = "label7";
            label7.Size = new Size(108, 18);
            label7.TabIndex = 37;
            label7.Text = "Total value: R$";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(148, 21);
            label6.Name = "label6";
            label6.Size = new Size(237, 29);
            label6.TabIndex = 36;
            label6.Text = "New Order Creation";
            // 
            // dtCreationD
            // 
            dtCreationD.Enabled = false;
            dtCreationD.Format = DateTimePickerFormat.Short;
            dtCreationD.Location = new Point(142, 338);
            dtCreationD.Name = "dtCreationD";
            dtCreationD.Size = new Size(104, 26);
            dtCreationD.TabIndex = 35;
            dtCreationD.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 344);
            label5.Name = "label5";
            label5.Size = new Size(110, 18);
            label5.TabIndex = 33;
            label5.Text = "Creation Date:";
            label5.Visible = false;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.AutoSize = true;
            btnCreateOrder.FlatStyle = FlatStyle.Flat;
            btnCreateOrder.Location = new Point(32, 286);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new Size(147, 30);
            btnCreateOrder.TabIndex = 44;
            btnCreateOrder.Text = "Create New Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnCheckOrder
            // 
            btnCheckOrder.AutoSize = true;
            btnCheckOrder.BackColor = Color.Transparent;
            btnCheckOrder.FlatAppearance.BorderColor = SystemColors.Control;
            btnCheckOrder.FlatAppearance.BorderSize = 0;
            btnCheckOrder.FlatStyle = FlatStyle.Flat;
            btnCheckOrder.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckOrder.Location = new Point(-3, 72);
            btnCheckOrder.Name = "btnCheckOrder";
            btnCheckOrder.Size = new Size(152, 29);
            btnCheckOrder.TabIndex = 33;
            btnCheckOrder.Text = "Check Orders";
            btnCheckOrder.UseVisualStyleBackColor = false;
            btnCheckOrder.Click += btnCheckOrder_Click;
            // 
            // pnlCheckOrder
            // 
            pnlCheckOrder.BackColor = SystemColors.Control;
            pnlCheckOrder.BorderStyle = BorderStyle.FixedSingle;
            pnlCheckOrder.Controls.Add(btnBackOrders);
            pnlCheckOrder.Controls.Add(label10);
            pnlCheckOrder.Controls.Add(btnCheckDrivers);
            pnlCheckOrder.Controls.Add(btnDeleteOrder);
            pnlCheckOrder.Controls.Add(btnEditOrder);
            pnlCheckOrder.Controls.Add(dtgOrders);
            pnlCheckOrder.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pnlCheckOrder.Location = new Point(149, -7);
            pnlCheckOrder.Name = "pnlCheckOrder";
            pnlCheckOrder.Size = new Size(560, 390);
            pnlCheckOrder.TabIndex = 34;
            pnlCheckOrder.Visible = false;
            // 
            // btnBackOrders
            // 
            btnBackOrders.AutoSize = true;
            btnBackOrders.BackColor = SystemColors.Control;
            btnBackOrders.FlatAppearance.BorderColor = Color.Black;
            btnBackOrders.FlatStyle = FlatStyle.Flat;
            btnBackOrders.Location = new Point(316, 21);
            btnBackOrders.Name = "btnBackOrders";
            btnBackOrders.Size = new Size(65, 30);
            btnBackOrders.TabIndex = 40;
            btnBackOrders.Text = "Back";
            btnBackOrders.UseVisualStyleBackColor = false;
            btnBackOrders.Visible = false;
            btnBackOrders.Click += btnBackOrders_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 27);
            label10.Name = "label10";
            label10.Size = new Size(291, 18);
            label10.TabIndex = 39;
            label10.Text = "Check delivery drivers for selected order:";
            // 
            // btnCheckDrivers
            // 
            btnCheckDrivers.AutoSize = true;
            btnCheckDrivers.BackColor = Color.LightGray;
            btnCheckDrivers.Enabled = false;
            btnCheckDrivers.FlatAppearance.BorderColor = Color.Black;
            btnCheckDrivers.FlatStyle = FlatStyle.Flat;
            btnCheckDrivers.Location = new Point(316, 21);
            btnCheckDrivers.Name = "btnCheckDrivers";
            btnCheckDrivers.Size = new Size(65, 30);
            btnCheckDrivers.TabIndex = 38;
            btnCheckDrivers.Text = "Check";
            btnCheckDrivers.UseVisualStyleBackColor = false;
            btnCheckDrivers.EnabledChanged += btnCheckDrivers_EnabledChanged;
            btnCheckDrivers.Click += btnCheckDrivers_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.BackColor = Color.LightGray;
            btnDeleteOrder.BackgroundImage = Properties.Resources.delete_Icon;
            btnDeleteOrder.BackgroundImageLayout = ImageLayout.Stretch;
            btnDeleteOrder.Enabled = false;
            btnDeleteOrder.FlatAppearance.BorderColor = Color.Black;
            btnDeleteOrder.FlatStyle = FlatStyle.Flat;
            btnDeleteOrder.Location = new Point(503, 21);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.RightToLeft = RightToLeft.No;
            btnDeleteOrder.Size = new Size(30, 30);
            btnDeleteOrder.TabIndex = 37;
            btnDeleteOrder.UseVisualStyleBackColor = false;
            btnDeleteOrder.EnabledChanged += btnDeleteOrder_EnabledChanged;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.BackColor = Color.LightGray;
            btnEditOrder.BackgroundImage = Properties.Resources.update;
            btnEditOrder.BackgroundImageLayout = ImageLayout.Zoom;
            btnEditOrder.Enabled = false;
            btnEditOrder.FlatAppearance.BorderColor = Color.Black;
            btnEditOrder.FlatStyle = FlatStyle.Flat;
            btnEditOrder.Location = new Point(467, 21);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(30, 30);
            btnEditOrder.TabIndex = 36;
            btnEditOrder.UseVisualStyleBackColor = false;
            btnEditOrder.EnabledChanged += btnEditOrder_EnabledChanged;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // dtgOrders
            // 
            dtgOrders.AllowUserToAddRows = false;
            dtgOrders.AllowUserToResizeColumns = false;
            dtgOrders.AllowUserToResizeRows = false;
            dtgOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgOrders.BackgroundColor = SystemColors.Control;
            dtgOrders.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dtgOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dtgOrders.DefaultCellStyle = dataGridViewCellStyle4;
            dtgOrders.EnableHeadersVisualStyles = false;
            dtgOrders.Location = new Point(19, 63);
            dtgOrders.MultiSelect = false;
            dtgOrders.Name = "dtgOrders";
            dtgOrders.RightToLeft = RightToLeft.No;
            dtgOrders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dtgOrders.RowHeadersVisible = false;
            dtgOrders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgOrders.Size = new Size(514, 310);
            dtgOrders.TabIndex = 35;
            dtgOrders.CellClick += dtgOrders_CellClick;
            dtgOrders.DataBindingComplete += dtgOrders_DataBindingComplete;
            // 
            // form_admin_int
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 381);
            Controls.Add(btnCheckOrder);
            Controls.Add(btnNewOrder);
            Controls.Add(btnLogOut);
            Controls.Add(btnCheckVh);
            Controls.Add(btnNewVh);
            Controls.Add(pnlCheckOrder);
            Controls.Add(pnlNewOrder);
            Controls.Add(pnlNewVh);
            Controls.Add(pnlCheckVh);
            MaximizeBox = false;
            Name = "form_admin_int";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            pnlNewVh.ResumeLayout(false);
            pnlNewVh.PerformLayout();
            pnlCheckVh.ResumeLayout(false);
            pnlCheckVh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgListVh).EndInit();
            pnlNewOrder.ResumeLayout(false);
            pnlNewOrder.PerformLayout();
            pnlCheckOrder.ResumeLayout(false);
            pnlCheckOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgOrders).EndInit();
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
        private Button btnLogOut;
        private Button btnNewOrder;
        private Panel pnlNewOrder;
        private Label label6;
        private DateTimePicker dtCreationD;
        private Label label5;
        private Button btnCreateOrder;
        private TextBox txtOrderValue;
        private Label label7;
        private TextBox txtLabel;
        private Label label8;
        private TextBox txtDesc;
        private Label label9;
        private Button btnCancelOrder;
        private Button btnCheckOrder;
        private Panel pnlCheckOrder;
        private DataGridView dtgOrders;
        private Label label10;
        private Button btnCheckDrivers;
        private Button btnDeleteOrder;
        private Button btnEditOrder;
        private Button btnBackOrders;
    }
}