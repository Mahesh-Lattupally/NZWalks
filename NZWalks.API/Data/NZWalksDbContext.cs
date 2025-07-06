using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions<NZWalksDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Data for difficulties
            var difficulties = new List<Difficulty>
            {
                new Difficulty
                {
                    Id = Guid.Parse("4c1c803b-205b-4da1-98fb-d3ece044b7f5"),
                    Name = "Easy"
                },
                new Difficulty
                {
                    Id = Guid.Parse("ad00f16c-69e9-41f6-bc1e-924d2dbbe52a"),
                    Name = "Medium"
                },
                new Difficulty
                {
                    Id = Guid.Parse("18a21bc0-9507-4665-8286-a218a8f79320"),
                    Name = "Hard"
                }
            };

            // Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            // Seed Data for regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("45d29a9c-3faa-47c1-8be4-2e0d6e4e0e34"),
                    Code = "AKL",
                    Name = "Auckland",
                    RegionImageUrl = "https://images.app.goo.gl/2cGwTsEPehnAJMLp7"
                },
                new Region
                {
                    Id = Guid.Parse("7cebc750-6f2c-4e49-ab04-f9d07303cc7d"),
                    Code = "WLG",
                    Name = "Wellingtown",
                    RegionImageUrl = "https://images.app.goo.gl/SbyGgmxzdswDkMPe6"
                },
                new Region
                {
                    Id = Guid.Parse("1fa662ba-fec9-4688-a791-a51abfe46636"),
                    Code = "CC",
                    Name = "Christchurch",
                    RegionImageUrl = "https://images.app.goo.gl/9UjWkwGkQTfSSoj18"
                },
                new Region
                {
                    Id = Guid.Parse("22595f86-fcc7-48db-a8a4-4c71e1d71a1c"),
                    Code = "STL",
                    Name = "Southland",
                    RegionImageUrl = "https://images.app.goo.gl/Jy7TLKwa5wgQtUneA"
                },
                new Region
                {
                    Id = Guid.Parse("854434c7-eebc-42ae-b045-57a583cd7e10"),
                    Code = "BOP",
                    Name = "Bay Of Plenty",
                    RegionImageUrl = "https://images.app.goo.gl/mGiWkWDenNQ8eHEH6"
                },
                new Region
                {
                    Id = Guid.Parse("14bb6474-98af-4af9-82f3-b0f0ea032151"),
                    Code = "Northland",
                    Name = "NTL",
                    RegionImageUrl = "https://images.app.goo.gl/o4ATMn4Dotz5AH7n8"
                },
                new Region
                {
                    Id = Guid.Parse("edf6f527-0338-4cce-a920-13cc51e8fc8d"),
                    Code = "Nelson",
                    Name = "NSN",
                    RegionImageUrl = "https://images.app.goo.gl/9F8Ki6uD6swa1EJR7"
                }
            };

            //Seed regions to the database
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
