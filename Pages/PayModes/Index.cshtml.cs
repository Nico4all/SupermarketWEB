using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        private readonly SumpermarketContext _context;

        public IndexModel(SumpermarketContext context)
        {
            _context = context;
        }

        public List<Paymode> Paymodes { get; set; } = default!;

        public async Task OnGet()
        {
            if (_context.PayModes != null)
            {
                Paymodes = await _context.PayModes.ToListAsync();
            }
        }
    }
}
