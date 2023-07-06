using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class OpłataZaWizyte
{
    public int IdOpłaty { get; set; }

    public int IdWizyty { get; set; }

    public bool Ubezpieczenie { get; set; }

    public decimal Kwota { get; set; }

    public virtual Wizyty IdWizytyNavigation { get; set; } = null!;
}
