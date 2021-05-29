using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class ComprobanteMap : IEntityTypeConfiguration<Comprobante>
    {
        public void Configure(EntityTypeBuilder<Comprobante> builder)
        {
            builder.ToTable("comprobante")
                .HasKey(c => c.idComprobante);
            builder.Property(c => c.serie)
                .HasMaxLength(7);
            builder.Property(c => c.numero)
                .HasMaxLength(10);

            builder.HasOne(p => p.TipoComprobantes)
                .WithOne();
        }
    }
}
