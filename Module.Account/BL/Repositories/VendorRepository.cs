using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;

namespace BL.Repositories
{
    internal interface IVendorRepository
    { }

    internal class VendorRepository : Repository<Vendor>, IVendorRepository
    {
        public VendorRepository(AccountAppDbContext ctx) : base(ctx)
        { }
    }
}