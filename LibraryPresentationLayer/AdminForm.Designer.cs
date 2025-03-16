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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            SignoutPage = new TabPage();
            ReportsPage = new TabPage();
            button6 = new Button();
            button5 = new Button();
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
            SignoutPage.BackColor = Color.Tan;
            SignoutPage.Location = new Point(4, 45);
            SignoutPage.Name = "SignoutPage";
            SignoutPage.Size = new Size(907, 547);
            SignoutPage.TabIndex = 9;
            SignoutPage.Text = "Sign out";
            // 
            // ReportsPage
            // 
            ReportsPage.Controls.Add(button6);
            ReportsPage.Controls.Add(button5);
            ReportsPage.Controls.Add(button4);
            ReportsPage.Controls.Add(button3);
            ReportsPage.Controls.Add(button2);
            ReportsPage.Controls.Add(button1);
            ReportsPage.Controls.Add(ExcelExport);
            ReportsPage.Controls.Add(dgv_Report);
            ReportsPage.Location = new Point(4, 45);
            ReportsPage.Margin = new Padding(3, 4, 3, 4);
            ReportsPage.Name = "ReportsPage";
            ReportsPage.Size = new Size(907, 547);
            ReportsPage.TabIndex = 7;
            ReportsPage.Text = "Reports";
            ReportsPage.UseVisualStyleBackColor = true;
            ReportsPage.Click += ReportsPage_Click;
            // 
            // button6
            // 
            button6.Location = new Point(669, 94);
            button6.Name = "button6";
            button6.Size = new Size(8, 8);
            button6.TabIndex = 7;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.Linen;
            button5.Font = new Font("Times New Roman", 12F);
            button5.ForeColor = Color.SaddleBrown;
            button5.Location = new Point(320, 109);
            button5.Name = "button5";
            button5.Padding = new Padding(5);
            button5.Size = new Size(229, 42);
            button5.TabIndex = 6;
            button5.Text = "View History";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Linen;
            button4.Font = new Font("Times New Roman", 12F);
            button4.ForeColor = Color.SaddleBrown;
            button4.Location = new Point(320, 35);
            button4.Name = "button4";
            button4.Padding = new Padding(5);
            button4.Size = new Size(229, 42);
            button4.TabIndex = 5;
            button4.Text = "View Available Book";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Linen;
            button3.Font = new Font("Times New Roman", 12F);
            button3.ForeColor = Color.SaddleBrown;
            button3.Location = new Point(40, 109);
            button3.Name = "button3";
            button3.Padding = new Padding(5);
            button3.Size = new Size(229, 42);
            button3.TabIndex = 4;
            button3.Text = "View Borrowed Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Linen;
            button2.Font = new Font("Times New Roman", 12F);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(40, 35);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(229, 42);
            button2.TabIndex = 3;
            button2.Text = "View Overdue Books ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SaddleBrown;
            button1.ForeColor = Color.MistyRose;
            button1.Location = new Point(683, 100);
            button1.Name = "button1";
            button1.Size = new Size(161, 40);
            button1.TabIndex = 2;
            button1.Text = "Export To PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ExcelExport
            // 
            ExcelExport.BackColor = Color.SaddleBrown;
            ExcelExport.ForeColor = Color.MistyRose;
            ExcelExport.Location = new Point(683, 43);
            ExcelExport.Name = "ExcelExport";
            ExcelExport.Size = new Size(161, 40);
            ExcelExport.TabIndex = 1;
            ExcelExport.Text = "Export To Excel";
            ExcelExport.UseVisualStyleBackColor = false;
            ExcelExport.Click += ExcelExport_Click;
            // 
            // dgv_Report
            // 
            dgv_Report.BackgroundColor = Color.Tan;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Linen;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Report.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Linen;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Report.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Report.GridColor = Color.OldLace;
            dgv_Report.Location = new Point(0, 195);
            dgv_Report.Name = "dgv_Report";
            dgv_Report.RowHeadersWidth = 51;
            dgv_Report.Size = new Size(907, 354);
            dgv_Report.TabIndex = 0;
            dgv_Report.DataBindingComplete += dgv_Report_DataBindingComplete;
            // 
            // RequestsPage
            // 
            RequestsPage.BackColor = Color.FloralWhite;
            RequestsPage.Location = new Point(4, 45);
            RequestsPage.Margin = new Padding(3, 4, 3, 4);
            RequestsPage.Name = "RequestsPage";
            RequestsPage.Size = new Size(907, 547);
            RequestsPage.TabIndex = 6;
            RequestsPage.Text = "Requests";
            // 
            // ReturnSTimePage
            // 
            ReturnSTimePage.BackColor = Color.FloralWhite;
            ReturnSTimePage.Location = new Point(4, 45);
            ReturnSTimePage.Margin = new Padding(3, 4, 3, 4);
            ReturnSTimePage.Name = "ReturnSTimePage";
            ReturnSTimePage.Size = new Size(907, 547);
            ReturnSTimePage.TabIndex = 5;
            ReturnSTimePage.Text = "Confirm Return Books";
            // 
            // AllBooksPage
            // 
            AllBooksPage.BackColor = Color.FloralWhite;
            AllBooksPage.Location = new Point(4, 45);
            AllBooksPage.Margin = new Padding(3, 4, 3, 4);
            AllBooksPage.Name = "AllBooksPage";
            AllBooksPage.Size = new Size(907, 547);
            AllBooksPage.TabIndex = 2;
            AllBooksPage.Text = "All Books";
            // 
            // StaffPage
            // 
            StaffPage.BackColor = Color.FloralWhite;
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
            StaffPage.ForeColor = Color.Sienna;
            StaffPage.Location = new Point(4, 45);
            StaffPage.Margin = new Padding(3, 4, 3, 4);
            StaffPage.Name = "StaffPage";
            StaffPage.Padding = new Padding(3, 4, 3, 4);
            StaffPage.Size = new Size(907, 547);
            StaffPage.TabIndex = 1;
            StaffPage.Text = "Staff";
            // 
            // LibrianDeleteBtn
            // 
            LibrianDeleteBtn.BackColor = Color.OldLace;
            LibrianDeleteBtn.Font = new Font("Times New Roman", 12F);
            LibrianDeleteBtn.Location = new Point(515, 261);
            LibrianDeleteBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianDeleteBtn.Name = "LibrianDeleteBtn";
            LibrianDeleteBtn.Size = new Size(156, 39);
            LibrianDeleteBtn.TabIndex = 18;
            LibrianDeleteBtn.Text = "Delete";
            LibrianDeleteBtn.UseVisualStyleBackColor = false;
            LibrianDeleteBtn.Click += LibrianDeleteBtn_Click;
            // 
            // LibrianUpdateBtn
            // 
            LibrianUpdateBtn.BackColor = Color.OldLace;
            LibrianUpdateBtn.Font = new Font("Times New Roman", 12F);
            LibrianUpdateBtn.Location = new Point(322, 261);
            LibrianUpdateBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianUpdateBtn.Name = "LibrianUpdateBtn";
            LibrianUpdateBtn.Size = new Size(156, 39);
            LibrianUpdateBtn.TabIndex = 17;
            LibrianUpdateBtn.Text = "Update";
            LibrianUpdateBtn.UseVisualStyleBackColor = false;
            LibrianUpdateBtn.Click += LibrianUpdateBtn_Click;
            // 
            // LibrianAddBtn
            // 
            LibrianAddBtn.BackColor = Color.OldLace;
            LibrianAddBtn.Font = new Font("Times New Roman", 12F);
            LibrianAddBtn.Location = new Point(129, 261);
            LibrianAddBtn.Margin = new Padding(3, 4, 3, 4);
            LibrianAddBtn.Name = "LibrianAddBtn";
            LibrianAddBtn.Size = new Size(156, 39);
            LibrianAddBtn.TabIndex = 16;
            LibrianAddBtn.Text = "Add";
            LibrianAddBtn.UseVisualStyleBackColor = false;
            LibrianAddBtn.Click += LibrianAddBtn_Click;
            // 
            // dgv_Librian
            // 
            dgv_Librian.BackgroundColor = Color.Tan;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(20, 25, 70);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Librian.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Librian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Linen;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 13F);
            dataGridViewCellStyle4.ForeColor = Color.Sienna;
            dataGridViewCellStyle4.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle4.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgv_Librian.DefaultCellStyle = dataGridViewCellStyle4;
            dgv_Librian.GridColor = Color.OldLace;
            dgv_Librian.Location = new Point(0, 317);
            dgv_Librian.Margin = new Padding(3, 4, 3, 4);
            dgv_Librian.Name = "dgv_Librian";
            dgv_Librian.RowHeadersWidth = 51;
            dgv_Librian.Size = new Size(907, 231);
            dgv_Librian.TabIndex = 15;
            dgv_Librian.RowHeaderMouseDoubleClick += dgv_Librian_RowHeaderMouseDoubleClick;
            // 
            // LibrianPhoneLbl
            // 
            LibrianPhoneLbl.AutoSize = true;
            LibrianPhoneLbl.Font = new Font("Times New Roman", 12F);
            LibrianPhoneLbl.ForeColor = Color.Sienna;
            LibrianPhoneLbl.Location = new Point(37, 98);
            LibrianPhoneLbl.Name = "LibrianPhoneLbl";
            LibrianPhoneLbl.Size = new Size(58, 22);
            LibrianPhoneLbl.TabIndex = 14;
            LibrianPhoneLbl.Text = "Phone";
            // 
            // LibrianEmailLbl
            // 
            LibrianEmailLbl.AutoSize = true;
            LibrianEmailLbl.Font = new Font("Times New Roman", 12F);
            LibrianEmailLbl.ForeColor = Color.Sienna;
            LibrianEmailLbl.Location = new Point(37, 155);
            LibrianEmailLbl.Name = "LibrianEmailLbl";
            LibrianEmailLbl.Size = new Size(57, 22);
            LibrianEmailLbl.TabIndex = 13;
            LibrianEmailLbl.Text = "Email";
            // 
            // LibrianUserNameLbl
            // 
            LibrianUserNameLbl.AutoSize = true;
            LibrianUserNameLbl.Font = new Font("Times New Roman", 12F);
            LibrianUserNameLbl.ForeColor = Color.Sienna;
            LibrianUserNameLbl.Location = new Point(417, 41);
            LibrianUserNameLbl.Name = "LibrianUserNameLbl";
            LibrianUserNameLbl.Size = new Size(98, 22);
            LibrianUserNameLbl.TabIndex = 12;
            LibrianUserNameLbl.Text = "User Name";
            // 
            // LibrianPasswordLbl
            // 
            LibrianPasswordLbl.AutoSize = true;
            LibrianPasswordLbl.Font = new Font("Times New Roman", 12F);
            LibrianPasswordLbl.ForeColor = Color.Sienna;
            LibrianPasswordLbl.Location = new Point(25, 212);
            LibrianPasswordLbl.Name = "LibrianPasswordLbl";
            LibrianPasswordLbl.Size = new Size(88, 22);
            LibrianPasswordLbl.TabIndex = 11;
            LibrianPasswordLbl.Text = "Password";
            // 
            // LibrianShipTypeLbl
            // 
            LibrianShipTypeLbl.AutoSize = true;
            LibrianShipTypeLbl.Font = new Font("Times New Roman", 12F);
            LibrianShipTypeLbl.ForeColor = Color.Sienna;
            LibrianShipTypeLbl.Location = new Point(417, 94);
            LibrianShipTypeLbl.Name = "LibrianShipTypeLbl";
            LibrianShipTypeLbl.Size = new Size(85, 22);
            LibrianShipTypeLbl.TabIndex = 10;
            LibrianShipTypeLbl.Text = "ShipType";
            // 
            // LibrianRoleLbl
            // 
            LibrianRoleLbl.AutoSize = true;
            LibrianRoleLbl.Font = new Font("Times New Roman", 12F);
            LibrianRoleLbl.ForeColor = Color.Sienna;
            LibrianRoleLbl.Location = new Point(437, 155);
            LibrianRoleLbl.Name = "LibrianRoleLbl";
            LibrianRoleLbl.Size = new Size(48, 22);
            LibrianRoleLbl.TabIndex = 9;
            LibrianRoleLbl.Text = "Role";
            // 
            // LibrianNameLbl
            // 
            LibrianNameLbl.AutoSize = true;
            LibrianNameLbl.Font = new Font("Times New Roman", 12F);
            LibrianNameLbl.ForeColor = Color.Sienna;
            LibrianNameLbl.Location = new Point(37, 41);
            LibrianNameLbl.Name = "LibrianNameLbl";
            LibrianNameLbl.Size = new Size(56, 22);
            LibrianNameLbl.TabIndex = 8;
            LibrianNameLbl.Text = "Name";
            // 
            // LibrianUserName_txt
            // 
            LibrianUserName_txt.Location = new Point(544, 31);
            LibrianUserName_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianUserName_txt.Name = "LibrianUserName_txt";
            LibrianUserName_txt.Size = new Size(200, 36);
            LibrianUserName_txt.TabIndex = 7;
            // 
            // LibrianPhone_txt
            // 
            LibrianPhone_txt.Location = new Point(129, 88);
            LibrianPhone_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianPhone_txt.Name = "LibrianPhone_txt";
            LibrianPhone_txt.Size = new Size(200, 36);
            LibrianPhone_txt.TabIndex = 6;
            // 
            // LibrianEmail_txt
            // 
            LibrianEmail_txt.Location = new Point(129, 145);
            LibrianEmail_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianEmail_txt.Name = "LibrianEmail_txt";
            LibrianEmail_txt.Size = new Size(200, 36);
            LibrianEmail_txt.TabIndex = 5;
            // 
            // LibrianPassword_txt
            // 
            LibrianPassword_txt.Location = new Point(129, 202);
            LibrianPassword_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianPassword_txt.Name = "LibrianPassword_txt";
            LibrianPassword_txt.Size = new Size(200, 36);
            LibrianPassword_txt.TabIndex = 4;
            // 
            // LibrianName_txt
            // 
            LibrianName_txt.Location = new Point(129, 31);
            LibrianName_txt.Margin = new Padding(3, 4, 3, 4);
            LibrianName_txt.Name = "LibrianName_txt";
            LibrianName_txt.Size = new Size(200, 36);
            LibrianName_txt.TabIndex = 2;
            // 
            // LibrianRole_cbox
            // 
            LibrianRole_cbox.FormattingEnabled = true;
            LibrianRole_cbox.Location = new Point(544, 139);
            LibrianRole_cbox.Margin = new Padding(3, 4, 3, 4);
            LibrianRole_cbox.Name = "LibrianRole_cbox";
            LibrianRole_cbox.Size = new Size(200, 38);
            LibrianRole_cbox.TabIndex = 1;
            // 
            // LibrianShipType_cbox
            // 
            LibrianShipType_cbox.FormattingEnabled = true;
            LibrianShipType_cbox.Location = new Point(544, 84);
            LibrianShipType_cbox.Margin = new Padding(3, 4, 3, 4);
            LibrianShipType_cbox.Name = "LibrianShipType_cbox";
            LibrianShipType_cbox.Size = new Size(200, 38);
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
            Members.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Members.Location = new Point(-1, 4);
            Members.Margin = new Padding(3, 4, 3, 4);
            Members.Name = "Members";
            Members.Padding = new Point(15, 10);
            Members.SelectedIndex = 0;
            Members.Size = new Size(915, 596);
            Members.TabIndex = 0;
            Members.SelectedIndexChanged += Members_SelectedIndexChanged_1;
            // 
            // MembersPage
            // 
            MembersPage.BackColor = Color.FloralWhite;
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
            MembersPage.Location = new Point(4, 45);
            MembersPage.Margin = new Padding(3, 4, 3, 4);
            MembersPage.Name = "MembersPage";
            MembersPage.Padding = new Padding(3, 4, 3, 4);
            MembersPage.Size = new Size(907, 547);
            MembersPage.TabIndex = 0;
            MembersPage.Text = "Members";
            // 
            // MemberRolev2Lbl
            // 
            MemberRolev2Lbl.AutoSize = true;
            MemberRolev2Lbl.Font = new Font("Times New Roman", 12F);
            MemberRolev2Lbl.ForeColor = Color.Sienna;
            MemberRolev2Lbl.Location = new Point(427, 150);
            MemberRolev2Lbl.Name = "MemberRolev2Lbl";
            MemberRolev2Lbl.Size = new Size(48, 22);
            MemberRolev2Lbl.TabIndex = 24;
            MemberRolev2Lbl.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.ForeColor = Color.Sienna;
            label6.Location = new Point(413, 90);
            label6.Name = "label6";
            label6.Size = new Size(90, 22);
            label6.TabIndex = 23;
            label6.Text = "Ship Type";
            // 
            // MemberPasswordv2Lbl
            // 
            MemberPasswordv2Lbl.AutoSize = true;
            MemberPasswordv2Lbl.Font = new Font("Times New Roman", 12F);
            MemberPasswordv2Lbl.ForeColor = Color.Sienna;
            MemberPasswordv2Lbl.Location = new Point(24, 211);
            MemberPasswordv2Lbl.Name = "MemberPasswordv2Lbl";
            MemberPasswordv2Lbl.Size = new Size(88, 22);
            MemberPasswordv2Lbl.TabIndex = 22;
            MemberPasswordv2Lbl.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.ForeColor = Color.Sienna;
            label4.Location = new Point(22, 156);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 21;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F);
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(37, 95);
            label3.Name = "label3";
            label3.Size = new Size(57, 22);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(427, 35);
            label2.Name = "label2";
            label2.Size = new Size(58, 22);
            label2.TabIndex = 19;
            label2.Text = "Phone";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(37, 35);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // UpdateMemberBtn
            // 
            UpdateMemberBtn.BackColor = Color.OldLace;
            UpdateMemberBtn.Font = new Font("Times New Roman", 12F);
            UpdateMemberBtn.ForeColor = Color.Sienna;
            UpdateMemberBtn.Location = new Point(351, 260);
            UpdateMemberBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateMemberBtn.Name = "UpdateMemberBtn";
            UpdateMemberBtn.Size = new Size(156, 39);
            UpdateMemberBtn.TabIndex = 17;
            UpdateMemberBtn.Text = "Update";
            UpdateMemberBtn.UseVisualStyleBackColor = false;
            UpdateMemberBtn.Click += UpdateMemberBtn_Click;
            // 
            // DeleteMemberBtn
            // 
            DeleteMemberBtn.BackColor = Color.OldLace;
            DeleteMemberBtn.Font = new Font("Times New Roman", 12F);
            DeleteMemberBtn.ForeColor = Color.Sienna;
            DeleteMemberBtn.Location = new Point(559, 260);
            DeleteMemberBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteMemberBtn.Name = "DeleteMemberBtn";
            DeleteMemberBtn.Size = new Size(156, 39);
            DeleteMemberBtn.TabIndex = 16;
            DeleteMemberBtn.Text = "Delete";
            DeleteMemberBtn.UseVisualStyleBackColor = false;
            DeleteMemberBtn.Click += DeleteMemberBtn_Click;
            // 
            // AddMemberBtn
            // 
            AddMemberBtn.BackColor = Color.OldLace;
            AddMemberBtn.Font = new Font("Times New Roman", 12F);
            AddMemberBtn.ForeColor = Color.Sienna;
            AddMemberBtn.Location = new Point(143, 260);
            AddMemberBtn.Margin = new Padding(3, 4, 3, 4);
            AddMemberBtn.Name = "AddMemberBtn";
            AddMemberBtn.Size = new Size(156, 39);
            AddMemberBtn.TabIndex = 15;
            AddMemberBtn.Text = "Add";
            AddMemberBtn.UseVisualStyleBackColor = false;
            AddMemberBtn.Click += AddMemberBtn_Click;
            // 
            // MemberPhone_txt
            // 
            MemberPhone_txt.Location = new Point(531, 29);
            MemberPhone_txt.Margin = new Padding(3, 4, 3, 4);
            MemberPhone_txt.Name = "MemberPhone_txt";
            MemberPhone_txt.Size = new Size(200, 32);
            MemberPhone_txt.TabIndex = 14;
            // 
            // MemberEmail_txt
            // 
            MemberEmail_txt.Location = new Point(143, 88);
            MemberEmail_txt.Margin = new Padding(3, 4, 3, 4);
            MemberEmail_txt.Name = "MemberEmail_txt";
            MemberEmail_txt.Size = new Size(200, 32);
            MemberEmail_txt.TabIndex = 13;
            // 
            // MemberPassword_txt
            // 
            MemberPassword_txt.Location = new Point(143, 204);
            MemberPassword_txt.Margin = new Padding(3, 4, 3, 4);
            MemberPassword_txt.Name = "MemberPassword_txt";
            MemberPassword_txt.Size = new Size(200, 32);
            MemberPassword_txt.TabIndex = 12;
            // 
            // MemberUserName_txt
            // 
            MemberUserName_txt.Location = new Point(143, 146);
            MemberUserName_txt.Margin = new Padding(3, 4, 3, 4);
            MemberUserName_txt.Name = "MemberUserName_txt";
            MemberUserName_txt.Size = new Size(200, 32);
            MemberUserName_txt.TabIndex = 11;
            // 
            // MemberName_txt
            // 
            MemberName_txt.Location = new Point(143, 30);
            MemberName_txt.Margin = new Padding(3, 4, 3, 4);
            MemberName_txt.Name = "MemberName_txt";
            MemberName_txt.Size = new Size(200, 32);
            MemberName_txt.TabIndex = 10;
            // 
            // MemberShipType_cbox
            // 
            MemberShipType_cbox.FormattingEnabled = true;
            MemberShipType_cbox.Location = new Point(531, 86);
            MemberShipType_cbox.Margin = new Padding(3, 4, 3, 4);
            MemberShipType_cbox.Name = "MemberShipType_cbox";
            MemberShipType_cbox.Size = new Size(200, 33);
            MemberShipType_cbox.TabIndex = 9;
            // 
            // MemberRole_cbox
            // 
            MemberRole_cbox.FormattingEnabled = true;
            MemberRole_cbox.Location = new Point(531, 144);
            MemberRole_cbox.Margin = new Padding(3, 4, 3, 4);
            MemberRole_cbox.Name = "MemberRole_cbox";
            MemberRole_cbox.Size = new Size(200, 33);
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
            dataGridView1.BackgroundColor = Color.Tan;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.Sienna;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = Color.Linen;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.Linen;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle6.ForeColor = Color.Sienna;
            dataGridViewCellStyle6.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle6.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.GridColor = Color.OldLace;
            dataGridView1.Location = new Point(3, 307);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Size = new Size(908, 241);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseDoubleClick += dataGridView1_RowHeaderMouseDoubleClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 595);
            ControlBox = false;
            Controls.Add(Members);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard";
            Load += AdminForm_Load;
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
        private Button button6;
        private Button button5;
        //private Button ExportToExcel;
    }
}