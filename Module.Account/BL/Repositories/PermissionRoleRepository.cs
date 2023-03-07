using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface IPermissionRoleRepository
    { }

    internal class PermissionRoleRepository : Repository<PermissionRoles>, IPermissionRoleRepository
    {
        public PermissionRoleRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}