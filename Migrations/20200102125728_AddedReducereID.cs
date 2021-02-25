using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class AddedReducereID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReducereID",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Client_ReducereID",
                table: "Client",
                column: "ReducereID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Reducere_ReducereID",
                table: "Client",
                column: "ReducereID",
                principalTable: "Reducere",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
