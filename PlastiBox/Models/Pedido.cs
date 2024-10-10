using System;
using System.Collections.Generic;

namespace PlastiBox.Models;

public partial class Pedido
{
    public int IdPedido { get; set; }

    public int IdUsuario { get; set; }

    public int? IdCarrito { get; set; }

    public string IdEstado { get; set; } = null!;

    public DateOnly FechaPedido { get; set; }
}
