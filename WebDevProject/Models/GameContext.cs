using Microsoft.EntityFrameworkCore;

namespace WebDevProject.Models
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options) : base(options)
        { }
        public DbSet<Game> Games { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Rating>().HasData(
                 new Rating { RatingId = "EC", Name = "Early Childhood" },
                 new Rating { RatingId = "E", Name = "Everyone" },
                 new Rating { RatingId = "T", Name = "Teen" },
                 new Rating { RatingId = "M", Name = "Mature" },
                 new Rating { RatingId = "RP", Name = "Rating Pending" }
            );

            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    GameId = 1,
                    Name = "Madden NFL 20",
                    Year = 2019,
                    RatingId = "E"
                },
                new Game
                {
                    GameId = 2,
                    Name = "Fortnite",
                    Year = 2017,
                    RatingId = "T"
                },
                new Game
                {
                    GameId = 3,
                    Name = "Call of Duty: Black Ops 4",
                    Year = 2018,
                    RatingId = "M"
                },
                new Game
                {
                    GameId = 4,
                    Name = "NBA 2K21",
                    Year = 2020,
                    RatingId = "E"
                },
                new Game
                {
                    GameId = 5,
                    Name = "Rocket League",
                    Year = 2015,
                    RatingId = "E"
                },
                new Game
                {
                    GameId = 6,
                    Name = "Apex Legends",
                    Year = 2019,
                    RatingId = "T"
                }
            );
        }
    }
}
