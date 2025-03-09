using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.LibraryDataAccess.Models;
using LibraryManagementSystem.LibraryDataAccess.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class Login : Form
    {
        private readonly LibraryDBContext cxt;
        private readonly UserService userService;
        public static User LoggedInUser;

        public Login()
        {
            InitializeComponent();
            this.cxt = new LibraryDBContext();
            this.userService = new UserService(cxt);
            // lblError.Visible = false;

            txt_password.UseSystemPasswordChar = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_logIn_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text.Trim();
            string password = txt_password.Text.Trim();
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
             
                    MessageBox.Show("Please enter both username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
               
            }




            User user = userService.AuthenticateUser(username, password);

            if (user != null)
            {
                LoggedInUser = user;
                MessageBox.Show($"Welcome, {user.Name}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OpenFormBasedOnRole(user.Role);
            }
            else
            {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          
            }
        }

        private void OpenFormBasedOnRole(Role userRole)
        {
            Form nextForm = null;

            if (userRole == Role.Admin)
            {
                nextForm = new AdminForm();
            }
            else if (userRole == Role.Librarian)
            {
                nextForm = new LibrarianForm();
            }
            else if (userRole == Role.Member)
            {
                nextForm = new Member();
            }

            if (nextForm != null)
            {
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Logout()
        {
            LoggedInUser = null;
        }
    }
}
