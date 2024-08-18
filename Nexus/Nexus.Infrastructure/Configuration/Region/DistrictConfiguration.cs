using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class DistrictConfiguration : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(d => d.Id);

            // Configuración de la propiedad Name
            builder.Property(d => d.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Description)
                   .HasMaxLength(500);

            // Configuración de la relación uno-a-muchos con Structures
            builder.HasMany(d => d.Structures)
                   .WithOne(s => s.District)
                   .HasForeignKey(s => s.DistrictId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la tabla
            builder.ToTable("Districts");
        }
    }
}
