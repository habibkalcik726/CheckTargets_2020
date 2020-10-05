using CheckTargets_2020.DBModel.DBObjects;
using Microsoft.EntityFrameworkCore;


namespace CheckTargets_2020.DBModel.Context
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Targets> Targets { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
    }
}

