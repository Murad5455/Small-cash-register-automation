using Microsoft.EntityFrameworkCore;

namespace CoreTask3.Models
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MSI1S2I;database=CoreTask3;integrated security=true");
        }


        public DbSet<Product> Products { get; set; }


    }
}
