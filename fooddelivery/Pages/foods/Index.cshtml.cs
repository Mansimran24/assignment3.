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
    public class IndexModel : PageModel
    {
        private readonly fooddelivery.foodieContext _context;

        public IndexModel(fooddelivery.foodieContext context)
        {
            _context = context;
        }

        public IList<newfoodie> newfoodie { get;set; }

        public async Task OnGetAsync()
        {
            newfoodie = await _context.newfoodie.ToListAsync();
        }
    }
}
