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

namespace LibraryManagementSystem.LibraryPresentationLayer
{
    public partial class SignUp : Form
    {
        LibraryDBContext cxt;
        UserService userService;
        public SignUp()
        {
            InitializeComponent();
            cxt = new LibraryDBContext();
            userService = new UserService(cxt);
        }
    }
}
