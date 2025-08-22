using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class JugadorEquipoConfiguration: IEntityTypeConfiguration<Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities.JugadorEquipo>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.JugadorEquipo.Domain.Entities.JugadorEquipo> builder)
        {
            builder.ToTable("JugadorEquipo");
            builder.HasKey(je => new { je.JugadorId, je.EquipoId });

            builder.Property(je => je.FechaInicio).IsRequired();
            builder.Property(je => je.FechaFin).IsRequired();

            builder.HasOne(je => je.Jugador)
                   .WithMany()
                   .HasForeignKey(je => je.JugadorId);

            builder.HasOne(je => je.Equipo)
                   .WithMany()
                   .HasForeignKey(je => je.EquipoId);
        }
    }
}