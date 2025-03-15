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
    public partial class AdminRequest : Form
    {
        public AdminRequest()
        {
            InitializeComponent();
            LoadPendingRequests();
            this.dgvRequests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequests_CellClick);

        }

        private void LoadPendingRequests()
        {
            dgvRequests.Rows.Clear();
            dgvRequests.Columns.Clear();

            dgvRequests.Columns.Add("ID", "Request ID");
            dgvRequests.Columns.Add("MemberID", "Member ID");
            dgvRequests.Columns.Add("Title", "Book Title");
            dgvRequests.Columns.Add("RequestDate", "Request Date");

            dgvRequests.Columns.Add(new DataGridViewButtonColumn { Name = "Accept", Text = "Accept", UseColumnTextForButtonValue = true });
            dgvRequests.Columns.Add(new DataGridViewButtonColumn { Name = "Reject", Text = "Reject", UseColumnTextForButtonValue = true });

            using (var context = new LibraryDBContext())
            {
                var requests = context.BorrowingRecords
                    .Where(r => r.Status == "Pending")
                    .Select(r => new
                    {
                        r.Id,
                        r.MemberId,
                        Title = r.Book.Title,
                        RequestDate = r.BorrowDate
                    }).ToList();

                foreach (var request in requests)
                {
                    dgvRequests.Rows.Add(request.Id, request.MemberId, request.Title, request.RequestDate);
                }
            }
        }

        private void dgvRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int requestId = Convert.ToInt32(dgvRequests.Rows[e.RowIndex].Cells["ID"].Value);

                using (var context = new LibraryDBContext())
                {
                    var request = context.BorrowingRecords.FirstOrDefault(r => r.Id == requestId);
                    if (request != null)
                    {
                        if (e.ColumnIndex == dgvRequests.Columns["Accept"].Index)
                        {
                            request.Status = "Approved";
                            request.DueDate = DateTime.Now.AddDays(14);

                            var book = context.Books.FirstOrDefault(b => b.Id == request.BookId);
                            if (book != null && book.Quantity > 0)
                            {
                                book.Quantity -= 1;
                                MessageBox.Show("Request approved.");
                            }
                            else
                            {
                                MessageBox.Show("Not enough copies available.");
                                return;
                            }
                        }
                        else if (e.ColumnIndex == dgvRequests.Columns["Reject"].Index)
                        {
                            request.Status = "Rejected";
                            MessageBox.Show("Request rejected.");
                        }

                        context.SaveChanges();
                        LoadPendingRequests();
                    }
                }
            }
        }

        private void gobackinARequest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            this.Hide();
            AdminForm.ShowDialog();
            this.Close();
        }
    }
}
