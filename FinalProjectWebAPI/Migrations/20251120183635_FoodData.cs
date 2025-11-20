using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProjectWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class FoodData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Fats = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");
        }
    }
}
