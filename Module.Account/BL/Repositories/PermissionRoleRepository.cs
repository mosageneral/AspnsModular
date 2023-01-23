
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

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
