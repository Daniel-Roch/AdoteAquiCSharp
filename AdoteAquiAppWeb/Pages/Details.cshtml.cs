using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        public Animal? AnimalDetails { get; private set; }
        public IActionResult OnGet(int id)
        {
            AnimalsServices animalServices = new AnimalsServices();
            AnimalDetails = animalServices.getAnimal(id);

            if (AnimalDetails == null) {
                return NotFound();
            }
            return Page();
        }
    }
}
