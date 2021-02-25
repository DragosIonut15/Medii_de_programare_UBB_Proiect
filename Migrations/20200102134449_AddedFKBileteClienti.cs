using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class AddedFKBileteClienti : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Bilet",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet",
                column: "ClientID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilet_Client_ClientID",
                table: "Bilet",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilet_Client_ClientID",
                table: "Bilet");

            migrationBuilder.DropIndex(
                name: "IX_Bilet_ClientID",
                table: "Bilet");

            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Bilet");
        }
    }
}
