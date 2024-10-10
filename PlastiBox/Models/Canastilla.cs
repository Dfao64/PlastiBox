using System;
using System.Collections.Generic;

namespace PlastiBox.Models;

public partial class Canastilla
{
    public int IdCanastilla { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public string TipoPlastico { get; set; } = null!;

    public string Color { get; set; } = null!;

    public string Costo { get; set; } = null!;
}
