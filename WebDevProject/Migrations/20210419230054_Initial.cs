using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDevProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "RatingId", "Year" },
                values: new object[] { 1, "Madden NFL 20", "E", 2019 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "RatingId", "Year" },
                values: new object[] { 2, "Fortnite", "T", 2017 });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "Name", "RatingId", "Year" },
                values: new object[] { 3, "Call of Duty: Black Ops 4", "M", 2018 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
