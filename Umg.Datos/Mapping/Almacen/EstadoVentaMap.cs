using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.EstadoVenta;

namespace Umg.Datos.Mapping.Almacen
{
    public class EstadoVentaMap : IEntityTypeConfiguration<EstadoVenta>
    {
        public void Configure(EntityTypeBuilder<EstadoVenta> builder)
        {
            builder.ToTable("estadoventa")
                .HasKey(c => c.idEstadoVenta);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
            
        }
    }
}