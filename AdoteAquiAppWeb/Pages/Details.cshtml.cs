using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages
{
    public class DetailsModel : PageModel
    {
        public Animal? AnimalDetails { get; private set; }
        public void OnGet(int id)
        {
            AnimalsServices animalServices = new AnimalsServices();
            AnimalDetails = animalServices.getAnimal(id);
        }
    }
}
