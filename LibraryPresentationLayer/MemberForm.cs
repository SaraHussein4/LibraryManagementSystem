using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class MemberForm : Form
    {
        public MemberForm()
        {
            InitializeComponent();
            viewAvailableBookToolStripMenuItem.Click += viewAvailableBookToolStripMenuItem_Click_1;
        }

     

        private void LoadBooks()
        {
            flowLayoutPanelBooks.Controls.Clear(); 

            using (LibraryDBContext context = new LibraryDBContext())
            {
                var books = context.Books.ToList();

                foreach (var book in books)
                {
                    Panel panel = new Panel
                    {
                        Width = 200,
                        Height = 250,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 180,
                        Height = 120,
                        Location = new Point(10, 10),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    if (book.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream(book.Image))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    Label lblTitle = new Label
                    {
                        Text = book.Title,
                        Location = new Point(10, 140),
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Bold)
                    };

                    Button btnBorrow = new Button
                    {
                        Text = "Borrow",
                        Location = new Point(10, 180),
                        Width = 180
                    };
                    btnBorrow.Click += (sender, e) => BorrowBook(book.Id);

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(lblTitle);
                    panel.Controls.Add(btnBorrow);

                    flowLayoutPanelBooks.Controls.Add(panel);
                }
            }
        }

        private void BorrowBook(int bookId)
        {
            MessageBox.Show($"Borrow request sent for Book ID: {bookId}");
        }

        private void viewAvailableBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}
