﻿using LibraryManagementSystem.LibraryDataAccess.Models;
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
    public partial class ManageReturn : Form
    {
        public ManageReturn()
        {
            InitializeComponent();
        }

        private void LoadBorrowedBooks()
        {
            dgvBorrowedBooks.Rows.Clear();
            dgvBorrowedBooks.Columns.Clear();

            dgvBorrowedBooks.Columns.Add("ID", "Borrow ID");
            dgvBorrowedBooks.Columns["ID"].Visible = false;
            dgvBorrowedBooks.Columns.Add("MemberName", "Member Name");
            dgvBorrowedBooks.Columns.Add("Title", "Book Title");
            dgvBorrowedBooks.Columns.Add("BorrowDate", "Borrow Date");
            dgvBorrowedBooks.Columns.Add("DueDate", "Due Date");
            dgvBorrowedBooks.Columns.Add("Is Returned ?", "Is Returned ?");

            dgvBorrowedBooks.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "ReturnBook",
                Text = "Mark as Returned",
                UseColumnTextForButtonValue = true
            });

            using (var context = new LibraryDBContext())
            {
                var borrowedBooks = context.BorrowingRecords
                    .Where(r => r.Status == "Approved" && !r.IsReturned)
                    .Select(r => new
                    {
                        r.Id,
                        r.Member.Name,
                        Title = r.Book.Title,
                        r.BorrowDate,
                        r.DueDate,
                        r.IsReturned
                    }).ToList();

                foreach (var book in borrowedBooks)
                {
                    dgvBorrowedBooks.Rows.Add( book.Id,book.Name, book.Title, book.BorrowDate, book.DueDate, book.IsReturned ? "True" : "false");
                }
            }
        }

        private void ManageReturn_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }

        private void dgvBorrowedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBorrowedBooks.Columns["ReturnBook"].Index)
            {
                int borrowId = Convert.ToInt32(dgvBorrowedBooks.Rows[e.RowIndex].Cells["ID"].Value);

                using (var context = new LibraryDBContext())
                {
                    var record = context.BorrowingRecords.FirstOrDefault(r => r.Id == borrowId);
                    if (record != null)
                    {
                        record.IsReturned = true;
                        context.SaveChanges();

                        MessageBox.Show("Book marked as returned successfully.");
                        LoadBorrowedBooks();
                    }
                }
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            AdminForm AdminForm = new AdminForm();
            this.Hide();
            AdminForm.ShowDialog();
            this.Close();
        }

        private void dgvBorrowedBooks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBorrowedBooks.Columns[5].Width = 300;
        }
    }
}
