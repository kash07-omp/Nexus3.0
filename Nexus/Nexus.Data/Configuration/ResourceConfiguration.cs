using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class ResourceConfiguration : EntityTypeConfiguration<Resource>
    {
        public ResourceConfiguration()
        {
            ToTable("Resources");
            HasKey(r => r.Id);

            Property(r => r.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(r => r.Description)
                .IsOptional()
                .HasMaxLength(500);
        }
    }
}
