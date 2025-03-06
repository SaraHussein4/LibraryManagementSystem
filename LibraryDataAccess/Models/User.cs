using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryDataAccess.Models
{
    public enum Role
    {
        Admin,
        Member,
        Librarian
    }
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Username { get; set; }

        [Required, MaxLength(100)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public Role Role { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        public virtual List<BorrowingRecord> BorrowingRecords { get; set; }
        public virtual List<Log> Logs { get; set; }
    }
}
