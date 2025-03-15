namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class LibrarianForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void LibrarianForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ManageBooks()); // تحميل واجهة إدارة الكتب عند فتح الفورم
        }

        private void InitializeComponent()
        {
            tabSignOut = new TabPage();
            tabManageBooks = new TabPage();
            panelContainer = new Panel();
            tabControlLibrarian = new TabControl();
            tabManageBooks.SuspendLayout();
            tabControlLibrarian.SuspendLayout();
            SuspendLayout();
            // 
            // tabSignOut
            // 
            tabSignOut.BackColor = Color.FloralWhite;
            tabSignOut.ForeColor = Color.SaddleBrown;
            tabSignOut.Location = new Point(4, 60);
            tabSignOut.Margin = new Padding(2);
            tabSignOut.Name = "tabSignOut";
            tabSignOut.Size = new Size(903, 412);
            tabSignOut.TabIndex = 2;
            tabSignOut.Text = "LogOut";
            tabSignOut.Click += tabSignOut_Click;
            // 
            // tabManageBooks
            // 
            tabManageBooks.BackColor = Color.FloralWhite;
            tabManageBooks.Controls.Add(panelContainer);
            tabManageBooks.ForeColor = Color.SaddleBrown;
            tabManageBooks.Location = new Point(4, 60);
            tabManageBooks.Margin = new Padding(2);
            tabManageBooks.Name = "tabManageBooks";
            tabManageBooks.Padding = new Padding(2);
            tabManageBooks.Size = new Size(903, 412);
            tabManageBooks.TabIndex = 0;
            tabManageBooks.Text = "Manage Books";
            tabManageBooks.Click += tabManageBooks_Click;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(2, 2);
            panelContainer.Margin = new Padding(2);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(899, 408);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint_1;
            // 
            // tabControlLibrarian
            // 
            tabControlLibrarian.Controls.Add(tabManageBooks);
            tabControlLibrarian.Controls.Add(tabSignOut);
            tabControlLibrarian.Dock = DockStyle.Fill;
            tabControlLibrarian.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlLibrarian.Location = new Point(0, 0);
            tabControlLibrarian.Margin = new Padding(2);
            tabControlLibrarian.Name = "tabControlLibrarian";
            tabControlLibrarian.Padding = new Point(20, 16);
            tabControlLibrarian.SelectedIndex = 0;
            tabControlLibrarian.Size = new Size(911, 476);
            tabControlLibrarian.TabIndex = 0;
            tabControlLibrarian.SelectedIndexChanged += tabManageBooks_Click;
            tabControlLibrarian.Click += tabSignOut_Click;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 476);
            Controls.Add(tabControlLibrarian);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "LibrarianForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            tabManageBooks.ResumeLayout(false);
            tabControlLibrarian.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabSignOut;
        private TabPage tabManageBooks;
        private Panel panelContainer;
        private TabControl tabControlLibrarian;

        //private UC_UpdateProfile uC_UpdateProfile1;
    }
}








