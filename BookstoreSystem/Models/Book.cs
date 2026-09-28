using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreSystem.Models
{
    // Q1 Answer: "Id" became a Primary Key by EF Core Convention because it is named "Id" (or ClassNameId).
    // Q2 Answer: "Country" (string?) is reference type and marked nullable, so EF maps it to NULL in DB.
    // Q3 Answer: "Price" (decimal) is a non-nullable value type, so EF maps it to NOT NULL by default.
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public DateTime? PublishedDate { get; set; }
    }
}
