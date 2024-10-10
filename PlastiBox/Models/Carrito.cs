using System;
using System.Collections.Generic;

namespace PlastiBox.Models;

public partial class Carrito
{
    public int IdCarrito { get; set; }

    public int? IdUsuario { get; set; }

    public int IdCanastilla { get; set; }

    public int Cantidad { get; set; }

    public string Subtotal { get; set; } = null!;

    public string PrecioTotal { get; set; } = null!;
}
