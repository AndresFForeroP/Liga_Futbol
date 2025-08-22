using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Notificacion.Domain.Entities
{
    public class Notificacion
    {
        public int Id { get; set; }
        public Decimal Precio { get; set; }
        public int EquipoId { get; set; }
        public int JugadorId { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Tipo { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? Equipo { get; set; }
        public Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador? Jugador { get; set; }
    }
}