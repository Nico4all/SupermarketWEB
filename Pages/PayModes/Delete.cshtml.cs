using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWEB.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.PayModes
{
    public class DeleteModel : PageModel
    {
        private readonly SumpermarketContext _context;
        public DeleteModel(SumpermarketContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Paymode Paymode { get; set; }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var payMode = await _context.PayModes.FirstOrDefaultAsync(m => m.Id == id);


            if (payMode == null)
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

            var paymode = await _context.PayModes.FindAsync(id);

            if (paymode != null)
            {
                Paymode = paymode;
                _context.PayModes.Remove(paymode);                
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
