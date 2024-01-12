using Microsoft.EntityFrameworkCore;
using StudentDatabase.Model;

namespace StudentDatabase.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}