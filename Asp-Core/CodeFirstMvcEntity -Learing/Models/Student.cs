using System.ComponentModel.DataAnnotations;

namespace MvcEntityCodeFirst.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public byte Marks { get; set; }

        public string? department { get; set; }

        public  string? Emails { get; set; }

        
    }
}
