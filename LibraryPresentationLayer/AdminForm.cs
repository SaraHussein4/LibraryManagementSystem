using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class AdminForm : Form
    {
        private readonly LibraryDBContext context;

        public AdminForm()
        {
            InitializeComponent();
            context = new LibraryDBContext();
            GenerateBorrowedBooksReport();
        }
        public void LoadBooks()
        {
            #region books

            AllBooksPage.Controls.Clear();

            FlowLayoutPanel flowPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10)
            };

            Panel panelButton = new Panel
            {
                Width = 600,
                Height = 50,
                BackColor = System.Drawing.Color.White
            };

            Button btnAddBook = new Button
            {
                Text = "Add Books",
                Width = 140,
                Height = 40,
                Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold),
                BackColor = System.Drawing.Color.LightBlue,
                ForeColor = System.Drawing.Color.Black
            };

            btnAddBook.Click += (object sender, EventArgs e) =>
            {
                AddBook addBook = new AddBook();
                this.Hide();
                addBook.ShowDialog();
                this.Close();
            };

            panelButton.Controls.Add(btnAddBook);
            flowPanel.Controls.Add(panelButton);

            var Books = context.Books.ToList();

            foreach (var book in Books)
            {
                Panel panel = new Panel
                {
                    Width = 150,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10)
                };

                PictureBox pictureBox = new PictureBox
                {
                    Width = 130,
                    Height = 150,
                    Location = new Point(10, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                if (book.Image != null && book.Image.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(book.Image))
                    {
                        pictureBox.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox.Image = Properties.Resources.DeWatermark_ai_1741085488178;
                }

                Label lblTitle = new Label
                {
                    Text = book.Title,
                    AutoSize = false,
                    Width = 130,
                    Height = 40,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold),
                    Location = new Point(10, 165)
                };

                Button btnManageBook = new Button
                {
                    Text = "Manage Books",
                    Width = 130,
                    Height = 30,
                    Font = new System.Drawing.Font("Arial", 8, FontStyle.Bold),
                    BackColor = System.Drawing.Color.LightGray,
                    ForeColor = System.Drawing.Color.Black,
                    Location = new Point(10, 210)
                };

                btnManageBook.Click += (object sender, EventArgs e) =>
                {
                    AddBook addBook = new AddBook(book.Id);
                    this.Hide();
                    addBook.ShowDialog();
                    this.Close();






                };

                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblTitle);
                panel.Controls.Add(btnManageBook);
                flowPanel.Controls.Add(panel);
            }

            AllBooksPage.Controls.Add(flowPanel);

            #endregion
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            ////Books
            ///
            LoadBooks();

            //Member

            dataGridView1.DataSource = context.Users
        .Select(u => new
        {
            u.Id,
            u.Username,
            u.Role,
            u.MemberShipType,
            u.Name,
            u.Email,
            u.Phone
        }).Where(u => u.Role == Role.Member).ToList();
            MemberShipType_cbox.DataSource = Enum.GetValues(typeof(MemberShipType));
            MemberRole_cbox.DataSource = Enum.GetValues(typeof(Role));
            MemberRole_cbox.Visible = false;
            MemberRolev2Lbl.Visible = false;
            //Librian
            dgv_Librian.DataSource = context.Users
     .Select(u => new
     {
         u.Id,
         u.Username,
         u.Role,
         u.MemberShipType,
         u.Name,
         u.Email,
         u.Phone
     }).Where(u => u.Role == Role.Librarian).ToList();
            LibrianShipType_cbox.DataSource = Enum.GetValues(typeof(MemberShipType));
            LibrianRole_cbox.DataSource = Enum.GetValues(typeof(Role));
            LibrianRole_cbox.Visible = false;
            LibrianRoleLbl.Visible = false;
            LibrianShipType_cbox.Visible = false;
            LibrianShipTypeLbl.Visible = false;
        }

        private void AddMemberBtn_Click(object sender, EventArgs e)
        {
            //Member
            string name = MemberName_txt.Text.Trim();
            string username = MemberUserName_txt.Text.Trim();
            string email = MemberEmail_txt.Text.Trim();
            string phone = MemberPhone_txt.Text.Trim();
            string password = MemberPassword_txt.Text.Trim();
            var membershipType = (MemberShipType)MemberShipType_cbox.SelectedItem;


            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("All fields Are Required", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("This Email is not valied!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.IsMatch(phone, @"^(010|011|012|015)\d{8}$"))
            {
                MessageBox.Show("This phone is not valied!!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (context.Users.Any(u => u.Username == username))
            {
                MessageBox.Show("This Username is Already Exist!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (context.Users.Any(u => u.Email == email))
            {
                MessageBox.Show("This Email is Already Exist!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);


            var user = new LibraryDataAccess.Models.User
            {
                Name = name,
                Username = username,
                Email = email,
                Phone = phone,
                Password = hashedPassword,
                Role = Role.Member,
                MemberShipType = membershipType
            };


            context.Users.Add(user);
            context.SaveChanges();


            MemberName_txt.Text = "";
            MemberUserName_txt.Text = "";
            MemberEmail_txt.Text = "";
            MemberPhone_txt.Text = "";
            MemberPassword_txt.Text = "";

            MessageBox.Show("Member is Added", "sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = context.Users
          .Select(u => new
          {
              u.Id,
              u.Username,
              u.Role,
              u.MemberShipType,
              u.Name,
              u.Email,
              u.Phone
          }).Where(u => u.Role == Role.Member).ToList();


        }

        int id;

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            MemberUserName_txt.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            //    password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            MemberName_txt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            MemberEmail_txt.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            MemberPhone_txt.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            MemberPassword_txt.Visible = false;
            MemberPasswordv2Lbl.Visible = false;
            MemberUserName_txt.Enabled = false;
            AddMemberBtn.Enabled = false;
            if (Enum.TryParse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), out Role userRole))
            {
                MemberRole_cbox.SelectedItem = userRole;
            }

            if (Enum.TryParse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), out MemberShipType membershipType))
            {
                MemberShipType_cbox.SelectedItem = membershipType;
            }
            MemberRole_cbox.Visible = true;
            MemberRolev2Lbl.Visible = true;
        }

        private void UpdateMemberBtn_Click(object sender, EventArgs e)
        {
            LibraryDataAccess.Models.User u = context.Users.Where(u => u.Id == id).FirstOrDefault();
            string password = u.Password;
            u.Name = MemberName_txt.Text;
            u.Email = MemberEmail_txt.Text;
            u.Phone = MemberPhone_txt.Text;
            u.Password = password;
            u.Username = MemberUserName_txt.Text;
            u.Password = u.Password;
            u.Role = (Role)MemberRole_cbox.SelectedItem;
            u.MemberShipType = (MemberShipType)MemberShipType_cbox.SelectedItem;
            context.SaveChanges();
            MemberName_txt.Text = "";
            MemberUserName_txt.Text = "";
            MemberEmail_txt.Text = "";
            MemberPhone_txt.Text = "";
            MemberPassword_txt.Text = "";
            MemberUserName_txt.Enabled = true;
            MessageBox.Show(" updated", "sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.DataSource = context.Users
          .Select(u => new
          {
              u.Id,
              u.Username,
              u.Role,
              u.MemberShipType,
              u.Name,
              u.Email,
              u.Phone
          }).Where(u => u.Role == Role.Member).ToList();
        }

        private void DeleteMemberBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this Member", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                LibraryDataAccess.Models.User u = context.Users.Where(n => n.Id == id).SingleOrDefault();
                context.Users.Remove(u);
                context.SaveChanges();
                MemberName_txt.Text = "";
                MemberUserName_txt.Text = "";
                MemberEmail_txt.Text = "";
                MemberPhone_txt.Text = "";
                MemberPassword_txt.Text = "";

                MemberUserName_txt.Enabled = true;
                dataGridView1.DataSource = context.Users.Where(u => u.Role == Role.Member).ToList();

                MessageBox.Show("deleted");
            }
        }

        private void LibrianAddBtn_Click(object sender, EventArgs e)
        {
            //Libriran
            string LibrianName = LibrianName_txt.Text.Trim();
            string LibrianUserName = LibrianUserName_txt.Text.Trim();
            string LibrianEmail = LibrianEmail_txt.Text.Trim();
            string LibrianPhone = LibrianPhone_txt.Text.Trim();
            string LibrianPassword = LibrianPassword_txt.Text.Trim();
            var LibrianshipType = MemberShipType.None;
            var librianRole = Role.Librarian;


            if (string.IsNullOrEmpty(LibrianName) || string.IsNullOrEmpty(LibrianUserName) ||
                string.IsNullOrEmpty(LibrianEmail) || string.IsNullOrEmpty(LibrianPhone) || string.IsNullOrEmpty(LibrianPassword))
            {
                MessageBox.Show("All fields Are Required", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.IsMatch(LibrianEmail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("This Email is not valied!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!Regex.IsMatch(LibrianPhone, @"^(010|011|012|015)\d{8}$"))
            {
                MessageBox.Show("This phone is not valied!!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (context.Users.Any(u => u.Username == LibrianUserName))
            {
                MessageBox.Show("This Username is Already Exist!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (context.Users.Any(u => u.Email == LibrianEmail))
            {
                MessageBox.Show("This Email is Already Exist!", "fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string librianhashedPassword = BCrypt.Net.BCrypt.HashPassword(LibrianPassword);


            var librian = new LibraryDataAccess.Models.User
            {
                Name = LibrianName,
                Username = LibrianUserName,
                Email = LibrianEmail,
                Phone = LibrianPhone,
                Password = librianhashedPassword,
                Role = Role.Librarian,
                MemberShipType = MemberShipType.None,
            };


            context.Users.Add(librian);
            context.SaveChanges();


            LibrianEmail_txt.Text = "";
            LibrianName_txt.Text = "";
            LibrianPassword_txt.Text = "";
            LibrianPhone_txt.Text = "";
            LibrianUserName_txt.Text = "";

            MessageBox.Show("librian is Added", "sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Librian.DataSource = context.Users
          .Select(u => new
          {
              u.Id,
              u.Username,
              u.Role,
              u.MemberShipType,
              u.Name,
              u.Email,
              u.Phone
          }).Where(u => u.Role == Role.Librarian).ToList();

        }
        int librianId;
        private object flowLayoutPanelBooks;

        private void dgv_Librian_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            librianId = (int)dgv_Librian.SelectedRows[0].Cells[0].Value;
            LibrianUserName_txt.Text = dgv_Librian.SelectedRows[0].Cells[1].Value.ToString();
            //    password = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            LibrianName_txt.Text = dgv_Librian.SelectedRows[0].Cells[4].Value.ToString();
            LibrianEmail_txt.Text = dgv_Librian.SelectedRows[0].Cells[5].Value.ToString();
            LibrianPhone_txt.Text = dgv_Librian.SelectedRows[0].Cells[6].Value.ToString();
            LibrianPassword_txt.Visible = false;
            LibrianPasswordLbl.Visible = false;
            LibrianUserName_txt.Enabled = false;
            LibrianAddBtn.Enabled = false;
            MemberRole_cbox.Visible = true;
            MemberRolev2Lbl.Visible = true;

        }

        private void LibrianUpdateBtn_Click(object sender, EventArgs e)
        {
            LibraryDataAccess.Models.User u = context.Users.Where(u => u.Id == librianId).FirstOrDefault();
            string password = u.Password;
            u.Name = LibrianName_txt.Text;
            u.Email = LibrianEmail_txt.Text;
            u.Phone = LibrianPhone_txt.Text;
            u.Password = password;
            u.Username = LibrianUserName_txt.Text;

            u.Role = Role.Librarian;
            u.MemberShipType = MemberShipType.None;
            context.SaveChanges();
            LibrianName_txt.Text = "";
            LibrianUserName_txt.Text = "";
            LibrianEmail_txt.Text = "";
            LibrianPhone_txt.Text = "";
            LibrianPassword_txt.Text = "";
            MemberUserName_txt.Enabled = true;
            MessageBox.Show(" updated", "sucsses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgv_Librian.DataSource = context.Users
          .Select(u => new
          {
              u.Id,
              u.Username,
              u.Role,
              u.MemberShipType,
              u.Name,
              u.Email,
              u.Phone
          }).Where(u => u.Role == Role.Librarian).ToList();
        }

        private void LibrianDeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this librian", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                LibraryDataAccess.Models.User u = context.Users.Where(n => n.Id == librianId).SingleOrDefault();
                context.Users.Remove(u);
                context.SaveChanges();
                LibrianName_txt.Text = "";
                LibrianUserName_txt.Text = "";
                LibrianEmail_txt.Text = "";
                LibrianPhone_txt.Text = "";
                LibrianPassword_txt.Text = "";

                MemberUserName_txt.Enabled = true;
                dgv_Librian.DataSource = context.Users.Where(u => u.Role == Role.Librarian).ToList();

                MessageBox.Show("deleted");
            }
        }

     













































































































































































        private void ExportToExcel(DataGridView dgv, string fileName)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (ExcelPackage excel = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("Report");

                // Header
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dgv.Columns[i - 1].HeaderText;
                }

                // Data
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                // Save to file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    FileName = fileName
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, excel.GetAsByteArray());
                    MessageBox.Show("Excel Report Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }









        private void ExportToPDF(DataGridView dgv, string fileName)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files|*.pdf",
                FileName = fileName
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                document.Open();

                PdfPTable table = new PdfPTable(dgv.Columns.Count);
                table.WidthPercentage = 100;

                // Header
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = BaseColor.LIGHT_GRAY;
                    table.AddCell(cell);
                }

                // Data
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(cell.Value?.ToString() ?? "");
                    }
                }

                document.Add(table);
                document.Close();
                MessageBox.Show("PDF Report Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }





        private void GenerateBorrowedBooksReport()
        {
            var borrowedBooks = context.BorrowingRecords
                .Where(b => b.ReturnDate == null) // Books not returned yet
                .Select(b => new
                {
                    b.Id,
                    b.Book.Title,
                    b.Member.Name,
                    b.BorrowDate,
                    b.DueDate
                }).ToList();

            dgv_Report.DataSource = borrowedBooks;
        }

        private void GenerateAvailableBooksReport()
        {
            var availableBooks = context.Books
                .Where(b => b.Quantity > 0) // Books in stock
                .Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.Author,
                    b.ISBN,
                    b.PublishedYear,
                    b.Quantity
                }).ToList();

            dgv_Report.DataSource = availableBooks;
        }



        private void GenerateOverdueBooksReport()
        {
            var overdueBooks = context.BorrowingRecords
                .Where(b => b.DueDate < DateTime.Now && b.ReturnDate == null) // Overdue and not returned
                .Select(b => new
                {
                    b.Id,
                    b.Book.Title,
                    b.Member.Name,
                    b.BorrowDate,
                    b.DueDate
                }).ToList();

            dgv_Report.DataSource = overdueBooks;
        }

        private void ExcelExport_Click(object sender, EventArgs e)
        {
            ExportToExcel(dgv_Report, "Library_Report.xlsx");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToPDF(dgv_Report, "Library_Report.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateOverdueBooksReport();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GenerateBorrowedBooksReport();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            GenerateAvailableBooksReport();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SginoutBtn_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.ShowDialog();
            this.Close();
        }

        private void Members_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Members.SelectedTab.Name == "ReturnSTimePage")
            {

                ManageReturn ManageReturn = new ManageReturn();

                this.Hide();
                ManageReturn.ShowDialog();
                this.Close();

            }
            else if (Members.SelectedTab.Name == "RequestsPage")
            {

                AdminRequest AdminRequest = new AdminRequest();
                this.Hide();
                AdminRequest.ShowDialog();
                this.Close();
            }
        }
    }
}
