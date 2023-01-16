using LGC_Check_In.Models;
using Microsoft.EntityFrameworkCore;

namespace LGC_Check_In.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Children> Children { get; set; }
    }
}
