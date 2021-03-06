using Microsoft.EntityFrameworkCore;

namespace ParksAPI2.Models
{
  public class ParksAPI2Context : DbContext
  {
    public ParksAPI2Context(DbContextOptions<ParksAPI2Context> options)
        :base(options)
        {

        }
        public DbSet<Park> Parks {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
          .HasData(
                            new Park { ParkId = 1, ParkName = "Drake Park", Size = "Medium", Description="Music, river, events" },
                new Park { ParkId = 2, ParkName = "Esther Short", Size = "Medium", Description="Gazebos, playground" },
                new Park { ParkId = 3, ParkName = "Mount Tabor", Size = "Large", Description="Music, Dancing, Trees" },
                new Park { ParkId = 4, ParkName = "Cottonwood", Size = "Small", Description="Beach, pavilions, grills" }
          );
        }
  }
}