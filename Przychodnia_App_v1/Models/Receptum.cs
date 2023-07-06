using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class Receptum
{
    public int IdRecepty { get; set; }

    public int IdWizyty { get; set; }

    public decimal? Refundacja { get; set; }

    public virtual Wizyty IdWizytyNavigation { get; set; } = null!;

    public virtual ICollection<SzczegółyRecepty> SzczegółyRecepties { get; } = new List<SzczegółyRecepty>();
}
