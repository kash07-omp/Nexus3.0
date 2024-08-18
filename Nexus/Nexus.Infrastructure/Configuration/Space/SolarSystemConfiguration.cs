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

            builder.ToTable("SolarSystems");
        }
    }
}
