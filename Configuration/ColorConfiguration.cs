using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configuration;
public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.ToTable("color");
        builder.HasKey(e => e.Id).HasName("PRIMARY");
        builder.Property(e => e.Descripcion).HasMaxLength(255);
    }
}
