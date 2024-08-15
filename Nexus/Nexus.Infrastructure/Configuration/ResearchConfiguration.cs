using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class ResearchConfiguration : IEntityTypeConfiguration<Research>
    {
        public void Configure(EntityTypeBuilder<Research> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Code).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Name).IsRequired().HasMaxLength(100);
            builder.Property(r => r.Description).IsRequired().HasMaxLength(500);
            builder.ToTable("Researches");
        }
    }
}
