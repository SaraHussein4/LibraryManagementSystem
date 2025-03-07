using LibraryManagementSystem.LibraryDataAccess.Models;
using LibraryManagementSystem.LibraryDataAccess.Service;
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
    public partial class SignUp : Form
    {
        private readonly LibraryDBContext cxt;
        private readonly UserService userService;
        public SignUp()
        {
            InitializeComponent();
            cxt = new LibraryDBContext();
            userService = new UserService(cxt);
            cb_membershipType.DataSource = Enum.GetValues(typeof(MemberShipType));
            tb_pass.UseSystemPasswordChar = true;
            tb_confpass.UseSystemPasswordChar = true;
        }




        private void tb_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                string name = tb_name.Text.Trim();
                string username = tb_uname.Text.Trim();
                string email = tb_email.Text.Trim();
                string phone = tb_phone.Text.Trim();
                string password = tb_pass.Text;
                string confirmPassword = tb_confpass.Text;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
                {
                    MessageBox.Show("All fields are required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MemberShipType selectedMembership = (MemberShipType)cb_membershipType.SelectedItem;

                userService.RegisterUser(name, username, email, phone, password, selectedMembership);

                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle password visibility
            tb_pass.UseSystemPasswordChar = !checkbxShowPass.Checked;
            tb_confpass.UseSystemPasswordChar = !checkbxShowPass.Checked;
        }

        private void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btn_signUp;

            cb_membershipType.DataSource = Enum.GetValues(typeof(MemberShipType));
            cb_membershipType.SelectedIndex = -1;
            cb_membershipType.Text = "Membership Type";
            //btn_signUp.Focus();

        }

        private void cb_membershipType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
