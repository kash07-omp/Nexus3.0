using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class MineConfiguration : EntityTypeConfiguration<Mine>
    {
        public MineConfiguration()
        {
            ToTable("Mines");
            HasKey(m => m.Id);

            Property(m => m.Code)
                .IsRequired()
                .HasMaxLength(50);

            Property(m => m.GainMultiplier)
                .IsRequired();

            HasRequired(m => m.Resource)
                .WithMany()
                .HasForeignKey(m => m.ResourceId);
        }
    }
}
