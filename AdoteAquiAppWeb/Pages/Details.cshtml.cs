using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        private IAnimalsServices _animalsService;
        public string DescriptBreed { get; set; }

        public DetailsModel(IAnimalsServices service) {
            _animalsService = service;
        }
        public Animal? AnimalDetails { get; set; }
        public IActionResult OnGet(int id)
        {
            AnimalDetails = _animalsService.GetAnimal(id);

            if (AnimalDetails.BreedId is not null) {
                //Como pode ser null, quero pegar seu valor inteiro
                DescriptBreed = _animalsService.GetBreed(AnimalDetails.BreedId.Value).Name;
            }

            if (AnimalDetails == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
