using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nexus.Domain.Entities;

namespace Nexus.Infrastructure.Configuration
{
    public class RegionStructureConfiguration : IEntityTypeConfiguration<RegionStructure>
    {
        public void Configure(EntityTypeBuilder<RegionStructure> builder)
        {
            // Configuración de la clave primaria compuesta
            builder.HasKey(rs => new { rs.StructureId, rs.RegionId });

            // Configuración de la relación con Structure
            builder.HasOne(rs => rs.Structure)
                   .WithMany()
                   .HasForeignKey(rs => rs.StructureId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la relación con Region
            builder.HasOne(rs => rs.Region)
                   .WithMany(r => r.RegionStructures)
                   .HasForeignKey(rs => rs.RegionId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Configuración de la propiedad Level
            builder.Property(rs => rs.Level)
                   .IsRequired();

            // Configuración de la tabla
            builder.ToTable("RegionStructures");
        }
    }
}
