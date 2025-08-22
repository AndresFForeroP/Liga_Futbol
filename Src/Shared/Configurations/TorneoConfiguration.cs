using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_futbol.Src.Modules.Torneo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class TorneoConfiguration : IEntityTypeConfiguration<Torneo>
    {
        public void Configure(EntityTypeBuilder<Torneo> builder)
        {
            builder.ToTable("Torneo");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Nombre).IsRequired().HasMaxLength(100);
            builder.Property(t => t.FechaInicio).IsRequired();
            builder.Property(t => t.FechaFin).IsRequired();
            builder.Property(t => t.Capacidad).IsRequired();
            builder.HasMany(t => t.TorneoEquipos)
                   .WithOne(te => te.Torneo)
                   .HasForeignKey(te => te.TorneoId);
        }
    }
        
}