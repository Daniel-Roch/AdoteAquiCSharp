using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdoteAquiAppWeb.Pages
{
    public class EditDetailsModel : PageModel
    {
        private IAnimalsServices _animalsServices;
        public SelectList BreedOptions { get; set; }
        public EditDetailsModel(IAnimalsServices service) {
            _animalsServices = service;
        }
         
        [BindProperty]
        public Animal animal { get; set; }

        public IActionResult OnGet(int id)
        {
            ViewData["Title"] = "Alteraçãor";
            BreedOptions = new SelectList(_animalsServices.AllBreeds(), nameof(Breed.BreedId), nameof(Breed.Name));
            animal = _animalsServices.GetAnimal(id);
            if (animal == null) {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost() {
            if(!ModelState.IsValid) {
                return Page();
            }

            _animalsServices.AlterAnimal(animal);
            TempData["EditSucess"] = true;
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDelete() {
            _animalsServices.DeleteAnimal(animal.Id);
            TempData["EditDelete"] = true;
            return RedirectToPage("/Index");
        }
    }
}
