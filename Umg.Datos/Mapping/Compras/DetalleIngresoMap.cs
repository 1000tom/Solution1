using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Compras;

namespace Umg.Datos.Mapping.Compras
{
    public class DetalleIngresoMap : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("detalleingreso")
                .HasKey(c => c.idDetalleIngreso);
            builder.Property(c => c.cantidad)
                .HasMaxLength(50);
            builder.Property(c => c.total)
                .HasMaxLength(50);

            builder.HasOne(p => p.Ingresos)
                .WithOne();
            builder.HasOne(p => p.Articulos)
                .WithOne();
        }
    }
}
