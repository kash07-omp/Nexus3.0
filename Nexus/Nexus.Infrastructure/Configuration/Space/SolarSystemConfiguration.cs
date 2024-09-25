using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class SolarSystemConfiguration : IEntityTypeConfiguration<SolarSystem>
    {
        public void Configure(EntityTypeBuilder<SolarSystem> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasMany(s => s.Planets)
                   .WithOne(p => p.SolarSystem)
                   .HasForeignKey(p => p.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.Fleets)
                   .WithOne(f => f.SolarSystem)
                   .HasForeignKey(f => f.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.AsteroidFields)
                   .WithOne(a => a.SolarSystem)
                   .HasForeignKey(a => a.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(s => s.JumpGates)
                   .WithOne(j => j.SolarSystem)
                   .HasForeignKey(j => j.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("SolarSystems");
        }
    }
}