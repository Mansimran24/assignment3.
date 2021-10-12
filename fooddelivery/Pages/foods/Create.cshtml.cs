using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using fooddelivery;
using fooddelivery.foodie;

namespace fooddelivery.Pages_foods
{
    public class CreateModel : PageModel
    {
        private readonly fooddelivery.foodieContext _context;

        public CreateModel(fooddelivery.foodieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public newfoodie newfoodie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.newfoodie.Add(newfoodie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
