using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class ShipConfiguration : IEntityTypeConfiguration<Ship>
    {
        public void Configure(EntityTypeBuilder<Ship> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(s => s.Function)
                .IsRequired();

            builder.Property(s => s.Strenght).IsRequired();
            builder.Property(s => s.Shields).IsRequired();
            builder.Property(s => s.Health).IsRequired();
            builder.Property(s => s.Maniobrability).IsRequired();
            builder.Property(s => s.Ability).IsRequired();
            builder.Property(s => s.Speed).IsRequired();
            builder.Property(s => s.CargoCapacity).IsRequired();

            // Costes
            builder.Property(s => s.MineralsCost).IsRequired();
            builder.Property(s => s.MicrochipsCost).IsRequired();
            builder.Property(s => s.HydrogenCost).IsRequired();
            builder.Property(s => s.CreditsCost).IsRequired();

            builder.ToTable("Ships");
        }
    }
}
