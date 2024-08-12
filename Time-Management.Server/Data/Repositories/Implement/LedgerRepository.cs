using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Data.Repositories.Interfaces;

namespace Time_Management.Server.Data.Repositories.Implement
{
    public class LedgerRepository : Repository<Ledger>, IGoalRepository
    {
        public LedgerRepository(DbContext context) : base(context)
        {
        }
    }
}
