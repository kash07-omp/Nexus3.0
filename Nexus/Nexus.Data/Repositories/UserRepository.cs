using Nexus.Data.Infrastructure;
using Nexus.Model;

namespace Nexus.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDbFactory dbFactory) : base(dbFactory) { }
    }

    public interface IUserRepository : IRepository<User>
    {
    }
}
