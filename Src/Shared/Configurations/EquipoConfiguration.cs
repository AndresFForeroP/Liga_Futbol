using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class EquipoConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.Equipo.Domain.Entities.Equipo> builder)
        {
            builder.ToTable("Equipo");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(e => e.Pais).IsRequired().HasMaxLength(50);
            builder.HasMany(e => e.Notificaciones)
                   .WithOne(n => n.Equipo)
                   .HasForeignKey(n => n.EquipoId);
            builder.HasMany(e => e.TorneoEquipos)
                   .WithOne(te => te.Equipo)
                   .HasForeignKey(te => te.EquipoId);
            builder.HasMany(e => e.Personal)
                    .WithOne(p => p.Equipo)
                    .HasForeignKey(p => p.EquipoId);
            builder.HasMany(e => e.JugadoresEquipo)
                   .WithOne(je => je.Equipo)
                   .HasForeignKey(je => je.EquipoId);
            builder.HasMany(e => e.TransferenciaOrigen)
                   .WithOne(t => t.EquipoOrigen)
                   .HasForeignKey(t => t.EquipoOrigenId)
                   .OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(e => e.TransferenciaDestino)
                   .WithOne(t => t.EquipoDestino)
                   .HasForeignKey(t => t.EquipoDestinoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}