using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Facturas
{
    public class DeleteModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public DeleteModel(SumpermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Invoice Invoice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices.FirstOrDefaultAsync(m => m.Id == id);


            if (invoice == null)
            {
                return NotFound();
            }

            return Page();
        }
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices.FindAsync(id);

            if (Invoice != null)
            {
                Invoice = invoice;
                _context.Invoices.Remove(Invoice);
                await _context.SaveChangesAsync();

            }

            return RedirectToPage("./Index");
        }
    }
}
