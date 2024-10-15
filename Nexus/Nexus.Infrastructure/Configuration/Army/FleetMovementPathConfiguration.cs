namespace Nexus.Infrastructure.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Nexus.Domain.Entities;

    public class FleetMovementPathConfiguration : IEntityTypeConfiguration<FleetMovementPath>
    {
        public void Configure(EntityTypeBuilder<FleetMovementPath> builder)
        {
            // Clave primaria
            builder.HasKey(fmp => fmp.Id);

            // Propiedades requeridas
            builder.Property(fmp => fmp.FromX).IsRequired();
            builder.Property(fmp => fmp.FromY).IsRequired();
            builder.Property(fmp => fmp.ToX).IsRequired();
            builder.Property(fmp => fmp.ToY).IsRequired();
            builder.Property(fmp => fmp.ArrivalTime).IsRequired();
            builder.Property(fmp => fmp.DepartureTime).IsRequired();
        }
    }
}