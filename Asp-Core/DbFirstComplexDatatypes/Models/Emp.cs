using System;
using System.Collections.Generic;

namespace DbFirstComplexDatatypes.Models;

public partial class Emp
{
    public int Eid { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public DateTime? Doj { get; set; }

    public DateTime? Dob { get; set; }

    public decimal? Sal { get; set; }

    public decimal? Comm { get; set; }

    public int? Mid { get; set; }

    public int? Did { get; set; }

    public string? Jobs { get; set; }

    public string? Gender { get; set; }

    public virtual Dept? DidNavigation { get; set; }

    public virtual ICollection<Emp> InverseMidNavigation { get; set; } = new List<Emp>();

    public virtual Emp? MidNavigation { get; set; }
}
