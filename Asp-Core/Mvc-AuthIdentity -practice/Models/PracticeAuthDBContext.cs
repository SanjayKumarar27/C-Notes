using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mvc_AuthIdentity__practice.Models
{
    public class PracticeAuthDBContext : IdentityDbContext
    {
        public PracticeAuthDBContext(DbContextOptions options) : base(options)
        {
        }

        protected PracticeAuthDBContext()
        {
        }
    }
}
