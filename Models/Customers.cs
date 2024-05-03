using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Column(TypeName = "char(15)")]
        public char Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }

        [Column(TypeName = "char(16)")]
        public char Number { get; set; }
        public string Email { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}