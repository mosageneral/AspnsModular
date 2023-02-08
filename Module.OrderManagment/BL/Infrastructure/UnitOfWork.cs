




using BL.Repositories;
using Module.OrderManagment.BL.Abstraction;
using Module.OrderManagment.DL.appDBContext;

namespace BL.Infrastructure
{
    internal class UnitOfWork : IUnitOfWork
    {
        private OrderManagmentAppDbContext _ctx;
        public UnitOfWork(OrderManagmentAppDbContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = true;
        }

        public BuyerGroupRepository BuyerGroupRepository => new BuyerGroupRepository(_ctx);

        public BuyerGroupUserBuyerRepository BuyerGroupUserBuyerRepository => new BuyerGroupUserBuyerRepository(_ctx);

        public OrderRepository OrderRepository => new OrderRepository(_ctx);

        public OrderItemRepository OrderItemRepository => new OrderItemRepository(_ctx);

        public VendorGroupRepository VendorGroupRepositoryer => new VendorGroupRepository(_ctx);

        public VendorGroupWareHouseRepository VendorGroupWareHouseRepository => new VendorGroupWareHouseRepository(_ctx);

        public WareHouseRepository WareHouseRepository => new WareHouseRepository(_ctx);

        public VendorGroupRepository VendorGroupRepository => throw new NotImplementedException();

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
