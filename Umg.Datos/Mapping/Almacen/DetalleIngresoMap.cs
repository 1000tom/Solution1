using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.DetalleIngreso;

namespace Umg.Datos.Mapping.Almacen
{
    public class DetalleIngresoMap : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("detalleingreso")
                .HasKey(c => c.idArticulo);
            builder.Property(c => c.cantidad)
                .HasMaxLength(50);
            builder.Property(c => c.total)
                .HasMaxLength(50);
        }
    }
}
