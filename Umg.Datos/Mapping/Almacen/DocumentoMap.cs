using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Almacen;

namespace Umg.Datos.Mapping.Almacen
{
    public class DocumentoMap : IEntityTypeConfiguration<Documento>
    {
        public void Configure(EntityTypeBuilder<Documento> builder)
        {
            builder.ToTable("documento")
                .HasKey(c => c.idDocumento);
            builder.Property(c => c.numero)
                .HasMaxLength(20);

            builder.HasOne(p => p.TipoDocumento)
                .WithOne();

        }
    }
}
