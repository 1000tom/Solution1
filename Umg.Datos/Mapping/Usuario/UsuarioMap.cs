using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) 
        {
            builder.ToTable("usuario")
              .HasKey(c => c.idUsuario);
            builder.Property(c => c.PrimerNombre )
                .HasMaxLength(20);
            builder.Property(c => c.SegundoNombre)
                .HasMaxLength(20);
            builder.Property(c => c.PrimerApellido)
                .HasMaxLength(20);
            builder.Property(c => c.SegundoApellido)
                .HasMaxLength(20);
            builder.Property(c => c.direccion)
                .HasMaxLength(20);
            builder.Property(c => c.telefono)
                .HasMaxLength(20);
            builder.Property(c => c.email)
                .HasMaxLength(20);
            builder.Property(c => c.passwordHash)
                .HasMaxLength(20);
            builder.Property(c => c.passwordSal)
                .HasMaxLength(20);
            builder.Property(c => c.condicion)
                .HasMaxLength(20);

            builder.HasOne(p => p.Roles)
                .WithOne();
            builder.HasOne(p => p.Documentos)
                .WithOne();

        }

            
    }
    
}

