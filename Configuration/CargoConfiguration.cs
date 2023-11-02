using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configuration;
public class CargoConfiguration : IEntityTypeConfiguration<Cargo>
{
    public void Configure(EntityTypeBuilder<Cargo> builder)
    {
        builder.ToTable("cargo");
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.Property(e => e.Descripcion)
            .HasMaxLength(50)
            .HasColumnName("descripcion");
        builder.Property(e => e.SueldoBase).HasColumnName("sueldo_base");
    }
}
