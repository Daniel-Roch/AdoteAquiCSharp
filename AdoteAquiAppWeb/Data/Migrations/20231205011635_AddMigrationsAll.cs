using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoteAquiAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddMigrationsAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Breeds",
                columns: table => new
                {
                    BreedId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Breeds", x => x.BreedId);
                });

            migrationBuilder.CreateTable(
                name: "TBL_ANIMAL",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    Img = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    Adoption = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Andress = table.Column<string>(type: "TEXT", nullable: false),
                    BreedId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_ANIMAL", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBL_ANIMAL_Breeds_BreedId",
                        column: x => x.BreedId,
                        principalTable: "Breeds",
                        principalColumn: "BreedId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBL_ANIMAL_BreedId",
                table: "TBL_ANIMAL",
                column: "BreedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_ANIMAL");

            migrationBuilder.DropTable(
                name: "Breeds");
        }
    }
}
