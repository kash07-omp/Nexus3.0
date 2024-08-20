﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Mine> Mines { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<RegionStructure> RegionStructures { get; set; }
        public DbSet<SolarSystem> SolarSystems { get; set; }
        public DbSet<RegionResource> RegionResources { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Llamar a la base es importante para Identity

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

            SeedData.Seed(modelBuilder);
        }
    }
}
