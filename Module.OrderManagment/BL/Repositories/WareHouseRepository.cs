
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IWareHouseRepository
    { }

    internal class WareHouseRepository : Repository<WareHouse>, IWareHouseRepository
    {
        public WareHouseRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
