using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Articulo;

namespace Umg.Datos.Mapping.Almacen
{
   public class ArticuloMap : IEntityTypeConfiguration<Articulo>
    {

        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("articulo")
                .HasKey(c => c.idArticulo);
            builder.Property(c => c.codigo)
                .HasMaxLength(50);
            builder.Property(c => c.nombre)
               .HasMaxLength(50);
            builder.Property(c => c.precio)
               .HasMaxLength(50);
            builder.Property(c => c.stock)
               .HasMaxLength(50);
            builder.Property(c => c.descripcion)
               .HasMaxLength(256);
            builder.Property(c => c.condicion)
               .HasMaxLength(50);

        }
    }
}
