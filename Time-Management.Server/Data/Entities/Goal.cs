namespace Time_Management.Server.Data.Entities
{
    public class Goal: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public double HourSpent { get; set; }
        public TaskStatusManagement Status { get; set; }

        public int UserId { get; set; }
        public User? User { get; set; }
        IEnumerable<TimeManagementTask>? Tasks { get; set; }
    }
}
