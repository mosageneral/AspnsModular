
using BL.Infrastructure;
using Module.Account.DL.appDBContext;
using Module.Account.DL.Entities.UserEntites;
using System.Collections.Generic;

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
