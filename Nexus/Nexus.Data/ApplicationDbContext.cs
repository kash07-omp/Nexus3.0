using Microsoft.EntityFrameworkCore;
using Nexus.Model;
using System.Reflection;

namespace Nexus.Data
{

    public class ApplicationDbContext : DbContext
    {
        //public ApplicationDbContext() : base("NexusEntities")
        //{
        //}
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Planet> Planets { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Structure> Structures { get; set; }
        public DbSet<Mine> Mines { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<RegionStructure> RegionStructures { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Eliminar la convención de pluralización de nombres de tablas
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        //    // Añadir configuraciones específicas para cada entidad
        //    modelBuilder.Configurations.Add(new PlanetConfiguration());
        //    modelBuilder.Configurations.Add(new RegionConfiguration());
        //    modelBuilder.Configurations.Add(new UserConfiguration());
        //    modelBuilder.Configurations.Add(new StructureConfiguration());
        //    modelBuilder.Configurations.Add(new MineConfiguration());
        //    modelBuilder.Configurations.Add(new ResourceConfiguration());
        //    modelBuilder.Configurations.Add(new RegionStructureConfiguration());
        //}
    }

}
