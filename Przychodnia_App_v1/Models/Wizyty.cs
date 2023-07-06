using System;
using System.Collections.Generic;

namespace Przychodnia_App_v1.Models;

public partial class Wizyty
{
    public int IdWizyty { get; set; }

    public DateTime Data { get; set; }

    public TimeSpan Godzina { get; set; }

    public int IdPacjenta { get; set; }

    public int IdLekarza { get; set; }

    public string? WywiadLekarski { get; set; }

    public string? BadaniePrzedmiotowe { get; set; }

    public string? Zalecenia { get; set; }

    public virtual Lekarz IdLekarzaNavigation { get; set; } = null!;

    public virtual Pacjent IdPacjentaNavigation { get; set; } = null!;

    public virtual ICollection<OpłataZaWizyte> OpłataZaWizytes { get; } = new List<OpłataZaWizyte>();

    public virtual ICollection<Receptum> Recepta { get; } = new List<Receptum>();

    public virtual ICollection<Skierowanie> Skierowanies { get; } = new List<Skierowanie>();

    public virtual ICollection<SzczegółyBadań> SzczegółyBadańs { get; } = new List<SzczegółyBadań>();
}
