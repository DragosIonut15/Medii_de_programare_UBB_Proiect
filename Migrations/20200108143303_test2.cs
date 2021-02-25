using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet");

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet",
                column: "ClientID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet");

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet",
                column: "ClientID",
                unique: true);
        }
    }
}
