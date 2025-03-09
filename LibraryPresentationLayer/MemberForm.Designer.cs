namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class MemberForm
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
            menuStrip1 = new MenuStrip();
            viewAvailableBookToolStripMenuItem = new ToolStripMenuItem();
            borrowBookToolStripMenuItem = new ToolStripMenuItem();
            updateProfileToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            flowLayoutPanelBooks = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { viewAvailableBookToolStripMenuItem, borrowBookToolStripMenuItem, updateProfileToolStripMenuItem, logOutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // viewAvailableBookToolStripMenuItem
            // 
            viewAvailableBookToolStripMenuItem.Name = "viewAvailableBookToolStripMenuItem";
            viewAvailableBookToolStripMenuItem.Size = new Size(159, 24);
            viewAvailableBookToolStripMenuItem.Text = "View Available Book";
            viewAvailableBookToolStripMenuItem.Click += viewAvailableBookToolStripMenuItem_Click_1;
            // 
            // borrowBookToolStripMenuItem
            // 
            borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            borrowBookToolStripMenuItem.Size = new Size(109, 24);
            borrowBookToolStripMenuItem.Text = "Borrow Book";
            borrowBookToolStripMenuItem.Click += borrowBookToolStripMenuItem_Click;
            // 
            // updateProfileToolStripMenuItem
            // 
            updateProfileToolStripMenuItem.Name = "updateProfileToolStripMenuItem";
            updateProfileToolStripMenuItem.Size = new Size(119, 24);
            updateProfileToolStripMenuItem.Text = "Update Profile";
            updateProfileToolStripMenuItem.Click += updateProfileToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(72, 24);
            logOutToolStripMenuItem.Text = "LogOut";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // flowLayoutPanelBooks
            // 
            flowLayoutPanelBooks.AutoScroll = true;
            flowLayoutPanelBooks.Dock = DockStyle.Fill;
            flowLayoutPanelBooks.Location = new Point(0, 28);
            flowLayoutPanelBooks.Name = "flowLayoutPanelBooks";
            flowLayoutPanelBooks.Size = new Size(800, 422);
            flowLayoutPanelBooks.TabIndex = 1;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanelBooks);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MemberForm";
            Text = "MemberForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem viewAvailableBookToolStripMenuItem;
        private ToolStripMenuItem borrowBookToolStripMenuItem;
        private ToolStripMenuItem updateProfileToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private FlowLayoutPanel flowLayoutPanelBooks;
    }
}