using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessEF.MyDBContext
{
    public class CustomContext : DbContext
    {
        public CustomContext(DbContextOptions<CustomContext> options) : base(options) 
        {
        }
        public DbSet<User> User { get; set; }
    }
}
