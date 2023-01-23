﻿
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IPermissionRepository
    { }

    internal class PermissionRepository : Repository<Permission>, IPermissionRepository
    {
        public PermissionRepository(AccountAppDbContext ctx) : base(ctx)
        { }

       
    }
}
