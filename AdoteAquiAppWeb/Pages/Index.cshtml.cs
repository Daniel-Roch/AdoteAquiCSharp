using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages;
public class IndexModel : PageModel {
    public IList<Animal> ListAnimals { get; private set; }
    public void OnGet() {
        ViewData["Title"] = "Home";
        AnimalsServices animalServices = new AnimalsServices();
        ListAnimals = animalServices.AllAnimals();
    }
}