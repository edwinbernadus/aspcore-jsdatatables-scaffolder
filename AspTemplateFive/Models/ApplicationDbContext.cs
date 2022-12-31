using Microsoft.EntityFrameworkCore;
using AspTemplateFive.Controllers;

namespace AspTemplateFive.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}