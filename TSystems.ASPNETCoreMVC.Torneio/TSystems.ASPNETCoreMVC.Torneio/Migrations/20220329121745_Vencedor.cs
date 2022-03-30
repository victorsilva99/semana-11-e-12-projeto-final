using Microsoft.EntityFrameworkCore.Migrations;

namespace TSystems.ASPNETCoreMVC.Torneio.Migrations
{
    public partial class Vencedor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vencedor",
                columns: table => new
                {
                    VencedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChampionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vencedor", x => x.VencedorId);
                    table.ForeignKey(
                        name: "FK_Vencedor_Champion_ChampionId",
                        column: x => x.ChampionId,
                        principalTable: "Champion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vencedor_ChampionId",
                table: "Vencedor",
                column: "ChampionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vencedor");
        }
    }
}
