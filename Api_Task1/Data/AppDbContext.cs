using Api_Task1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api_Task1.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }
        public DbSet<Group> Groups { get; set; }
    }
}
