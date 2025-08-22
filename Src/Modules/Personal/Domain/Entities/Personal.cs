using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liga_futbol.Src.Modules.Personal.Domain.Entities
{
    public class Personal
    {
        public int Id { get; set; }
        public string? Tipo { get; set; }
        public int EquipoId { get; set; }
        public Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo? Equipo { get; set; }
        public Liga_futbol.Src.Modules.Persona.Domain.Entities.Persona? Persona { get; set; }
    }
}