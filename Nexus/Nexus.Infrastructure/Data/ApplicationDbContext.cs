using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
using Nexus.Infrastructure.Configuration;

namespace Nexus.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<CardBonus> CardBonus { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Mine> Mines { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<RegionStructure> RegionStructures { get; set; }
        public DbSet<SolarSystem> SolarSystems { get; set; }
        public DbSet<RegionResource> RegionResources { get; set; }
        public DbSet<Fleet> Fleets { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<FleetShip> FleetShips { get; set; }
        public DbSet<FleetMovementPath> FleetMovementPaths { get; set; }
        public DbSet<ShipBuildQueue> ShipBuildQueues { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new ResourceConfiguration());
            modelBuilder.ApplyConfiguration(new SolarSystemConfiguration());
            modelBuilder.ApplyConfiguration(new PlanetConfiguration());
            modelBuilder.ApplyConfiguration(new RegionConfiguration());
            modelBuilder.ApplyConfiguration(new StructureConfiguration());
            modelBuilder.ApplyConfiguration(new MineConfiguration());
            modelBuilder.ApplyConfiguration(new RegionStructureConfiguration());
            modelBuilder.ApplyConfiguration(new RegionResourceConfiguration());
            modelBuilder.ApplyConfiguration(new ResearchConfiguration());
            modelBuilder.ApplyConfiguration(new StructureRequiredStructureConfiguration());
            modelBuilder.ApplyConfiguration(new StructureRequiredResearchConfiguration());
            modelBuilder.ApplyConfiguration(new ResearchRequiredStructureConfiguration());
            modelBuilder.ApplyConfiguration(new ResearchRequiredResearchConfiguration());
            modelBuilder.ApplyConfiguration(new CardConfiguration());
            modelBuilder.ApplyConfiguration(new CardBonusConfiguration());
            modelBuilder.ApplyConfiguration(new ShipConfiguration());
            modelBuilder.ApplyConfiguration(new FleetConfiguration());
            modelBuilder.ApplyConfiguration(new FleetShipConfiguration());
            modelBuilder.ApplyConfiguration(new ShipBuildQueueConfiguration());

            modelBuilder.Entity<User>()
                .HasMany(u => u.Cards)
                .WithMany(c => c.Users)
                .UsingEntity(j => j.ToTable("UserCards"));

            SeedData.Seed(modelBuilder);
        }
    }
}
