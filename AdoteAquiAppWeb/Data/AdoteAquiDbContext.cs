using AdoteAquiAppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AdoteAquiAppWeb.Data;
public class AdoteAquiDbContext : DbContext {

    public DbSet<Animal> Animals { get; set; }
    public DbSet<Breed> Breeds { get; set; }

    public AdoteAquiDbContext(){ }

    public AdoteAquiDbContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        var config = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var stringCon = config.GetConnectionString("StringConnection");

        optionsBuilder.UseSqlServer(stringCon);
    }

}
