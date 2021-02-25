using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class DeletedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Client_ClientID",
                table: "Bilet");

            migrationBuilder.DropForeignKey(
                name: "FK_Reducere_Client_ClientID",
                table: "Reducere");

            migrationBuilder.DropIndex(
                name: "IX_Reducere_ClientID",
                table: "Reducere");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Reducere");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Bilet");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Reducere",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Bilet",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reducere_ClientID",
                table: "Reducere",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet",
                column: "ClientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilet_Client_ClientID",
                table: "Bilet",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reducere_Client_ClientID",
                table: "Reducere",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
