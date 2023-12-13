using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Pages.Breeds
{
    public class EditModel : PageModel
    {
        private readonly AdoteAquiAppWeb.Data.AdoteAquiDbContext _context;

        public EditModel(AdoteAquiAppWeb.Data.AdoteAquiDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Breed Breed { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Breeds == null)
            {
                return NotFound();
            }

            var breed =  await _context.Breeds.FirstOrDefaultAsync(m => m.BreedId == id);
            if (breed == null)
            {
                return NotFound();
            }
            Breed = breed;
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

            _context.Attach(Breed).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreedExists(Breed.BreedId))
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

        private bool BreedExists(int id)
        {
          return (_context.Breeds?.Any(e => e.BreedId == id)).GetValueOrDefault();
        }
    }
}
