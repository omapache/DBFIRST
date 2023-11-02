using System;
using System.Collections.Generic;

namespace produccion.Entities;

public partial class Insumo
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public double ValorUnit { get; set; }

    public double StockMin { get; set; }

    public double StockMax { get; set; }

    public virtual ICollection<InsumoPrenda> InsumoPrendas { get; set; } = new List<InsumoPrenda>();

    public virtual ICollection<Proveedor> Proveedores { get; set; } = new List<Proveedor>();
}
