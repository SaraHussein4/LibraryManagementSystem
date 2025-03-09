﻿namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class Member
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
            tabControl1 = new TabControl();
            ViewBooks = new TabPage();
            flowLayoutPanelBooks = new FlowLayoutPanel();
            MyBorrowingBooks = new TabPage();
            dgvBorrowedBooks = new DataGridView();
            UpdateProfile = new TabPage();
            LogOut = new TabPage();
            txtUsername = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtEma = new Label();
            label3 = new Label();
            btnSave = new Button();
            tabControl1.SuspendLayout();
            ViewBooks.SuspendLayout();
            MyBorrowingBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            UpdateProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ViewBooks);
            tabControl1.Controls.Add(MyBorrowingBooks);
            tabControl1.Controls.Add(UpdateProfile);
            tabControl1.Controls.Add(LogOut);
            tabControl1.Location = new Point(-1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(802, 448);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ViewBooks
            // 
            ViewBooks.AutoScroll = true;
            ViewBooks.BorderStyle = BorderStyle.FixedSingle;
            ViewBooks.Controls.Add(flowLayoutPanelBooks);
            ViewBooks.Location = new Point(4, 29);
            ViewBooks.Name = "ViewBooks";
            ViewBooks.Padding = new Padding(3);
            ViewBooks.Size = new Size(794, 415);
            ViewBooks.TabIndex = 0;
            ViewBooks.Text = "ViewBooks";
            ViewBooks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelBooks
            // 
            flowLayoutPanelBooks.AutoScroll = true;
            flowLayoutPanelBooks.Dock = DockStyle.Fill;
            flowLayoutPanelBooks.Location = new Point(3, 3);
            flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            flowLayoutPanelBooks.Size = new Size(786, 407);
            flowLayoutPanelBooks.TabIndex = 0;
            // 
            // MyBorrowingBooks
            // 
            MyBorrowingBooks.Controls.Add(dgvBorrowedBooks);
            MyBorrowingBooks.Location = new Point(4, 29);
            MyBorrowingBooks.Name = "MyBorrowingBooks";
            MyBorrowingBooks.Padding = new Padding(3);
            MyBorrowingBooks.Size = new Size(794, 415);
            MyBorrowingBooks.TabIndex = 1;
            MyBorrowingBooks.Text = "MyBorrowingBooks";
            MyBorrowingBooks.UseVisualStyleBackColor = true;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Dock = DockStyle.Fill;
            dgvBorrowedBooks.Location = new Point(3, 3);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.ReadOnly = true;
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.Size = new Size(788, 409);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // UpdateProfile
            // 
            UpdateProfile.Controls.Add(btnSave);
            UpdateProfile.Controls.Add(label3);
            UpdateProfile.Controls.Add(txtEma);
            UpdateProfile.Controls.Add(label2);
            UpdateProfile.Controls.Add(label1);
            UpdateProfile.Controls.Add(pictureBox1);
            UpdateProfile.Controls.Add(txtPhone);
            UpdateProfile.Controls.Add(txtEmail);
            UpdateProfile.Controls.Add(txtName);
            UpdateProfile.Controls.Add(txtUsername);
            UpdateProfile.ForeColor = Color.Tan;
            UpdateProfile.Location = new Point(4, 29);
            UpdateProfile.Name = "UpdateProfile";
            UpdateProfile.Padding = new Padding(3);
            UpdateProfile.Size = new Size(794, 415);
            UpdateProfile.TabIndex = 2;
            UpdateProfile.Text = "UpdateProfile";
            UpdateProfile.UseVisualStyleBackColor = true;
            // 
            // LogOut
            // 
            LogOut.Location = new Point(4, 29);
            LogOut.Name = "LogOut";
            LogOut.Padding = new Padding(3);
            LogOut.Size = new Size(794, 415);
            LogOut.TabIndex = 3;
            LogOut.Text = "LogOut";
            LogOut.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(138, 43);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 27);
            txtUsername.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 102);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(139, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(135, 227);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(222, 27);
            txtPhone.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources._0b54e106ca533b44d972e4f1cf52fb0c_removebg_preview__1_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(401, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 412);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 10.8F);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(23, 43);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 10.8F);
            label2.ForeColor = Color.Tan;
            label2.Location = new Point(23, 106);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // txtEma
            // 
            txtEma.AutoSize = true;
            txtEma.Font = new Font("Rockwell", 10.8F);
            txtEma.ForeColor = Color.Tan;
            txtEma.Location = new Point(23, 169);
            txtEma.Name = "txtEma";
            txtEma.Size = new Size(56, 20);
            txtEma.TabIndex = 7;
            txtEma.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 10.8F);
            label3.ForeColor = Color.Tan;
            label3.Location = new Point(23, 232);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 305);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Member";
            Text = "Member";
            tabControl1.ResumeLayout(false);
            ViewBooks.ResumeLayout(false);
            MyBorrowingBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            UpdateProfile.ResumeLayout(false);
            UpdateProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ViewBooks;
        private TabPage MyBorrowingBooks;
        private TabPage UpdateProfile;
        private TabPage LogOut;
        private FlowLayoutPanel flowLayoutPanelBooks;
        private DataGridView dgvBorrowedBooks;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtUsername;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label txtEma;
        private Button btnSave;
        private Label label3;
    }
}