namespace LibraryManagementSystem.LibraryPresentationLayer
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            btn_add = new Button();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtCategory = new TextBox();
            txtPublishedYear = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            UpdateBookBtn = new Button();
            DeleteBookBtn = new Button();
            txtQuantity = new NumericUpDown();
            Closebtn = new Button();
            lblBookImage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.SeaShell;
            button1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Sienna;
            button1.Location = new Point(32, 290);
            button1.Name = "button1";
            button1.Size = new Size(113, 57);
            button1.TabIndex = 0;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(183, 238);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Sienna;
            btn_add.Font = new Font("Times New Roman", 12F);
            btn_add.ForeColor = Color.Linen;
            btn_add.Location = new Point(161, 455);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(151, 44);
            btn_add.TabIndex = 2;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(137, 44);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(227, 27);
            txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(137, 102);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(227, 27);
            txtAuthor.TabIndex = 4;
            txtAuthor.TextChanged += txtAuthor_TextChanged;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(137, 160);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(227, 27);
            txtISBN.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(546, 43);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(227, 27);
            txtCategory.TabIndex = 6;
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(546, 159);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(227, 27);
            txtPublishedYear.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F);
            label1.ForeColor = Color.Sienna;
            label1.Location = new Point(37, 44);
            label1.Name = "label1";
            label1.Size = new Size(53, 26);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F);
            label2.ForeColor = Color.Sienna;
            label2.Location = new Point(32, 160);
            label2.Name = "label2";
            label2.Size = new Size(63, 26);
            label2.TabIndex = 10;
            label2.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F);
            label3.ForeColor = Color.Sienna;
            label3.Location = new Point(404, 44);
            label3.Name = "label3";
            label3.Size = new Size(95, 26);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F);
            label4.ForeColor = Color.Sienna;
            label4.Location = new Point(404, 103);
            label4.Name = "label4";
            label4.Size = new Size(92, 26);
            label4.TabIndex = 12;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F);
            label5.ForeColor = Color.Sienna;
            label5.Location = new Point(404, 160);
            label5.Name = "label5";
            label5.Size = new Size(127, 26);
            label5.TabIndex = 13;
            label5.Text = "Publish year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F);
            label6.ForeColor = Color.Sienna;
            label6.Location = new Point(32, 99);
            label6.Name = "label6";
            label6.Size = new Size(78, 26);
            label6.TabIndex = 14;
            label6.Text = "Author";
            // 
            // UpdateBookBtn
            // 
            UpdateBookBtn.BackColor = Color.Sienna;
            UpdateBookBtn.Font = new Font("Times New Roman", 12F);
            UpdateBookBtn.ForeColor = Color.Linen;
            UpdateBookBtn.Location = new Point(373, 455);
            UpdateBookBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBookBtn.Name = "UpdateBookBtn";
            UpdateBookBtn.Size = new Size(151, 44);
            UpdateBookBtn.TabIndex = 15;
            UpdateBookBtn.Text = "Update";
            UpdateBookBtn.UseVisualStyleBackColor = false;
            UpdateBookBtn.Click += UpdateBookBtn_Click_1;
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.BackColor = Color.Sienna;
            DeleteBookBtn.Font = new Font("Times New Roman", 12F);
            DeleteBookBtn.ForeColor = Color.Linen;
            DeleteBookBtn.Location = new Point(585, 456);
            DeleteBookBtn.Margin = new Padding(3, 4, 3, 4);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(151, 44);
            DeleteBookBtn.TabIndex = 16;
            DeleteBookBtn.Text = "Delete";
            DeleteBookBtn.UseVisualStyleBackColor = false;
            DeleteBookBtn.Click += DeleteBookBtn_Click_1;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(546, 101);
            txtQuantity.Margin = new Padding(3, 4, 3, 4);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(227, 27);
            txtQuantity.TabIndex = 17;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // Closebtn
            // 
            Closebtn.BackgroundImage = (Image)resources.GetObject("Closebtn.BackgroundImage");
            Closebtn.BackgroundImageLayout = ImageLayout.Zoom;
            Closebtn.Location = new Point(864, 13);
            Closebtn.Margin = new Padding(3, 4, 3, 4);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(31, 29);
            Closebtn.TabIndex = 18;
            Closebtn.UseVisualStyleBackColor = true;
            Closebtn.Click += Closebtn_Click_1;
            // 
            // lblBookImage
            // 
            lblBookImage.AutoSize = true;
            lblBookImage.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookImage.ForeColor = Color.SaddleBrown;
            lblBookImage.Location = new Point(200, 403);
            lblBookImage.Margin = new Padding(2, 0, 2, 0);
            lblBookImage.Name = "lblBookImage";
            lblBookImage.Size = new Size(106, 22);
            lblBookImage.TabIndex = 19;
            lblBookImage.Text = "Book Cover";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(907, 547);
            Controls.Add(lblBookImage);
            Controls.Add(Closebtn);
            Controls.Add(txtQuantity);
            Controls.Add(DeleteBookBtn);
            Controls.Add(UpdateBookBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPublishedYear);
            Controls.Add(txtCategory);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(btn_add);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private PictureBox pictureBox1;
        private Button btn_add;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtCategory;
        private TextBox txtPublishedYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button UpdateBookBtn;
        private Button DeleteBookBtn;
        private NumericUpDown txtQuantity;
        private Button Closebtn;
        private Label lblBookImage;
    }
}