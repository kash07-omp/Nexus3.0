using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class ShipBuildQueueConfiguration : IEntityTypeConfiguration<ShipBuildQueue>
    {
        public void Configure(EntityTypeBuilder<ShipBuildQueue> builder)
        {
            // Set the primary key
            builder.HasKey(sbq => sbq.Id);

            // Define the relationships
            builder.HasOne(sbq => sbq.Region)
                .WithMany()
                .HasForeignKey(sbq => sbq.RegionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sbq => sbq.Fleet)
                .WithMany()
                .HasForeignKey(sbq => sbq.FleetId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(sbq => sbq.Ship)
                .WithMany()
                .HasForeignKey(sbq => sbq.ShipId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure CompletionTime as required
            builder.Property(sbq => sbq.CompletionTime)
                .IsRequired();
        }
    }
}