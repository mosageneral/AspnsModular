




using Module.Financial.DL.appDBContext;
using Module.Financial.BL.Repositories;

namespace BL.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private FinancialAppDbContext _ctx;
        public UnitOfWork(FinancialAppDbContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = true;
        }

        public B2BInvoiceRepository B2BInvoiceRepository => new B2BInvoiceRepository(_ctx);

        public B2BInvoiceItemRepository B2BInvoiceItemRepository => new B2BInvoiceItemRepository(_ctx);

        public B2CInvoiceRepository B2CInvoiceRepository => new B2CInvoiceRepository(_ctx);

        public B2CInvoiceItemRepository B2CInvoiceItemRepository => new B2CInvoiceItemRepository(_ctx); 

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
