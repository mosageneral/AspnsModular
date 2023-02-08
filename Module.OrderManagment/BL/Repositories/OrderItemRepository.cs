
using BL.Infrastructure;
using Module.OrderManagment.DL.appDBContext;
using Module.OrderManagment.DL.Entities.OrderManagmentEntities;
using System.Collections.Generic;

namespace BL.Repositories
{
    internal interface IOrderItemRepository
    { }

    internal class OrderItemRepository : Repository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(OrderManagmentAppDbContext ctx) : base(ctx)
        { }


    }
}
