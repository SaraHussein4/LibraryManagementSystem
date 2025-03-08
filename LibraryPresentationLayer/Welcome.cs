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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SignUp signUpForm = new SignUp();
            signUpForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


