using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class TransferenciaConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.Transferencia.Domain.Entities.Transferencia>
    {
        public void Configure(EntityTypeBuilder<Liga_futbol.Src.Modules.Transferencia.Domain.Entities.Transferencia> builder)
        {
            builder.ToTable("Transferencia");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Tipo).IsRequired().HasMaxLength(14);
            builder.Property(t => t.Precio).HasColumnType("decimal(10,2)");
            builder.Property(t => t.Fecha).IsRequired();

            builder.HasOne(t => t.Jugador)
                   .WithMany()
                   .HasForeignKey(t => t.JugadorId);

            builder.HasOne(t => t.EquipoOrigen)
                   .WithMany(e => e.TransferenciaOrigen)
                   .HasForeignKey(t => t.EquipoOrigenId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(t => t.EquipoDestino)
                   .WithMany(e => e.TransferenciaDestino)
                   .HasForeignKey(t => t.EquipoDestinoId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}