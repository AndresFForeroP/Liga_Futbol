using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Equipo.Domain.Entities
{
    public class Equipo
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Pais { get; set; }
        public ICollection<Liga_futbol.Src.Modules.TorneoEquipo.Domain.Entities.TorneoEquipo>? TorneoEquipos { get; set; }
        public ICollection<Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities.JugadorEquipo>? JugadoresEquipo { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Personal.Domain.Entities.Personal>? Personal { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Transferencia.Domain.Entities.Transferencia>? TransferenciaOrigen { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Transferencia.Domain.Entities.Transferencia>? TransferenciaDestino { get; set; }
        public ICollection<Liga_futbol.Src.Modules.Notificacion.Domain.Entities.Notificacion>? Notificaciones { get; set; }
    }
}