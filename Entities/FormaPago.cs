using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class FormaPago
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Venta> Ventas { get; set; } = new List<Venta>();
}
