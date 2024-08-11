using Nexus.Model;
using System.Data.Entity.ModelConfiguration;

namespace Nexus.Data.Configuration
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            ToTable("AspNetUsers");
            HasKey(u => u.Id);

            HasMany(u => u.Regions)
                .WithOptional(r => r.User)
                .HasForeignKey(r => r.UserId);
        }
    }
}
