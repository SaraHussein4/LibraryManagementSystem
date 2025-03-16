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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvBorrowedBooks = new DataGridView();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.BackgroundColor = Color.Linen;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Linen;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle1.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBorrowedBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Linen;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle2.SelectionForeColor = Color.Linen;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBorrowedBooks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBorrowedBooks.Location = new Point(12, 77);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 70;
            dgvBorrowedBooks.Size = new Size(883, 391);
            dgvBorrowedBooks.TabIndex = 0;
            dgvBorrowedBooks.CellClick += dgvBorrowedBooks_CellClick;
            dgvBorrowedBooks.DataBindingComplete += dgvBorrowedBooks_DataBindingComplete;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Tan;
            label1.Location = new Point(813, 495);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(78, 29);
            label1.TabIndex = 1;
            label1.Text = "Go Back";
            label1.MouseClick += label1_MouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poor Richard", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Linen;
            label4.Location = new Point(14, 28);
            label4.Name = "label4";
            label4.Size = new Size(263, 31);
            label4.TabIndex = 3;
            label4.Text = "Handle Returned Books";
            // 
            // ManageReturn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(907, 547);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(dgvBorrowedBooks);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageReturn";
            Load += ManageReturn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBorrowedBooks;
        private Label label1;
        private Label label4;
    }
}