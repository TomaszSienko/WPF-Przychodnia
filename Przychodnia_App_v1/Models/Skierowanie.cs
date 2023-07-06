using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class Skierowanie
{
    public int IdSkierowania { get; set; }

    public int IdWizyty { get; set; }

    public string Specjalista { get; set; } = null!;

    public string Oddział { get; set; } = null!;

    public virtual Wizyty IdWizytyNavigation { get; set; } = null!;
}
