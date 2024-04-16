using ChooseFreeGame.Logic.Entities.Internal;
using Microsoft.EntityFrameworkCore;

namespace ChooseFreeGame.Logic.Repositories
{
    public class SavedGameRepository : DbContext
    {
        public DbSet<SavedGame> SavedGames { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("datasource=127.0.0.1;port=3306;username=root;password=planetynas123;database=choose_free_game");
        }
    }
}