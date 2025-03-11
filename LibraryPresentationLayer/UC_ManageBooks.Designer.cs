namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class UC_ManageBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBrowseImage = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvBooks = new DataGridView();
            lblTitle = new Label();
            lblAuthor = new Label();
            lblISBN = new Label();
            lblCategory = new Label();
            lblQuantity = new Label();
            pbBookImage = new PictureBox();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtPublishedYear = new TextBox();
            lblBookImage = new Label();
            lblPublishedYear = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).BeginInit();
            SuspendLayout();
            // 
            // btnBrowseImage
            // 
            btnBrowseImage.BackColor = Color.SaddleBrown;
            btnBrowseImage.FlatAppearance.BorderSize = 0;
            btnBrowseImage.FlatStyle = FlatStyle.Flat;
            btnBrowseImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowseImage.ForeColor = Color.FloralWhite;
            btnBrowseImage.Location = new Point(1144, 307);
            btnBrowseImage.Name = "btnBrowseImage";
            btnBrowseImage.Size = new Size(112, 50);
            btnBrowseImage.TabIndex = 0;
            btnBrowseImage.Text = "Browse";
            btnBrowseImage.UseVisualStyleBackColor = false;
            btnBrowseImage.Click += btnBrowseImage_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SaddleBrown;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FloralWhite;
            btnAdd.Location = new Point(522, 307);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 50);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SaddleBrown;
            btnUpdate.FlatAppearance.BorderColor = Color.Salmon;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.FloralWhite;
            btnUpdate.Location = new Point(655, 307);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SaddleBrown;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.FloralWhite;
            btnDelete.Location = new Point(787, 307);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(0, 383);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 62;
            dgvBooks.Size = new Size(1400, 713);
            dgvBooks.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.SaddleBrown;
            lblTitle.Location = new Point(31, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(50, 25);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAuthor.ForeColor = Color.SaddleBrown;
            lblAuthor.Location = new Point(27, 99);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(72, 25);
            lblAuthor.TabIndex = 6;
            lblAuthor.Text = "Author";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = Color.SaddleBrown;
            lblISBN.Location = new Point(27, 150);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(54, 25);
            lblISBN.TabIndex = 7;
            lblISBN.Text = "ISBN";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.SaddleBrown;
            lblCategory.Location = new Point(27, 192);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(90, 25);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.SaddleBrown;
            lblQuantity.Location = new Point(27, 238);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(87, 25);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // pbBookImage
            // 
            pbBookImage.Location = new Point(1118, 68);
            pbBookImage.Name = "pbBookImage";
            pbBookImage.Size = new Size(151, 180);
            pbBookImage.TabIndex = 10;
            pbBookImage.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(187, 49);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(261, 31);
            txtTitle.TabIndex = 11;
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Location = new Point(187, 93);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(261, 31);
            txtAuthor.TabIndex = 12;
            // 
            // txtISBN
            // 
            txtISBN.BorderStyle = BorderStyle.FixedSingle;
            txtISBN.Location = new Point(187, 144);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(261, 31);
            txtISBN.TabIndex = 13;
            // 
            // txtCategory
            // 
            txtCategory.BorderStyle = BorderStyle.FixedSingle;
            txtCategory.Location = new Point(187, 186);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(261, 31);
            txtCategory.TabIndex = 14;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(187, 232);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(261, 31);
            txtQuantity.TabIndex = 15;
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.BorderStyle = BorderStyle.FixedSingle;
            txtPublishedYear.Location = new Point(187, 279);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(261, 31);
            txtPublishedYear.TabIndex = 16;
            // 
            // lblBookImage
            // 
            lblBookImage.AutoSize = true;
            lblBookImage.ForeColor = Color.SaddleBrown;
            lblBookImage.Location = new Point(1144, 263);
            lblBookImage.Name = "lblBookImage";
            lblBookImage.Size = new Size(104, 25);
            lblBookImage.TabIndex = 17;
            lblBookImage.Text = "Book Cover";
            // 
            // lblPublishedYear
            // 
            lblPublishedYear.AutoSize = true;
            lblPublishedYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPublishedYear.ForeColor = Color.SaddleBrown;
            lblPublishedYear.Location = new Point(27, 285);
            lblPublishedYear.Name = "lblPublishedYear";
            lblPublishedYear.Size = new Size(136, 25);
            lblPublishedYear.TabIndex = 18;
            lblPublishedYear.Text = "Published Year";
            // 
            // UC_ManageBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FloralWhite;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(lblPublishedYear);
            Controls.Add(lblBookImage);
            Controls.Add(txtPublishedYear);
            Controls.Add(txtQuantity);
            Controls.Add(txtCategory);
            Controls.Add(txtISBN);
            Controls.Add(pbBookImage);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblISBN);
            Controls.Add(dgvBooks);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnBrowseImage);
            Name = "UC_ManageBooks";
            Size = new Size(1403, 1099);
            Load += UC_ManageBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBookImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBrowseImage;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvBooks;
        private Label lblTitle;
        private Label lblAuthor;
        private Label lblISBN;
        private Label lblCategory;
        private Label lblQuantity;
        private PictureBox pbBookImage;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtPublishedYear;
        private Label lblBookImage;
        private Label lblPublishedYear;
    }
}
