using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class TipoComprobanteMap : IEntityTypeConfiguration<TipoComprobante>
    {
        public void Configure(EntityTypeBuilder<TipoComprobante> builder)
        {
            builder.ToTable("categoria")
                .HasKey(c => c.idTipoComprobante);
            builder.Property(c => c.Nombre)
                .HasMaxLength(50);
            
        }
    }
}
