using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuario;

namespace Umg.Datos.Mapping.Usuario
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) 
        {
            builder.ToTable("usuario")
              .HasKey(c => c.idUsuario);
            builder.Property(c => PrimerNombre )
                .HasMaxLength(20);
            builder.Property(c => SegundoNombre)
                .HasMaxLength(20);
            builder.Property(c => PrimerApellido)
                .HasMaxLength(20);
            builder.Property(c => SegundoApellido)
                .HasMaxLength(20);
            builder.Property(c => Direccion)
                .HasMaxLength(20);
            builder.Property(c => Telefono)
                .HasMaxLength(20);
            builder.Property(c => email)
                .HasMaxLength(20);
            builder.Property(c => passwordHash)
                .HasMaxLength(20);
            builder.Property(c => passwordSal)
                .HasMaxLength(20);
            builder.Property(c => condicion)
                .HasMaxLength(20);

        }

            
        }
    
    }

