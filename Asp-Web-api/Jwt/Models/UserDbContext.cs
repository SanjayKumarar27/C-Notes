using https_Codefirst.Models;
using Microsoft.EntityFrameworkCore;

namespace https_Codefirst.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
