using System.ComponentModel.DataAnnotations;

namespace DbFirstComplexDatatypes.Models
{
    public class EmpMgrDtoClass
    {
        [Key]
        public int EmployeeId { get; set; }

        public string ?EmployeeName { get; set; }

        public string ?ManagerName { get; set; }


    }

}
