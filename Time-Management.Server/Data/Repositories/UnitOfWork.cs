using Microsoft.EntityFrameworkCore.Storage;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Data.Repositories.Implement;

namespace Time_Management.Server.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TimeManagementDBContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(TimeManagementDBContext context)
        {
            _context = context;
            GoalRepository = new GoalRepository(_context);
            LedgerRepository = new LedgerRepository(_context);
            TaskRepository = new TaskRepository(_context);
            UserRepository = new UserRepository(_context);
        }

        public IRepository<Goal> GoalRepository { get; private set; }
        public IRepository<Ledger> LedgerRepository { get; private set; }
        public IRepository<TimeManagementTask> TaskRepository { get; private set; }
        public IRepository<User> UserRepository { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _context.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                await _transaction?.CommitAsync();
            }
            catch
            {
                await RollbackTransactionAsync();
                throw;
            }
            finally
            {
                if (_transaction != null)
                {
                    await _transaction.DisposeAsync();
                    _transaction = null;
                }
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                await _transaction.DisposeAsync();
                _transaction = null;
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _context.Dispose();
        }
    }
}