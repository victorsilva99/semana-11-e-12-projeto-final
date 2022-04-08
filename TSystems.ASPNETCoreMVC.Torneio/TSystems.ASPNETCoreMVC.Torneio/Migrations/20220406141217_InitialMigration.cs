using Microsoft.EntityFrameworkCore.Migrations;

namespace TSystems.ASPNETCoreMVC.Torneio.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Champion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Habilidades = table.Column<int>(type: "int", nullable: false),
                    TotalDeLutas = table.Column<int>(type: "int", nullable: false),
                    Vitorias = table.Column<int>(type: "int", nullable: false),
                    Derrotas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Champion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VencedorModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionVencedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VencedorModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VencedorModel_Champion_ChampionVencedorId",
                        column: x => x.ChampionVencedorId,
                        principalTable: "Champion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VencedorModel_ChampionVencedorId",
                table: "VencedorModel",
                column: "ChampionVencedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VencedorModel");

            migrationBuilder.DropTable(
                name: "Champion");
        }
    }
}
