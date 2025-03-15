namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            SignoutPage = new TabPage();
            SginoutBtn = new Button();
            pictureBox1 = new PictureBox();
            ReportsPage = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ExcelExport = new Button();
            dgv_Report = new DataGridView();
            RequestsPage = new TabPage();
            ReturnSTimePage = new TabPage();
            AllBooksPage = new TabPage();
            StaffPage = new TabPage();
            LibrianDeleteBtn = new Button();
            LibrianUpdateBtn = new Button();
            LibrianAddBtn = new Button();
            dgv_Librian = new DataGridView();
            LibrianPhoneLbl = new Label();
            LibrianEmailLbl = new Label();
            LibrianUserNameLbl = new Label();
            LibrianPasswordLbl = new Label();
            LibrianShipTypeLbl = new Label();
            LibrianRoleLbl = new Label();
            LibrianNameLbl = new Label();
            LibrianUserName_txt = new TextBox();
            LibrianPhone_txt = new TextBox();
            LibrianEmail_txt = new TextBox();
            LibrianPassword_txt = new TextBox();
            LibrianName_txt = new TextBox();
            LibrianRole_cbox = new ComboBox();
            LibrianShipType_cbox = new ComboBox();
            Members = new TabControl();
            MembersPage = new TabPage();
            MemberRolev2Lbl = new Label();
            label6 = new Label();
            MemberPasswordv2Lbl = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            UpdateMemberBtn = new Button();
            DeleteMemberBtn = new Button();
            AddMemberBtn = new Button();
            MemberPhone_txt = new TextBox();
            MemberEmail_txt = new TextBox();
            MemberPassword_txt = new TextBox();
            MemberUserName_txt = new TextBox();
            MemberName_txt = new TextBox();
            MemberShipType_cbox = new ComboBox();
            MemberRole_cbox = new ComboBox();
            MemberEmailLbl = new Label();
            MemberPasswordLbl = new Label();
            MemberUserNameLbl = new Label();
            MemberPhoneLbl = new Label();
            MemberRoleLbl = new Label();
            MemberShipTypeLbl = new Label();
            MemberNameLbl = new Label();
            dataGridView1 = new DataGridView();
            SignoutPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ReportsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Report).BeginInit();
            StaffPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Librian).BeginInit();
            Members.SuspendLayout();
            MembersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SignoutPage
            // 
            SignoutPage.BackColor = Color.White;
            SignoutPage.Controls.Add(SginoutBtn);
            SignoutPage.Controls.Add(pictureBox1);
            SignoutPage.Location = new Point(4, 29);
            SignoutPage.Margin = new Padding(3, 4, 3, 4);
            SignoutPage.Name = "SignoutPage";
            SignoutPage.Size = new Size(907, 563);
            SignoutPage.TabIndex = 9;
            SignoutPage.Text = "Sign out";
            // 
            // SginoutBtn
            // 
            SginoutBtn.BackColor = Color.FromArgb(192, 0, 0);
            SginoutBtn.Font = new Font("Segoe UI", 15F);
            SginoutBtn.ForeColor = Color.White;
            SginoutBtn.Location = new Point(698, 487);
            SginoutBtn.Margin = new Padding(3, 4, 3, 4);
            SginoutBtn.Name = "SginoutBtn";
            SginoutBtn.Size = new Size(192, 61);
            SginoutBtn.TabIndex = 1;
            SginoutBtn.Text = "Sgin out";
            SginoutBtn.UseVisualStyleBackColor = false;
            SginoutBtn.Click += SginoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(10, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(681, 525);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ReportsPage
            // 
            ReportsPage.Controls.Add(button4);
            ReportsPage.Controls.Add(button3);
            ReportsPage.Controls.Add(button2);
            ReportsPage.Controls.Add(button1);
            ReportsPage.Controls.Add(ExcelExport);
            ReportsPage.Controls.Add(dgv_Report);
            ReportsPage.Location = new Point(4, 29);
            ReportsPage.Margin = new Padding(3, 4, 3, 4);
            ReportsPage.Name = "ReportsPage";
            ReportsPage.Size = new Size(907, 563);
            ReportsPage.TabIndex = 7;
            ReportsPage.Text = "Reports";
            ReportsPage.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(600, 23);
            button4.Name = "button4";
            button4.Size = new Size(175, 29);
            button4.TabIndex = 5;
            button4.Text = "View Available Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(295, 23);
            button3.Name = "button3";
            button3.Size = new Size(247, 29);
            button3.TabIndex = 4;
            button3.Text = "View Borrowed Books";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(41, 23);
            button2.Name = "button2";
            button2.Size = new Size(229, 29);
            button2.TabIndex = 3;
            button2.Text = "View Overdue Books ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(277, 77);
            button1.Name = "button1";
            button1.Size = new Size(161, 29);
            button1.TabIndex = 2;
            button1.Text = "Export To PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ExcelExport
            // 
            ExcelExport.Location = new Point(41, 77);
            ExcelExport.Name = "ExcelExport";
            ExcelExport.Size = new Size(161, 29);
            ExcelExport.TabIndex = 1;
            ExcelExport.Text = "Export To Excel";
            ExcelExport.UseVisualStyleBackColor = true;
            ExcelExport.Click += ExcelExport_Click;
            // 
            // dgv_Report
            // 
            dgv_Report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Report.Location = new Point(0, 124);
            dgv_Report.Name = "dgv_Report";
            dgv_Report.RowHeadersWidth = 51;
            dgv_Report.Size = new Size(944, 439);
            dgv_Report.TabIndex = 0;
            // 
            // RequestsPage
            // 
            RequestsPage.Location = new Point(4, 29);
            RequestsPage.Margin = new Padding(3, 4, 3, 4);
            RequestsPage.Name = "RequestsPage";
            RequestsPage.Size = new Size(907, 563);
            RequestsPage.TabIndex = 6;
            RequestsPage.Text = "Requests";
            RequestsPage.UseVisualStyleBackColor = true;
            // 
            // ReturnSTimePage
            // 
            ReturnSTimePage.Location = new Point(4, 29);
            ReturnSTimePage.Margin = new Padding(3, 4, 3, 4);
            ReturnSTimePage.Name = "ReturnSTimePage";
            ReturnSTimePage.Size = new Size(907, 563);
            ReturnSTimePage.TabIndex = 5;
            ReturnSTimePage.Text = "Confirm Return Books";
            ReturnSTimePage.UseVisualStyleBackColor = true;
            // 
            // AllBooksPage
            // 
            AllBooksPage.Location = new Point(4, 29);
            AllBooksPage.Margin = new Padding(3, 4, 3, 4);
            AllBooksPage.Name = "AllBooksPage";
            AllBooksPage.Size = new Size(907, 563);
            AllBooksPage.TabIndex = 2;
            AllBooksPage.Text = "All Books";
            AllBooksPage.UseVisualStyleBackColor = true;
            // 
            // StaffPage
            // 
            StaffPage.Controls.Add(LibrianDeleteBtn);
            StaffPage.Controls.Add(LibrianUpdateBtn);
            StaffPage.Controls.Add(LibrianAddBtn);
            StaffPage.Controls.Add(dgv_Librian);
            StaffPage.Controls.Add(LibrianPhoneLbl);
            StaffPage.Controls.Add(LibrianEmailLbl);
            StaffPage.Controls.Add(LibrianUserNameLbl);
            StaffPage.Controls.Add(LibrianPasswordLbl);
            StaffPage.Controls.Add(LibrianShipTypeLbl);
            StaffPage.Controls.Add(LibrianRoleLbl);
            StaffPage.Controls.Add(LibrianNameLbl);
            StaffPage.Controls.Add(LibrianUserName_txt);
            StaffPage.Controls.Add(LibrianPhone_txt);
            StaffPage.Controls.Add(LibrianEmail_txt);
            StaffPage.Controls.Add(LibrianPassword_txt);
            StaffPage.Controls.Add(LibrianName_txt);
            StaffPage.Controls.Add(LibrianRole_cbox);
            StaffPage.Controls.Add(LibrianShipType_cbox);
            StaffPage.Font = new Font("Segoe UI", 13F);
            StaffPage.Location = new Point(4, 29);
            StaffPage.Margin = new Padding(3, 4, 3, 4);
            StaffPage.Name = "StaffPage";
            StaffPage.Padding = new Padding(3, 4, 3, 4);
            StaffPage.Size = new Size(907, 563);
            StaffPage.TabIndex = 1;
            StaffPage.Text = "Staff";
            StaffPage.UseVisualStyleBackColor = true;
            // 
            // LibrianDeleteBtn
            // 
            LibrianDeleteBtn.Location = new Point(400, 261);
            LibrianDeleteBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianDeleteBtn.Name = "LibrianDeleteBtn";
            LibrianDeleteBtn.Size = new Size(131, 48);
            LibrianDeleteBtn.TabIndex = 18;
            LibrianDeleteBtn.Text = "delete";
            LibrianDeleteBtn.UseVisualStyleBackColor = true;
            LibrianDeleteBtn.Click += LibrianDeleteBtn_Click;
            // 
            // LibrianUpdateBtn
            // 
            LibrianUpdateBtn.Location = new Point(262, 261);
            LibrianUpdateBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianUpdateBtn.Name = "LibrianUpdateBtn";
            LibrianUpdateBtn.Size = new Size(131, 48);
            LibrianUpdateBtn.TabIndex = 17;
            LibrianUpdateBtn.Text = "Update";
            LibrianUpdateBtn.UseVisualStyleBackColor = true;
            LibrianUpdateBtn.Click += LibrianUpdateBtn_Click;
            // 
            // LibrianAddBtn
            // 
            LibrianAddBtn.Location = new Point(112, 261);
            LibrianAddBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianAddBtn.Name = "LibrianAddBtn";
            LibrianAddBtn.Size = new Size(131, 48);
            LibrianAddBtn.TabIndex = 16;
            LibrianAddBtn.Text = "Add";
            LibrianAddBtn.UseVisualStyleBackColor = true;
            LibrianAddBtn.Click += LibrianAddBtn_Click;
            // 
            // dgv_Librian
            // 
            dgv_Librian.BackgroundColor = Color.White;
            dgv_Librian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Librian.GridColor = Color.Gray;
            dgv_Librian.Location = new Point(37, 317);
            dgv_Librian.Margin = new Padding(3, 4, 3, 4);
            dgv_Librian.Name = "dgv_Librian";
            dgv_Librian.RowHeadersWidth = 51;
            dgv_Librian.Size = new Size(840, 231);
            dgv_Librian.TabIndex = 15;
            dgv_Librian.RowHeaderMouseDoubleClick += dgv_Librian_RowHeaderMouseDoubleClick;
            // 
            // LibrianPhoneLbl
            // 
            LibrianPhoneLbl.AutoSize = true;
            LibrianPhoneLbl.Location = new Point(55, 83);
            LibrianPhoneLbl.Name = "LibrianPhoneLbl";
            LibrianPhoneLbl.Size = new Size(74, 30);
            LibrianPhoneLbl.TabIndex = 14;
            LibrianPhoneLbl.Text = "Phone";
            // 
            // LibrianEmailLbl
            // 
            LibrianEmailLbl.AutoSize = true;
            LibrianEmailLbl.Location = new Point(55, 139);
            LibrianEmailLbl.Name = "LibrianEmailLbl";
            LibrianEmailLbl.Size = new Size(64, 30);
            LibrianEmailLbl.TabIndex = 13;
            LibrianEmailLbl.Text = "Email";
            // 
            // LibrianUserNameLbl
            // 
            LibrianUserNameLbl.AutoSize = true;
            LibrianUserNameLbl.Location = new Point(249, 39);
            LibrianUserNameLbl.Name = "LibrianUserNameLbl";
            LibrianUserNameLbl.Size = new Size(121, 30);
            LibrianUserNameLbl.TabIndex = 12;
            LibrianUserNameLbl.Text = "User Name";
            // 
            // LibrianPasswordLbl
            // 
            LibrianPasswordLbl.AutoSize = true;
            LibrianPasswordLbl.Location = new Point(23, 203);
            LibrianPasswordLbl.Name = "LibrianPasswordLbl";
            LibrianPasswordLbl.Size = new Size(103, 30);
            LibrianPasswordLbl.TabIndex = 11;
            LibrianPasswordLbl.Text = "Password";
            // 
            // LibrianShipTypeLbl
            // 
            LibrianShipTypeLbl.AutoSize = true;
            LibrianShipTypeLbl.Location = new Point(262, 109);
            LibrianShipTypeLbl.Name = "LibrianShipTypeLbl";
            LibrianShipTypeLbl.Size = new Size(102, 30);
            LibrianShipTypeLbl.TabIndex = 10;
            LibrianShipTypeLbl.Text = "ShipType";
            // 
            // LibrianRoleLbl
            // 
            LibrianRoleLbl.AutoSize = true;
            LibrianRoleLbl.Location = new Point(290, 163);
            LibrianRoleLbl.Name = "LibrianRoleLbl";
            LibrianRoleLbl.Size = new Size(55, 30);
            LibrianRoleLbl.TabIndex = 9;
            LibrianRoleLbl.Text = "Role";
            // 
            // LibrianNameLbl
            // 
            LibrianNameLbl.AutoSize = true;
            LibrianNameLbl.Location = new Point(55, 31);
            LibrianNameLbl.Name = "LibrianNameLbl";
            LibrianNameLbl.Size = new Size(71, 30);
            LibrianNameLbl.TabIndex = 8;
            LibrianNameLbl.Text = "Name";
            // 
            // LibrianUserName_txt
            // 
            LibrianUserName_txt.Location = new Point(367, 39);
            LibrianUserName_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianUserName_txt.Name = "LibrianUserName_txt";
            LibrianUserName_txt.Size = new Size(138, 36);
            LibrianUserName_txt.TabIndex = 7;
            // 
            // LibrianPhone_txt
            // 
            LibrianPhone_txt.Location = new Point(129, 83);
            LibrianPhone_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianPhone_txt.Name = "LibrianPhone_txt";
            LibrianPhone_txt.Size = new Size(114, 36);
            LibrianPhone_txt.TabIndex = 6;
            // 
            // LibrianEmail_txt
            // 
            LibrianEmail_txt.Location = new Point(129, 135);
            LibrianEmail_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianEmail_txt.Name = "LibrianEmail_txt";
            LibrianEmail_txt.Size = new Size(114, 36);
            LibrianEmail_txt.TabIndex = 5;
            // 
            // LibrianPassword_txt
            // 
            LibrianPassword_txt.Location = new Point(129, 200);
            LibrianPassword_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianPassword_txt.Name = "LibrianPassword_txt";
            LibrianPassword_txt.Size = new Size(114, 36);
            LibrianPassword_txt.TabIndex = 4;
            // 
            // LibrianName_txt
            // 
            LibrianName_txt.Location = new Point(129, 31);
            LibrianName_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianName_txt.Name = "LibrianName_txt";
            LibrianName_txt.Size = new Size(114, 36);
            LibrianName_txt.TabIndex = 2;
            // 
            // LibrianRole_cbox
            // 
            LibrianRole_cbox.FormattingEnabled = true;
            LibrianRole_cbox.Location = new Point(367, 159);
            LibrianRole_cbox.Margin = new Padding(3, 4, 3, 4);
            LibrianRole_cbox.Name = "LibrianRole_cbox";
            LibrianRole_cbox.Size = new Size(138, 38);
            LibrianRole_cbox.TabIndex = 1;
            // 
            // LibrianShipType_cbox
            // 
            LibrianShipType_cbox.FormattingEnabled = true;
            LibrianShipType_cbox.Location = new Point(367, 105);
            LibrianShipType_cbox.Margin = new Padding(3, 4, 3, 4);
            LibrianShipType_cbox.Name = "LibrianShipType_cbox";
            LibrianShipType_cbox.Size = new Size(138, 38);
            LibrianShipType_cbox.TabIndex = 0;
            // 
            // Members
            // 
            Members.AccessibleName = "";
            Members.Controls.Add(MembersPage);
            Members.Controls.Add(StaffPage);
            Members.Controls.Add(AllBooksPage);
            Members.Controls.Add(ReturnSTimePage);
            Members.Controls.Add(RequestsPage);
            Members.Controls.Add(ReportsPage);
            Members.Controls.Add(SignoutPage);
            Members.Location = new Point(-1, 4);
            Members.Margin = new Padding(3, 4, 3, 4);
            Members.Name = "Members";
            Members.SelectedIndex = 0;
            Members.Size = new Size(915, 596);
            Members.TabIndex = 0;
            // 
            // MembersPage
            // 
            MembersPage.Controls.Add(MemberRolev2Lbl);
            MembersPage.Controls.Add(label6);
            MembersPage.Controls.Add(MemberPasswordv2Lbl);
            MembersPage.Controls.Add(label4);
            MembersPage.Controls.Add(label3);
            MembersPage.Controls.Add(label2);
            MembersPage.Controls.Add(label1);
            MembersPage.Controls.Add(UpdateMemberBtn);
            MembersPage.Controls.Add(DeleteMemberBtn);
            MembersPage.Controls.Add(AddMemberBtn);
            MembersPage.Controls.Add(MemberPhone_txt);
            MembersPage.Controls.Add(MemberEmail_txt);
            MembersPage.Controls.Add(MemberPassword_txt);
            MembersPage.Controls.Add(MemberUserName_txt);
            MembersPage.Controls.Add(MemberName_txt);
            MembersPage.Controls.Add(MemberShipType_cbox);
            MembersPage.Controls.Add(MemberRole_cbox);
            MembersPage.Controls.Add(MemberEmailLbl);
            MembersPage.Controls.Add(MemberPasswordLbl);
            MembersPage.Controls.Add(MemberUserNameLbl);
            MembersPage.Controls.Add(MemberPhoneLbl);
            MembersPage.Controls.Add(MemberRoleLbl);
            MembersPage.Controls.Add(MemberShipTypeLbl);
            MembersPage.Controls.Add(MemberNameLbl);
            MembersPage.Controls.Add(dataGridView1);
            MembersPage.Font = new Font("Segoe UI", 11F);
            MembersPage.Location = new Point(4, 29);
            MembersPage.Margin = new Padding(3, 4, 3, 4);
            MembersPage.Name = "MembersPage";
            MembersPage.Padding = new Padding(3, 4, 3, 4);
            MembersPage.Size = new Size(907, 563);
            MembersPage.TabIndex = 0;
            MembersPage.Text = "Members";
            MembersPage.UseVisualStyleBackColor = true;
            // 
            // MemberRolev2Lbl
            // 
            MemberRolev2Lbl.AutoSize = true;
            MemberRolev2Lbl.Location = new Point(264, 92);
            MemberRolev2Lbl.Name = "MemberRolev2Lbl";
            MemberRolev2Lbl.Size = new Size(48, 25);
            MemberRolev2Lbl.TabIndex = 24;
            MemberRolev2Lbl.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(234, 39);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 23;
            label6.Text = "Ship Type";
            // 
            // MemberPasswordv2Lbl
            // 
            MemberPasswordv2Lbl.AutoSize = true;
            MemberPasswordv2Lbl.Location = new Point(10, 224);
            MemberPasswordv2Lbl.Name = "MemberPasswordv2Lbl";
            MemberPasswordv2Lbl.Size = new Size(91, 25);
            MemberPasswordv2Lbl.TabIndex = 22;
            MemberPasswordv2Lbl.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 176);
            label4.Name = "label4";
            label4.Size = new Size(105, 25);
            label4.TabIndex = 21;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 131);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 87);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 19;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 37);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.Location = new Point(365, 271);
            UpdateMemberBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(86, 39);
            UpdateMemberBtn.TabIndex = 17;
            UpdateMemberBtn.Text = "Update";
            UpdateMemberBtn.UseVisualStyleBackColor = true;
            UpdateMemberBtn.Click += UpdateMemberBtn_Click;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.Location = new Point(485, 271);
            DeleteMemberBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(107, 39);
            DeleteMemberBtn.TabIndex = 16;
            DeleteMemberBtn.Text = "Delete";
            DeleteMemberBtn.UseVisualStyleBackColor = true;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(248, 271);
            AddMemberBtn.Margin = new Padding(3, 4, 3, 4);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(86, 39);
            AddMemberBtn.TabIndex = 15;
            AddMemberBtn.Text = "Add";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // MemberPhone_txt
            // 
            MemberPhone_txt.Location = new Point(105, 77);
            MemberPhone_txt.Margin = new Padding(3, 4, 3, 4);
            MemberPhone_txt.Name = "MemberPhone_txt";
            MemberPhone_txt.Size = new Size(114, 32);
            MemberPhone_txt.TabIndex = 14;
            // 
            // MemberEmail_txt
            // 
            MemberEmail_txt.Location = new Point(105, 121);
            MemberEmail_txt.Margin = new Padding(3, 4, 3, 4);
            MemberEmail_txt.Name = "MemberEmail_txt";
            MemberEmail_txt.Size = new Size(114, 32);
            MemberEmail_txt.TabIndex = 13;
            // 
            // MemberPassword_txt
            // 
            MemberPassword_txt.Location = new Point(105, 224);
            MemberPassword_txt.Margin = new Padding(3, 4, 3, 4);
            MemberPassword_txt.Name = "MemberPassword_txt";
            MemberPassword_txt.Size = new Size(114, 32);
            MemberPassword_txt.TabIndex = 12;
            // 
            // MemberUserName_txt
            // 
            MemberUserName_txt.Location = new Point(105, 172);
            MemberUserName_txt.Margin = new Padding(3, 4, 3, 4);
            MemberUserName_txt.Name = "MemberUserName_txt";
            MemberUserName_txt.Size = new Size(114, 32);
            MemberUserName_txt.TabIndex = 11;
            // 
            // MemberName_txt
            // 
            MemberName_txt.Location = new Point(105, 29);
            MemberName_txt.Margin = new Padding(3, 4, 3, 4);
            MemberName_txt.Name = "MemberName_txt";
            MemberName_txt.Size = new Size(114, 32);
            MemberName_txt.TabIndex = 10;
            // 
            // MemberShipType_cbox
            // 
            MemberShipType_cbox.FormattingEnabled = true;
            MemberShipType_cbox.Location = new Point(326, 33);
            MemberShipType_cbox.Margin = new Padding(3, 4, 3, 4);
            MemberShipType_cbox.Name = "MemberShipType_cbox";
            MemberShipType_cbox.Size = new Size(138, 33);
            MemberShipType_cbox.TabIndex = 9;
            // 
            // MemberRole_cbox
            // 
            MemberRole_cbox.FormattingEnabled = true;
            MemberRole_cbox.Location = new Point(326, 87);
            MemberRole_cbox.Margin = new Padding(3, 4, 3, 4);
            MemberRole_cbox.Name = "MemberRole_cbox";
            MemberRole_cbox.Size = new Size(138, 33);
            MemberRole_cbox.TabIndex = 8;
            // 
            // MemberEmailLbl
            // 
            MemberEmailLbl.AutoSize = true;
            MemberEmailLbl.Location = new Point(31, 125);
            MemberEmailLbl.Name = "MemberEmailLbl";
            MemberEmailLbl.Size = new Size(0, 25);
            MemberEmailLbl.TabIndex = 7;
            // 
            // MemberPasswordLbl
            // 
            MemberPasswordLbl.AutoSize = true;
            MemberPasswordLbl.Location = new Point(18, 233);
            MemberPasswordLbl.Name = "MemberPasswordLbl";
            MemberPasswordLbl.Size = new Size(0, 25);
            MemberPasswordLbl.TabIndex = 6;
            // 
            // MemberUserNameLbl
            // 
            MemberUserNameLbl.AutoSize = true;
            MemberUserNameLbl.Location = new Point(7, 177);
            MemberUserNameLbl.Name = "MemberUserNameLbl";
            MemberUserNameLbl.Size = new Size(0, 25);
            MemberUserNameLbl.TabIndex = 5;
            // 
            // MemberPhoneLbl
            // 
            MemberPhoneLbl.AutoSize = true;
            MemberPhoneLbl.Location = new Point(31, 77);
            MemberPhoneLbl.Name = "MemberPhoneLbl";
            MemberPhoneLbl.Size = new Size(0, 25);
            MemberPhoneLbl.TabIndex = 4;
            // 
            // MemberRoleLbl
            // 
            MemberRoleLbl.AutoSize = true;
            MemberRoleLbl.Location = new Point(248, 92);
            MemberRoleLbl.Name = "MemberRoleLbl";
            MemberRoleLbl.Size = new Size(0, 25);
            MemberRoleLbl.TabIndex = 3;
            // 
            // MemberShipTypeLbl
            // 
            MemberShipTypeLbl.AutoSize = true;
            MemberShipTypeLbl.Location = new Point(235, 33);
            MemberShipTypeLbl.Name = "MemberShipTypeLbl";
            MemberShipTypeLbl.Size = new Size(0, 25);
            MemberShipTypeLbl.TabIndex = 2;
            // 
            // MemberNameLbl
            // 
            MemberNameLbl.AutoSize = true;
            MemberNameLbl.Location = new Point(31, 29);
            MemberNameLbl.Name = "MemberNameLbl";
            MemberNameLbl.Size = new Size(0, 25);
            MemberNameLbl.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(3, 317);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(897, 231);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 638);
            Controls.Add(Members);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            SignoutPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ReportsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Report).EndInit();
            StaffPage.ResumeLayout(false);
            StaffPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Librian).EndInit();
            Members.ResumeLayout(false);
            MembersPage.ResumeLayout(false);
            MembersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage SignoutPage;
        private TabPage ReportsPage;
        private TabPage RequestsPage;
        private TabPage ReturnSTimePage;
        private TabPage AllBooksPage;
        private TabPage StaffPage;
        private Button LibrianDeleteBtn;
        private Button LibrianUpdateBtn;
        private Button LibrianAddBtn;
        private DataGridView dgv_Librian;
        private Label LibrianPhoneLbl;
        private Label LibrianEmailLbl;
        private Label LibrianUserNameLbl;
        private Label LibrianPasswordLbl;
        private Label LibrianShipTypeLbl;
        private Label LibrianRoleLbl;
        private Label LibrianNameLbl;
        private TextBox LibrianUserName_txt;
        private TextBox LibrianPhone_txt;
        private TextBox LibrianEmail_txt;
        private TextBox LibrianPassword_txt;
        private TextBox LibrianName_txt;
        private ComboBox LibrianRole_cbox;
        private ComboBox LibrianShipType_cbox;
        private TabControl Members;
        private TabPage MembersPage;
        private Button UpdateMemberBtn;
        private Button DeleteMemberBtn;
        private Button AddMemberBtn;
        private TextBox MemberPhone_txt;
        private TextBox MemberEmail_txt;
        private TextBox MemberPassword_txt;
        private TextBox MemberUserName_txt;
        private TextBox MemberName_txt;
        private ComboBox MemberShipType_cbox;
        private ComboBox MemberRole_cbox;
        private Label MemberEmailLbl;
        private Label MemberPasswordLbl;
        private Label MemberUserNameLbl;
        private Label MemberPhoneLbl;
        private Label MemberRoleLbl;
        private Label MemberShipTypeLbl;
        private Label MemberNameLbl;
        private DataGridView dataGridView1;
        private Label MemberPasswordv2Lbl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label MemberRolev2Lbl;
        private Label label6;
        private DataGridView dgv_Report;
        private Button ExcelExport;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private PictureBox pictureBox1;
        private Button SginoutBtn;
        //private Button ExportToExcel;
    }
}