using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configuration;
public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
{
    public void Configure(EntityTypeBuilder<Estado> builder)
    {
        builder.HasKey(e => e.Id).HasName("PRIMARY");

        builder.ToTable("estado");

        builder.HasIndex(e => e.IdTipoEstadoFk, "IX_estado_IdTipoEstadoFk");

        builder.Property(e => e.Descripcion)
            .HasMaxLength(50)
            .HasColumnName("descripcion");

        builder.HasOne(d => d.IdTipoEstadoFkNavigation).WithMany(p => p.Estados)
            .HasForeignKey(d => d.IdTipoEstadoFk)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
