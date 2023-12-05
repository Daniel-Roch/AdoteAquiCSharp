using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using NToastNotify;

namespace AdoteAquiAppWeb.Pages
{
    public class EditDetailsModel : PageModel
    {
        private IAnimalsServices _animalsServices;
        public SelectList BreedOptions { get; set; }
        private IToastNotification _toastNotification;

        public EditDetailsModel(IAnimalsServices service, IToastNotification toastNotification) {
            _animalsServices = service;
            _toastNotification = toastNotification;
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
            _toastNotification.AddSuccessToastMessage("Card editado com sucesso!");
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostDelete() {
            _animalsServices.DeleteAnimal(animal.Id);
            _toastNotification.AddAlertToastMessage("Card deletado com sucesso!");
            return RedirectToPage("/Index");
        }
    }
}
