using DataAccessEF.MyDBContext;
using Domain.Entities;
using Domain.Interfaces;

namespace DataAccessEF.TypeRepositories
{
    class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(CustomContext context) : base(context)
        {
        }

        public Task<IEnumerable<User>> GetAdultUsers()
        {
            return Task.FromResult<IEnumerable<User>>(_context.User.Where(o => o.Age >= 18).ToList());
        }
    }
}
