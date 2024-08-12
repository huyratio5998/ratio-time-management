using Time_Management.Server.Data.Entities;

namespace Time_Management.Server.Models.ViewModels
{
    public class GoalViewModel : BaseResponseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public double HourSpent { get; set; }
        public TaskStatusManagement Status { get; set; }

        public User? User { get; set; }
        IEnumerable<TimeManagementTask>? Tasks { get; set; }
    }
}
