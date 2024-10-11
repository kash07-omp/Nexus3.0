using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class ResearchRequiredResearchConfiguration : IEntityTypeConfiguration<ResearchRequiredResearch>
    {
        public void Configure(EntityTypeBuilder<ResearchRequiredResearch> builder)
        {
            builder.HasKey(rrr => new { rrr.ResearchId, rrr.RequiredResearchId });

            builder.HasOne(rrr => rrr.Research)
                .WithMany(r => r.ResearchRequiredResearchs)
                .HasForeignKey(rrr => rrr.ResearchId)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.HasOne(rrr => rrr.RequiredResearch)
                .WithMany() 
                .HasForeignKey(rrr => rrr.RequiredResearchId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
