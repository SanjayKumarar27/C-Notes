using System.ComponentModel.DataAnnotations;

namespace DbFirstComplexDatatypes.Models
{
    public class DtoClass
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string DepartmentName { get; set; }
    }
}
