
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IProductRepository
    { }

    internal class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
