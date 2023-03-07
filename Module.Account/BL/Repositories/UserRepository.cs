using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface IUserRepository
    { }

    internal class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}