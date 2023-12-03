using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Interfaces;
public interface IAnimalsServices {
    IList<Animal> AllAnimals();
    Animal GetAnimal(int id);
    void SetAnimal(Animal animal);
    void AlterAnimal(Animal animal);
    void DeleteAnimal(int id);
    IList<Breed> AllBreeds();
}

