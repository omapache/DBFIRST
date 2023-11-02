using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Prenda
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public double ValorUnitCop { get; set; }

    public double ValorUnitUsd { get; set; }

    public int IdEstadoFk { get; set; }

    public int IdTipoProteccion { get; set; }

    public int IdGeneroFk { get; set; }

    public string Codigo { get; set; } = null!;

    public virtual ICollection<DetalleOrden> DetalleOrdenes { get; set; } = new List<DetalleOrden>();

    public virtual Estado IdEstadoFkNavigation { get; set; } = null!;

    public virtual Genero IdGeneroFkNavigation { get; set; } = null!;

    public virtual TipoProteccion IdTipoProteccionNavigation { get; set; } = null!;

    public virtual ICollection<InsumoPrenda> InsumoPrendas { get; set; } = new List<InsumoPrenda>();

    public virtual ICollection<Inventario> Inventarios { get; set; } = new List<Inventario>();
}
