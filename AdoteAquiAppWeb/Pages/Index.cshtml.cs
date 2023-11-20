using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using AdoteAquiAppWeb.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages;
public class IndexModel : PageModel {

    private IClientAdoptionService _clientAdoptionService;
    private IAnimalsServices _animalsServices;
    public IndexModel(IClientAdoptionService serviceClient, IAnimalsServices animalsServices) {
        _clientAdoptionService = serviceClient;
        _animalsServices = animalsServices;
    }

    public IList<Animal> ListAnimals { get; private set; }
    public IList<ClientAdoption> ListClientAdoption { get; private set; }

    public void OnGet() {
        ViewData["Title"] = "Home";
        //Por causa da injeção de dependencia, eu não preciso mais dessa parte
        //ClientAdoptionService clientAdoption = new ClientAdoptionService();
        ListAnimals = _animalsServices.AllAnimals();
        ListClientAdoption = _clientAdoptionService.AllClients();
    }
}