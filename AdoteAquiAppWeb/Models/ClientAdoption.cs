using System.ComponentModel.DataAnnotations;

namespace AdoteAquiAppWeb.Models;
public class ClientAdoption {

    public int ClientAdoptionId { get; set; }

    [Required(ErrorMessage = "Campo Nome obrigatório.")]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Caracteres inválidos.")]
    [Display(Name = "Nome")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Campo Email obrigatório.")]
    [StringLength(50, MinimumLength = 10, ErrorMessage = "Caracteres inválidos.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Campo Data de Nascimento obrigatório.")]
    [Display(Name = "Data de Nascimento")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime DateBirth { get; set; }

    public int Age => DateTime.Now.Year - DateBirth.Year;

    [Required(ErrorMessage = "Campo Descrição obrigatório.")]
    [Display(Name = "Descrição")]
    public string Descript { get; set; }

    public ClientAdoption() {}

    public ClientAdoption( int clietId, string name, string email, DateTime dateBirth, string descript) {
        ClientAdoptionId = clietId;
        Name = name;
        Email = email;
        DateBirth = dateBirth;
        Descript = descript;
    }
}
