using Microsoft.EntityFrameworkCore;
using StudentPoral.Web.Models.Entities;

namespace StudentPoral.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    
    public DbSet<Student> Students { get; set; }
    }
}
