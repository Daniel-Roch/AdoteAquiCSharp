using AdoteAquiAppWeb.Data;
using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Services.Data;
public class AnimalsServices : IAnimalsServices {

    private AdoteAquiDbContext _context;

    public AnimalsServices(AdoteAquiDbContext context) {
        _context = context;
    }

    public IList<Animal> AllAnimals() {
        return _context.Animals.ToList();
    }

    public void AlterAnimal(Animal animal) {
        Animal modific = GetAnimal(animal.Id);
        if (modific != null) {
            modific.Name = animal.Name;
            modific.Andress = animal.Andress;
            modific.Img = animal.Img;
            modific.Url = animal.Url;
            modific.Description = animal.Description;
            modific.BreedId = animal.BreedId;
            _context.SaveChanges();
        }
    }

    public void DeleteAnimal(int id) {
        Animal getAnimal = GetAnimal(id);
        _context.Animals.Remove(getAnimal);
        _context.SaveChanges();
    }

    public Animal GetAnimal(int id) {
        return _context.Animals.SingleOrDefault(animal => animal.Id == id);
    }

    public void SetAnimal(Animal animal) {
        _context.Animals.Add(animal);
        _context.SaveChanges();
    }
    public IList<Breed> AllBreeds() => _context.Breeds.ToList();
    public Breed GetBreed(int id) => _context.Breeds.SingleOrDefault(breed => breed.BreedId == id);
}
