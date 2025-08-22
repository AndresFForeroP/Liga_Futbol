using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Liga_futbol.Src.Modules.Jugador.Domain.Entities;
using Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class EstadisticasJugadorConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities.EstadisticasJugador>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities.EstadisticasJugador> builder)
        {
            builder.ToTable("EstadisticasJugador");
            builder.HasKey(ej => ej.JugadorId);
            builder.Property(ej => ej.Goles).IsRequired();
            builder.Property(ej => ej.Asistencias).IsRequired();
            builder.Property(ej => ej.TarjetasAmarillas).IsRequired();
            builder.Property(ej => ej.TarjetasRojas).IsRequired();
            
            builder.HasMany(e => e.Jugadores)
               .WithOne(j => j.EstadisticasJugador)
               .HasForeignKey(j => j.Id);
        }
        
    }
}