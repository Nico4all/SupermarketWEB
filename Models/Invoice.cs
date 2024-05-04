using Microsoft.AspNetCore.Razor.TagHelpers;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWEB.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public int Number { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int PaymodeId { get; set; }
        public Paymode Paymode { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Detail>? Details { get; set; } = default;
    }
}