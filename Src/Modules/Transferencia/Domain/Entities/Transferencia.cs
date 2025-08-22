using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Transferencia.Domain.Entities
{
    public class Transferencia
    {
        public int Id { get; set; }
        public int JugadorId { get; set; }
        public int EquipoOrigenId { get; set; }
        public int EquipoDestinoId { get; set; }
        public string? Tipo { get; set; }
        public Decimal Precio { get; set; }
        public DateTime Fecha { get; set; }
        public Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador? Jugador { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? EquipoOrigen { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? EquipoDestino { get; set; }
    }
}