using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS_EFCore_CodeFIrst.Migrations
{
    public partial class tableperhierarchyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductionUnit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<int>(type: "int", nullable: true),
                    Collection = table.Column<int>(type: "int", nullable: true),
                    NoOfSeasons = table.Column<int>(type: "int", nullable: true),
                    EpisodsPerSeason = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductionUnit", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ProductionUnit",
                columns: new[] { "Id", "Category", "Collection", "Discriminator", "Duration", "Name", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, "Spy", 300000, "Movies", 120, "Dr.No", 1963 },
                    { 2, "Comedy", 60000, "Movies", 180, "Golmal", 1976 }
                });

            migrationBuilder.InsertData(
                table: "ProductionUnit",
                columns: new[] { "Id", "Discriminator", "EpisodsPerSeason", "Name", "NoOfSeasons", "ReleaseYear" },
                values: new object[,]
                {
                    { 3, "WebSeries", 70, "Ramayan", 2, 1986 },
                    { 4, "WebSeries", 70, "CID", 50, 1998 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductionUnit");
        }
    }
}
