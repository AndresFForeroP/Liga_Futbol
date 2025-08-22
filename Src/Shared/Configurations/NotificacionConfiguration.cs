using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class NotificacionConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.Notificacion.Domain.Entities.Notificacion>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.Notificacion.Domain.Entities.Notificacion> builder)
        {
            builder.ToTable("Notificacion");
            builder.HasKey(n => n.Id);
            builder.Property(n => n.Tipo).IsRequired().HasMaxLength(14);
            builder.Property(n => n.Precio).HasColumnType("decimal(10,2)");
            builder.Property(n => n.Fecha).IsRequired();
            builder.Property(n => n.EquipoId).IsRequired();
            builder.Property(n => n.JugadorId).IsRequired();

            builder.HasOne(n => n.Equipo)
                   .WithMany()
                   .HasForeignKey(n => n.EquipoId);

            builder.HasOne(n => n.Jugador)
                   .WithMany()
                   .HasForeignKey(n => n.JugadorId);
        }
    }

        
}