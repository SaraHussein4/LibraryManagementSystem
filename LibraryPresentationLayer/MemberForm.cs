using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class MemberForm : Form
    {
        private User loggedInUser;
        private DataGridView dgvBorrowedBooks;
        private DataGridView dgvReturnedBooks;


        public MemberForm()
        {
            InitializeComponent();
            viewAvailableBookToolStripMenuItem.Click += viewAvailableBookToolStripMenuItem_Click_1;
            borrowBookToolStripMenuItem.Click += borrowBookToolStripMenuItem_Click;

            if (Login.LoggedInUser != null)
            {
                loggedInUser = Login.LoggedInUser;
            }
            LoadBooks();
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
            int memberId = loggedInUser.Id;

            using (var context = new LibraryDBContext())
            {
                var borrowedBooks = context.BorrowingRecords
                    .Where(b => b.MemberId == memberId && !b.IsReturned)
                    .Select(b => new
                    {
                        b.Id,
                        Title = b.Book.Title,
                        BorrowDate = b.BorrowDate,
                        DueDate = b.DueDate,
                        DaysLeft = (b.DueDate - DateTime.Now).Days,
                        IsReturned = b.IsReturned,
                        b.Status
                    })
                    .ToList();

                foreach (var book in borrowedBooks)
                {
                    int rowIndex = dgvBorrowedBooks.Rows.Add(
                        book.Id,
                        book.Title,
                        book.BorrowDate.ToShortDateString(),
                        book.DueDate.ToShortDateString(),
                        book.DaysLeft,
                        book.IsReturned ? "Returned" : "Not Returned",
                        book.Status


                    );


                }
            }
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
                    .Count(b => b.MemberId == loggedInUser.Id && !b.IsReturned);

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

                MessageBox.Show($"You have successfully borrowed {book.Title}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks();
            }
        }

        private void viewAvailableBookToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            this.Controls.Clear();

            this.Controls.Add(menuStrip1);

            if (flowLayoutPanelBooks == null)
            {
                flowLayoutPanelBooks = new FlowLayoutPanel
                {
                    Name = "flowLayoutPanelBooks",
                    Size = new Size(800, 422),
                    Location = new Point(40, 90),
                    Margin = new Padding(0, 20, 0, 0),
                    AutoScroll = true
                };
               
            }
            else
            {
                flowLayoutPanelBooks.Controls.Clear(); 
            }

            this.Controls.Add(flowLayoutPanelBooks);

            flowLayoutPanelBooks.Dock = DockStyle.Fill;
            flowLayoutPanelBooks.Padding = new Padding(0, 30, 0, 0); 

            LoadBooks();
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Controls.Add(menuStrip1);

            if (dgvBorrowedBooks == null)
            {
                dgvBorrowedBooks = new DataGridView
                {
                    Name = "dgvBorrowedBooks",
                    Size = new Size(750, 400),
                    Location = new Point(20, 50),
                    ReadOnly = true,
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                    AutoGenerateColumns = false
                };
                dgvBorrowedBooks.Columns.Add("ID", "ID");
                dgvBorrowedBooks.Columns.Add("Title", "Title");
                dgvBorrowedBooks.Columns.Add("Borrow Date", "Borrow Date");
                dgvBorrowedBooks.Columns.Add("Due Date", "Due Date");
                dgvBorrowedBooks.Columns.Add("Days Left", "Days Left");
          
                dgvBorrowedBooks.Columns.Add("Returned ?", "Returned ?");
                dgvBorrowedBooks.Columns.Add("Status", "Status");
            }
            this.Controls.Add(dgvBorrowedBooks);
            LoadBorrowedBooks();

        }
       
    

        private void updateProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loggedInUser == null)
            {
                MessageBox.Show("User session expired. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ProfileUpdateForm profileForm = new ProfileUpdateForm(loggedInUser);
            profileForm.ShowDialog();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
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

      
    }
}
