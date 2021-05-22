using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.DetalleVenta;

namespace Umg.Datos.Mapping.Almacen
{
   public  class DetalleVentaMap : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("detalleventa")
                .HasKey(c => c.idDetalleVenta);
            builder.Property(c => c.cantidad)
                .HasMaxLength(50);
            builder.Property(c => c.total)
                .HasMaxLength(50);
            builder.Property(c => c.descuento)
               .HasMaxLength(50);
        }
    }
}
