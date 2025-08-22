using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_futbol.Src.Modules.TorneoEquipo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class ToreoEquipoConfiguration : IEntityTypeConfiguration<TorneoEquipo>
    {
        public void Configure(EntityTypeBuilder<TorneoEquipo> builder)
        {
            builder.ToTable("TorneoEquipo");
            builder.HasKey(te => new { te.TorneoId, te.EquipoId });

            builder.HasOne(te => te.Torneo)
                   .WithMany(t => t.TorneoEquipos)
                   .HasForeignKey(te => te.TorneoId);

            builder.HasOne(te => te.Equipo)
                   .WithMany(e => e.TorneoEquipos)
                   .HasForeignKey(te => te.EquipoId);
        }
    }
}