
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IVendorGroupRepository
    { }

    internal class VendorGroupRepository : Repository<VendorGroup>, IVendorGroupRepository
    {
        public VendorGroupRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
