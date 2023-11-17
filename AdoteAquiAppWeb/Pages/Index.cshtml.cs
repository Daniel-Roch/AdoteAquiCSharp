using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages;
public class IndexModel : PageModel {

    private IClientAdoptionService _clientAdoptionService;
    public IndexModel(IClientAdoptionService serviceClient) {
        _clientAdoptionService = serviceClient;
    }

    public IList<Animal> ListAnimals { get; private set; }
    public IList<ClientAdoption> ListClientAdoption { get; private set; }

    public void OnGet() {
        ViewData["Title"] = "Home";
        //Por causa da injeção de dependencia, eu não preciso mais dessa parte
        AnimalsServices animalServices = new AnimalsServices();
        //ClientAdoptionService clientAdoption = new ClientAdoptionService();
        ListAnimals = animalServices.AllAnimals();
        ListClientAdoption = _clientAdoptionService.AllClients();
    }
}