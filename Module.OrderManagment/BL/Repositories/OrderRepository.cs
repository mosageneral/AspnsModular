
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IOrderRepository
    { }

    internal class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
