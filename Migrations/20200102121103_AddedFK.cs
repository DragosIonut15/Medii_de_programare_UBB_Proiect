using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class AddedFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReducereID",
                table: "Client",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Bilet",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ReducereID",
                table: "Client",
                column: "ReducereID");

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
                name: "FK_Client_Reducere_ReducereID",
                table: "Client",
                column: "ReducereID",
                principalTable: "Reducere",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Client_ClientID",
                table: "Bilet");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_Reducere_ReducereID",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Client_ReducereID",
                table: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "ReducereID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Bilet");
        }
    }
}
