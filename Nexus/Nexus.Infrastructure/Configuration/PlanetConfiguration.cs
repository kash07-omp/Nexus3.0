using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class PlanetConfiguration : IEntityTypeConfiguration<Planet>
    {
        public void Configure(EntityTypeBuilder<Planet> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(p => p.Id);

            // Configuración de la relación uno-a-muchos con Regions
            builder.HasMany(p => p.Regions)
                   .WithOne(r => r.Planet)
                   .HasForeignKey(r => r.PlanetId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la tabla
            builder.ToTable("Planets");
        }
    }
}
