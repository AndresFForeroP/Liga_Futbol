using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Liga_Futbol.Src.Modules.Torneo.Interfaces.Repository
{
    public class TorneoRepository
    {
        internal readonly DbContext _context;

        public TorneoRepository(DbContext context)
        {
            _context = context;
        }
        public async Task<List<Liga_futbol.Src.Modules.Torneo.Domain.Entities.Torneo>> GetAllTorneosAsync()
        {
            return await _context.Set<Liga_futbol.Src.Modules.Torneo.Domain.Entities.Torneo>()
                .Include(te => te.TorneoEquipos!)
                    .ThenInclude(e => e.Equipo).ToListAsync();
        }
    }
}