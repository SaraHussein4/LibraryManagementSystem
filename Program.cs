using LibraryManagementSystem.LibraryPresentationLayer;

namespace LibraryManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
              ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
           // Application.Run(new Welcome());
            //Application.Run(new AddBook());
            //Application.Run(new MemberForm());
            //Application.Run(new Login());

            //Application.Run(new SignUp());

            Application.Run(new AdminForm());
            //Application.Run(new LibrarianForm(Login.LoggedInUser.Id));






        }
    }
}