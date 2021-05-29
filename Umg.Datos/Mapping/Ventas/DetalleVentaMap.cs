using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public  class DetalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa")
                .HasKey(c => c.idDetalleVenta);
            builder.Property(c => c.cantidad)
                .HasMaxLength(50);
            builder.Property(c => c.total)
                .HasMaxLength(50);
            builder.Property(c => c.descuento)
               .HasMaxLength(50);

            builder.HasOne(p => p.Ventas)
                .WithOne();
            builder.HasOne(p => p.Articulos)
                .WithOne();
        }
    }
}
