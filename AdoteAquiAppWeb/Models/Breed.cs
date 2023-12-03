namespace AdoteAquiAppWeb.Models;
public class Breed {
    public int BreedId { get; set; }
    public string Name { get; set; }
    public ICollection<Animal> Animals { get; set; }
}

