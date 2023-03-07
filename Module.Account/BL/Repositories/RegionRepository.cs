using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

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