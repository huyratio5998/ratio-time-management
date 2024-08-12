using Time_Management.Server.Models.ViewModels;

namespace Time_Management.Server.Services.Interfaces
{
    public interface IGoalService
    {
        public Task<IEnumerable<GoalViewModel>> GetGoalsAsync(GoalRequestViewModel request);
    }
}
