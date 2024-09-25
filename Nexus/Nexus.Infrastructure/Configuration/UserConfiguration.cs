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

            // Configuración de la relación uno-a-muchos con Fleets
            builder.HasMany(u => u.Fleets)
                   .WithOne(f => f.User)
                   .HasForeignKey(f => f.UserId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la relación muchos-a-muchos con Cards
            builder.HasMany(u => u.Cards)
                   .WithMany(c => c.Users)
                   .UsingEntity(j => j.ToTable("UserCards"));

            // Configuración de la propiedad Credits con valor por defecto
            builder.Property(u => u.Credits)
                .HasDefaultValue(0);

            // Configuración de la tabla (usando la tabla por defecto de Identity)
            builder.ToTable("AspNetUsers");
        }
    }
}
