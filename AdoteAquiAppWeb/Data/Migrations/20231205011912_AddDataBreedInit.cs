using AdoteAquiAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoteAquiAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDataBreedInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new AdoteAquiDbContext();
            context.Breeds.AddRange(InitDataBreeds());
            context.SaveChanges();
        }

        private IList<Breed> InitDataBreeds() {
            return new List<Breed>() {
                new Breed(){ Name = "Viralata" },
                new Breed(){ Name = "Pastor Alemão" },
                new Breed(){ Name = "Siamês" },
                new Breed(){ Name = "Persa" },
                new Breed(){ Name = "Maine Coon" },
                new Breed(){ Name = "Beagle" }
            };
        }
    }
}
