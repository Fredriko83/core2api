using estore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace estore.API.Data
{
    public class EstoreDBContext : DbContext
    {
        public EstoreDBContext(DbContextOptions<EstoreDBContext> options) : base(options){}
        public DbSet<Brand> Brands { get; set; }
        
    }
}