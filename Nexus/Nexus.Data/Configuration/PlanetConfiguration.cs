using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class PlanetConfiguration : EntityTypeConfiguration<Planet>
    {
        public PlanetConfiguration()
        {
            ToTable("Planets");
            HasKey(p => p.Id);

            HasMany(p => p.Regions)
                .WithOptional(r => r.Planet)
                .HasForeignKey(r => r.PlanetId);
        }
    }
}
