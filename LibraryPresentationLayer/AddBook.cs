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
using LibraryManagementSystem.LibraryDataAccess.Models;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class AddBook : Form
    {
        private string imagePath = "";
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please Select a photo";
            ofd.Filter = "JPG|*.jpg|PNG|*.png|GIF|*gif";
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

        }
    }
}
