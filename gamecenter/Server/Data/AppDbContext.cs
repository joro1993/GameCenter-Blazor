using gamecenter.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace gamecenter.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamesGenres>().HasKey(x => new { x.GameId, x.GenresId});
            modelBuilder.Entity<GamesPeople>().HasKey(x => new { x.GameId, x.PersonId});

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<GamesPeople> GamesPeople { get; set; }
        public DbSet<GamesGenres> GamesGenres { get; set; }
    }
}