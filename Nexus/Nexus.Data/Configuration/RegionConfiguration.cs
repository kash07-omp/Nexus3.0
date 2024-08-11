using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class RegionConfiguration : EntityTypeConfiguration<Region>
    {
        public RegionConfiguration()
        {
            ToTable("Regions");
            HasKey(r => r.Id);

            Property(r => r.IsColonized)
                .IsRequired();

            HasOptional(r => r.User)
                .WithMany(u => u.Regions)
                .HasForeignKey(r => r.UserId);

            HasMany(r => r.RegionStructures)
                .WithRequired(rs => rs.Region)
                .HasForeignKey(rs => rs.RegionId);
        }
    }
}
