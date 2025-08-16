using Microsoft.EntityFrameworkCore;
using ThanachartApi.Models;

namespace ThanachartApi.Database
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public DbSet<Stock> Stock { get; set; }
    }
}
