using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class AdminForm : Form
    {
        private readonly LibraryDBContext context;

        public AdminForm()
        {
            InitializeComponent();
            context = new LibraryDBContext();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
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
            /* if (Enum.TryParse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), out Role userRole))
             {
                 MemberRole_cbox.SelectedItem = userRole;
             }

             if (Enum.TryParse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), out MemberShipType membershipType))
             {
                 MemberShipType_cbox.SelectedItem = membershipType;
             }*/
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
    }
}
