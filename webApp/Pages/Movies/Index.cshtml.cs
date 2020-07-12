using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webApp.Data;
using webApp.Models;

namespace webApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly webApp.Data.RazorPagesMovieContext _context;

        public IndexModel(webApp.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
