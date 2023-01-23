
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IMakeRepository
    { }

    internal class MakeRepository : Repository<Make>, IMakeRepository
    {
        public MakeRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
