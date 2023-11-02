using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Estado
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdTipoEstadoFk { get; set; }

    public virtual ICollection<DetalleOrden> DetalleOrdenes { get; set; } = new List<DetalleOrden>();

    public virtual TipoEstado IdTipoEstadoFkNavigation { get; set; } = null!;

    public virtual ICollection<Orden> Ordenes { get; set; } = new List<Orden>();

    public virtual ICollection<Prenda> Prendas { get; set; } = new List<Prenda>();
}
