using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class EstadoVentaMap : IEntityTypeConfiguration<EstadoVenta>
    {
        public void Configure(EntityTypeBuilder<EstadoVenta> builder)
        {
            builder.ToTable("estadoventa")
                .HasKey(c => c.idEstadoVenta);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            
        }
    }
}