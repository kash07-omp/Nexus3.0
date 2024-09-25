using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class FleetShipConfiguration : IEntityTypeConfiguration<FleetShip>
    {
        public void Configure(EntityTypeBuilder<FleetShip> builder)
        {
            builder.HasKey(fs => new { fs.FleetId, fs.ShipId });

            builder.HasOne(fs => fs.Fleet)
                .WithMany(f => f.FleetShips)
                .HasForeignKey(fs => fs.FleetId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(fs => fs.Ship)
                .WithMany()
                .HasForeignKey(fs => fs.ShipId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(fs => fs.Quantity)
                .IsRequired();

            builder.ToTable("FleetShips");
        }
    }
}