using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class StructureRequiredResearchConfiguration : IEntityTypeConfiguration<StructureRequiredResearch>
    {
        public void Configure(EntityTypeBuilder<StructureRequiredResearch> builder)
        {
            builder.HasKey(srr => new { srr.StructureId, srr.RequiredResearchId });
            builder.HasOne(srr => srr.Structure)
                .WithMany()
                .HasForeignKey(srr => srr.StructureId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(srr => srr.RequiredResearch)
                .WithMany()
                .HasForeignKey(srr => srr.RequiredResearchId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
