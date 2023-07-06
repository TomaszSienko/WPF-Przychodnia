using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class Lekarstwo
{
    public int IdLekarstwa { get; set; }

    public string Nazwa { get; set; } = null!;

    public string Rodzaj { get; set; } = null!;

    public string Producent { get; set; } = null!;

    public virtual ICollection<SzczegółyRecepty> SzczegółyRecepties { get; } = new List<SzczegółyRecepty>();
}
