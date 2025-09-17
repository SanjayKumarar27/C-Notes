using Microsoft.EntityFrameworkCore;

namespace CodeFirstEmp.Models
{
    public class CodeFirstEmpDbContext:DbContext
    {
        public CodeFirstEmpDbContext()
        {

        }

        public CodeFirstEmpDbContext(DbContextOptions<CodeFirstEmpDbContext> options) : base(options) { }

        public virtual DbSet<Employee> Employees { get;set; }
    }
}
