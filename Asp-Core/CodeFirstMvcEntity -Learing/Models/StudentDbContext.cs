using Microsoft.EntityFrameworkCore;

namespace MvcEntityCodeFirst.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext()
        {

        }
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }

        public virtual DbSet<Student> Students { get; set; }

    }
}
