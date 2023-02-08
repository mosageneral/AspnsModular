
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IBuyerGroupUserBuyerRepository
    { }

    internal class BuyerGroupUserBuyerRepository : Repository<BuyerGroupUserBuyer>, IBuyerGroupUserBuyerRepository
    {
        public BuyerGroupUserBuyerRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
