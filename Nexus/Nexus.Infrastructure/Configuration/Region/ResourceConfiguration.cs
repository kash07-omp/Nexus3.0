using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class ResourceConfiguration : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
        {
            // Configuración de la clave primaria
            builder.HasKey(r => r.Id);

            // Configuración de las propiedades Code, Name, y Description
            builder.Property(r => r.Code)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(r => r.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(r => r.Description)
                   .HasMaxLength(500);

            // Configuración de la relación uno-a-muchos con Mines
            builder.HasMany(r => r.Mines)
                   .WithOne(m => m.Resource)
                   .HasForeignKey(m => m.ResourceId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la tabla
            builder.ToTable("Resources");
        }
    }
}
