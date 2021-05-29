using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Compras;

namespace Umg.Datos.Mapping.Compras
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

            builder.HasOne(p => p.Personas)
                .WithOne();
            builder.HasOne(p => p.Usuarios)
                .WithOne();
            builder.HasOne(p => p.Comprobantes)
                .WithOne();
            builder.HasOne(p => p.EstadosIngresos)
                .WithOne();
        }
    }
}
