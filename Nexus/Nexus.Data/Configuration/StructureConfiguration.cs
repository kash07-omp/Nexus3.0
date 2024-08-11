using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class StructureConfiguration : EntityTypeConfiguration<Structure>
    {
        public StructureConfiguration()
        {
            ToTable("Structures");
            HasKey(s => s.Id);

            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            Property(s => s.Description)
                .IsOptional()
                .HasMaxLength(500);

            HasOptional(s => s.Mine)
                .WithOptionalPrincipal()
                .Map(m => m.MapKey("MineId"));
        }
    }
}
