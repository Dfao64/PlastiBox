using System;
using System.Collections.Generic;

namespace PlastiBox.Models;

public partial class Auditorium
{
    public string IdAuditoria { get; set; } = null!;

    public int IdUsuario { get; set; }

    public string NombreAnterior { get; set; } = null!;

    public string? NombreNuevo { get; set; }

    public string ApellidoAnterior { get; set; } = null!;

    public string? ApellidoNuevo { get; set; }

    public int TelefonoAnterior { get; set; }

    public int? TelefonoNuevo { get; set; }

    public string CorreoAnterior { get; set; } = null!;

    public string? CorrecoNuevo { get; set; }

    public string ContrasenaAnterior { get; set; } = null!;

    public string? ContrasenaNueva { get; set; }
}
