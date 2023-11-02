using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdoteAquiAppWeb.Pages;

public class AboutUsModel : PageModel
{
    public void OnGet()
    {
        ViewData["Title"] = "Quem Somos";
    }
}
