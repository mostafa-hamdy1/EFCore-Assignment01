using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreSystem.Models
{
    [Table("Writers")] // Part B: Maps class to table "Writers"
    public class Author
    {
        public int Id { get; set; }

        [Required] // Part B: Required
        [MaxLength(100)] // Part B: Max length 100
        public string Name { get; set; }

        public string? Country { get; set; }
    }
}
