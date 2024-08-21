using Microsoft.EntityFrameworkCore;
using RestApi.Domain.Model;

namespace RestApi.Persistence
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }

 
}

