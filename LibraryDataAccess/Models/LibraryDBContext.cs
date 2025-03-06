using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
