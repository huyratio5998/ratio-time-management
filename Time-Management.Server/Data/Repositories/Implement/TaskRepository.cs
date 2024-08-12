using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Data.Repositories.Interfaces;

namespace Time_Management.Server.Data.Repositories.Implement
{
    public class TaskRepository : Repository<TimeManagementTask>, IGoalRepository
    {
        public TaskRepository(DbContext context) : base(context)
        {
        }
    }
}
