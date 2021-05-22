using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.TipoDocumento;

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