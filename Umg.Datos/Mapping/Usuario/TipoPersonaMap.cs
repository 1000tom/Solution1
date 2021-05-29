using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class TipoPersonaMap : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("categoria")
                .HasKey(c => c.idTipoPersona);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
           
        }
    }
}
