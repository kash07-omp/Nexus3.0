namespace Nexus.Data.Configuration
{
    using Nexus.Model;
    using System.Data.Entity.ModelConfiguration;

    public class RegionStructureConfiguration : EntityTypeConfiguration<RegionStructure>
    {
        public RegionStructureConfiguration()
        {
            ToTable("RegionStructures");
            HasKey(rs => new { rs.StructureId, rs.RegionId });

            Property(rs => rs.Level)
                .IsRequired();

            HasRequired(rs => rs.Structure)
                .WithMany()
                .HasForeignKey(rs => rs.StructureId);
        }
    }

}
