using System;
using System.Collections.Generic;

namespace MagicMvcEntity.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public byte? Marks { get; set; }
}
