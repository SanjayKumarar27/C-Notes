using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEmp.Models
{
    public class AuthDbEmpContext : IdentityDbContext
    {
        public AuthDbEmpContext(DbContextOptions options) : base(options)
        {
        }

        protected AuthDbEmpContext()
        {
        }
    }
}
