using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Talla
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
