using Microsoft.EntityFrameworkCore;

namespace APIExampleNewOne.Models
{
     // For database we use DbContext
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        // table created through DbSet
        public DbSet<Student> Students { get; set; }
    }
}
