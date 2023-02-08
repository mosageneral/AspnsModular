

using BL.Repositories;
using System;

namespace BL.Infrastructure
{
    internal interface IUnitOfWork : IDisposable
    {


     BuyerGroupRepository BuyerGroupRepository { get; }
     BuyerGroupUserBuyerRepository BuyerGroupUserBuyerRepository { get; }
     OrderRepository OrderRepository { get; }
     OrderItemRepository OrderItemRepository { get; }
     VendorGroupRepository VendorGroupRepository { get; }
     VendorGroupWareHouseRepository VendorGroupWareHouseRepository { get; }
     WareHouseRepository WareHouseRepository { get; }




        int Save();
      
    }
}
