namespace SupermarketWEB.Models
{
    public class Detail
    {
        public int Id { get; set; }
        public int Quiantity { get; set; }
        public int Price { get; set; }

        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}