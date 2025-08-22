using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Torneo.Domain.Entities
{
    public class Torneo
    {
        public int Id { get; set; }
        public int Capacidad { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public ICollection<Liga_futbol.Src.Modules.TorneoEquipo.Domain.Entities.TorneoEquipo>? TorneoEquipos { get; set; }
    }
}