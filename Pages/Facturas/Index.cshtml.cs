using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Facturas
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }

        public List<Invoice> Invoices { get; set; } = default!;

        public async Task OnGet()
        {
            if (_context.Invoices != null)
            {
                Invoices = await _context.Invoices.ToListAsync();
            }
        }
    }
}
