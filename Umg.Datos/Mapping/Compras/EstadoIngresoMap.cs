using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Compras;

namespace Umg.Datos.Mapping.Compras
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
