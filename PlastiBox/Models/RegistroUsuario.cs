using System;
using System.Collections.Generic;

namespace PlastiBox.Models;

public partial class RegistroUsuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public int Telefono { get; set; }

    public string Correo { get; set; } = null!;

    public string Contrasena { get; set; } = null!;
}
