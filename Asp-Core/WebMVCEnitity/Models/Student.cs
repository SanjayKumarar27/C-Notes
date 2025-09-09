using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebMVCEnitity.Models;

public partial class Student
{
    [DisplayName("Student Id")]
    public int Sid { get; set; }

    [DisplayName("Student Name")]
    [Required(ErrorMessage ="Name is Required")]

    public string? Sname { get; set; }

    [Required]
    [Range(0,100)]
    //[Range(0,100),()]
    public byte? Marks { get; set; }
}
