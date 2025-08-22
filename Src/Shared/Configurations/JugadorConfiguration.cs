using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_futbol.Src.Modules.Jugador.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class JugadorConfiguration: IEntityTypeConfiguration<Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador> builder)
        {
            builder.ToTable("Jugador");
            builder.HasKey(j => j.Id);
            builder.Property(j => j.Posicion).IsRequired().HasMaxLength(100);
            builder.Property(j => j.Dorsal).IsRequired();
            builder.Property(j => j.Precio).IsRequired().HasColumnType("decimal(10,2)");

            builder.HasOne(j => j.Persona)
                   .WithOne(p => p.Jugador)
                   .HasForeignKey<Jugador>(j => j.Id)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}