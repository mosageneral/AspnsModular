
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

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
