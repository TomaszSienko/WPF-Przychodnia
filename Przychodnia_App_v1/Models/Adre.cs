using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class Adre
{
    public int IdAdresu { get; set; }

    public string Miasto { get; set; } = null!;

    public string Ulica { get; set; } = null!;

    public string KodPocztowy { get; set; } = null!;

    public string? NrMieszkania { get; set; }

    public virtual ICollection<Pacjent> Pacjents { get; } = new List<Pacjent>();
}
