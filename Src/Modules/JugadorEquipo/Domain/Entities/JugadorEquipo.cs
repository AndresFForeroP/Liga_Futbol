using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities
{
    public class JugadorEquipo
    {
        public int JugadorId { get; set; }
        public int EquipoId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador? Jugador { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? Equipo { get; set; }
    }
}