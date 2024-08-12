using Time_Management.Server.Data.Entities;

namespace Time_Management.Server.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Goal> GoalRepository { get; }
        IRepository<Ledger> LedgerRepository { get; }
        IRepository<TimeManagementTask> TaskRepository { get; }
        IRepository<User> UserRepository { get; }

        Task<int> CompleteAsync();
        Task BeginTransactionAsync();
        Task CommitTransactionAsync();
        Task RollbackTransactionAsync();
    }
}
