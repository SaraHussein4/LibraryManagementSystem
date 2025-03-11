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


      

        private void PopulateFieldsFromQR(string qrData)
        {
            try
            {
                string[] bookDetails = qrData.Split('|'); // Assuming QR data is "Title|Author|ISBN|Category|Quantity|Year"

                if (bookDetails.Length == 6)
                {
                    txtTitle.Text = bookDetails[0];
                    txtAuthor.Text = bookDetails[1];
                    txtISBN.Text = bookDetails[2];
                    txtCategory.Text = bookDetails[3];
                    txtQuantity.Text = bookDetails[4];
                    txtPublishedYear.Text = bookDetails[5];
                }
                else
                {
                    MessageBox.Show("Invalid QR format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing QR data: " + ex.Message);
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

        private void btnScanQR_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select QR Code Image";
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pictureBox1.ImageLocation = imagePath;
                DecodeQRCode(imagePath);
            }
        }

        private void DecodeQRCode(string filePath)
        {
            try
            {
                Bitmap bitmap = new Bitmap(filePath);
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);
                if (result != null)
                {
                    string[] bookDetails = result.Text.Split(';');
                    if (bookDetails.Length == 6)
                    {
                        txtTitle.Text = bookDetails[0];
                        txtAuthor.Text = bookDetails[1];
                        txtISBN.Text = bookDetails[2];
                        txtCategory.Text = bookDetails[3];
                        txtQuantity.Text = bookDetails[4];
                        txtPublishedYear.Text = bookDetails[5];
                    }
                    else
                    {
                        MessageBox.Show("Invalid QR Code Format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("QR Code could not be read.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
