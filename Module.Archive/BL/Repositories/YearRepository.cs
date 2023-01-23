
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IYearRepository
    { }

    internal class YearRepository : Repository<Year>, IYearRepository
    {
        public YearRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
