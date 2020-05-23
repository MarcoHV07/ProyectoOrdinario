

namespace MaquinaTortillera
{
    using MaquinaTortillera.data;
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext() : base("name=Choquis")
        {
        }
    }
}
