using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int Document { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

        [Column(TypeName = "date")]
        public DateTime Birthday { get; set; }
        public int Number { get; set; }
        public string Email { get; set; }


        public ICollection<Invoice> Invoices { get; set; }
    }
}