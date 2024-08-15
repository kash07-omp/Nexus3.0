using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class StructureRequiredStructureConfiguration : IEntityTypeConfiguration<StructureRequiredStructure>
    {
        public void Configure(EntityTypeBuilder<StructureRequiredStructure> builder)
        {
            builder.HasKey(srs => new { srs.StructureId, srs.RequiredStructureId });
            builder.HasOne(srs => srs.Structure)
                .WithMany()
                .HasForeignKey(srs => srs.StructureId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(srs => srs.RequiredStructure)
                .WithMany()
                .HasForeignKey(srs => srs.RequiredStructureId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
