using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class JumpGateConfiguration : IEntityTypeConfiguration<JumpGate>
    {
        public void Configure(EntityTypeBuilder<JumpGate> builder)
        {
            builder.HasKey(j => j.Id);

            builder.Property(j => j.CoordinateX).IsRequired();
            builder.Property(j => j.CoordinateY).IsRequired();

            builder.HasOne(j => j.SolarSystem)
                   .WithMany()
                   .HasForeignKey(j => j.SolarSystemId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("JumpGates");
        }
    }
}