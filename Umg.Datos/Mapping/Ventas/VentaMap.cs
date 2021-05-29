using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Ventas;

namespace Umg.Datos.Mapping.Ventas
{
    public class VentaMap : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("ventas")
                .HasKey(c => c.idVenta);
            builder.Property(c => c.idCliente);
            builder.Property(c => c.idComprobante);
            builder.Property(c => c.idEstadoVenta);
            builder.Property(c => c.idUsuario);
            builder.Property(c => c.fechaHora)
                .HasMaxLength(50);

            builder.HasOne(p => p.Personas)
                .WithOne();
            builder.HasOne(p => p.Comprobantes)
                .WithOne();
            builder.HasOne(p => p.EstadosVenta)
                .WithOne();
            builder.HasOne(p => p.Usuarios)
                .WithOne();
        }
    }
}
