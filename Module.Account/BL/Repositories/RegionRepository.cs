
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IRegionRepository
    { }

    internal class RegionRepository : Repository<Region>, IRegionRepository
    {
        public RegionRepository(AccountAppDbContext ctx) : base(ctx)
        { }

       
    }
}
