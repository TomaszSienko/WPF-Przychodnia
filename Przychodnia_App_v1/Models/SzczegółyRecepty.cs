using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class SzczegółyRecepty
{
    public int IdSzczegółówRecepty { get; set; }

    public int IdLekarstwa { get; set; }

    public int IdRecepty { get; set; }

    public string Dawkowanie { get; set; } = null!;

    public virtual Lekarstwo IdLekarstwaNavigation { get; set; } = null!;

    public virtual Receptum IdReceptyNavigation { get; set; } = null!;
}
