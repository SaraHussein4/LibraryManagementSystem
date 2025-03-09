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
using System.Xml.Linq;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class ProfileUpdateForm : Form
    {
        private readonly LibraryDBContext _context;
        private readonly User _loggedInUser;

        public ProfileUpdateForm(User user)
        {
            InitializeComponent();
            _context = new LibraryDBContext();
            _loggedInUser = Login.LoggedInUser;

            if (_loggedInUser != null)
            {
                txtUsername.Text = _loggedInUser.Username;
                txtName.Text = _loggedInUser.Name;
                txtEmail.Text = _loggedInUser.Email;
                txtPhone.Text = _loggedInUser.Phone;
            }
        }

       
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (_loggedInUser != null)
            {
                _loggedInUser.Username = txtUsername.Text;
                _loggedInUser.Name = txtName.Text;
                _loggedInUser.Email = txtEmail.Text;
                _loggedInUser.Phone = txtPhone.Text;

                _context.Entry(_loggedInUser).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();

                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }
    }
}
