using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages
{
    public class ContactModel : PageModel
    {
        private IClientAdoptionService _clientAdoptionService;
        public ContactModel(IClientAdoptionService service) {
            _clientAdoptionService = service;
        }

        [BindProperty]
        public ClientAdoption? clientAdoption { get; set; }
        public void OnGet() {
            ViewData["Title"] = "Cadastro";
        }
        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }
            //Modal
            //TempData["ViewModal"] = true;

            //incusao - Com esse BindProperty ele j� vai auto cadastrar (inje��o de dependencia)
            _clientAdoptionService.SetCliente(clientAdoption);

            //redirect
            return RedirectToPage("/Index");
        }
    }
}
