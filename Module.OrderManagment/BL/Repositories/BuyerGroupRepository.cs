
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IBuyerGroupRepository
    { }

    internal class BuyerGroupRepository : Repository<BuyerGroup>, IBuyerGroupRepository
    {
        public BuyerGroupRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
