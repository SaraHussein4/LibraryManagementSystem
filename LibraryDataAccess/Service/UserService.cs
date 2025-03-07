using LibraryManagementSystem.LibraryDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BCrypt.Net;

namespace LibraryManagementSystem.LibraryDataAccess.Service
{
    public class UserService
    {
        private readonly LibraryDBContext cxt;

        public UserService(LibraryDBContext cxt)
        {
            this.cxt = cxt;
        }

        // Get all users from the database
        public List<User> GetUsers() => cxt.Users.ToList();

        // Add a new user to the database
        public void AddUser(User user)
        {
            cxt.Users.Add(user);
            cxt.SaveChanges();
        }

        // Update an existing user in the database
        public void UpdateUser(User user)
        {
            cxt.Users.Update(user);
            cxt.SaveChanges();
        }

        // Delete a user from the database by ID
        public void DeleteUser(int userId)
        {
            var user = cxt.Users.Find(userId);
            if (user != null)
            {
                cxt.Users.Remove(user);
                cxt.SaveChanges();
            }
        }

        // Register a new user with validation
        public bool RegisterUser(string name, string username, string email, string phone, string password, MemberShipType membershipType)
        {
            // Validate username uniqueness
            if (cxt.Users.Any(u => u.Username == username))
                throw new Exception("Username is already taken.");

            // Validate email uniqueness
            if (cxt.Users.Any(u => u.Email == email))
                throw new Exception("Email is already registered.");

            //  Validate Email Format
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                throw new Exception("Invalid email format! Please enter a valid email address.");

            // Validate phone number format
            if (!Regex.IsMatch(phone, @"^(010|011|012|015)\d{8}$"))
                throw new Exception("Invalid phone number!");
            
            
            // Hash the password before storing it
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Create a new user with default Role as Member
            var newUser = new User
            {
                Name = name,
                Username = username,
                Email = email,
                Phone = phone,
                Password = hashedPassword,
                Role = Role.Member, // Default role is Member
                MemberShipType = membershipType
            };

            // Add the new user to the database and save changes
            cxt.Users.Add(newUser);
            cxt.SaveChanges();
            return true;
        }
    }
}






























