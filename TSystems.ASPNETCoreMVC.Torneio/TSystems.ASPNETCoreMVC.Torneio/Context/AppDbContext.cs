using TSystems.ASPNETCoreMVC.Torneio.Models;
using Microsoft.EntityFrameworkCore;

namespace TSystems.ASPNETCoreMVC.Torneio.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ChampionModel> Champion { get; set; }

    }
}
