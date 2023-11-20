using AdoteAquiAppWeb.Interfaces;
using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Services;
public class AnimalsServices : IAnimalsServices {

    public AnimalsServices() => LoadAnimals();
    private IList<Animal> _animals;

    public IList<Animal> AllAnimals() => _animals;

    public void LoadAnimals() {
        _animals = new List<Animal>() {
        new Animal(1,"Biscoito", "/images/Biscoito.jpg", "https://www.amigonaosecompra.com.br/pets/biscoito-rio-de-janeiro-rio-de-janeiro-macho-b58cdfc2-22fe-4085-a648-beb624d0b095", true, "Biscoito é muito divertido! Adora bolinhas e receber carinho! Um gatinho muito especial!", "Rio de Janeiro - Rio de janeiro"),
        new Animal(2,"BomBom", "/images/BomBom.jpg", "https://www.amigonaosecompra.com.br/pets/bombom-sao-paulo-sao-paulo-femea-46d35523-eb9f-4910-a131-b8d14ffe7792", true, "BOMBOM é outro doce de gatinha. Ama um colinho é ronronenta e muito carinhosa. Também é brincalhona e cheia de charme.", "São Paulo - São Paulo"),
        new Animal(3,"Eliana", "/images/Eliana.jpg", "https://www.amigonaosecompra.com.br/pets/filhotes-eliana-sao-paulo-sao-paulo-femea-3c2dbd0c-bcc4-4a77-a63b-bde1bca081e9", true, "Eliana é uma gatinha doce, adora brincar e ficar de grude.", "São Paulo - São Paulo"),
        new Animal(4,"Laila", "/images/Laila.jpg", "https://www.amigonaosecompra.com.br/pets/laila-sao-paulo-cotia-femea-76d68a50-e34b-4b5a-8ade-2723fda29cc5", true, "Fêmea com 1 ano e meio, porte pequeno, pesa 6 klilos,dócil, será castrada.", "Cotia - São Paulo"),
        new Animal(5,"Luigi", "/images/Luigi.jpeg", "https://www.amigonaosecompra.com.br/pets/luigi-sao-paulo-sao-paulo-macho-a2e42cf7-3a0a-4cbe-acd4-0c0f2a3054c3", true, "Luigi, carinhoso, brincalhãom, super ativo! mestiços de pit.", "São Paulo - São Paulo"),
        new Animal(6,"Mel", "/images/Mel.jpg", "https://www.amigonaosecompra.com.br/pets/mel-sao-paulo-sao-paulo-femea-709f8d93-5fae-44ee-b137-63075b44c004", true, "MEL é um doce de gatinha. Já dá para perceber isso por esse olharzinho, né. Ela é a mais comilona. Super curiosa e brincalhona, assim como os irmãozinhos.", "São Paulo - São Paulo"),
        new Animal(7,"Tufinho", "/images/Tufinho.jpeg", "https://www.amigonaosecompra.com.br/pets/tufinho-rio-de-janeiro-rio-de-janeiro-macho-52bce030-0f7a-4ed8-a319-c06fadf0c0bb", true, "Pense num cãozinho que nunca teve uma família ou um lar! Vivia acorrentado num quintal de uma acumuladora, exposto ao tempo! Tem apenas 3 aninhos mas já conheceu os horrores dos maus tratos!", "Rio de janeiro - Rio de janeiro"),
        new Animal(8,"Vitoria", "/images/Vitoria.jpeg", "https://www.amigonaosecompra.com.br/pets/vitoria-sao-paulo-sao-paulo-femea-4fa6b388-6319-4c86-aadb-38d5a5648d10", true, "3 meses de muita fofura, pesando 2,5kg, vai ficar porte pequeno pra médio, vermifugado, para lares 100% seguros.", "São Paulo - São Paulo"),
        };
    }
    //Add dora: https://www.amigonaosecompra.com.br/pets/dora-pernambuco-paulista-femea-a6f8b10f-f08e-4076-bf84-3cdc5bf08862
    //img /images/Dora.jpg
    //Gata Angorá, aproximadamente 4 meses, encontrada abandonada em um ponto de ônibus perto do Hotel Cupido. Muito curiosa e brincalhona. Está em um lar temporário de pouco espaço, com outros três gatos. Terá o pelo grande, cheio e macio.
    //Paulista, Pernambuco
    public Animal GetAnimal(int id)  => _animals.SingleOrDefault( animal => animal.Id == id);

    public void SetAnimal(Animal animal) {
        int nextId = _animals.Count > 0 ? _animals.Max(animal => animal.Id) : 0;
        animal.Id = nextId + 1;
        _animals.Add(animal);
    }

    public void AlterAnimal(Animal animal) {
        Animal modific = _animals.SingleOrDefault(item => item.Id == animal.Id);
        if (modific != null) {
            modific.Name = animal.Name;
            modific.Andress = animal.Andress;
            modific.Img = animal.Img;
            modific.Url = animal.Url;
            modific.Description = animal.Description;
        }

    }

    public void DeleteAnimal(int id) {
        Animal animalId = GetAnimal(id);
        _animals.Remove(animalId);
    }

}
