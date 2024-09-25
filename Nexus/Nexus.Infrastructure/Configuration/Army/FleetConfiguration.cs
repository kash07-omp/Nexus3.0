using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

public class FleetConfiguration : IEntityTypeConfiguration<Fleet>
{
    public void Configure(EntityTypeBuilder<Fleet> builder)
    {
        builder.HasKey(f => f.Id);

        builder.Property(f => f.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(f => f.CoordinateX).IsRequired();
        builder.Property(f => f.CoordinateY).IsRequired();

        builder.HasOne(f => f.User)
            .WithMany(u => u.Fleets)
            .HasForeignKey(f => f.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(f => f.AdmiralCard)
            .WithMany()
            .HasForeignKey(f => f.AdmiralCardId)
            .OnDelete(DeleteBehavior.SetNull);

        builder.HasMany(f => f.FleetShips)
            .WithOne(fs => fs.Fleet)
            .HasForeignKey(fs => fs.FleetId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.ToTable("Fleets");
    }
}
