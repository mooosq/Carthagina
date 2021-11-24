using Carthagina.Database.DbModels;
using Microsoft.EntityFrameworkCore;

namespace Carthagina.Database.DbContexts
{
    public class CarthaginaContext : DbContext
    {
        public CarthaginaContext(DbContextOptions<CarthaginaContext> options) : base(options)
        {
        }
        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}