using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class MineConfiguration : IEntityTypeConfiguration<Mine>
    {
        public void Configure(EntityTypeBuilder<Mine> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Code)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(m => m.GainMultiplier)
                   .HasPrecision(18);

            builder.HasOne(m => m.Resource)
                   .WithMany(r => r.Mines)
                   .HasForeignKey(m => m.ResourceId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.ToTable("Mines");
        }
    }
}
