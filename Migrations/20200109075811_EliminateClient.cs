using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class EliminateClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Client_ReducereID",
                table: "Client");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ReducereID",
                table: "Client",
                column: "ReducereID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Client_ReducereID",
                table: "Client");

            migrationBuilder.CreateIndex(
                name: "IX_Client_ReducereID",
                table: "Client",
                column: "ReducereID",
                unique: true);
        }
    }
}
