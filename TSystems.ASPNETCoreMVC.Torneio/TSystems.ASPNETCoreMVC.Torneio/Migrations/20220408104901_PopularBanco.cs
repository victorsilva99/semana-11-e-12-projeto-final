using Microsoft.EntityFrameworkCore.Migrations;

namespace TSystems.ASPNETCoreMVC.Torneio.Migrations
{
    public partial class PopularBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Champion(Nome, Idade, Habilidades, TotalDeLutas, Vitorias, Derrotas)" +
             "VALUES ('Ashe', 21, 4, 4, 3, 1)," +
                    "('Azir', 39, 5, 8, 3, 5)," +
                    "('Ezreal', 21, 6, 5, 3, 2)," +
                    "('Jarvan', 41, 3, 6, 4, 2)," +
                    "('Jax', 38, 8, 7, 3, 4)," +
                    "('Jayce', 27, 4, 6, 3, 3)," +
                    "('Jinx', 20, 4, 7, 3, 4)," +
                    "('Kassadin', 37, 11, 5, 3, 2)," +
                    "('Kassandra', 39, 3, 7, 3, 4)," +
                    "('Kindred', 40, 5, 4, 2, 2)," +
                    "('Lee Sin', 37, 9, 8, 5, 3)," +
                    "('Rengar', 55, 5, 8, 7, 1)," +
                    "('Shaco', 22, 6, 5, 4, 1)," +
                    "('Shyvana', 35, 4, 4, 2, 2)," +
                    "('Sona', 21, 4, 7, 6, 1)," +
                    "('Thresh', 78, 5, 5, 3, 2)," +
                    "('Twisted Fate', 24, 7, 3, 2, 1)," +
                    "('Vladimir', 27, 8, 5, 3, 2)," +
                    "('Yasuo', 28, 9, 9, 8, 1)," +
                    "('Zed', 38, 4, 9, 9, 0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
