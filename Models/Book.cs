using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [Required, MaxLength(100)]
        public string Author { get; set; }

        [Required, MaxLength(20)]
        public string ISBN { get; set; }

        [Required, MaxLength(50)]
        public string Category { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int PublishedYear { get; set; }
    }
}
