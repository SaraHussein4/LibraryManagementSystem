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
using Microsoft.VisualBasic.ApplicationServices;

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class LibrarianForm : Form
    {
        private int userId;
        public LibrarianForm(int userId)
        {


            InitializeComponent();


            if (Login.LoggedInUser != null)
            {
                this.userId = Login.LoggedInUser.Id;
            }
            else
            {
                MessageBox.Show("No user is logged in!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            LoadUserControl(new UC_ManageBooks());
            this.userId = userId;

        }


        private void LoadUserControl(UserControl userControl)
        {
            panelContainer.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void tabManageBooks_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UC_ManageBooks());
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void tabUpdateProfile_Click(object sender, EventArgs e)
        {
            //LoadUserControl(new UC_UpdateProfile(userId));
        }

        private void uC_UpdateProfile1_Load(object sender, EventArgs e)
        {

        }

    

        
       
        private void tabSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?","Confirm Logout",MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                 
                    Login.LoggedInUser = null;
                    this.Close();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
       

        }
    }


}








