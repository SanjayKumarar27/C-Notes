using System;
using System.Collections.Generic;

namespace DbFirstComplexDatatypes.Models;

public partial class EmpHistory
{
    public int? Eid { get; set; }

    public string? Job { get; set; }

    public decimal? Sal { get; set; }

    public DateTime? Fd { get; set; }

    public DateTime? Td { get; set; }
}
