using AaronBookWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace AaronBookWebApplication.Data
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Author> Authors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        
    }
}
