using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface ICityRepository
    { }

    internal class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}