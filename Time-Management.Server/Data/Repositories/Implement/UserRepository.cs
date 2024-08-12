using Microsoft.EntityFrameworkCore;
using Time_Management.Server.Data.Entities;
using Time_Management.Server.Data.Repositories.Interfaces;

namespace Time_Management.Server.Data.Repositories.Implement
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
