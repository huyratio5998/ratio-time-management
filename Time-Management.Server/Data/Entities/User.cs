namespace Time_Management.Server.Data.Entities
{
    public class User: BaseEntity
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Bio { get; set; }

        public IEnumerable<TimeManagementTask>? Tasks { get; set; }
        public IEnumerable<Goal>? Goals { get; set; }
    }
}
