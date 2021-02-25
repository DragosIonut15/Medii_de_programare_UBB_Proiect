using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_Nohai.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bilet",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EchipaGazda = table.Column<string>(nullable: true),
                    EchipaOaspete = table.Column<string>(nullable: true),
                    DataJocului = table.Column<DateTime>(nullable: false),
                    BileteCumparate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilet");
        }
    }
}
