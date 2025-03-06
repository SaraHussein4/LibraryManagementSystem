using LibraryManagementSystem.LibraryDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryDataAccess.Service
{
    public class UserService
    {
        public LibraryDBContext cxt;
        public UserService(LibraryDBContext cxt)
        {
            this.cxt = cxt;
        }

        public List<User>GetUsers()=>cxt.Users.ToList();
        
        public void AddUser(User user)
        {
            cxt.Users.Add(user);
            cxt.SaveChanges();
        }

        public void UpdateUser(User user) 
        {
            cxt.Users.Update(user);
            cxt.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = cxt.Users.Find(userId);
            cxt.Users.Remove(user);
            cxt.SaveChanges();
        
        }
    }
}
