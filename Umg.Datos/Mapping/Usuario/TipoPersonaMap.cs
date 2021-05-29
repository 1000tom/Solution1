using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.TipoPersona;

namespace Umg.Datos.Mapping.Almacen
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
