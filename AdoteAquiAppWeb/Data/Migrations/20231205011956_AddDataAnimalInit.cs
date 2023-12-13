using AdoteAquiAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoteAquiAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataAnimalInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new AdoteAquiDbContext();
            context.Animals.AddRange(InitDataAnimals());
            context.SaveChanges();
        }
        private IList<Animal> InitDataAnimals() {
            return new List<Animal>() {
                new Animal
                {
                    Name = "Biscoito",
                    Img = "/images/Biscoito.jpg",
                    Url = "https://www.amigonaosecompra.com.br/pets/biscoito-rio-de-janeiro-rio-de-janeiro-macho-b58cdfc2-22fe-4085-a648-beb624d0b095",
                    Adoption = true,
                    Description = "Biscoito é muito divertido! Adora bolinhas e receber carinho! Um gatinho muito especial!",
                    Andress = "Rio de Janeiro - Rio de janeiro"
                },
                new Animal
                {
                    Name = "BomBom",
                    Img = "/images/BomBom.jpg",
                    Url = "https://www.amigonaosecompra.com.br/pets/bombom-sao-paulo-sao-paulo-femea-46d35523-eb9f-4910-a131-b8d14ffe7792",
                    Adoption = true,
                    Description = "BOMBOM é outro doce de gatinha. Ama um colinho é ronronenta e muito carinhosa. Também é brincalhona e cheia de charme.",
                    Andress = "São Paulo - São Paulo"
                },
                new Animal
                {
                    Name = "Eliana",
                    Img = "/images/Eliana.jpg",
                    Url = "https://www.amigonaosecompra.com.br/pets/filhotes-eliana-sao-paulo-sao-paulo-femea-3c2dbd0c-bcc4-4a77-a63b-bde1bca081e9",
                    Adoption = true,
                    Description = "Eliana é uma gatinha doce, adora brincar e ficar de grude.",
                    Andress = "São Paulo - São Paulo"
                },
                new Animal
                {
                    Name = "Laila",
                    Img = "/images/Laila.jpg",
                    Url = "https://www.amigonaosecompra.com.br/pets/laila-sao-paulo-cotia-femea-76d68a50-e34b-4b5a-8ade-2723fda29cc5",
                    Adoption = true,
                    Description = "Fêmea com 1 ano e meio, porte pequeno, pesa 6 klilos, dócil, será castrada.",
                    Andress = "Cotia - São Paulo"
                },
                new Animal
                {
                    Name = "Luigi",
                    Img = "/images/Luigi.jpeg",
                    Url = "https://www.amigonaosecompra.com.br/pets/luigi-sao-paulo-sao-paulo-macho-a2e42cf7-3a0a-4cbe-acd4-0c0f2a3054c3",
                    Adoption = true,
                    Description = "Luigi, carinhoso, brincalhão, super ativo! Mestiços de pit.",
                    Andress = "São Paulo - São Paulo"
                },
                new Animal
                {
                    Name = "Mel",
                    Img = "/images/Mel.jpg",
                    Url = "https://www.amigonaosecompra.com.br/pets/mel-sao-paulo-sao-paulo-femea-709f8d93-5fae-44ee-b137-63075b44c004",
                    Adoption = true,
                    Description = "MEL é um doce de gatinha. Já dá para perceber isso por esse olharzinho, né. Ela é a mais comilona. Super curiosa e brincalhona, assim como os irmãozinhos.",
                    Andress = "São Paulo - São Paulo"
                },
                new Animal
                {
                    Name = "Tufinho",
                    Img = "/images/Tufinho.jpeg",
                    Url = "https://www.amigonaosecompra.com.br/pets/tufinho-rio-de-janeiro-rio-de-janeiro-macho-52bce030-0f7a-4ed8-a319-c06fadf0c0bb",
                    Adoption = true,
                    Description = "Pense num cãozinho que nunca teve uma família ou um lar! Vivia acorrentado num quintal de uma acumuladora, exposto ao tempo! Tem apenas 3 aninhos mas já conheceu os horrores dos maus tratos!",
                    Andress = "Rio de Janeiro - Rio de janeiro"
                },
                new Animal
                {
                    Name = "Vitoria",
                    Img = "/images/Vitoria.jpeg",
                    Url = "https://www.amigonaosecompra.com.br/pets/vitoria-sao-paulo-sao-paulo-femea-4fa6b388-6319-4c86-aadb-38d5a5648d10",
                    Adoption = true,
                    Description = "3 meses de muita fofura, pesando 2,5kg, vai ficar porte pequeno pra médio, vermifugado, para lares 100% seguros.",
                    Andress = "São Paulo - São Paulo"
                }
            };
        }
    }
}
