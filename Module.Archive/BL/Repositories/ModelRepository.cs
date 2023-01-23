
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IModelRepository
    { }

    internal class ModelRepository : Repository<Model>, IModelRepository
    {
        public ModelRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
