using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeMvcEntity.Models;

public partial class Employee
{
    [DisplayName("Employee Id")]
    [Required]
    public int Eid { get; set; }

    [DisplayName("Employee  Name")]
    [Required]
    [StringLength(20)]
    [RegularExpression("[A-Za-z],{0,20}",ErrorMessage="Aplhabets Only ")]
    public string? Ename { get; set; }

    [Required]
    [Range(0,2000000,ErrorMessage="Salary should be  in range of 0-2000000")]
    public decimal? Salary { get; set; }
}
