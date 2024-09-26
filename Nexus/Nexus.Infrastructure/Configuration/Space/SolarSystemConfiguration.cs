namespace Nexus.Infrastructure.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Nexus.Domain.Entities;

    public class SolarSystemConfiguration : IEntityTypeConfiguration<SolarSystem>
    {
        public void Configure(EntityTypeBuilder<SolarSystem> builder)
        {
            // Clave primaria
            builder.HasKey(ss => ss.Id);

            // Propiedades
            builder.Property(ss => ss.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(ss => ss.GridSizeX).IsRequired();
            builder.Property(ss => ss.GridSizeY).IsRequired();

            // Relaciones
            builder.HasMany(ss => ss.Planets)
                   .WithOne(p => p.SolarSystem)
                   .HasForeignKey(p => p.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ss => ss.Fleets)
                   .WithOne(f => f.SolarSystem)
                   .HasForeignKey(f => f.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ss => ss.AsteroidFields)
                   .WithOne(a => a.SolarSystem)
                   .HasForeignKey(a => a.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(ss => ss.JumpGates)
                   .WithOne(j => j.SolarSystem)
                   .HasForeignKey(j => j.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
