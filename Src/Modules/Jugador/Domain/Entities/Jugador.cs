using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Jugador.Domain.Entities
{
    public class Jugador
    {
        public int Id { get; set; }
        public string? Posicion { get; set; }
        public int Dorsal { get; set; }
        public Decimal Precio { get; set; }
        public Liga_futbol.Src.Modules.Persona.Domain.Entities.Persona? Persona { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Transferencia.Domain.Entities.Transferencia>? Transferencias { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Notificacion.Domain.Entities.Notificacion>? Notificaciones { get; set; }
        public ICollection<Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities.JugadorEquipo>? JugadoresEquipo { get; set; }
        public Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities.EstadisticasJugador? EstadisticasJugador { get; set; }
    }
}