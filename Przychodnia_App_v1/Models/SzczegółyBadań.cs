using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class SzczegółyBadań
{
    public int IdSzegółówBadań { get; set; }

    public int IdWizyty { get; set; }

    public int IdBadaniaDodatkowe { get; set; }

    public string Wynik { get; set; } = null!;

    public virtual BadanieDodatkowe IdBadaniaDodatkoweNavigation { get; set; } = null!;

    public virtual Wizyty IdWizytyNavigation { get; set; } = null!;
}
