using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Ingreso;

namespace Umg.Datos.Mapping.Almacen
{
   public  class IngresoMap : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("ingreso")
                .HasKey(c => c.idIngreso);
            builder.Property(c => c.fechaHora)
                .HasMaxLength(50);
            builder.Property(c => c.impuesto)
                .HasMaxLength(50);
            builder.Property(c => c.total)
               .HasMaxLength(50);
        }
    }
}
