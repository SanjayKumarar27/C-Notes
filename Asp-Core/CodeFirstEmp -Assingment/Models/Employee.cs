using System.ComponentModel.DataAnnotations;

namespace CodeFirstEmp.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }

        public string ?Ename { get; set; }

        public double Salary { get; set; }
    }
}
