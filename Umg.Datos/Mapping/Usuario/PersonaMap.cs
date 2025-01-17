﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Umg.Entidades.Usuarios;

namespace Umg.Datos.Mapping.Usuarios
{
    public class PersonaMap : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("persona")
                .HasKey(c => c.idPersona);
            builder.Property(c => c.primerNombre)
                .HasMaxLength(20);
            builder.Property(c => c.segundoNombre)
                .HasMaxLength(20);
            builder.Property(c => c.primerApellido)
                .HasMaxLength(20);
            builder.Property(c => c.segundoApellido)
                .HasMaxLength(20);
            builder.Property(c => c.direccion)
                .HasMaxLength(70);
            builder.Property(c => c.telefono)
                .HasMaxLength(20);
            builder.Property(c => c.email)
                .HasMaxLength(50);

            builder.HasOne(p => p.TipoPersonas)
                .WithOne();
            builder.HasOne(p => p.Documentos)
                .WithOne();
        }
    }
}