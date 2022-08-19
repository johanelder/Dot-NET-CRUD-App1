using AppDevSession1.Model;
using Microsoft.EntityFrameworkCore;

namespace AppDevSession1.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<BikeType> BikeType { get; set; }
    }
}
