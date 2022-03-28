using Microsoft.EntityFrameworkCore.Migrations;

namespace TSystems.ASPNETCoreMVC.Torneio.Migrations
{
    public partial class PopularChampions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Champion(Nome, Idade, Habilidades, TotalDeLutas, Vitorias, Derrotas)" +
             "VALUES ('Ashe', 21, 4, 0, 0, 0)," +
                    "('Azir', 39, 4, 0, 0, 0)," +
                    "('Ezreal', 21, 4, 0, 0, 0)," +
                    "('Jarvan', 41, 4, 0, 0, 0)," +
                    "('Jax', 38, 4, 0, 0, 0)," +
                    "('Jayce', 27, 4, 0, 0, 0)," +
                    "('Jinx', 20, 4, 0, 0, 0)," +
                    "('Kassadin', 37, 4, 0, 0, 0)," +
                    "('Kassandra', 39, 4, 0, 0, 0)," +
                    "('Kindred', 40, 4, 0, 0, 0)," +
                    "('Lee Sin', 37, 4, 0, 0, 0)," +
                    "('Rengar', 55, 4, 0, 0, 0)," +
                    "('Shaco', 22, 4, 0, 0, 0)," +
                    "('Shyvana', 35, 4, 0, 0, 0)," +
                    "('Sona', 21, 4, 0, 0, 0)," +
                    "('Thresh', 78, 4, 0, 0, 0)," +
                    "('Twisted Fate', 24, 4, 0, 0, 0)," +
                    "('Vladimir', 27, 4, 0, 0, 0)," +
                    "('Yasuo', 28, 4, 0, 0, 0)," +
                    "('Zed', 38, 4, 0, 0, 0)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
