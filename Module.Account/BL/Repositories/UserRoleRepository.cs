
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IUserRolesRepository
    { }

    internal class UserRolesRepository : Repository<UserRoles>, IUserRolesRepository
    {
        public UserRolesRepository(AccountAppDbContext ctx) : base(ctx)
        { }

       
    }
}
