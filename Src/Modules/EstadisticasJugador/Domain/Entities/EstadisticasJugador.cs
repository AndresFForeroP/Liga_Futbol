using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.EstadisticasJugador.Domain.Entities
{
    public class EstadisticasJugador
    {
        public int JugadorId { get; set; }
        public int Goles { get; set; }
        public int GolesEnContra { get; set; }
        public int Asistencias { get; set; }
        public int TarjetasAmarillas { get; set; }
        public int TarjetasRojas { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador>? Jugadores { get; set; }
    }
}