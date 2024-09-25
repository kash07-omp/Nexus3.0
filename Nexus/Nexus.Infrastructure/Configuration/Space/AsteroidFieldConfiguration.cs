using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class AsteroidFieldConfiguration : IEntityTypeConfiguration<AsteroidField>
    {
        public void Configure(EntityTypeBuilder<AsteroidField> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.CoordinateX).IsRequired();
            builder.Property(a => a.CoordinateY).IsRequired();

            builder.HasOne(a => a.SolarSystem)
                   .WithMany()
                   .HasForeignKey(a => a.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("AsteroidFields");
        }
    }
}
