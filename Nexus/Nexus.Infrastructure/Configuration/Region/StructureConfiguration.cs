using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class StructureConfiguration : IEntityTypeConfiguration<Structure>
    {
        public void Configure(EntityTypeBuilder<Structure> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.Description)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(s => s.CanLevelUp)
                   .IsRequired();

            builder.Property(s => s.BaseMinerales)
                   .IsRequired();

            builder.Property(s => s.BaseChips)
                   .IsRequired();

            builder.Property(s => s.BaseHydrogen)
                   .IsRequired();

            builder.Property(s => s.BaseEnergy)
                   .IsRequired();

            builder.Property(s => s.BaseCredits)
                   .IsRequired();

            builder.HasOne(s => s.Mine)
                   .WithMany()
                   .HasForeignKey(s => s.MineId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("Structures");
        }
    }
}
