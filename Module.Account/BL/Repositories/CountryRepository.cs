using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface ICountryRepository
    { }

    internal class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}