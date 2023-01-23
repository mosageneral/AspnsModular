﻿
using BL.Infrastructure;
using Module.Product.DL.appDBContext;
using Module.Product.DL.Entities.ProductEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface ICategoryRepository
    { }

    internal class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ProductAppDbContext ctx) : base(ctx)
        { }

       
    }
}
