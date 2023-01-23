



using BL.Repositories;
using Module.Product.DL.appDBContext;

namespace BL.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private ProductAppDbContext _ctx;
        public UnitOfWork(ProductAppDbContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = true;
        }

    

        public ProductRepository ProductRepository => new ProductRepository(_ctx);

        public CategoryRepository CategoryRepository => new CategoryRepository(_ctx);

        public SubCategoryRepository SubCategoryRepository => new SubCategoryRepository(_ctx);

        public MakeRepository MakeRepository => new MakeRepository(_ctx);

        public ModelRepository ModelRepository => new ModelRepository(_ctx);

        public YearRepository YearRepository => throw new NotImplementedException();

        public void Dispose()
        {
            _ctx.Dispose();
        }



        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
