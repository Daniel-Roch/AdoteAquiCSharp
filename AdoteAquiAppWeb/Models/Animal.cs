using System.ComponentModel.DataAnnotations;

namespace AdoteAquiAppWeb.Models;
public class Animal {
    public int Id { get; set; }
    [Required(ErrorMessage = "Campo Nome obrigatório.")]
    [StringLength(20, MinimumLength = 3, ErrorMessage = "Caracteres inválidos.")]
    [Display(Name = "Nome")]
    public string Name { get; set; }
    public string NameSlug => Name.ToLower().Replace(" ","-");
    public string Img { get; set; }
    public string Url { get; set; }
    public bool Adoption { get; set; }
    public string AdoptionShadow => Adoption ? "Sim" : "Não";
    [Required(ErrorMessage = "Descricao obrigatoria.")]
    [StringLength(200, MinimumLength = 10, ErrorMessage = "Caracteres inválidos.")]
    [Display(Name = "Descrição")]
    public string Description { get; set; }
    [Display(Name = "Local")]
    public string Andress { get; set; }

    public Animal() { }

    public Animal(int id, string name, string img, string url, bool adoption, string description, string andress) {
        Id = id;
        Name = name; 
        Img = img; 
        Url = url;
        Adoption = adoption;
        Description = description;
        Andress = andress;
    }
    public Animal(int id, string name, string img, string url, string description, string andress) {
        Id = id;
        Name = name;
        Img = img;
        Url = url;
        Adoption = true;
        Description = description;
        Andress = andress;
    }
}
