using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class RegionResourceConfiguration : IEntityTypeConfiguration<RegionResource>
    {
        public void Configure(EntityTypeBuilder<RegionResource> builder)
        {
            builder.HasKey(rr => rr.Id);

            builder.HasOne(rr => rr.Region)
                .WithMany(r => r.RegionResources)
                .HasForeignKey(rr => rr.RegionId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(rr => rr.Resource)
                .WithMany()
                .HasForeignKey(rr => rr.ResourceId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Property(rr => rr.Quantity)
                .IsRequired();

            builder.ToTable("RegionResources");
        }
    }
}
