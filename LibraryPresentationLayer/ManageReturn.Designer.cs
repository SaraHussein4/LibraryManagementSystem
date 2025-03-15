namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class ManageReturn
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
            dgvBorrowedBooks = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.BackgroundColor = Color.White;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.Location = new Point(23, 9);
            dgvBorrowedBooks.Margin = new Padding(3, 2, 3, 2);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 51;
            dgvBorrowedBooks.Size = new Size(636, 305);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.CellClick += dgvBorrowedBooks_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(644, 318);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Go back";
            label1.MouseClick += label1_MouseClick;
            // 
            // ManageReturn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(dgvBorrowedBooks);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageReturn";
            Text = "ManageReturn";
            Load += ManageReturn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Label label1;
    }
}