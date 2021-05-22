using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.EstadoIngreso;

namespace Umg.Datos.Mapping.Almacen
{
    public class EstadoIngresoMap : IEntityTypeConfiguration<EstadoIngreso>
    {
        public void Configure(EntityTypeBuilder<EstadoIngreso> builder)
        {
            builder.ToTable("estadoingreso")
                .HasKey(c => c.idEstadoIngreso);
            builder.Property(c => c.nombre)
                .HasMaxLength(50);
          
        }
    }
}
