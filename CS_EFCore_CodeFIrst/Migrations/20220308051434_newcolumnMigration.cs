using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS_EFCore_CodeFIrst.Migrations
{
    public partial class newcolumnMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WarrantyYrars",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WarrantyYrars",
                table: "Products");
        }
    }
}
