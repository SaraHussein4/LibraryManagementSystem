using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryDataAccess.Models
{
    public class LibraryDBContext : DbContext
    {
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<BorrowingRecord> BorrowingRecords { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=.;Database=LibrarySystem;Integrated Security=True;Encrypt=False;Trust Server Certificate=True");
            string con = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            optionsBuilder.UseSqlServer(con);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(u => u.Role).HasConversion<string>();

            modelBuilder.Entity<User>().Property(u => u.MemberShipType).HasConversion<string>();



            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "admin",
                    Password = HashPassword("Admin@123"),  // Hash the password before saving
                    Role = Role.Admin,
                    MemberShipType = MemberShipType.None,
                    Name = "Admin User",
                    Email = "admin@library.com",
                    Phone = "01000000000"
                },
                new User
                {
                    Id = 2,
                    Username = "librarian",
                    Password = HashPassword("Librarian@123"),
                    Role = Role.Librarian,
                    MemberShipType = MemberShipType.None,
                    Name = "Library Manager",
                    Email = "librarian@library.com",
                    Phone = "01011111111"
                },
                new User
                {
                    Id = 3,
                    Username = "member",
                    Password = HashPassword("Member@123"),
                    Role = Role.Member,
                    MemberShipType = MemberShipType.Student,
                    Name = "John Doe",
                    Email = "member@library.com",
                    Phone = "01022222222"
                }
            );


            base.OnModelCreating(modelBuilder);



        }

        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
