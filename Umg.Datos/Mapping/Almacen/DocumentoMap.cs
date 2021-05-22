using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Documento;

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
          
        }
    }
}
