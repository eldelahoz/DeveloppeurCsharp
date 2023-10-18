using Microsoft.EntityFrameworkCore;
using pizza_hz.Models;

namespace pizza_hz.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
