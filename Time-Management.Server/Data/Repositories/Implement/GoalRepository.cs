using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Data.Repositories.Interfaces;

namespace Time_Management.Server.Data.Repositories.Implement
{
    public class GoalRepository : Repository<Goal>, IGoalRepository
    {
        public GoalRepository(DbContext context) : base(context)
        {
        }
    }
}
