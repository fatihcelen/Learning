using Microsoft.EntityFrameworkCore;
using TeknoLabs.Ardiye.Entities.Model;

namespace TeknoLabs.Ardiye.DataAccess.Model.EntityFramework
{
    public class ArdiyeContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
