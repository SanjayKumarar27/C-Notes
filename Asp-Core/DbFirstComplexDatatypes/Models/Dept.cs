using System;
using System.Collections.Generic;

namespace DbFirstComplexDatatypes.Models;

public partial class Dept
{
    public int Did { get; set; }

    public string? Dname { get; set; }

    public int? Lid { get; set; }

    public virtual ICollection<Emp> Emps { get; set; } = new List<Emp>();

    public virtual Loc? LidNavigation { get; set; }
}
