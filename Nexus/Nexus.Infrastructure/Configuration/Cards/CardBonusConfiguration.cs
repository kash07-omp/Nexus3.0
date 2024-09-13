using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class CardBonusConfiguration : IEntityTypeConfiguration<CardBonus>
    {
        public void Configure(EntityTypeBuilder<CardBonus> builder)
        {
            builder.HasKey(cb => cb.Id);

            builder.Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(cb => cb.Percentage)
                .IsRequired();

            builder.Property(cb => cb.BonusType)
                .IsRequired();

            builder.HasOne(cb => cb.Structure)
                .WithMany()
                .HasForeignKey(cb => cb.StructureId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("CardBonuses");
        }
    }
}