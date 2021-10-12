using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fooddelivery;
using fooddelivery.foodie;

namespace fooddelivery.Pages_foods
{
    public class EditModel : PageModel
    {
        private readonly fooddelivery.foodieContext _context;

        public EditModel(fooddelivery.foodieContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(newfoodie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!newfoodieExists(newfoodie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool newfoodieExists(int id)
        {
            return _context.newfoodie.Any(e => e.ID == id);
        }
    }
}
