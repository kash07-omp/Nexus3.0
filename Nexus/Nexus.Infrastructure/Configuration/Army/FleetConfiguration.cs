namespace Nexus.Infrastructure.Configuration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Nexus.Domain.Entities;

    public class FleetConfiguration : IEntityTypeConfiguration<Fleet>
    {
        public void Configure(EntityTypeBuilder<Fleet> builder)
        {
            // Clave primaria
            builder.HasKey(f => f.Id);

            // Propiedades requeridas
            builder.Property(f => f.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(f => f.CoordinateX).IsRequired();
            builder.Property(f => f.CoordinateY).IsRequired();

            // Relación con User
            builder.HasOne(f => f.User)
                   .WithMany(u => u.Fleets)
                   .HasForeignKey(f => f.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Relación con SolarSystem
            builder.HasOne(f => f.SolarSystem)
                   .WithMany(s => s.Fleets)
                   .HasForeignKey(f => f.SolarSystemId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Relación con AdmiralCard
            builder.HasOne(f => f.AdmiralCard)
                   .WithMany()
                   .HasForeignKey(f => f.AdmiralCardId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Relación con FleetShips
            builder.HasMany(f => f.FleetShips)
                   .WithOne(fs => fs.Fleet)
                   .HasForeignKey(fs => fs.FleetId);
        }
    }
}
