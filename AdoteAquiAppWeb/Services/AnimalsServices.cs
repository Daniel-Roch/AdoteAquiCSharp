using AdoteAquiAppWeb.Models;

namespace AdoteAquiAppWeb.Services;
public class AnimalsServices {
    public IList<Animal> AllAnimals() {
        return new List<Animal>() {
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
    public Animal getAnimal(int id)  => AllAnimals().SingleOrDefault( animal => animal.Id == id);
}
