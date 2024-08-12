namespace Time_Management.Server.Data.Entities
{
    public class Ledger: BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
    }
}
