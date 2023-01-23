
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

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
