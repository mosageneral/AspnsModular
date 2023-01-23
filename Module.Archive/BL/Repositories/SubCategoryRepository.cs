
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface ISubCategoryRepository
    { }

    internal class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
