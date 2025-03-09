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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            SignoutPage = new TabPage();
            EditProfilePage = new TabPage();
            ReportsPage = new TabPage();
            RequestsPage = new TabPage();
            ReturnSTimePage = new TabPage();
            BorrowsBookPage = new TabPage();
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
            StaffPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Librian).BeginInit();
            Members.SuspendLayout();
            MembersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SignoutPage
            // 
            SignoutPage.Location = new Point(4, 24);
            SignoutPage.Name = "SignoutPage";
            SignoutPage.Size = new Size(793, 419);
            SignoutPage.TabIndex = 9;
            SignoutPage.Text = "Sign out";
            SignoutPage.UseVisualStyleBackColor = true;
            // 
            // EditProfilePage
            // 
            EditProfilePage.Location = new Point(4, 24);
            EditProfilePage.Name = "EditProfilePage";
            EditProfilePage.Size = new Size(793, 419);
            EditProfilePage.TabIndex = 8;
            EditProfilePage.Text = "Edit Profile";
            EditProfilePage.UseVisualStyleBackColor = true;
            // 
            // ReportsPage
            // 
            ReportsPage.Location = new Point(4, 24);
            ReportsPage.Name = "ReportsPage";
            ReportsPage.Size = new Size(793, 419);
            ReportsPage.TabIndex = 7;
            ReportsPage.Text = "Reports";
            ReportsPage.UseVisualStyleBackColor = true;
            // 
            // RequestsPage
            // 
            RequestsPage.Location = new Point(4, 24);
            RequestsPage.Name = "RequestsPage";
            RequestsPage.Size = new Size(793, 419);
            RequestsPage.TabIndex = 6;
            RequestsPage.Text = "Requests";
            RequestsPage.UseVisualStyleBackColor = true;
            // 
            // ReturnSTimePage
            // 
            ReturnSTimePage.Location = new Point(4, 24);
            ReturnSTimePage.Name = "ReturnSTimePage";
            ReturnSTimePage.Size = new Size(793, 419);
            ReturnSTimePage.TabIndex = 5;
            ReturnSTimePage.Text = "Confirm Return Books";
            ReturnSTimePage.UseVisualStyleBackColor = true;
            // 
            // BorrowsBookPage
            // 
            BorrowsBookPage.Location = new Point(4, 24);
            BorrowsBookPage.Name = "BorrowsBookPage";
            BorrowsBookPage.Size = new Size(793, 419);
            BorrowsBookPage.TabIndex = 3;
            BorrowsBookPage.Text = "Borrows Book";
            BorrowsBookPage.UseVisualStyleBackColor = true;
            // 
            // AllBooksPage
            // 
            AllBooksPage.Location = new Point(4, 24);
            AllBooksPage.Name = "AllBooksPage";
            AllBooksPage.Size = new Size(793, 419);
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
            StaffPage.Location = new Point(4, 24);
            StaffPage.Name = "StaffPage";
            StaffPage.Padding = new Padding(3);
            StaffPage.Size = new Size(793, 419);
            StaffPage.TabIndex = 1;
            StaffPage.Text = "Staff";
            StaffPage.UseVisualStyleBackColor = true;
            // 
            // LibrianDeleteBtn
            // 
            LibrianDeleteBtn.Location = new Point(350, 196);
            LibrianDeleteBtn.Name = "LibrianDeleteBtn";
            LibrianDeleteBtn.Size = new Size(115, 36);
            LibrianDeleteBtn.TabIndex = 18;
            LibrianDeleteBtn.Text = "delete";
            LibrianDeleteBtn.UseVisualStyleBackColor = true;
            LibrianDeleteBtn.Click += LibrianDeleteBtn_Click;
            // 
            // LibrianUpdateBtn
            // 
            LibrianUpdateBtn.Location = new Point(229, 196);
            LibrianUpdateBtn.Name = "LibrianUpdateBtn";
            LibrianUpdateBtn.Size = new Size(115, 36);
            LibrianUpdateBtn.TabIndex = 17;
            LibrianUpdateBtn.Text = "Update";
            LibrianUpdateBtn.UseVisualStyleBackColor = true;
            LibrianUpdateBtn.Click += LibrianUpdateBtn_Click;
            // 
            // LibrianAddBtn
            // 
            LibrianAddBtn.Location = new Point(98, 196);
            LibrianAddBtn.Name = "LibrianAddBtn";
            LibrianAddBtn.Size = new Size(115, 36);
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
            dgv_Librian.Location = new Point(32, 238);
            dgv_Librian.Name = "dgv_Librian";
            dgv_Librian.Size = new Size(735, 173);
            dgv_Librian.TabIndex = 15;
            dgv_Librian.RowHeaderMouseDoubleClick += dgv_Librian_RowHeaderMouseDoubleClick;
            // 
            // LibrianPhoneLbl
            // 
            LibrianPhoneLbl.AutoSize = true;
            LibrianPhoneLbl.Location = new Point(48, 62);
            LibrianPhoneLbl.Name = "LibrianPhoneLbl";
            LibrianPhoneLbl.Size = new Size(62, 25);
            LibrianPhoneLbl.TabIndex = 14;
            LibrianPhoneLbl.Text = "Phone";
            // 
            // LibrianEmailLbl
            // 
            LibrianEmailLbl.AutoSize = true;
            LibrianEmailLbl.Location = new Point(48, 104);
            LibrianEmailLbl.Name = "LibrianEmailLbl";
            LibrianEmailLbl.Size = new Size(54, 25);
            LibrianEmailLbl.TabIndex = 13;
            LibrianEmailLbl.Text = "Email";
            // 
            // LibrianUserNameLbl
            // 
            LibrianUserNameLbl.AutoSize = true;
            LibrianUserNameLbl.Location = new Point(218, 29);
            LibrianUserNameLbl.Name = "LibrianUserNameLbl";
            LibrianUserNameLbl.Size = new Size(99, 25);
            LibrianUserNameLbl.TabIndex = 12;
            LibrianUserNameLbl.Text = "User Name";
            // 
            // LibrianPasswordLbl
            // 
            LibrianPasswordLbl.AutoSize = true;
            LibrianPasswordLbl.Location = new Point(20, 152);
            LibrianPasswordLbl.Name = "LibrianPasswordLbl";
            LibrianPasswordLbl.Size = new Size(87, 25);
            LibrianPasswordLbl.TabIndex = 11;
            LibrianPasswordLbl.Text = "Password";
            // 
            // LibrianShipTypeLbl
            // 
            LibrianShipTypeLbl.AutoSize = true;
            LibrianShipTypeLbl.Location = new Point(229, 82);
            LibrianShipTypeLbl.Name = "LibrianShipTypeLbl";
            LibrianShipTypeLbl.Size = new Size(84, 25);
            LibrianShipTypeLbl.TabIndex = 10;
            LibrianShipTypeLbl.Text = "ShipType";
            // 
            // LibrianRoleLbl
            // 
            LibrianRoleLbl.AutoSize = true;
            LibrianRoleLbl.Location = new Point(254, 122);
            LibrianRoleLbl.Name = "LibrianRoleLbl";
            LibrianRoleLbl.Size = new Size(46, 25);
            LibrianRoleLbl.TabIndex = 9;
            LibrianRoleLbl.Text = "Role";
            // 
            // LibrianNameLbl
            // 
            LibrianNameLbl.AutoSize = true;
            LibrianNameLbl.Location = new Point(48, 23);
            LibrianNameLbl.Name = "LibrianNameLbl";
            LibrianNameLbl.Size = new Size(59, 25);
            LibrianNameLbl.TabIndex = 8;
            LibrianNameLbl.Text = "Name";
            // 
            // LibrianUserName_txt
            // 
            LibrianUserName_txt.Location = new Point(321, 29);
            LibrianUserName_txt.Name = "LibrianUserName_txt";
            LibrianUserName_txt.Size = new Size(121, 31);
            LibrianUserName_txt.TabIndex = 7;
            // 
            // LibrianPhone_txt
            // 
            LibrianPhone_txt.Location = new Point(113, 62);
            LibrianPhone_txt.Name = "LibrianPhone_txt";
            LibrianPhone_txt.Size = new Size(100, 31);
            LibrianPhone_txt.TabIndex = 6;
            // 
            // LibrianEmail_txt
            // 
            LibrianEmail_txt.Location = new Point(113, 101);
            LibrianEmail_txt.Name = "LibrianEmail_txt";
            LibrianEmail_txt.Size = new Size(100, 31);
            LibrianEmail_txt.TabIndex = 5;
            // 
            // LibrianPassword_txt
            // 
            LibrianPassword_txt.Location = new Point(113, 150);
            LibrianPassword_txt.Name = "LibrianPassword_txt";
            LibrianPassword_txt.Size = new Size(100, 31);
            LibrianPassword_txt.TabIndex = 4;
            // 
            // LibrianName_txt
            // 
            LibrianName_txt.Location = new Point(113, 23);
            LibrianName_txt.Name = "LibrianName_txt";
            LibrianName_txt.Size = new Size(100, 31);
            LibrianName_txt.TabIndex = 2;
            // 
            // LibrianRole_cbox
            // 
            LibrianRole_cbox.FormattingEnabled = true;
            LibrianRole_cbox.Location = new Point(321, 119);
            LibrianRole_cbox.Name = "LibrianRole_cbox";
            LibrianRole_cbox.Size = new Size(121, 31);
            LibrianRole_cbox.TabIndex = 1;
            // 
            // LibrianShipType_cbox
            // 
            LibrianShipType_cbox.FormattingEnabled = true;
            LibrianShipType_cbox.Location = new Point(321, 79);
            LibrianShipType_cbox.Name = "LibrianShipType_cbox";
            LibrianShipType_cbox.Size = new Size(121, 31);
            LibrianShipType_cbox.TabIndex = 0;
            // 
            // Members
            // 
            Members.AccessibleName = "";
            Members.Controls.Add(MembersPage);
            Members.Controls.Add(StaffPage);
            Members.Controls.Add(AllBooksPage);
            Members.Controls.Add(BorrowsBookPage);
            Members.Controls.Add(ReturnSTimePage);
            Members.Controls.Add(RequestsPage);
            Members.Controls.Add(ReportsPage);
            Members.Controls.Add(EditProfilePage);
            Members.Controls.Add(SignoutPage);
            Members.Location = new Point(-1, 3);
            Members.Name = "Members";
            Members.SelectedIndex = 0;
            Members.Size = new Size(801, 447);
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
            MembersPage.Location = new Point(4, 24);
            MembersPage.Name = "MembersPage";
            MembersPage.Padding = new Padding(3);
            MembersPage.Size = new Size(793, 419);
            MembersPage.TabIndex = 0;
            MembersPage.Text = "Members";
            MembersPage.UseVisualStyleBackColor = true;
            // 
            // MemberRolev2Lbl
            // 
            MemberRolev2Lbl.AutoSize = true;
            MemberRolev2Lbl.Location = new Point(231, 69);
            MemberRolev2Lbl.Name = "MemberRolev2Lbl";
            MemberRolev2Lbl.Size = new Size(39, 20);
            MemberRolev2Lbl.TabIndex = 24;
            MemberRolev2Lbl.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(205, 29);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 23;
            label6.Text = "Ship Type";
            // 
            // MemberPasswordv2Lbl
            // 
            MemberPasswordv2Lbl.AutoSize = true;
            MemberPasswordv2Lbl.Location = new Point(9, 168);
            MemberPasswordv2Lbl.Name = "MemberPasswordv2Lbl";
            MemberPasswordv2Lbl.Size = new Size(70, 20);
            MemberPasswordv2Lbl.TabIndex = 22;
            MemberPasswordv2Lbl.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 132);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 21;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 98);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 19;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 28);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.Location = new Point(319, 203);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(75, 29);
            UpdateMemberBtn.TabIndex = 17;
            UpdateMemberBtn.Text = "Update";
            UpdateMemberBtn.UseVisualStyleBackColor = true;
            UpdateMemberBtn.Click += UpdateMemberBtn_Click;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.Location = new Point(424, 203);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(94, 29);
            DeleteMemberBtn.TabIndex = 16;
            DeleteMemberBtn.Text = "Delete";
            DeleteMemberBtn.UseVisualStyleBackColor = true;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.Location = new Point(217, 203);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(75, 29);
            AddMemberBtn.TabIndex = 15;
            AddMemberBtn.Text = "Add";
            AddMemberBtn.UseVisualStyleBackColor = true;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // MemberPhone_txt
            // 
            MemberPhone_txt.Location = new Point(92, 58);
            MemberPhone_txt.Name = "MemberPhone_txt";
            MemberPhone_txt.Size = new Size(100, 27);
            MemberPhone_txt.TabIndex = 14;
            // 
            // MemberEmail_txt
            // 
            MemberEmail_txt.Location = new Point(92, 91);
            MemberEmail_txt.Name = "MemberEmail_txt";
            MemberEmail_txt.Size = new Size(100, 27);
            MemberEmail_txt.TabIndex = 13;
            // 
            // MemberPassword_txt
            // 
            MemberPassword_txt.Location = new Point(92, 168);
            MemberPassword_txt.Name = "MemberPassword_txt";
            MemberPassword_txt.Size = new Size(100, 27);
            MemberPassword_txt.TabIndex = 12;
            // 
            // MemberUserName_txt
            // 
            MemberUserName_txt.Location = new Point(92, 129);
            MemberUserName_txt.Name = "MemberUserName_txt";
            MemberUserName_txt.Size = new Size(100, 27);
            MemberUserName_txt.TabIndex = 11;
            // 
            // MemberName_txt
            // 
            MemberName_txt.Location = new Point(92, 22);
            MemberName_txt.Name = "MemberName_txt";
            MemberName_txt.Size = new Size(100, 27);
            MemberName_txt.TabIndex = 10;
            // 
            // MemberShipType_cbox
            // 
            MemberShipType_cbox.FormattingEnabled = true;
            MemberShipType_cbox.Location = new Point(285, 25);
            MemberShipType_cbox.Name = "MemberShipType_cbox";
            MemberShipType_cbox.Size = new Size(121, 28);
            MemberShipType_cbox.TabIndex = 9;
            // 
            // MemberRole_cbox
            // 
            MemberRole_cbox.FormattingEnabled = true;
            MemberRole_cbox.Location = new Point(285, 65);
            MemberRole_cbox.Name = "MemberRole_cbox";
            MemberRole_cbox.Size = new Size(121, 28);
            MemberRole_cbox.TabIndex = 8;
            // 
            // MemberEmailLbl
            // 
            MemberEmailLbl.AutoSize = true;
            MemberEmailLbl.Location = new Point(27, 94);
            MemberEmailLbl.Name = "MemberEmailLbl";
            MemberEmailLbl.Size = new Size(0, 20);
            MemberEmailLbl.TabIndex = 7;
            // 
            // MemberPasswordLbl
            // 
            MemberPasswordLbl.AutoSize = true;
            MemberPasswordLbl.Location = new Point(16, 175);
            MemberPasswordLbl.Name = "MemberPasswordLbl";
            MemberPasswordLbl.Size = new Size(0, 20);
            MemberPasswordLbl.TabIndex = 6;
            // 
            // MemberUserNameLbl
            // 
            MemberUserNameLbl.AutoSize = true;
            MemberUserNameLbl.Location = new Point(6, 133);
            MemberUserNameLbl.Name = "MemberUserNameLbl";
            MemberUserNameLbl.Size = new Size(0, 20);
            MemberUserNameLbl.TabIndex = 5;
            // 
            // MemberPhoneLbl
            // 
            MemberPhoneLbl.AutoSize = true;
            MemberPhoneLbl.Location = new Point(27, 58);
            MemberPhoneLbl.Name = "MemberPhoneLbl";
            MemberPhoneLbl.Size = new Size(0, 20);
            MemberPhoneLbl.TabIndex = 4;
            // 
            // MemberRoleLbl
            // 
            MemberRoleLbl.AutoSize = true;
            MemberRoleLbl.Location = new Point(217, 69);
            MemberRoleLbl.Name = "MemberRoleLbl";
            MemberRoleLbl.Size = new Size(0, 20);
            MemberRoleLbl.TabIndex = 3;
            // 
            // MemberShipTypeLbl
            // 
            MemberShipTypeLbl.AutoSize = true;
            MemberShipTypeLbl.Location = new Point(206, 25);
            MemberShipTypeLbl.Name = "MemberShipTypeLbl";
            MemberShipTypeLbl.Size = new Size(0, 20);
            MemberShipTypeLbl.TabIndex = 2;
            // 
            // MemberNameLbl
            // 
            MemberNameLbl.AutoSize = true;
            MemberNameLbl.Location = new Point(27, 22);
            MemberNameLbl.Name = "MemberNameLbl";
            MemberNameLbl.Size = new Size(0, 20);
            MemberNameLbl.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(3, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(785, 173);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 450);
            Controls.Add(Members);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
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
        private TabPage EditProfilePage;
        private TabPage ReportsPage;
        private TabPage RequestsPage;
        private TabPage ReturnSTimePage;
        private TabPage BorrowsBookPage;
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
    }
}