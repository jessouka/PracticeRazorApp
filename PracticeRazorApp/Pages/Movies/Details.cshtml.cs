using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracticeRazorApp.Models;

namespace PracticeRazorApp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly PracticeRazorApp.Models.PracticeRazorAppContext _context;

        public DetailsModel(PracticeRazorApp.Models.PracticeRazorAppContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
