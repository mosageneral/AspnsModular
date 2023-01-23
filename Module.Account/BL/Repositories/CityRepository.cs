
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

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
