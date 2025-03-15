using LibraryManagementSystem.LibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class Member : Form
    {
        private User loggedInUser;
        public Member()
        {
            InitializeComponent();
            if (Login.LoggedInUser != null)
            {
                loggedInUser = Login.LoggedInUser;
            }
            LoadBooks();
            CreateSearchPanel();
        }

        private void CreateSearchPanel()
        {
            Panel searchPanel = new Panel
            {
                Width = flowLayoutPanelBooks.Width,
                Height = 50,
                Dock = DockStyle.Top,

            };

            TextBox txtSearch = new TextBox
            {
                Width = 200,
                Location = new Point(10, 10),
                PlaceholderText = "Search..."
            };
            txtSearch.TextChanged += (sender, e) => LoadBooks(txtSearch.Text);

            searchPanel.Controls.Add(txtSearch);
            flowLayoutPanelBooks.Parent.Controls.Add(searchPanel);
        }

        private void BorrowBook(int bookId)
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("User session expired. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            using (LibraryDBContext context = new LibraryDBContext())
            {


                int borrowedBooksCount = context.BorrowingRecords
                    .Count(b => b.MemberId == loggedInUser.Id && !b.IsReturned && b.Status != "Rejected");

                if (borrowedBooksCount >= 2)
                {
                    MessageBox.Show("You cannot borrow more than 2 books at the same time.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var book = context.Books.FirstOrDefault(b => b.Id == bookId);
                if (book == null || book.Quantity <= 0)
                {
                    MessageBox.Show("This book is currently not available.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var borrowingRecord = new BorrowingRecord
                {
                    MemberId = loggedInUser.Id,
                    BookId = book.Id,
                    BorrowDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(14),
                    IsReturned = false,
                    Status = "Pending"
                };

                context.BorrowingRecords.Add(borrowingRecord);
                book.Quantity -= 1;
                context.SaveChanges();

                var logEntry = new Log
                {
                    ActionType = "Borrow Requested",
                    ActionDate = DateTime.Now,
                    MemberId = loggedInUser.Id,
                    BookId = book.Id
                };

                context.Logs.Add(logEntry);
                context.SaveChanges();

                MessageBox.Show($"You have successfully requested to borrow {book.Title}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
        }




        private void LoadBooks(string searchQuery = "")
        {
            flowLayoutPanelBooks.Controls.Clear();

            using (LibraryDBContext context = new LibraryDBContext())
            {
                var books = context.Books
                    .Where(b => string.IsNullOrEmpty(searchQuery) ||
                                b.Title.Contains(searchQuery) ||
                                b.Category.Contains(searchQuery))
                    .ToList();

                foreach (var book in books)
                {
                    Panel panel = new Panel
                    {
                        Width = 230,
                        Height = 310,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(20, 20, 0, 0)
                    };

                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 210,
                        Height = 220,
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
                        Location = new Point(10, 230),
                        Size = new Size(200, 40),
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = false,
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        Margin = new Padding(0, 5, 0, 0)
                    };

                    Button btnBorrow = new Button
                    {
                        Text = book.Quantity > 0 ? "Borrow" : "Not Available",
                        Location = new Point(10, 270),
                        Width = 210,
                        Height = 30,
                        Enabled = book.Quantity > 0
                    };

                    if (book.Quantity > 0)
                        btnBorrow.Click += (sender, e) => BorrowBook(book.Id);

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(lblTitle);
                    panel.Controls.Add(btnBorrow);
                    flowLayoutPanelBooks.Controls.Add(panel);
                }
            }
        }



        private void LoadBorrowedBooks()
        {
            dgvBorrowedBooks.Rows.Clear();

            if (dgvBorrowedBooks.Columns.Count == 0)
            {
                //dgvBorrowedBooks.Columns.Add("ID", "ID");
                dgvBorrowedBooks.Columns.Add("Title", "Title");
                dgvBorrowedBooks.Columns.Add("BorrowDate", "Borrow Date");
                dgvBorrowedBooks.Columns.Add("DueDate", "Due Date");
                dgvBorrowedBooks.Columns.Add("DaysLeft", "Days Left");
                //dgvBorrowedBooks.Columns.Add("IsReturned", "Returned?");
                dgvBorrowedBooks.Columns.Add("Status", "Status");
            }

            int memberId = loggedInUser.Id;
            bool isDueToday = false;

            using (var context = new LibraryDBContext())
            {
                var borrowedBooks = context.BorrowingRecords
                    .Where(b => b.MemberId == memberId && !b.IsReturned)
                    .Select(b => new
                    {
                        //b.Id,
                        Title = b.Book.Title,
                        BorrowDate = b.BorrowDate,
                        DueDate = b.DueDate,
                        DaysLeft = (b.DueDate - DateTime.Now).Days,
                        //DaysLeft = 0,
                        //IsReturned = b.IsReturned ? "Returned" : "Not Returned",
                        b.Status
                    })
                    .ToList();

                foreach (var book in borrowedBooks)
                {
                    dgvBorrowedBooks.Rows.Add(
                        //book.Id,
                        book.Title,
                        book.BorrowDate.ToShortDateString(),
                        book.DueDate.ToShortDateString(),
                        book.DaysLeft,
                        //book.IsReturned,
                        book.Status
                    );
                    if (book.DaysLeft == 0)
                    {
                        isDueToday = true;
                    }
                }
            }
            label5.Text = isDueToday ? "1" : "0";
        }


        private void LogginOut()
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                loggedInUser = null;

                this.Close();

                Login login = new Login();
                login.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == ViewBooks)
            {
                LoadBooks();
            }
            if (tabControl1.SelectedTab == MyBorrowingBooks)
            {
                LoadBorrowedBooks();
            }
            if (tabControl1.SelectedTab == LogOut)
            {
                LogginOut();
            }

            if (tabControl1.SelectedTab == UpdateProfile)
            {
                LoadUserProfile();
            }

        }


        private void LoadUserProfile()
        {
            if (loggedInUser != null)
            {
                txtUsername.Text = loggedInUser.Username;
                txtName.Text = loggedInUser.Name;
                txtEmail.Text = loggedInUser.Email;
                txtPhone.Text = loggedInUser.Phone;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (loggedInUser != null)
            {
                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!txtPhone.Text.All(char.IsDigit) || txtPhone.Text.Length < 10)
                {
                    MessageBox.Show("Phone number must contain only digits and be at least 10 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                loggedInUser.Username = txtUsername.Text.Trim();
                loggedInUser.Name = txtName.Text.Trim();
                loggedInUser.Email = txtEmail.Text.Trim();
                loggedInUser.Phone = txtPhone.Text.Trim();

                using (var context = new LibraryDBContext())
                {
                    context.Users.Attach(loggedInUser);
                    context.Entry(loggedInUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (label5.Text == "1")
            {
                MessageBox.Show("You Should Return The Book!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label5.Text = "0";
            }

        }

    }
}
