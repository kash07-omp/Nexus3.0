using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.CoordinateX).IsRequired();
            builder.Property(p => p.CoordinateY).IsRequired();

            builder.HasMany(p => p.Regions)
                   .WithOne(r => r.Planet)
                   .HasForeignKey(r => r.PlanetId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(p => p.SolarSystem)
                   .WithMany(s => s.Planets)
                   .HasForeignKey(p => p.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Planets");
        }
    }
}
