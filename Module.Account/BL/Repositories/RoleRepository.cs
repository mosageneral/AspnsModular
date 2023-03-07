using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface IRoleRepository
    { }

    internal class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}