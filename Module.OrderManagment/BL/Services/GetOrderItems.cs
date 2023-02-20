using BL.Infrastructure;
using Shared.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.BL.Services
{
    internal class GetOrderItems : IGetOrderItems
    {
        private readonly IUnitOfWork unitOfWork;

        public GetOrderItems(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public List<object> GetItems(Guid OrderId)
        {
            var Items = new List<object>();
            var items = unitOfWork.OrderItemRepository.GetMany(a=>a.OrderId==OrderId).ToHashSet();
            foreach (var item in items) { Items.Add(item); }
            return Items;

        }
    }
}
