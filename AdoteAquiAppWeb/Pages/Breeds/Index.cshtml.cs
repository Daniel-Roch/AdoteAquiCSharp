using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Pages.Breeds
{
    public class IndexModel : PageModel
    {
        private readonly AdoteAquiAppWeb.Data.AdoteAquiDbContext _context;

        public IndexModel(AdoteAquiAppWeb.Data.AdoteAquiDbContext context)
        {
            _context = context;
        }

        public IList<Breed> Breed { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Breeds != null)
            {
                Breed = await _context.Breeds.ToListAsync();
            }
        }
    }
}
