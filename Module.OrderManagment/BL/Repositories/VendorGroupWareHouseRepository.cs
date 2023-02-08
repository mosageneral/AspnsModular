
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IVendorGroupWareHouseRepository
    { }

    internal class VendorGroupWareHouseRepository : Repository<VendorGroupWareHouse>, IVendorGroupWareHouseRepository
    {
        public VendorGroupWareHouseRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
