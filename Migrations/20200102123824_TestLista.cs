using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class TestLista : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Reducere_ReducereID",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ReducereID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ReducereID",
                table: "Client");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Reducere",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reducere_ClientID",
                table: "Reducere",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Reducere_Client_ClientID",
                table: "Reducere",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reducere_Client_ClientID",
                table: "Reducere");

            migrationBuilder.DropIndex(
                name: "IX_Reducere_ClientID",
                table: "Reducere");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Reducere");

            migrationBuilder.AddColumn<int>(
                name: "ReducereID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ReducereID",
                table: "Client",
                column: "ReducereID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Reducere_ReducereID",
                table: "Client",
                column: "ReducereID",
                principalTable: "Reducere",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
