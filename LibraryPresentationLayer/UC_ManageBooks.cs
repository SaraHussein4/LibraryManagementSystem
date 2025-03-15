using System;
using LibraryManagementSystem.LibraryDataAccess.Models;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using LibraryManagementSystem.LibraryDataAccess.Models;
using ZXing.Windows.Compatibility;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class UC_ManageBooks : UserControl
    {
        private string imagePath = "";

        public UC_ManageBooks()
        {
            InitializeComponent();
            this.dgvBooks.CellFormatting += new DataGridViewCellFormattingEventHandler(this.dgvBooks_CellFormatting);
            this.dgvBooks.CellDoubleClick += new DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            this.dgvBooks.MouseClick += new MouseEventHandler(this.dgvBooks_MouseClick);


        }

        private void UC_ManageBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadBooks();
        }


      
        private void LoadBooks()
        {
            using (var context = new LibraryDBContext())
            {
                var books = context.Books.ToList().Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Author,
                    b.ISBN,
                    b.Category,
                    b.Quantity,
                    b.PublishedYear,
                    Image = (b.Image != null) ? ConvertByteToImage(b.Image) : null
                }).ToList();

                dgvBooks.DataSource = books;

                DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)dgvBooks.Columns["Image"];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imageColumn.Width = pbBookImage.Width;
                dgvBooks.RowTemplate.Height = pbBookImage.Height;
            }



        }




        private Image ConvertByteToImage(byte[] imageData)
        {
            if (imageData == null) return null;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return ResizeImage(Image.FromStream(ms), 151, 180);
            }
        }

        private Image ResizeImage(Image img, int width, int height)
        {
            Bitmap bmp = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(img, 0, 0, width, height);
            }
            return bmp;
        }

        private void dgvBooks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBooks.Columns[e.ColumnIndex].Name == "Image" && e.Value is byte[])
            {
                byte[] imageData = (byte[])e.Value;
                e.Value = ConvertByteToImage(imageData);
            }
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select a Book Cover",
                Filter = "Images|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbBookImage.Image = ResizeImage(Image.FromFile(ofd.FileName), 151, 180);
                imagePath = ofd.FileName;
            }
        }

          private void ClearFields()
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtISBN.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtPublishedYear.Text = "";
            pbBookImage.Image = null;
            imagePath = "";
        }




        private byte[] ConvertFileToByte(string path)
        {
            if (string.IsNullOrEmpty(path)) return null;
            return File.ReadAllBytes(path);
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPublishedYear.Text))
            {
                MessageBox.Show("Please fill in all fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _) || !int.TryParse(txtPublishedYear.Text, out _))
            {
                MessageBox.Show("Quantity and Published Year must be numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                using (var context = new LibraryDBContext())
                {
                    Book newBook = new Book
                    {
                        Title = txtTitle.Text,
                        Author = txtAuthor.Text,
                        ISBN = txtISBN.Text,
                        Category = txtCategory.Text,
                        Quantity = int.Parse(txtQuantity.Text),
                        PublishedYear = int.Parse(txtPublishedYear.Text),
                        Image = ConvertFileToByte(imagePath)
                    };

                    context.Books.Add(newBook);
                    context.SaveChanges();
                    MessageBox.Show("Book added successfully!");
                    LoadBooks();
  ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int bookId = Convert.ToInt32(dgvBooks.Rows[e.RowIndex].Cells["Id"].Value);

                using (var context = new LibraryDBContext())
                {
                    var book = context.Books.Find(bookId);
                    if (book != null)
                    {

                        txtTitle.Text = book.Title;
                        txtAuthor.Text = book.Author;
                        txtISBN.Text = book.ISBN;
                        txtCategory.Text = book.Category;
                        txtQuantity.Text = book.Quantity.ToString();
                        txtPublishedYear.Text = book.PublishedYear.ToString();

                        if (book.Image != null && book.Image.Length > 0)
                        {
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(book.Image))
                                {
                                    pbBookImage.Image = ResizeImage(Image.FromStream(ms), 151, 180);
                                }
                            }
                            catch
                            {
                                pbBookImage.Image = null;
                            }
                        }
                        else
                        {
                            pbBookImage.Image = null;
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                if (!ValidateInputs()) return;

                int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["Id"].Value);
                using (var context = new LibraryDBContext())
                {
                    var book = context.Books.Find(bookId);
                    if (book != null)
                    {
                        book.Title = txtTitle.Text;
                        book.Author = txtAuthor.Text;
                        book.ISBN = txtISBN.Text;
                        book.Category = txtCategory.Text;
                        book.Quantity = int.Parse(txtQuantity.Text);
                        book.PublishedYear = int.Parse(txtPublishedYear.Text);


                        if (!string.IsNullOrEmpty(imagePath))
                        {
                            book.Image = ConvertFileToByte(imagePath);
                        }

                        context.SaveChanges();

                        MessageBox.Show("Book updated successfully!");
                        LoadBooks();
 ClearFields();

                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to update.");
            }
        }




        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int bookId = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["Id"].Value);
                using (var context = new LibraryDBContext())
                {
                    var book = context.Books.Find(bookId);
                    if (book != null)
                    {
                        var confirmDelete = MessageBox.Show("Are you sure you want to delete this book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (confirmDelete == DialogResult.Yes)
                        {
                            context.Books.Remove(book);
                            context.SaveChanges();
                            MessageBox.Show("Book deleted successfully!");
                            LoadBooks();
      ClearFields();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select QR Code Image";
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagePath = ofd.FileName;
                pbBookImage.ImageLocation = imagePath;
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
        private void dgvBooks_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvBooks.HitTest(e.X, e.Y).RowIndex == -1)
            {
                ClearFields(); 
            }
        }




    }
}