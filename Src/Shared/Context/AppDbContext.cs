using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_futbol.Src.Modules.Equipo.Domain.Entities;
using Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities;
using Liga_futbol.Src.Modules.Jugador.Domain.Entities;
using Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities;
using Liga_futbol.Src.Modules.Notificacion.Domain.Entities;
using Liga_futbol.Src.Modules.Personal.Domain.Entities;
using Liga_futbol.Src.Modules.Persona.Domain.Entities;
using Liga_futbol.Src.Modules.Torneo.Domain.Entities;
using Liga_futbol.Src.Modules.TorneoEquipo.Domain.Entities;
using Liga_futbol.Src.Modules.Transferencia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Liga_futbol.Src.Shared.Context
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {
            }
            public DbSet<Equipo> Equipo { get; set; }
            public DbSet<EstadisticasJugador> EstadisticasJugador { get; set; }
            public DbSet<Jugador> Jugador { get; set; }
            public DbSet<JugadorEquipo> JugadorEquipo { get; set; }
            public DbSet<Notificacion> Notificacion { get; set; }
            public DbSet<Personal> Personal { get; set; }
            public DbSet<Persona> Persona { get; set; }
            public DbSet<Torneo> Torneo { get; set; }
            public DbSet<TorneoEquipo> TorneoEquipo { get; set; }
            public DbSet<Transferencia> Transferencia { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}