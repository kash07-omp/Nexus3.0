using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(r => r.Id);

            // Configuración de la propiedad IsColonized
            builder.Property(r => r.IsColonized)
                   .IsRequired();

            // Configuración de la propiedad TotalEnergy
            builder.Property(r => r.TotalEnergy)
                   .HasDefaultValue(0)
                   .IsRequired();

            // Configuración de la propiedad AvailableEnergy
            builder.Property(r => r.AvailableEnergy)
                   .HasDefaultValue(0)
                   .IsRequired();

            // Configuración de la relación opcional con Planet
            builder.HasOne(r => r.Planet)
                   .WithMany(p => p.Regions)
                   .HasForeignKey(r => r.PlanetId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la relación opcional con User
            builder.HasOne(r => r.User)
                   .WithMany(u => u.Regions)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Configuración de la relación uno-a-muchos con RegionStructures
            builder.HasMany(r => r.RegionStructures)
                   .WithOne(rs => rs.Region)
                   .HasForeignKey(rs => rs.RegionId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la tabla
            builder.ToTable("Regions");
        }
    }
}
