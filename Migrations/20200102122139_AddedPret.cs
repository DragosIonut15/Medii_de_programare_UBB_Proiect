using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class AddedPret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Pret",
                table: "Bilet",
                type: "decimal(6, 2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Bilet");
        }
    }
}
