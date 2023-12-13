﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly AdoteAquiAppWeb.Data.AdoteAquiDbContext _context;

        public DetailsModel(AdoteAquiAppWeb.Data.AdoteAquiDbContext context)
        {
            _context = context;
        }

      public Breed Breed { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Breeds == null)
            {
                return NotFound();
            }

            var breed = await _context.Breeds.FirstOrDefaultAsync(m => m.BreedId == id);
            if (breed == null)
            {
                return NotFound();
            }
            else 
            {
                Breed = breed;
            }
            return Page();
        }
    }
}
