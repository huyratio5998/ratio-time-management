using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Data.Entities;

namespace Time_Management.Server.Data
{
    public class TimeManagementDBContext : DbContext
    {
        public TimeManagementDBContext(DbContextOptions<TimeManagementDBContext> options) : base(options)
        {
        }

        public DbSet<Goal> Goals { get; set; }
        public DbSet<TimeManagementTask> Tasks { get; set; }
        public DbSet<Ledger> Ledgers { get; set; }
        public DbSet<User> Users { get; set; }
    }    
}
