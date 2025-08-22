using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Liga_futbol.Src.Modules.Personal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Liga_futbol.Src.Shared.Configurations
{
    public class PersonalConfiguration : IEntityTypeConfiguration<Liga_futbol.Src.Modules.Personal.Domain.Entities.Personal>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Liga_futbol.Src.Modules.Personal.Domain.Entities.Personal> builder)
        {
            builder.ToTable("Personal");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Tipo).IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Equipo)
                   .WithMany()
                   .HasForeignKey(p => p.EquipoId);

            builder.HasOne(p => p.Persona)
                .WithOne(pers => pers.Personal)
                .HasForeignKey<Personal>(p => p.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}