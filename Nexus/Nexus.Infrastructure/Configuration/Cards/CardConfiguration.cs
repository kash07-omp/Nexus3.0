using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.CardType)
                .IsRequired();

            builder.Property(c => c.ImageUrl);

            builder.HasMany(c => c.Bonuses)
                .WithOne(cb => cb.Card)
                .HasForeignKey(cb => cb.CardId);

            builder.ToTable("Cards");
        }
    }
}