using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using produccion.Entities;

namespace produccion.Configuration;
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
            {
                public void Configure(EntityTypeBuilder<Venta> builder)
                {
                    builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("venta");

            builder.HasIndex(e => e.IdClienteFk, "IX_venta_IdClienteFk");

            builder.HasIndex(e => e.IdEmpleadoFk, "IX_venta_IdEmpleadoFk");

            builder.HasIndex(e => e.IdFormaPagoFk, "IX_venta_IdFormaPagoFk");

            builder.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Ventas)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.IdEmpleadoFkNavigation).WithMany(p => p.Ventas)
                .HasForeignKey(d => d.IdEmpleadoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(d => d.IdFormaPagoFkNavigation).WithMany(p => p.Ventas)
                .HasForeignKey(d => d.IdFormaPagoFk)
                .OnDelete(DeleteBehavior.ClientSetNull);
                }
            }
