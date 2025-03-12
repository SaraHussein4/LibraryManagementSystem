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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(5, 260);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 34);
            button1.TabIndex = 0;
            button1.Text = "browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(92, 224);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 108);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(86, 347);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(101, 33);
            btn_add.TabIndex = 2;
            btn_add.Text = "add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(86, 27);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(110, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(87, 59);
            txtAuthor.Margin = new Padding(3, 2, 3, 2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(110, 23);
            txtAuthor.TabIndex = 4;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(88, 94);
            txtISBN.Margin = new Padding(3, 2, 3, 2);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(110, 23);
            txtISBN.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(88, 127);
            txtCategory.Margin = new Padding(3, 2, 3, 2);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(110, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(89, 190);
            txtPublishedYear.Margin = new Padding(3, 2, 3, 2);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(110, 23);
            txtPublishedYear.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 33);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 9;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 100);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 10;
            label2.Text = "isbN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 11;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 164);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 12;
            label4.Text = "quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 13;
            label5.Text = "Publish year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 63);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 14;
            label6.Text = "Author";
            // 
            // UpdateBookBtn
            // 
            UpdateBookBtn.Location = new Point(202, 347);
            UpdateBookBtn.Name = "UpdateBookBtn";
            UpdateBookBtn.Size = new Size(91, 32);
            UpdateBookBtn.TabIndex = 15;
            UpdateBookBtn.Text = "Update";
            UpdateBookBtn.UseVisualStyleBackColor = true;
            //UpdateBookBtn.Click += UpdateBookBtn_Click;
            // 
            // DeleteBookBtn
            // 
            DeleteBookBtn.Location = new Point(305, 347);
            DeleteBookBtn.Name = "DeleteBookBtn";
            DeleteBookBtn.Size = new Size(91, 32);
            DeleteBookBtn.TabIndex = 16;
            DeleteBookBtn.Text = "Delete";
            DeleteBookBtn.UseVisualStyleBackColor = true;
            //DeleteBookBtn.Click += DeleteBookBtn_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(86, 159);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(113, 23);
            txtQuantity.TabIndex = 17;
            // 
            // Closebtn
            // 
            Closebtn.BackgroundImage = (Image)resources.GetObject("Closebtn.BackgroundImage");
            Closebtn.BackgroundImageLayout = ImageLayout.Zoom;
            Closebtn.Location = new Point(647, 12);
            Closebtn.Name = "Closebtn";
            Closebtn.Size = new Size(41, 36);
            Closebtn.TabIndex = 18;
            Closebtn.UseVisualStyleBackColor = true;
            //Closebtn.Click += Closebtn_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 391);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddBook";
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
    }
}