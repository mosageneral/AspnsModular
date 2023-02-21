using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.OrderManagment.DL.DTO.OrderManagmentDto
{
    internal class OrderItemDTO
    {
        public Guid ItemId { get; set; }
        public int ItemQTY { get; set; }
    }
}
