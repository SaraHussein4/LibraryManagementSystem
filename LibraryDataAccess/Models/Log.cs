using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.LibraryDataAccess.Models
{
    public class Log
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionType { get; set; }

        [Required]
        public DateTime ActionDate { get; set; } = DateTime.Now;

        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public virtual User Member { get; set; }
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public virtual Book Book { get; set; }


    }
}
