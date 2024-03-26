using Microsoft.EntityFrameworkCore;
using WebApplication4.Models.Entities;
namespace WebApplication4.Date
{
    public class MVCDBContext : DbContext
    {
        public MVCDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customers> Customers
        {
        get; set; }
    }
}
