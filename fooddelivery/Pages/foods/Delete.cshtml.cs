using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using fooddelivery;
using fooddelivery.foodie;

namespace fooddelivery.Pages_foods
{
    public class DeleteModel : PageModel
    {
        private readonly fooddelivery.foodieContext _context;

        public DeleteModel(fooddelivery.foodieContext context)
        {
            _context = context;
        }

        [BindProperty]
        public newfoodie newfoodie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            newfoodie = await _context.newfoodie.FirstOrDefaultAsync(m => m.ID == id);

            if (newfoodie == null)
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

            newfoodie = await _context.newfoodie.FindAsync(id);

            if (newfoodie != null)
            {
                _context.newfoodie.Remove(newfoodie);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
