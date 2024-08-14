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

            builder.HasOne(s => s.Mine)
                   .WithMany() // No necesitamos una colección de Structures en Mine
                   .HasForeignKey(s => s.MineId)
                   .OnDelete(DeleteBehavior.SetNull);

            builder.ToTable("Structures");
        }
    }
}
