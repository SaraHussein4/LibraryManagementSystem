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
            tabSignOut.Location = new Point(4, 36);
            tabSignOut.Name = "tabSignOut";
            tabSignOut.Size = new Size(1213, 546);
            tabSignOut.TabIndex = 2;
            tabSignOut.Text = "LogOut";
            tabSignOut.Click += tabSignOut_Click;
            // 
            // tabManageBooks
            // 
            tabManageBooks.BackColor = Color.FloralWhite;
            tabManageBooks.Controls.Add(panelContainer);
            tabManageBooks.ForeColor = Color.SaddleBrown;
            tabManageBooks.Location = new Point(4, 36);
            tabManageBooks.Name = "tabManageBooks";
            tabManageBooks.Padding = new Padding(3);
            tabManageBooks.Size = new Size(1213, 546);
            tabManageBooks.TabIndex = 0;
            tabManageBooks.Text = "Manage Books";
            tabManageBooks.Click += tabManageBooks_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(3, 3);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1207, 540);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelContainer_Paint_1;
            // 
            // tabControlLibrarian
            // 
            tabControlLibrarian.Controls.Add(tabManageBooks);
            tabControlLibrarian.Controls.Add(tabSignOut);
            tabControlLibrarian.Dock = DockStyle.Fill;
            tabControlLibrarian.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControlLibrarian.Location = new Point(0, 0);
            tabControlLibrarian.Name = "tabControlLibrarian";
            tabControlLibrarian.Padding = new Point(7, 4);
            tabControlLibrarian.SelectedIndex = 0;
            tabControlLibrarian.Size = new Size(1221, 586);
            tabControlLibrarian.TabIndex = 0;
            tabControlLibrarian.SelectedIndexChanged += tabManageBooks_Click;
            tabControlLibrarian.Click += tabSignOut_Click;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 586);
            Controls.Add(tabControlLibrarian);
            Name = "LibrarianForm";
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








