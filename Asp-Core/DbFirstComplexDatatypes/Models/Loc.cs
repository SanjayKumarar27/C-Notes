using System;
using System.Collections.Generic;

namespace DbFirstComplexDatatypes.Models;

public partial class Loc
{
    public int Lid { get; set; }

    public string? City { get; set; }

    public virtual ICollection<Dept> Depts { get; set; } = new List<Dept>();
}
