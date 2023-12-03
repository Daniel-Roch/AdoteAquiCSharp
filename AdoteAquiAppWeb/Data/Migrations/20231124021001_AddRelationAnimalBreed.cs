using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoteAquiAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationAnimalBreed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BreedId",
                table: "TBL_ANIMAL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_ANIMAL_BreedId",
                table: "TBL_ANIMAL",
                column: "BreedId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_ANIMAL_Breeds_BreedId",
                table: "TBL_ANIMAL",
                column: "BreedId",
                principalTable: "Breeds",
                principalColumn: "BreedId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_ANIMAL_Breeds_BreedId",
                table: "TBL_ANIMAL");

            migrationBuilder.DropIndex(
                name: "IX_TBL_ANIMAL_BreedId",
                table: "TBL_ANIMAL");

            migrationBuilder.DropColumn(
                name: "BreedId",
                table: "TBL_ANIMAL");
        }
    }
}
