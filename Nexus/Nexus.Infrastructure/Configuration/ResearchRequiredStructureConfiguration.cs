using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;
namespace Nexus.Infrastructure.Configuration
{
    public class ResearchRequiredStructureConfiguration : IEntityTypeConfiguration<ResearchRequiredStructure>
    {
        public void Configure(EntityTypeBuilder<ResearchRequiredStructure> builder)
        {
            builder.HasKey(rrs => new { rrs.ResearchId, rrs.RequiredStructureId });
            builder.HasOne(rrs => rrs.Research)
                .WithMany()
                .HasForeignKey(rrs => rrs.ResearchId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rrs => rrs.RequiredStructure)
                .WithMany()
                .HasForeignKey(rrs => rrs.RequiredStructureId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
