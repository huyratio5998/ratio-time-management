namespace Time_Management.Server.Data.Entities
{
    public class TimeManagementTask : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public TaskTemplateType Type { get; set; }
        public TaskType TaskType { get; set; }
        public TaskStatusManagement TaskStatus { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public double HourSpent { get; set; }
        public double HourEstimate { get; set; }
        public double Score { get; set; }
        public int ParentId { get; set; }

        public int GoalId { get; set; }
        public Goal? Goal { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }

    public enum TaskTemplateType
    {
        Work = 0,
        Entertainment = 1,
        Study = 2,
        Reading = 3,
        HappyHour = 4,
        Chatting = 5,
        Eating = 6,
        Other = 7
    }

    public enum TaskStatusManagement
    {
        Pending = 0,
        InProgress = 1,
        Completed = 2,
        Canceled = 3
    }

    public enum TaskType
    {
        Parent = 0,
        SubTask= 1
    }
}
