using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZXing;
using LibraryManagementSystem.LibraryDataAccess.Models;
using ZXing.QrCode;
using ZXing.Windows.Compatibility; 

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class AddBook : Form
    {
        private readonly LibraryDBContext context;
        private string imagePath = "";
        int? BookSid = null;
        public AddBook()
        {
            InitializeComponent();
        }


        public AddBook(int _id)
        {
            this.BookSid = _id;
            InitializeComponent();
            context = new LibraryDBContext();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Select a photo";
            ofd.Filter = "JPG|.jpg|JPEG|.jpeg|PNG|.png|GIF|.gif";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.pictureBox1.ImageLocation = ofd.FileName;
                imagePath = ofd.FileName;
            }
        }


        private byte[] ConvertFileToByte(string sPath)
        {
            byte[] data = null;
            if (!string.IsNullOrEmpty(sPath))
            {
                FileInfo fileInfo = new FileInfo(sPath);
                long numBytes = fileInfo.Length;
                FileStream fileStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fileStream);
                data = br.ReadBytes((int)numBytes);
            }
            return data;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                LibraryDBContext context = new LibraryDBContext();
                Book book = new Book()
                {
                    Title = txtTitle.Text,
                    Author = txtAuthor.Text,
                    ISBN = txtISBN.Text,
                    Category = txtCategory.Text,
                    Quantity = int.Parse(txtQuantity.Text),
                    PublishedYear = int.Parse(txtPublishedYear.Text),
                    Image = ConvertFileToByte(imagePath)
                };
                context.Books.Add(book);
                context.SaveChanges();
                MessageBox.Show("Book added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            if (BookSid.HasValue)
            {
                //  MessageBox.Show("Editing Book ID: " + BookSid.Value);
                btn_add.Visible = false;
                var book = context?.Books?.FirstOrDefault(n => n.Id == BookSid.Value);

                if (book == null)
                {

                }
                else
                {
                    txtTitle.Text = book.Title;
                    txtAuthor.Text = book.Author;
                    txtISBN.Text = book.ISBN;
                    txtCategory.Text = book.Category;
                    txtQuantity.Value = book.Quantity;
                    txtPublishedYear.Text = book.PublishedYear.ToString();
                    if (book.Image != null && book.Image.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(book.Image))
                        {
                            pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.default_book_image;
                    }



                }

            }
            else
            {
                UpdateBookBtn.Visible = false;
                DeleteBookBtn.Visible = false;
            }

        }



        private void UpdateBookBtn_Click_1(object sender, EventArgs e)
        {
            var book = context?.Books?.FirstOrDefault(n => n.Id == BookSid.Value);
            if (book != null)
            {
                book.Title = txtTitle.Text;
                book.Author = txtAuthor.Text;
                book.ISBN = txtISBN.Text;
                book.Category = txtCategory.Text;
                book.Quantity = (int)txtQuantity.Value;
                book.PublishedYear = int.Parse(txtPublishedYear.Text);
                context.SaveChanges();
                MessageBox.Show("Updated Successfully!");
                txtTitle.Text = "";
                txtAuthor.Text = "";
                txtISBN.Text = "";
                txtCategory.Text = "";
                txtQuantity.Text = "";
                txtPublishedYear.Text = "";
                pictureBox1.Image = null;



            }
        }


        private void DeleteBookBtn_Click_1(object sender, EventArgs e)
        {
            var book = context?.Books?.FirstOrDefault(n => n.Id == BookSid.Value);
            if (book != null)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                    MessageBox.Show("Deleted successfully!");

                    txtTitle.Text = "";
                    txtAuthor.Text = "";
                    txtISBN.Text = "";
                    txtCategory.Text = "";
                    txtQuantity.Text = "";
                    txtPublishedYear.Text = "";
                    pictureBox1.Image = null;

                }
            }
        }


        private void Closebtn_Click_1(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            this.Hide();
            adminForm.ShowDialog();
            this.Close();
        }

    }
}
