using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Persona.Domain.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Pais { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public Liga_futbol.Src.Modules.Personal.Domain.Entities.Personal? Personal { get; set; }
        public Liga_futbol.Src.Modules.Jugador.Domain.Entities.Jugador? Jugador { get; set; }
    }
}