using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.TorneoEquipo.Domain.Entities
{
    public class TorneoEquipo
    {
        public int TorneoId { get; set; }
        public int EquipoId { get; set; }
        public Liga_futbol.Src.Modules.Torneo.Domain.Entities.Torneo? Torneo { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? Equipo { get; set; }
    }
}