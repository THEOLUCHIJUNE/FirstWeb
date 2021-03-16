using  Microsoft.EntityFrameworkCore;
using FirstWeb.Models;

namespace FirstWeb.DatabaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        
        
    }
}