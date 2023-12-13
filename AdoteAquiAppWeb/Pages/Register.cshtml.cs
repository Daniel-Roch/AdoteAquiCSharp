using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AdoteAquiAppWeb.Pages
{
    [Authorize]
    public class RegisterModel : PageModel
    {
        public SelectList BreedOptions { get; set; }
        private IAnimalsServices _animalsServices;
        public RegisterModel(IAnimalsServices service) {
            _animalsServices = service;
        }

        [BindProperty]
        public Animal? animal { get; set; }
        public void OnGet(){
            ViewData["Title"] = "Cadastro";
            //o primeiro nameof é o que vai entrar no cadastro, e o segundo é o que vai aparecer no front
            BreedOptions = new SelectList(_animalsServices.AllBreeds(), nameof(Breed.BreedId), nameof(Breed.Name));
        }
        public IActionResult OnPost() {
            if(!ModelState.IsValid) {
                return Page();
            }
            //Modal
            //TempData["ViewModal"] = true;

            //incusao - Com esse BindProperty ele já vai auto cadastrar (injeção de dependencia)
            _animalsServices.SetAnimal(animal);

            //redirect
            return RedirectToPage("/Index");
        }
    }
}
