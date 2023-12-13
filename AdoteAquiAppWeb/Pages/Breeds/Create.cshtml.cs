using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Pages.Breeds
{
    public class CreateModel : PageModel
    {
        private readonly AdoteAquiAppWeb.Data.AdoteAquiDbContext _context;

        public CreateModel(AdoteAquiAppWeb.Data.AdoteAquiDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Breed Breed { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Breeds == null || Breed == null)
            {
                return Page();
            }

            _context.Breeds.Add(Breed);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
