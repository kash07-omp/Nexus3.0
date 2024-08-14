using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Configuración de la relación uno-a-muchos con Regions
            builder.HasMany(u => u.Regions)
                   .WithOne(r => r.User)
                   .HasForeignKey(r => r.UserId)
                   .OnDelete(DeleteBehavior.SetNull);

            // Configuración de la tabla
            builder.ToTable("AspNetUsers");  // Usando la tabla por defecto de Identity
        }
    }
}
