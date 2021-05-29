using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class TipoDocumentoMap : IEntityTypeConfiguration<TipoDocumento>
    {
        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("categoria")
                .HasKey(c => c.idTipoDocumento);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            
        }
    }
}