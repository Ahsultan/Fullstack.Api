using fullstack.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace fullstack.Api.Data
{
    public class FullStackDbContext : DbContext
    {
        public FullStackDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
