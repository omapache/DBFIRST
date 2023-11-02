using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Venta
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdEmpleadoFk { get; set; }

    public int IdClienteFk { get; set; }

    public int IdFormaPagoFk { get; set; }

    public virtual ICollection<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();

    public virtual Cliente IdClienteFkNavigation { get; set; } = null!;

    public virtual Empleado IdEmpleadoFkNavigation { get; set; } = null!;

    public virtual FormaPago IdFormaPagoFkNavigation { get; set; } = null!;
}
