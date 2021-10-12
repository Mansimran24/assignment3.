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
    public class DetailsModel : PageModel
    {
        private readonly fooddelivery.foodieContext _context;

        public DetailsModel(fooddelivery.foodieContext context)
        {
            _context = context;
        }

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
    }
}
