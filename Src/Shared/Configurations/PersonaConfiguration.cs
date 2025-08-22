using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.Persona.Domain.Entities.Persona>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.Persona.Domain.Entities.Persona> builder)
        {
            builder.ToTable("Persona");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Pais).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Edad).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(200);
            builder.Property(p => p.Telefono).HasMaxLength(15);
        }
        
    }
}