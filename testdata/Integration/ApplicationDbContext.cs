using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using testdata.Integration.Models;

namespace testdata.Integration
{
    public class ApplicationDbContext: DbContext
    {
        
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Department> departments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
